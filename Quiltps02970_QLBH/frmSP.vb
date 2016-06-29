Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmSP
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanlyBHQuiltps02970.mssql.somee.com;packet size=4096;user id=quiluong9296_SQLLogin_2;pwd=fckqhnbr5c;data source=QuanlyBHQuiltps02970.mssql.somee.com;persist security info=False;initial catalog=QuanlyBHQuiltps02970"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaSP as 'Mã SP' ,TenSP as 'Tên Sản Phẩm', DonGia as 'Đơn giá', MaLoaiSP from Ps02970_SP", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSP.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub btnTHEM_Click(sender As Object, e As EventArgs) Handles btnTHEM.Click
        reset()
    End Sub
    Private Sub reset()
        txtMASP.Text = ""
        txtTENSP.Text = ""
        txtDonGia.Text = ""
        txtMaLoaiSP.Text = ""
        txtMASP.Focus()
    End Sub

    Private Sub btnLUU_Click(sender As Object, e As EventArgs) Handles btnLUU.Click
        If txtMASP.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Sản Phẩm")
            txtMASP.Focus()
        ElseIf txtTENSP.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên Sản Phẩm")
            txtTENSP.Focus()
        ElseIf txtDonGia.Text = "" Then
            MessageBox.Show("Chưa Nhập Đơn Giá")
            txtDonGia.Focus()
        ElseIf txtMaLoaiSP.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Loại SP")
            txtMaLoaiSP.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into Ps02970_LoaiSP values(@MaLoaiSP, @TenLoaiSP) insert into Ps02970_SP values(@MASP,@TENSP,@DONGIA,@MALOAISP) "
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMASP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDonGia.Text)
            save.Parameters.AddWithValue("@MALOAISP", txtMaLoaiSP.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub frmSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnXOA_Click(sender As Object, e As EventArgs) Handles btnXOA.Click
        If txtMASP.Text = "" Then
            MessageBox.Show("Nhập MASP cần xóa")
            txtTENSP.Focus()
        Else
            Dim delquery As String = "delete from Ps02970_SP where MaSP=@MASP"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = System.Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MASP", txtMASP.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSUA_Click(sender As Object, e As EventArgs) Handles btnSUA.Click
        If btnSUA.Text = "Sửa" Then
            txtMASP.ReadOnly = True
            btnSUA.Text = "Cập nhật"
            txtTENSP.Focus()
        ElseIf btnSUA.Text = "Cập nhật" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update Ps02970_SP set MaSP=@MASP, TenSP=@TENSP, DonGia=@DONGIA, MaLoaiSP=@MALOAISP where MaSP=@MASP"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MASP", txtMASP.Text)
            save.Parameters.AddWithValue("@TENSP", txtTENSP.Text)
            save.Parameters.AddWithValue("@DONGIA", txtDonGia.Text)
            save.Parameters.AddWithValue("@MALOAISP", txtMaLoaiSP.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMASP.ReadOnly = False
            btnSUA.Text = "Sửa"
            LoadData()
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSP.CellContentClick
        Dim click As Integer = dgvSP.CurrentCell.RowIndex
        txtMASP.Text = dgvSP.Item(0, click).Value
        txtTENSP.Text = dgvSP.Item(1, click).Value
        txtDonGia.Text = dgvSP.Item(2, click).Value
        txtMaLoaiSP.Text = dgvSP.Item(3, click).Value
    End Sub
End Class