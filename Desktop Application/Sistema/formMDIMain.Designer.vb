﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMDIMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMDIMain))
        Me.menustripMain = New System.Windows.Forms.MenuStrip()
        Me.menuitemArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Opciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Separador_CerrarSesion = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemArchivo_CerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_CambiarContrasena = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Separador_Salir = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemArchivo_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemVentanaCerrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparatorVentana = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemDebug = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAyuda_AcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelMain = New System.Windows.Forms.TableLayoutPanel()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.dropdownbuttonTablas = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemTablas_Entidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Camiones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_OrigenesDestinos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Productos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Cosechas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_GruposUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_GruposUsuariosPermisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Tarifas = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonPesadas = New System.Windows.Forms.ToolStripButton()
        Me.buttonResumenPesadas = New System.Windows.Forms.ToolStripButton()
        Me.buttonReportes = New System.Windows.Forms.ToolStripButton()
        Me.textboxKilogramo = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanelUsuario = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelUsuarioDescripcion = New System.Windows.Forms.Label()
        Me.PictureBoxUsuarioAvatar = New System.Windows.Forms.PictureBox()
        Me.menustripMain.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.toolstripMain.SuspendLayout()
        Me.TableLayoutPanelUsuario.SuspendLayout()
        CType(Me.PictureBoxUsuarioAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menustripMain
        '
        Me.menustripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemArchivo, Me.menuitemVentana, Me.menuitemDebug, Me.menuitemAyuda})
        Me.menustripMain.Location = New System.Drawing.Point(0, 0)
        Me.menustripMain.MdiWindowListItem = Me.menuitemVentana
        Me.menustripMain.Name = "menustripMain"
        Me.menustripMain.Size = New System.Drawing.Size(861, 24)
        Me.menustripMain.TabIndex = 0
        '
        'menuitemArchivo
        '
        Me.menuitemArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemArchivo_Opciones, Me.menuitemArchivo_Separador_CerrarSesion, Me.menuitemArchivo_CerrarSesion, Me.menuitemArchivo_CambiarContrasena, Me.menuitemArchivo_Separador_Salir, Me.menuitemArchivo_Salir})
        Me.menuitemArchivo.Name = "menuitemArchivo"
        Me.menuitemArchivo.Size = New System.Drawing.Size(60, 20)
        Me.menuitemArchivo.Text = "&Archivo"
        '
        'menuitemArchivo_Opciones
        '
        Me.menuitemArchivo_Opciones.Name = "menuitemArchivo_Opciones"
        Me.menuitemArchivo_Opciones.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_Opciones.Text = "Opciones"
        '
        'menuitemArchivo_Separador_CerrarSesion
        '
        Me.menuitemArchivo_Separador_CerrarSesion.Name = "menuitemArchivo_Separador_CerrarSesion"
        Me.menuitemArchivo_Separador_CerrarSesion.Size = New System.Drawing.Size(201, 6)
        '
        'menuitemArchivo_CerrarSesion
        '
        Me.menuitemArchivo_CerrarSesion.Name = "menuitemArchivo_CerrarSesion"
        Me.menuitemArchivo_CerrarSesion.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_CerrarSesion.Text = "Cerrar sesión del Usuario"
        '
        'menuitemArchivo_CambiarContrasena
        '
        Me.menuitemArchivo_CambiarContrasena.Name = "menuitemArchivo_CambiarContrasena"
        Me.menuitemArchivo_CambiarContrasena.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_CambiarContrasena.Text = "Cambiar contraseña"
        '
        'menuitemArchivo_Separador_Salir
        '
        Me.menuitemArchivo_Separador_Salir.Name = "menuitemArchivo_Separador_Salir"
        Me.menuitemArchivo_Separador_Salir.Size = New System.Drawing.Size(201, 6)
        '
        'menuitemArchivo_Salir
        '
        Me.menuitemArchivo_Salir.Name = "menuitemArchivo_Salir"
        Me.menuitemArchivo_Salir.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_Salir.Text = "&Salir"
        '
        'menuitemVentana
        '
        Me.menuitemVentana.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemVentanaCerrar, Me.ToolStripSeparatorVentana})
        Me.menuitemVentana.Name = "menuitemVentana"
        Me.menuitemVentana.Size = New System.Drawing.Size(61, 20)
        Me.menuitemVentana.Text = "&Ventana"
        '
        'ToolStripMenuItemVentanaCerrar
        '
        Me.ToolStripMenuItemVentanaCerrar.Name = "ToolStripMenuItemVentanaCerrar"
        Me.ToolStripMenuItemVentanaCerrar.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripMenuItemVentanaCerrar.Text = "Cerrar"
        '
        'ToolStripSeparatorVentana
        '
        Me.ToolStripSeparatorVentana.Name = "ToolStripSeparatorVentana"
        Me.ToolStripSeparatorVentana.Size = New System.Drawing.Size(103, 6)
        '
        'menuitemDebug
        '
        Me.menuitemDebug.Name = "menuitemDebug"
        Me.menuitemDebug.Size = New System.Drawing.Size(54, 20)
        Me.menuitemDebug.Text = "Debug"
        Me.menuitemDebug.Visible = False
        '
        'menuitemAyuda
        '
        Me.menuitemAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemAyuda_AcercaDe})
        Me.menuitemAyuda.Name = "menuitemAyuda"
        Me.menuitemAyuda.Size = New System.Drawing.Size(53, 20)
        Me.menuitemAyuda.Text = "A&yuda"
        '
        'menuitemAyuda_AcercaDe
        '
        Me.menuitemAyuda_AcercaDe.Name = "menuitemAyuda_AcercaDe"
        Me.menuitemAyuda_AcercaDe.Size = New System.Drawing.Size(135, 22)
        Me.menuitemAyuda_AcercaDe.Text = "&Acerca de..."
        '
        'panelMain
        '
        Me.panelMain.AutoSize = True
        Me.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelMain.ColumnCount = 3
        Me.panelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.panelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.panelMain.Controls.Add(Me.toolstripMain, 0, 0)
        Me.panelMain.Controls.Add(Me.textboxKilogramo, 2, 0)
        Me.panelMain.Controls.Add(Me.TableLayoutPanelUsuario, 1, 0)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMain.Location = New System.Drawing.Point(0, 24)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.RowCount = 1
        Me.panelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panelMain.Size = New System.Drawing.Size(861, 44)
        Me.panelMain.TabIndex = 4
        '
        'toolstripMain
        '
        Me.toolstripMain.AllowMerge = False
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dropdownbuttonTablas, Me.buttonPesadas, Me.buttonResumenPesadas, Me.buttonReportes})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(414, 39)
        Me.toolstripMain.TabIndex = 2
        Me.toolstripMain.Text = "Principal"
        '
        'dropdownbuttonTablas
        '
        Me.dropdownbuttonTablas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemTablas_Entidades, Me.menuitemTablas_Camiones, Me.menuitemTablas_OrigenesDestinos, Me.menuitemTablas_Productos, Me.menuitemTablas_Cosechas, Me.menuitemTablas_GruposUsuarios, Me.menuitemTablas_GruposUsuariosPermisos, Me.menuitemTablas_Usuarios, Me.menuitemTablas_Tarifas})
        Me.dropdownbuttonTablas.Image = Global.CSPesaje.My.Resources.Resources.ImageTablas32
        Me.dropdownbuttonTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dropdownbuttonTablas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.dropdownbuttonTablas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonTablas.Name = "dropdownbuttonTablas"
        Me.dropdownbuttonTablas.Size = New System.Drawing.Size(84, 36)
        Me.dropdownbuttonTablas.Text = "Tablas"
        '
        'menuitemTablas_Entidades
        '
        Me.menuitemTablas_Entidades.Name = "menuitemTablas_Entidades"
        Me.menuitemTablas_Entidades.Size = New System.Drawing.Size(241, 22)
        Me.menuitemTablas_Entidades.Text = "Entidades"
        '
        'menuitemTablas_Camiones
        '
        Me.menuitemTablas_Camiones.Name = "menuitemTablas_Camiones"
        Me.menuitemTablas_Camiones.Size = New System.Drawing.Size(241, 22)
        Me.menuitemTablas_Camiones.Text = "Camiones"
        '
        'menuitemTablas_OrigenesDestinos
        '
        Me.menuitemTablas_OrigenesDestinos.Name = "menuitemTablas_OrigenesDestinos"
        Me.menuitemTablas_OrigenesDestinos.Size = New System.Drawing.Size(241, 22)
        Me.menuitemTablas_OrigenesDestinos.Text = "Orígenes y destinos"
        '
        'menuitemTablas_Productos
        '
        Me.menuitemTablas_Productos.Name = "menuitemTablas_Productos"
        Me.menuitemTablas_Productos.Size = New System.Drawing.Size(241, 22)
        Me.menuitemTablas_Productos.Text = "Productos"
        '
        'menuitemTablas_Cosechas
        '
        Me.menuitemTablas_Cosechas.Name = "menuitemTablas_Cosechas"
        Me.menuitemTablas_Cosechas.Size = New System.Drawing.Size(241, 22)
        Me.menuitemTablas_Cosechas.Text = "Cosechas"
        '
        'menuitemTablas_GruposUsuarios
        '
        Me.menuitemTablas_GruposUsuarios.Name = "menuitemTablas_GruposUsuarios"
        Me.menuitemTablas_GruposUsuarios.Size = New System.Drawing.Size(241, 22)
        Me.menuitemTablas_GruposUsuarios.Text = "Grupos de usuarios"
        '
        'menuitemTablas_GruposUsuariosPermisos
        '
        Me.menuitemTablas_GruposUsuariosPermisos.Name = "menuitemTablas_GruposUsuariosPermisos"
        Me.menuitemTablas_GruposUsuariosPermisos.Size = New System.Drawing.Size(241, 22)
        Me.menuitemTablas_GruposUsuariosPermisos.Text = "Permisos de grupos de usuarios"
        '
        'menuitemTablas_Usuarios
        '
        Me.menuitemTablas_Usuarios.Name = "menuitemTablas_Usuarios"
        Me.menuitemTablas_Usuarios.Size = New System.Drawing.Size(241, 22)
        Me.menuitemTablas_Usuarios.Text = "Usuarios"
        '
        'menuitemTablas_Tarifas
        '
        Me.menuitemTablas_Tarifas.Name = "menuitemTablas_Tarifas"
        Me.menuitemTablas_Tarifas.Size = New System.Drawing.Size(241, 22)
        Me.menuitemTablas_Tarifas.Text = "Tarifas"
        '
        'buttonPesadas
        '
        Me.buttonPesadas.Image = Global.CSPesaje.My.Resources.Resources.ImagePesadas32
        Me.buttonPesadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPesadas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPesadas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPesadas.Name = "buttonPesadas"
        Me.buttonPesadas.Size = New System.Drawing.Size(85, 36)
        Me.buttonPesadas.Text = "Pesadas"
        '
        'buttonResumenPesadas
        '
        Me.buttonResumenPesadas.Image = Global.CSPesaje.My.Resources.Resources.ImageResumen32
        Me.buttonResumenPesadas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonResumenPesadas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonResumenPesadas.Name = "buttonResumenPesadas"
        Me.buttonResumenPesadas.Size = New System.Drawing.Size(153, 36)
        Me.buttonResumenPesadas.Text = "Resumen de pesadas"
        '
        'buttonReportes
        '
        Me.buttonReportes.Image = Global.CSPesaje.My.Resources.Resources.ImageReportes32
        Me.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonReportes.Name = "buttonReportes"
        Me.buttonReportes.Size = New System.Drawing.Size(89, 36)
        Me.buttonReportes.Text = "Reportes"
        '
        'textboxKilogramo
        '
        Me.textboxKilogramo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textboxKilogramo.Dock = System.Windows.Forms.DockStyle.Right
        Me.textboxKilogramo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textboxKilogramo.ForeColor = System.Drawing.Color.Lime
        Me.textboxKilogramo.Location = New System.Drawing.Point(745, 3)
        Me.textboxKilogramo.MaxLength = 6
        Me.textboxKilogramo.Name = "textboxKilogramo"
        Me.textboxKilogramo.ReadOnly = True
        Me.textboxKilogramo.Size = New System.Drawing.Size(113, 38)
        Me.textboxKilogramo.TabIndex = 3
        Me.textboxKilogramo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanelUsuario
        '
        Me.TableLayoutPanelUsuario.ColumnCount = 4
        Me.TableLayoutPanelUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanelUsuario.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUsuario.Controls.Add(Me.LabelUsuarioDescripcion, 2, 1)
        Me.TableLayoutPanelUsuario.Controls.Add(Me.PictureBoxUsuarioAvatar, 1, 1)
        Me.TableLayoutPanelUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanelUsuario.Location = New System.Drawing.Point(417, 3)
        Me.TableLayoutPanelUsuario.Name = "TableLayoutPanelUsuario"
        Me.TableLayoutPanelUsuario.RowCount = 3
        Me.TableLayoutPanelUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanelUsuario.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanelUsuario.Size = New System.Drawing.Size(217, 38)
        Me.TableLayoutPanelUsuario.TabIndex = 4
        '
        'LabelUsuarioDescripcion
        '
        Me.LabelUsuarioDescripcion.AutoSize = True
        Me.LabelUsuarioDescripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelUsuarioDescripcion.Location = New System.Drawing.Point(130, 12)
        Me.LabelUsuarioDescripcion.Name = "LabelUsuarioDescripcion"
        Me.LabelUsuarioDescripcion.Size = New System.Drawing.Size(0, 13)
        Me.LabelUsuarioDescripcion.TabIndex = 5
        Me.LabelUsuarioDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBoxUsuarioAvatar
        '
        Me.PictureBoxUsuarioAvatar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxUsuarioAvatar.Location = New System.Drawing.Point(83, 12)
        Me.PictureBoxUsuarioAvatar.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxUsuarioAvatar.Name = "PictureBoxUsuarioAvatar"
        Me.PictureBoxUsuarioAvatar.Size = New System.Drawing.Size(44, 13)
        Me.PictureBoxUsuarioAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxUsuarioAvatar.TabIndex = 6
        Me.PictureBoxUsuarioAvatar.TabStop = False
        '
        'formMDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 415)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.menustripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menustripMain
        Me.Name = "formMDIMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Title"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.menustripMain.ResumeLayout(False)
        Me.menustripMain.PerformLayout()
        Me.panelMain.ResumeLayout(False)
        Me.panelMain.PerformLayout()
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.TableLayoutPanelUsuario.ResumeLayout(False)
        Me.TableLayoutPanelUsuario.PerformLayout()
        CType(Me.PictureBoxUsuarioAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents menustripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents menuitemArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Opciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Separador_CerrarSesion As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemArchivo_CerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Separador_Salir As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemArchivo_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAyuda_AcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemDebug As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents panelMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents dropdownbuttonTablas As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemTablas_Entidades As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Productos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Cosechas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_GruposUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_GruposUsuariosPermisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buttonPesadas As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonReportes As System.Windows.Forms.ToolStripButton
    Friend WithEvents textboxKilogramo As System.Windows.Forms.TextBox
    Friend WithEvents menuitemTablas_Tarifas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Camiones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_OrigenesDestinos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buttonResumenPesadas As ToolStripButton
    Friend WithEvents menuitemArchivo_CambiarContrasena As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemVentanaCerrar As ToolStripMenuItem
    Friend WithEvents ToolStripSeparatorVentana As ToolStripSeparator
    Friend WithEvents TableLayoutPanelUsuario As TableLayoutPanel
    Friend WithEvents LabelUsuarioDescripcion As Label
    Friend WithEvents PictureBoxUsuarioAvatar As PictureBox
End Class
