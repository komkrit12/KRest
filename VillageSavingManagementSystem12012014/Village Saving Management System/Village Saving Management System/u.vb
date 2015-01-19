Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Windows.Forms



Public Class u

    Public Shared servername As String = "PC2013032317HNO"
    Public Shared login As String = "sa"
    Public Shared password As String = "tarnlalida"
    Public Shared database As String = "vsm"
    Public Shared constr As String = "Persist Security Info=False;Integrated Security=False;Server=" _
+ servername + ";user id=sa;password=" + password + ";initial catalog=" + database + ";"

    Public Shared connecttion As SqlConnection
    Public Shared command As SqlCommand
    Public Shared transaction As SqlTransaction
    Dim appPath As String = Application.StartupPath


    Public Class IniFiles                 '???????????????


    End Class

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()    '????????????????????
        MyBase.Finalize()
    End Sub

    Public Sub Internalloaddata()       '??????????????????


    End Sub



    Public Shared Sub modifydata(ByVal conn As SqlConnection, ByVal tran As SqlTransaction, ByVal sql As String)
        Dim command As New SqlCommand
        command = New SqlCommand

        Try
            With command
                .CommandType = CommandType.Text
                .CommandText = sql
                .CommandTimeout = 999999         '??????????????????????
                .Transaction = tran
                .Connection = conn
                .ExecuteNonQuery()

            End With

        Finally
            command = Nothing

        End Try

    End Sub


    Public Shared Function Querydata(ByVal conn As SqlConnection, ByVal sql As String) As DataTable
        Dim command As New SqlCommand
        Dim dataset As New DataSet
        Dim adepter As New SqlDataAdapter

        dataset = New DataSet
        command = New SqlCommand

        Try
            With command
                .CommandType = CommandType.Text
                .CommandText = sql
                .CommandTimeout = 999999            '???????????????????
                .Connection = conn

                adepter = New SqlDataAdapter(command)
                adepter.Fill(dataset, "Querydata")


                If (Not dataset Is Nothing) Then

                    If dataset.Tables("DataQuery").Rows.Count > 0 Then
                        Return dataset.Tables("DataQuery")
                    Else
                        Return Nothing
                    End If
                Else
                    Return Nothing
                End If
            End With

        Finally

            dataset = Nothing
            command = Nothing

        End Try

    End Function



End Class
