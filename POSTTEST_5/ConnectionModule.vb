Imports MySql.Data.MySqlClient

Module ConnectionModule
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet

    Public Sub koneksi()
        Try
            conn = New MySqlConnection("server=localhost;user id=root;password=;database=db_bantuan")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module