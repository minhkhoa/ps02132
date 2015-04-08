Imports System.Data.SqlClient

Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chuoiketnoi As String = "workstation id=khoanmps02132.mssql.somee.com;packet size=4096;user id=khoanmps02132;pwd=minhkhoa@123;data source=khoanmps02132.mssql.somee.com;persist security info=False;initial catalog=khoanmps02132"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where TenNV='" & txtuser.Text & "' and MaNV='" & txtpass.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("ket nối thành công")
                Main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tai Khoan hoac Mat Khau")
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class
