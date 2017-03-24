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

Partial Public Class Producto
    Public Property IDProducto As Byte
    Public Property Nombre As String
    Public Property MermaVolatil As Nullable(Of Decimal)
    Public Property MermaHumedadBase As Nullable(Of Decimal)
    Public Property MermaHumedadManipuleo As Nullable(Of Decimal)
    Public Property UtilizaPlanta As Boolean
    Public Property UtilizaCosecha As Boolean
    Public Property UsoFrecuente As Boolean
    Public Property UltimoUso As Date
    Public Property ReporteNombre As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Cosechas_Productos_Tarifas As ICollection(Of Cosecha_Producto_Tarifa) = New HashSet(Of Cosecha_Producto_Tarifa)
    Public Overridable Property Pesadas As ICollection(Of Pesada) = New HashSet(Of Pesada)
    Public Overridable Property Productos_Cosechas As ICollection(Of Producto_Cosecha) = New HashSet(Of Producto_Cosecha)
    Public Overridable Property Productos_Plantas As ICollection(Of Producto_Planta) = New HashSet(Of Producto_Planta)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property Producto_Humedades As ICollection(Of Producto_Humedad) = New HashSet(Of Producto_Humedad)

End Class
