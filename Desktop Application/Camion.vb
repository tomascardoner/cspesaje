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

Partial Public Class Camion
    Public Property IDEntidad As Integer
    Public Property IDCamion As Byte
    Public Property Nombre As String
    Public Property DominioChasis As String
    Public Property DominioAcoplado As String
    Public Property NombreDominios As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Choferes As ICollection(Of Entidad) = New HashSet(Of Entidad)
    Public Overridable Property Pesadas As ICollection(Of Pesada) = New HashSet(Of Pesada)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property Transportista As Entidad

End Class