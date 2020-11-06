Public Class Form1
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles chkmigor.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub konfirm_Click(sender As Object, e As EventArgs) Handles konfirm.Click
        Dim Pilihan As String
        Pilihan = " Anda Memilih "
        If chknasgor.Checked = True Then
            Pilihan = Pilihan & " Nasi Goreng "
        ElseIf chkobeng.Checked = True Then
            Pilihan = Pilihan & " Teh Obeng"
        ElseIf chkmigor.Checked = True Then
            Pilihan = Pilihan & " Mie Goreng "
        ElseIf chkagor.Checked = True Then
            Pilihan = Pilihan & " Ayam Goreng "
        End If
        MsgBox(Pilihan & " Pesanan Akan Segera Dibuatkan ")
    End Sub
End Class
