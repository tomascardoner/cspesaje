﻿Friend Class FillAndRefreshLists

#Region "Declarations..."
    Friend mdbContext As CSPesajeContext

    Public Sub New()
        mdbContext = New CSPesajeContext(True)
    End Sub

    Protected Overrides Sub Finalize()
        mdbContext.Dispose()
        MyBase.Finalize()
    End Sub

    Public Class Camion_ListItem
        Public Property IDCamion As Byte
        Public Property Descripcion As String
    End Class

#End Region

    Friend Sub Provincia(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_NoEspecifica As Boolean)
        ComboBoxControl.ValueMember = "IDProvincia"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In mdbContext.Provincia
                          Order By tbl.Nombre

        Dim localList = qryList.ToList
        If AgregarItem_NoEspecifica Then
            Dim UnspecifiedItem As New Provincia
            UnspecifiedItem.IDProvincia = FIELD_VALUE_NOTSPECIFIED_BYTE
            UnspecifiedItem.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Sub Localidad(ByRef ComboBoxControl As ComboBox, ByVal IDProvincia As Byte, ByVal AgregarItem_NoEspecifica As Boolean)
        ComboBoxControl.ValueMember = "IDLocalidad"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In mdbContext.Localidad
                          Where tbl.IDProvincia = IDProvincia
                          Order By tbl.Nombre

        Dim localList = qryList.ToList
        If AgregarItem_NoEspecifica Then
            Dim UnspecifiedItem As New Localidad
            UnspecifiedItem.IDLocalidad = FIELD_VALUE_NOTSPECIFIED_SHORT
            UnspecifiedItem.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Sub Genero(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim datatableGeneros As New DataTable("Generos")
        Dim datarowRow As DataRow

        ComboBoxControl.ValueMember = "IDGenero"
        ComboBoxControl.DisplayMember = "Nombre"

        With datatableGeneros
            .Columns.Add("IDGenero", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            If AgregarItem_NoEspecifica Then
                datarowRow = .NewRow
                datarowRow("IDGenero") = Constantes.PERSONA_GENERO_NOESPECIFICA
                datarowRow("Nombre") = My.Resources.STRING_ITEM_NOT_SPECIFIED
                .Rows.Add(datarowRow)
            End If

            datarowRow = .NewRow
            datarowRow("IDGenero") = Constantes.PERSONA_GENERO_MASCULINO
            datarowRow("Nombre") = My.Resources.STRING_GENERO_MASCULINO
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDGenero") = Constantes.PERSONA_GENERO_FEMENINO
            datarowRow("Nombre") = My.Resources.STRING_GENERO_FEMENINO
            .Rows.Add(datarowRow)
        End With

        ComboBoxControl.DataSource = datatableGeneros
        If AgregarItem_NoEspecifica Then
            ComboBoxControl.SelectedIndex = 0
        Else
            ComboBoxControl.SelectedIndex = -1
        End If
    End Sub

    Friend Sub UsuarioGrupo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of UsuarioGrupo)

        ComboBoxControl.ValueMember = "IDUsuarioGrupo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.UsuarioGrupo.OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New UsuarioGrupo
            Item_Todos.IDUsuarioGrupo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UsuarioGrupo
            Item_NoEspecifica.IDUsuarioGrupo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Entidad(ByRef ComboBoxControl As ComboBox, ByVal IDEntidadActual As Integer?, ByVal EsTitular As Boolean, ByVal EsTransportista As Boolean, ByVal EsChofer As Boolean, ByVal IDTransportista As Integer, ByVal UsoFrecuente As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Entidad)

        ComboBoxControl.ValueMember = "IDEntidad"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = (From ent In mdbContext.Entidad
                     Where (IDEntidadActual.HasValue And ent.IDEntidad = IDEntidadActual.Value) Or (ent.IDEntidad <> CS_Constants.FIELD_VALUE_OTHER_INTEGER And ent.EsActivo And ((EsTitular And ent.EsTitular) Or (EsTransportista And ent.EsTransportista) Or EsChofer And ent.EsChofer) And (ent.Transportista_IDEntidad = IDTransportista Or IDTransportista = CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER) And (ent.UsoFrecuente Or Not UsoFrecuente))
                     Order By ent.Nombre
                     Select ent).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Entidad
            Item_Todos.IDEntidad = FIELD_VALUE_ALL_INTEGER
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Entidad
            Item_NoEspecifica.IDEntidad = FIELD_VALUE_NOTSPECIFIED_INTEGER
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub EntidadTitularPorPlanta(ByRef ComboBoxControl As ComboBox, ByVal IDEntidad As Integer, ByVal IDPlanta As Byte, ByVal UsoFrecuente As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Entidad)

        ComboBoxControl.ValueMember = "IDEntidad"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = (From ent In mdbContext.Entidad
                     Join ent_pla In mdbContext.Entidad_Planta On ent.IDEntidad Equals ent_pla.IDEntidad
                     Where ent.IDEntidad = IDEntidad Or (ent.EsActivo And ent.EsTitular And (ent.UsoFrecuente Or Not UsoFrecuente) And ent_pla.IDPlanta = IDPlanta)
                     Order By ent.Nombre
                     Select ent).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Entidad
            Item_Todos.IDEntidad = FIELD_VALUE_ALL_INTEGER
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Entidad
            Item_NoEspecifica.IDEntidad = FIELD_VALUE_NOTSPECIFIED_INTEGER
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Camion(ByRef ComboBoxControl As ComboBox, ByVal IDCamionActual As Byte?, ByVal IDTransportista As Integer?, ByVal MostrarNombre As Boolean, ByVal MostrarPatentes As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Camion_ListItem)

        ComboBoxControl.ValueMember = "IDCamion"
        ComboBoxControl.DisplayMember = "Descripcion"

        If MostrarNombre And MostrarPatentes Then
            listItems = (From c In mdbContext.Camion
                         Where (IDTransportista.HasValue And IDCamionActual.HasValue And c.IDCamion = IDCamionActual.Value) Or (c.IDEntidad <> CS_Constants.FIELD_VALUE_OTHER_INTEGER And c.IDEntidad = IDTransportista)
                         Order By c.DominioChasis, c.DominioAcoplado
                         Select New Camion_ListItem With {.IDCamion = c.IDCamion, .Descripcion = c.Nombre & CStr(If(c.DominioChasis Is Nothing, "", " - " & c.DominioChasis)) & CStr(If(c.DominioAcoplado Is Nothing, "", " - " & c.DominioAcoplado))}).ToList
        ElseIf MostrarNombre Then
            listItems = (From c In mdbContext.Camion
                         Where (IDTransportista.HasValue And IDCamionActual.HasValue And c.IDCamion = IDCamionActual.Value) Or (c.IDEntidad <> CS_Constants.FIELD_VALUE_OTHER_INTEGER And c.IDEntidad = IDTransportista)
                         Order By c.Nombre
                         Select New Camion_ListItem With {.IDCamion = c.IDCamion, .Descripcion = c.Nombre}).ToList
        ElseIf MostrarPatentes Then
            listItems = (From c In mdbContext.Camion
                         Where (IDTransportista.HasValue And IDCamionActual.HasValue And c.IDCamion = IDCamionActual.Value) Or (c.IDEntidad <> CS_Constants.FIELD_VALUE_OTHER_INTEGER And c.IDEntidad = IDTransportista)
                         Order By c.DominioChasis, c.DominioAcoplado
                         Select New Camion_ListItem With {.IDCamion = c.IDCamion, .Descripcion = CStr(If(c.DominioChasis Is Nothing, "", c.DominioChasis)) & CStr(If(c.DominioAcoplado Is Nothing, "", " - " & c.DominioAcoplado))}).ToList
        Else
            listItems = New List(Of Camion_ListItem)
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Camion_ListItem
            Item_Todos.IDCamion = FIELD_VALUE_ALL_BYTE
            Item_Todos.Descripcion = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Camion_ListItem
            Item_NoEspecifica.IDCamion = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Descripcion = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Producto(ByRef ComboBoxControl As ComboBox, ByVal IDProductoActual As Byte?, ByVal UsoFrecuente As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Producto)

        ComboBoxControl.ValueMember = "IDProducto"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Producto.Where(Function(pr) (IDProductoActual.HasValue And pr.IDProducto = IDProductoActual.Value) Or (pr.IDProducto <> CS_Constants.FIELD_VALUE_OTHER_BYTE And (UsoFrecuente = False Or pr.UsoFrecuente) And pr.EsActivo)).OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Producto
            Item_Todos.IDProducto = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Producto
            Item_NoEspecifica.IDProducto = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Planta(ByRef ComboBoxControl As ComboBox, ByVal IDPlantaActual As Byte?, ByVal IDProducto As Byte, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Planta)

        ComboBoxControl.ValueMember = "IDPlanta"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDProducto = CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Planta.Where(Function(pl) (IDPlantaActual.HasValue And pl.IDPlanta = IDPlantaActual.Value) Or pl.EsActivo).OrderBy(Function(pl) pl.Nombre).ToList
        Else
            listItems = (From pl In mdbContext.Planta
                         Join pp In mdbContext.Producto_Planta On pl.IDPlanta Equals pp.IDPlanta
                         Where (IDPlantaActual.HasValue And pl.IDPlanta = IDPlantaActual.Value) Or (pp.IDProducto = IDProducto And pl.EsActivo)
                         Order By pl.Nombre
                         Select pl).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Planta
            Item_Todos.IDPlanta = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Planta
            Item_NoEspecifica.IDPlanta = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Cosecha(ByRef ComboBoxControl As ComboBox, ByVal IDCosecha As Byte?, ByVal IDProducto As Byte, ByVal Fecha As Date, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Cosecha)

        ComboBoxControl.ValueMember = "IDCosecha"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDProducto = CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Cosecha.Where(Function(co) (IDCosecha.HasValue And co.IDCosecha = IDCosecha.Value) Or co.EsActivo).OrderBy(Function(co) co.Nombre).ToList
        Else
            listItems = (From co In mdbContext.Cosecha
                         Join pc In mdbContext.Producto_Cosecha On co.IDCosecha Equals pc.IDCosecha
                         Where (IDCosecha.HasValue And co.IDCosecha = IDCosecha.Value) Or (pc.IDProducto = IDProducto And pc.EsActivo And pc.Inicio <= Fecha And pc.Fin >= Fecha)
                         Order By co.Nombre
                         Select co).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Cosecha
            Item_Todos.IDCosecha = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Cosecha
            Item_NoEspecifica.IDCosecha = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub OrigenDestino(ByRef ComboBoxControl As ComboBox, ByVal IDOrigenDestino As Integer?, ByVal IDEntidad As Integer, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of OrigenDestino)

        ComboBoxControl.ValueMember = "IDOrigenDestino"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDEntidad = CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER Then
            listItems = mdbContext.OrigenDestino.Where(Function(od) (IDOrigenDestino.HasValue And od.IDOrigenDestino = IDOrigenDestino.Value) Or od.EsActivo).OrderBy(Function(od) od.Nombre).ToList
        Else
            listItems = (From ori In mdbContext.OrigenDestino
                             Join ent_ori In mdbContext.Entidad_OrigenDestino On ori.IDOrigenDestino Equals ent_ori.IDOrigenDestino
                             Where (IDOrigenDestino.HasValue And ori.IDOrigenDestino = IDOrigenDestino.Value) Or ent_ori.IDEntidad = IDEntidad And ori.EsActivo
                             Order By ori.Nombre
                             Select ori).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New OrigenDestino
            Item_Todos.IDOrigenDestino = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New OrigenDestino
            Item_NoEspecifica.IDOrigenDestino = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub
End Class