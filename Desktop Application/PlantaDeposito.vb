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

Partial Public Class PlantaDeposito
    Public Property IDPlanta As Byte
    Public Property IDDeposito As Byte
    Public Property Nombre As String
    Public Property CapacidadToneladasBaseTrigo As Nullable(Of Short)
    Public Property Notas As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Pesadas As ICollection(Of Pesada) = New HashSet(Of Pesada)
    Public Overridable Property Planta As Planta
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class