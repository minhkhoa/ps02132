Public Class Main

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
        Application.Exit()

    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        PersonnelManager.Show()

    End Sub

    Private Sub ProductManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductManagerToolStripMenuItem.Click
        ProductManager.Show()
    End Sub

    Private Sub CopyrightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyrightToolStripMenuItem.Click
        MessageBox.Show("PS02132-PT9304-Assignment-Điện Toán Đám Mây")
    End Sub
End Class