Imports System.Data
Imports System.Data.SqlClient

Module general
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Public ds As New DataSet
    Public adapter As New SqlDataAdapter


    Public query, user As String

End Module
