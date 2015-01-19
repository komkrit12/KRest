Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Windows.Forms


Public Class uConnect

    Public Shared servername As String = "PC2013032317HNO"
    Public Shared id As String = "sa"
    Public Shared password As String = "tarnlalida"
    Public Shared Database As String = "Village Saving Management"
    Public Shared conStr As String = "Persist Security Info=False;Integrated Security=False;Server=" _
+ servername + ";user id=sa;password=" + password + ";initial catalog=" + Database + ";"

    Public Shared Connecttion As New SqlConnection(conStr)
    Public Shared command As New SqlCommand
    Public Shared transection As SqlTransaction

    Dim appPath As String = Application.StartupPath

    
    Public Class IniFiles

    End Class

    Public Sub New()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub


    Public Sub Internalloaddata()

    End Sub


    Public Shared Sub ModifyData_Str(ByVal conModify As SqlConnection, ByVal tran As SqlTransaction, ByVal sql As String)

        Dim command As New SqlCommand

        command = New SqlCommand

        Try

            With command
                .CommandType = CommandType.Text

                .CommandText = sql
                .CommandTimeout = 999999
                .Transaction = tran
                .Connection = conModify
                .ExecuteNonQuery()
            End With

        Finally
            command = Nothing
        End Try

    End Sub

    Public Shared Function QueryData_Str(ByVal conModify As SqlConnection, _
                                    ByVal vsql As String) As DataTable
        Dim command As New SqlCommand
        Dim dataset As New DataSet
        Dim adapter As New SqlDataAdapter

        dataset = New DataSet
        command = New SqlCommand

        Try
            With command
                .CommandType = CommandType.Text
                .CommandText = vsql
                .CommandTimeout = 999999
                .Connection = conModify

                adapter = New SqlDataAdapter(command)
                adapter.Fill(dataset, "DataQuery")

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
