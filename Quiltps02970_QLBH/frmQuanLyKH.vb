Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQuanLyKH
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanlyBHQuiltps02970.mssql.somee.com;packet size=4096;user id=quiluong9296_SQLLogin_2;pwd=fckqhnbr5c;data source=QuanlyBHQuiltps02970.mssql.somee.com;persist security info=False;initial catalog=QuanlyBHQuiltps02970"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Sub LoadData()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', Sdt from Ps02970_KH", conn)
        db.Clear()
        refesh.Fill(db)
        DataGridView1.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub btnTHEM_Click(sender As Object, e As EventArgs) Handles btnTHEM.Click
        Reset()
    End Sub
    Private Sub reset()
        txtMAKH.Text = ""
        txtTENKH.Text = ""
        txtDiachi.Text = ""
        txtsdt.Text = ""
        txtMAKH.Focus()
    End Sub

    Private Sub btnLUU_Click(sender As Object, e As EventArgs) Handles btnLUU.Click
        If txtMAKH.Text = "" Then
            MessageBox.Show("Chưa Nhập Mã Khách Hàng")
            txtMAKH.Focus()
        ElseIf txtTENKH.Text = "" Then
            MessageBox.Show("Chưa Nhập Tên Khách Hàng")
            txtTENKH.Focus()
        ElseIf txtDiachi.Text = "" Then
            MessageBox.Show("Chưa Nhập Địa chỉ")
            txtDiachi.Focus()
        ElseIf txtsdt.Text = "" Then
            MessageBox.Show("Chưa Nhập SDT")
            txtsdt.Focus()
        Else
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "insert into Ps02970_KH values(@MAKH,@TENKH,@DIACHI,@SDT)"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@TENKH", txtTENKH.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDiachi.Text)
            save.Parameters.AddWithValue("@SDT", txtsdt.Text)
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
        If txtMAKH.Text = "" Then
            MessageBox.Show("Nhập MAKH cần xóa")
            txtTENKH.Focus()
        Else
            Dim delquery As String = "delete from Ps02970_KH where MaKH=@MAKH"
            Dim delete As SqlCommand = New SqlCommand(delquery, conn)
            Dim resulft As DialogResult = MessageBox.Show("Bạn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If resulft = System.Windows.Forms.DialogResult.Yes Then
                conn.Open()
                delete.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
                delete.ExecuteNonQuery()
                conn.Close()
                MessageBox.Show("Xóa thành công")
                LoadData()
            End If
        End If
    End Sub

    Private Sub btnSUA_Click(sender As Object, e As EventArgs) Handles btnSUA.Click
        If btnSUA.Text = "Sửa" Then
            txtMAKH.ReadOnly = True
            btnSUA.Text = "Cập nhật"
            txtTENKH.Focus()
        ElseIf btnSUA.Text = "Cập nhật" Then
            Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
            Dim query As String = "update Ps02970_KH set MaKH=@MAKH, TenKH=@TENKH, DIACHI=@DIACHI, SDT=@SDT where MaKH=@MAKH"
            Dim save As SqlCommand = New SqlCommand(query, conn)
            conn.Open()
            save.Parameters.AddWithValue("@MAKH", txtMAKH.Text)
            save.Parameters.AddWithValue("@TENKH", txtTENKH.Text)
            save.Parameters.AddWithValue("@DIACHI", txtDiachi.Text)
            save.Parameters.AddWithValue("@SDT", txtsdt.Text)
            save.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("Update thành công")
            txtMAKH.ReadOnly = False
            btnSUA.Text = "Sửa"
            LoadData()
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim click As Integer = DataGridView1.CurrentCell.RowIndex
        txtMAKH.Text = DataGridView1.Item(0, click).Value
        txtTENKH.Text = DataGridView1.Item(1, click).Value
        txtDiachi.Text = DataGridView1.Item(2, click).Value
        txtsdt.Text = DataGridView1.Item(3, click).Value
    End Sub

End Class
