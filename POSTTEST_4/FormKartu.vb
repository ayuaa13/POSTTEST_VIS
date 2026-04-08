Imports System.Reflection.Emit

Public Class FormKartu

    Public nama As String
    Public id As String
    Public komunitas As String
    Public telepon As String
    Public hobby As String
    Public foto As Image
    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = nama
        lblID.Text = id
        lblKomunitas.Text = komunitas
        lblTelepon.Text = telepon
        lblHobby.Text = hobby
        picFotoCetak.Image = foto
    End Sub
End Class