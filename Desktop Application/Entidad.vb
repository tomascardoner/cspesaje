'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Entidad
    Public Property IDEntidad As Integer
    Public Property Nombre As String
    Public Property CUIT_CUIL As String
    Public Property EsTitular As Boolean
    Public Property EsTransportista As Boolean
    Public Property EsChofer As Boolean
    Public Property Transportista_IDEntidad As Nullable(Of Integer)
    Public Property IDCamion As Nullable(Of Byte)
    Public Property UsoFrecuente As Boolean
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Camion As Camion
    Public Overridable Property EntidadesChoferes As ICollection(Of Entidad) = New HashSet(Of Entidad)
    Public Overridable Property EntidadTransportista As Entidad
    Public Overridable Property PesadasComoChofer As ICollection(Of Pesada) = New HashSet(Of Pesada)
    Public Overridable Property PesadasComoTitular As ICollection(Of Pesada) = New HashSet(Of Pesada)
    Public Overridable Property PesadasComoTransportista As ICollection(Of Pesada) = New HashSet(Of Pesada)
    Public Overridable Property Entidades_OrigenesDestinos As ICollection(Of Entidad_OrigenDestino) = New HashSet(Of Entidad_OrigenDestino)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property Camiones As ICollection(Of Camion) = New HashSet(Of Camion)
    Public Overridable Property Entidad_Productos_Plantas As ICollection(Of Entidad_Producto_Planta) = New HashSet(Of Entidad_Producto_Planta)

End Class
