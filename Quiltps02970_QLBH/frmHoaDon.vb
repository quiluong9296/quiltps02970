Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmHoaDon
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanlyBHQuiltps02970.mssql.somee.com;packet size=4096;user id=quiluong9296_SQLLogin_2;pwd=fckqhnbr5c;data source=QuanlyBHQuiltps02970.mssql.somee.com;persist security info=False;initial catalog=QuanlyBHQuiltps02970"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaHD as 'Mã HD' ,NgayXuatHD as 'Ngày Xuất HD', MaKH from Ps02970_HD", conn)
        db.Clear()
        refesh.Fill(db)
        dgvHoadon.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub btnTHEM_Click(sender As Object, e As EventArgs) Handles btnTHEM.Click
        reset()
    End Sub
    Private Sub reset()
        txtMAHD.Text = ""
        txtDate.Text = ""
        txtMaKH.Text = ""
        txtMAHD.Focus()
    End Sub

    Private Sub btnLUU_Click(sender As Object, e As EventArgs) Handles btnLUU.Click
        If txtMAHD.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Hoá Đơn")
            txtMAHD.Focus()
        ElseIf txtDate.Text = "" Then
            MessageBox.Show("Ngày Xuất HD")
            txtDate.Focus()
        ElseIf txtMaKH.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Khách Hàng")
            txtMaKH.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into Ps02970_HD values(@MAHD,@NGAYXUATHD,@MAKH)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAHD", txtMAHD.Text)
            save.Parameters.AddWithValue("@NGAYXUATHD", txtDate.Text)
            save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Lưu thành công")
            LoadData()
        End If
    End Sub

    Private Sub frmQuanLyKH_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnXOA_Click(sender As Object, e As EventArgs) Handles btnXOA.Click
        If txtMAHD.Text = "" Then
            MessageBox.Show("Nhập MAHD cần xóa")
            txtDate.Focus()
        Else
            Dim delquery As String = "delete from Ps02970_HD where MaKH=@MAKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = System.Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAHD", txtMAHD.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSUA_Click(sender As Object, e As EventArgs) Handles btnSUA.Click
        If btnSUA.Text = "Sửa" Then
            txtMAHD.ReadOnly = True
            btnSUA.Text = "Cập nhật"
            txtDate.Focus()
        ElseIf btnSUA.Text = "Cập nhật" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update Ps02970_HD set MaDH=@MAHD, NgayXuatHD=@NGAYXUATHD, MaKH=@MAKH where MaHD=@MAHD"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAHD", txtMAHD.Text)
            save.Parameters.AddWithValue("@NGAYXUATHD", txtDate.Text)
            save.Parameters.AddWithValue("@MAKH", txtMaKH.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMAHD.ReadOnly = False
            btnSUA.Text = "Sửa"
            LoadData()
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoadon.CellContentClick
        Dim click As Integer = dgvHoadon.CurrentCell.RowIndex
        txtMAHD.Text = dgvHoadon.Item(0, click).Value
        txtDate.Text = dgvHoadon.Item(1, click).Value
        txtMaKH.Text = dgvHoadon.Item(2, click).Value
    End Sub
End Class