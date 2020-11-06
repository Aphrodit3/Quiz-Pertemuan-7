Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles prs.Click
        Dim bil1 As Integer = tb3.Text
        Dim bil2 As Integer = tb4.Text
        Dim bil3 As Integer
        Dim Nama As String
        Dim a As String
        Nama = " Gaji Karyawan Dengan Nama"
        a = " Adalah "
        Val(tb1.Text)
        Val(tb2.Text)
        bil3 = bil1 + bil2
        txtjumlah.Text = bil3
        MsgBox(Nama & tb1.Text & a & txtjumlah.Text)
    End Sub

    Private Sub tb5_TextChanged(sender As Object, e As EventArgs) Handles txtjumlah.TextChanged

    End Sub
End Class