Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class PersonnelManager
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=khoanmps02132.mssql.somee.com;packet size=4096;user id=khoanmps02132;pwd=minhkhoa@123;data source=khoanmps02132.mssql.somee.com;persist security info=False;initial catalog=khoanmps02132"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Add.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "insert into NhanVien values (@Tennhanvien,@Manhanvien,@total)"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Manhanvien", txtcode.Text)
            com.Parameters.AddWithValue("@Tennhanvien", txtname.Text)
            com.Parameters.AddWithValue("@total", txttotal.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show(" connect successfully")
        Catch ex As Exception
            MessageBox.Show(" Not connect successfully")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loaddata()

    End Sub
    Private Sub loaddata()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", KetNoi)
        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)

        Catch ex As Exception

        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub PersonnelManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaddata()

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "delete from NhanVien where MaNV = @Manhanvien"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try
            com.Parameters.AddWithValue("@Manhanvien", txtcode.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("Delete")
        Catch ex As Exception
            MessageBox.Show("Can't Delete")

        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loaddata()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtname.Text = DataGridView1.Item(0, index).Value
        txtcode.Text = DataGridView1.Item(1, index).Value
        txttotal.Text = DataGridView1.Item(2, index).Value
    End Sub

    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles Modify.Click
        Dim KetNoi As New SqlConnection(connectstr)
        KetNoi.Open()
        Dim stradd As String = "update NhanVien SET TenNV = @Tennhanvien, HoaDon_MaHoaDon = @total where MaNV = @Manhanvien"
        Dim com As New SqlCommand(stradd, KetNoi)
        Try

            com.Parameters.AddWithValue("@Tennhanvien", txtname.Text)
            com.Parameters.AddWithValue("@Manhanvien", txtcode.Text)
            com.Parameters.AddWithValue("@total", txttotal.Text)
            com.ExecuteNonQuery()
            KetNoi.Close()
            MessageBox.Show("successfully")
        Catch ex As Exception
            MessageBox.Show("  Not successfully")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        loaddata()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class