﻿Module StartUp

    ' Database stuff
    Friend pDatabase As CardonerSistemas.Database.ADO.SQLServer

    Friend pFillAndRefreshLists As FillAndRefreshLists

    Friend pFormMDIMain As formMDIMain
    Friend pPermisos As List(Of UsuarioGrupoPermiso)
    Friend pParametros As List(Of Parametro)
    Friend pLicensedTo As String
    Friend pUsuario As Usuario
    Friend pBalanzaConeccionHabilitada As Boolean = False

    Friend Sub Main()
        Dim StartupTime As Date
        Dim DataSourceIndex As Integer

        System.Windows.Forms.Cursor.Current = Cursors.AppStarting

        My.Application.Log.WriteEntry("La Aplicación se está iniciando.", TraceEventType.Information)

        ' Verifico si ya hay una instancia ejecutandose, si permite iniciar otra, o de lo contrario, muestro la instancia original
        If My.Settings.SingleInstanceApplication Then

        End If

        ' Realizo la inicialización de la Aplicación
        If My.Settings.EnableVisualStyles Then
            Application.EnableVisualStyles()
        End If

        ' Muestro el SplashScreen y cambio el puntero del mouse para indicar que la aplicación está iniciando.
        formSplashScreen.Show()
        formSplashScreen.Cursor = Cursors.AppStarting
        formSplashScreen.labelStatus.Text = "Obteniendo los parámetros de conexión a la Base de datos..."
        Application.DoEvents()

        ' Si hay más de un DataSource especificado, muestro la ventana de selección
        If My.Settings.DBConnection_Datasource.Contains(CardonerSistemas.Constants.STRING_LIST_SEPARATOR) Then
            CS_Database_SelectSource.comboboxDataSource.Items.AddRange(My.Settings.DBConnection_Datasource.Split(CChar(CardonerSistemas.Constants.STRING_LIST_SEPARATOR)))
            If Not CS_Database_SelectSource.ShowDialog(formSplashScreen) = DialogResult.OK Then
                Application.Exit()
                My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Usuario no ha seleccionado el origen de los datos.", TraceEventType.Warning)
                Exit Sub
            End If
            DataSourceIndex = CS_Database_SelectSource.comboboxDataSource.SelectedIndex
            CS_Database_SelectSource.Close()
            CS_Database_SelectSource.Dispose()
        Else
            DataSourceIndex = -1
        End If

        ' Obtengo el Connection String para las conexiones de ADO .NET
        pDatabase = New CardonerSistemas.Database.ADO.SQLServer
        pDatabase.ApplicationName = My.Application.Info.Title
        If DataSourceIndex > -1 Then
            pDatabase.DataSource = My.Settings.DBConnection_Datasource.Split(CChar(CardonerSistemas.Constants.STRING_LIST_SEPARATOR)).ElementAt(DataSourceIndex)
            ' Database
            If My.Settings.DBConnection_Database.Contains(CardonerSistemas.Constants.STRING_LIST_SEPARATOR) Then
                Dim aDatabase() As String
                aDatabase = My.Settings.DBConnection_Database.Split(CChar(CardonerSistemas.Constants.STRING_LIST_SEPARATOR))
                If aDatabase.GetUpperBound(0) >= DataSourceIndex Then
                    pDatabase.InitialCatalog = aDatabase(DataSourceIndex)
                Else
                    pDatabase.InitialCatalog = ""
                End If
                aDatabase = Nothing
            Else
                pDatabase.InitialCatalog = My.Settings.DBConnection_Database
            End If
            ' UserID
            If My.Settings.DBConnection_UserID.Contains(CardonerSistemas.Constants.STRING_LIST_SEPARATOR) Then
                Dim aUserID() As String
                aUserID = My.Settings.DBConnection_UserID.Split(CChar(CardonerSistemas.Constants.STRING_LIST_SEPARATOR))
                If aUserID.GetUpperBound(0) >= DataSourceIndex Then
                    pDatabase.UserID = aUserID(DataSourceIndex)
                Else
                    pDatabase.UserID = ""
                End If
                aUserID = Nothing
            Else
                pDatabase.UserID = My.Settings.DBConnection_UserID
            End If
            ' Password
            Dim PasswordEncrypted As String
            If My.Settings.DBConnection_Password.Contains(CardonerSistemas.Constants.STRING_LIST_SEPARATOR) Then
                Dim aPassword() As String
                aPassword = My.Settings.DBConnection_Password.Split(CChar(CardonerSistemas.Constants.STRING_LIST_SEPARATOR))
                If aPassword.GetUpperBound(0) >= DataSourceIndex Then
                    PasswordEncrypted = aPassword(DataSourceIndex)
                Else
                    PasswordEncrypted = ""
                End If
                aPassword = Nothing
            Else
                PasswordEncrypted = My.Settings.DBConnection_Password
            End If
            ' Desencripto la contraseña de la conexión a la base de datos que está en el archivo app.config
            If PasswordEncrypted.Length > 0 Then
                Dim PasswordDecrypter As New CS_Encrypt_TripleDES(CardonerSistemas.Constants.PUBLIC_ENCRYPTION_PASSWORD)
                Dim DecryptedPassword As String = ""
                If Not PasswordDecrypter.Decrypt(PasswordEncrypted, DecryptedPassword) Then
                    MsgBox("La contraseña de conexión a la base de datos es incorrecta.", MsgBoxStyle.Critical, My.Application.Info.Title)
                    formSplashScreen.Close()
                    formSplashScreen.Dispose()
                    TerminateApplication()
                    PasswordDecrypter = Nothing
                    Exit Sub
                End If
                pDatabase.Password = DecryptedPassword
                PasswordDecrypter = Nothing
            Else
                pDatabase.Password = ""
            End If
            PasswordEncrypted = Nothing
        Else
            pDatabase.DataSource = My.Settings.DBConnection_Datasource
            pDatabase.InitialCatalog = My.Settings.DBConnection_Database
            pDatabase.UserID = My.Settings.DBConnection_UserID
            ' Desencripto la contraseña de la conexión a la base de datos que está en el archivo app.config
            Dim PasswordDecrypter As New CS_Encrypt_TripleDES(CardonerSistemas.Constants.PUBLIC_ENCRYPTION_PASSWORD)
            Dim DecryptedPassword As String = ""
            If Not PasswordDecrypter.Decrypt(My.Settings.DBConnection_Password, DecryptedPassword) Then
                MsgBox("La contraseña de conexión a la base de datos es incorrecta.", MsgBoxStyle.Critical, My.Application.Info.Title)
                formSplashScreen.Close()
                formSplashScreen.Dispose()
                TerminateApplication()
                PasswordDecrypter = Nothing
                Exit Sub
            End If
            pDatabase.Password = DecryptedPassword
            PasswordDecrypter = Nothing
        End If
        pDatabase.MultipleActiveResultsets = True
        pDatabase.WorkstationID = My.Computer.Name
        pDatabase.CreateConnectionString()

        ' Obtengo el Connection String para las conexiones de Entity Framework
        CSPesajeContext.CreateConnectionString(My.Settings.DBConnection_Provider, pDatabase.ConnectionString)

        ' Cargos los Parámetros desde la Base de datos
        formSplashScreen.labelStatus.Text = "Cargando los parámetros desde la Base de datos..."
        Application.DoEvents()
        If Not Parametros.LoadParameters() Then
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Exit Sub
        End If

        ' Verifico que la Base de Datos corresponda a esta Aplicación a través del GUID guardado en los Parámetros
        If CS_Parameter_System.GetString(Parametros.APPLICATION_DATABASE_GUID) <> Constantes.APPLICATION_DATABASE_GUID Then
            MsgBox("La Base de Datos especificada no corresponde a esta aplicación.", MsgBoxStyle.Critical, My.Application.Info.Title)
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Exit Sub
        End If

        ' Muestro el Nombre de la Compañía a la que está licenciada la Aplicación
        Dim LicenseDecrypter As New CS_Encrypt_TripleDES(Constantes.APPLICATION_LICENSE_PASSWORD)
        Dim DecryptedLicense As String = ""
        If Not LicenseDecrypter.Decrypt(CS_Parameter_System.GetString(Parametros.LICENSE_COMPANY_NAME, "EMPTY"), DecryptedLicense) Then
            MsgBox("La Licencia especificada no es válida.", MsgBoxStyle.Critical, My.Application.Info.Title)
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            LicenseDecrypter = Nothing
            Exit Sub
        End If
        pLicensedTo = DecryptedLicense
        LicenseDecrypter = Nothing
        formSplashScreen.labelLicensedTo.Text = pLicensedTo
        Application.DoEvents()

        ' Preparo instancia de clase para llenar los ComboBox
        pFillAndRefreshLists = New FillAndRefreshLists

        ' Tomo el tiempo de inicio para controlar los segundos mínimos que se debe mostrar el Splash Screen
        StartupTime = Now

        ' Muestro el form MDI principal
        pFormMDIMain = New formMDIMain
        pFormMDIMain.Show()
        formSplashScreen.Focus()

        pFormMDIMain.Cursor = Cursors.AppStarting
        pFormMDIMain.Enabled = False

        ' Si corresponde, abro la conexión con el puerto correspondiente para leer los valores de la balanza
        If My.Settings.ScaleConnectionEnabled Then
            pBalanzaConeccionHabilitada = True
        End If

        ' Muestro el form de Pesadas
        formSplashScreen.labelStatus.Text = "Cargando y mostrando ventana de Pesadas..."
        formSplashScreen.Focus()
        Application.DoEvents()

        CS_Form.MDIChild_PositionAndSizeToFit(CType(pFormMDIMain, Form), CType(formPesadas, Form))

        formSplashScreen.labelStatus.Text = "Todo completado."
        Application.DoEvents()

        ' Espero el tiempo mínimo para mostrar el Splash Screen y después lo cierro
        If Not CS_Instance.IsRunningUnderIDE Then
            Do While Now.Subtract(StartupTime).Seconds < My.Settings.MinimumSplashScreenDisplaySeconds
                Application.DoEvents()
            Loop
        End If
        formSplashScreen.Close()
        formSplashScreen.Dispose()

        If CS_Instance.IsRunningUnderIDE Then
            ' Como se está ejecutando dentro del IDE de Visual Studio, en lugar de pedir Usuario y contraseña, asumo que es el Administrador
            Using dbcontext As New CSPesajeContext(True)
                pUsuario = dbcontext.Usuario.Find(1)
                Appearance.UserLoggedIn()
            End Using
        ElseIf My.Settings.AutoLogon_Usuario <> "" Then
            ' Se especifica un Usuario de Auto Logon, por lo tanto, se procederá a verificar la información de Logon
            Using dbcontext As New CSPesajeContext(True)
                pUsuario = dbcontext.Usuario.Where(Function(us) us.Nombre = My.Settings.AutoLogon_Usuario).FirstOrDefault
                If pUsuario Is Nothing Then
                    Application.Exit()
                    My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Usuario especificado en Auto-Logon no existe.", TraceEventType.Warning)
                    Exit Sub
                End If
                Dim UserPasswordDecrypter As New CS_Encrypt_TripleDES(CardonerSistemas.Constants.PUBLIC_ENCRYPTION_PASSWORD)
                Dim DecryptedPassword As String = ""
                If Not UserPasswordDecrypter.Decrypt(My.Settings.AutoLogon_Password, DecryptedPassword) Then
                    MsgBox("La contraseña especificada en Auto-Logon es incorrecta.", MsgBoxStyle.Critical, My.Application.Info.Title)
                    formSplashScreen.Close()
                    formSplashScreen.Dispose()
                    TerminateApplication()
                    UserPasswordDecrypter = Nothing
                    Application.Exit()
                    My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Password especificado en el Auto-Logon es incorrecto.", TraceEventType.Warning)
                    Exit Sub
                End If
                UserPasswordDecrypter = Nothing
                If DecryptedPassword <> pUsuario.Password Then
                    MsgBox("La contraseña especificada en Auto-Logon es incorrecta.", MsgBoxStyle.Critical, My.Application.Info.Title)
                    formSplashScreen.Close()
                    formSplashScreen.Dispose()
                    TerminateApplication()
                    UserPasswordDecrypter = Nothing
                    Application.Exit()
                    My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Password especificado en el Auto-Logon es incorrecto.", TraceEventType.Warning)
                    Exit Sub
                End If

                Appearance.UserLoggedIn()
            End Using
        Else
            ' El Usuario debe iniciar sesión a través del form correspondiente
            formSplashScreen.Show()
            If Not formLogin.ShowDialog(formSplashScreen) = DialogResult.OK Then
                Application.Exit()
                My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Usuario no ha iniciado sesión.", TraceEventType.Warning)
                Exit Sub
            End If
            formLogin.Close()
            formLogin.Dispose()
        End If

        ' Está todo listo. Cambio el puntero del mouse a modo normal y habilito los forms
        pFormMDIMain.Cursor = Cursors.Default
        pFormMDIMain.Enabled = True

        formPesadas.Show()

        System.Windows.Forms.Cursor.Current = Cursors.Default

        ' Inicio el loop sobre el form MDI principal
        My.Application.Log.WriteEntry("La Aplicación se ha iniciado correctamente.", TraceEventType.Information)
        Application.Run(pFormMDIMain)
    End Sub

    Friend Sub TerminateApplication()
        If Not pFormMDIMain Is Nothing Then
            CS_Form.MDIChild_CloseAll(CType(pFormMDIMain, Form))
        End If
        pDatabase = Nothing
        pFillAndRefreshLists = Nothing
        pPermisos = Nothing
        pParametros = Nothing
        pLicensedTo = Nothing
        pUsuario = Nothing
    End Sub

End Module