Imports MySqlConnector
Module DataModule
    Public Function GetAllData() As DataTable
        Dim dt As New DataTable()

        Dim query As String = "SELECT * FROM penerima_bantuan ORDER BY nkk ASC"

        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function
    Public Function SearchData(keyword As String) As DataTable
        Dim dt As New DataTable()

        Dim query As String =
            "SELECT * FROM penerima_bantuan WHERE " &
            "nkk LIKE @key OR nama LIKE @key"

        Using conn As MySqlConnection = GetConnection()
            Using da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function
    Public Function SimpanData(nkk As String, nama As String, alamat As String,
                          telp As String, rekening As String, gender As String,
                          pendapatan As Double, jumlah As Double, deskripsi As String) As Boolean

        Dim query As String = "INSERT INTO penerima_bantuan VALUES (@nkk,@nama,@alamat,@telp,@rek,@gender,@pend,@jumlah,@desk)"

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nkk", nkk)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@telp", telp)
                cmd.Parameters.AddWithValue("@rek", rekening)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@pend", pendapatan)
                cmd.Parameters.AddWithValue("@jumlah", jumlah)
                cmd.Parameters.AddWithValue("@desk", deskripsi)

                cmd.ExecuteNonQuery()
            End Using
        End Using

        Return True
    End Function
    Public Function UbahData(nkk As String, nama As String, alamat As String,
                        telp As String, rekening As String, gender As String,
                        pendapatan As Double, jumlah As Double, deskripsi As String) As Boolean

        Dim query As String = "UPDATE penerima_bantuan SET 
        nama=@nama, alamat=@alamat, no_telp=@telp, 
        no_rekening=@rek, gender=@gender, 
        pendapatan=@pend, jumlah_bantuan=@jumlah, deskripsi=@desk 
        WHERE nkk=@nkk"

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nkk", nkk)
                cmd.Parameters.AddWithValue("@nama", nama)
                cmd.Parameters.AddWithValue("@alamat", alamat)
                cmd.Parameters.AddWithValue("@telp", telp)
                cmd.Parameters.AddWithValue("@rek", rekening)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@pend", pendapatan)
                cmd.Parameters.AddWithValue("@jumlah", jumlah)
                cmd.Parameters.AddWithValue("@desk", deskripsi)

                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function
    Public Function HapusData(nkk As String) As Boolean

        Dim query As String = "DELETE FROM penerima_bantuan WHERE nkk=@nkk"

        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nkk", nkk)
                Return cmd.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function



End Module
