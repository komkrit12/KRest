Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Public Class class_conn
    Private DTDataReturn As DataTable
    Private StrValue As String
    Private checkeduser As Boolean = False
    Dim connect As SqlConnection
    Dim da As SqlDataAdapter
    Dim dt As DataTable
    Dim command As SqlCommand
    Dim connectstring As String = "Data Source=.; Initial Catalog=Village;Integrated Security=True"

    Public Function selectbase(ByVal sql As String) As DataTable
        Try
            connect = New SqlConnection(connectstring)
            connect.Open()
            da = New SqlDataAdapter(sql, connect)

            connect.Close()

            dt = New DataTable
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function writebase(ByVal sqlcommand As String) As Boolean
        connect = New SqlConnection(connectstring)
        Try
            Using cmd As New SqlCommand(sqlcommand, connect)
                connect.Open()
                cmd.ExecuteNonQuery()
                connect.Close()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


End Class

