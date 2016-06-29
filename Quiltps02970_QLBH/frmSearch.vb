Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmSearch
    Dim db As New DataTable
    Dim chuoiketnoi As String = "workstation id=QuanlyBHQuiltps02970.mssql.somee.com;packet size=4096;user id=quiluong9296_SQLLogin_2;pwd=fckqhnbr5c;data source=QuanlyBHQuiltps02970.mssql.somee.com;persist security info=False;initial catalog=QuanlyBHQuiltps02970"
    Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
    Private Databaseaccess As New DataBaseAccess
    'Load Dữ Liệu Tìm Kiếm
    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataTimKiem()
    End Sub
    Private Sub LoadDataTimKiem()
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        conn.Open()
        Dim refesh As SqlDataAdapter = New SqlDataAdapter("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa Chỉ', Sdt as 'Số Điện Thoại' from Ps02970_KH", conn)
        db.Clear()
        refesh.Fill(db)
        dgvSearch.DataSource = db.DefaultView
        conn.Close()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        SearchKhachHang(txtSearch.Text)
    End Sub
    Private Sub SearchKhachHang(value As String)
        Dim sqlQuery As String = String.Format("select MaKH as 'Mã KH' ,TenKH as 'Tên Khách Hàng', DiaChi as 'Địa Chỉ', Sdt as 'Số Điện Thoại' from Ps02970_KH")
        If cmbSearch.SelectedIndex = 0 Then
            sqlQuery += String.Format(" where MaKH like '{0}%'", value)
        ElseIf cmbSearch.SelectedIndex = 1 Then
            sqlQuery += String.Format(" where TenKH LIKE N'{0}%'", value)
        ElseIf cmbSearch.SelectedIndex = 2 Then
            sqlQuery += String.Format(" where DiaChi LIKE N'{0}%'", value)
        ElseIf cmbSearch.SelectedIndex = 3 Then
            sqlQuery += String.Format(" where Sdt LIKE N'{0}%'", value)
        End If
        Dim data As DataTable = Databaseaccess.GetDataTable(sqlQuery)
        dgvSearch.DataSource = data
        With dgvSearch
            .Columns(0).HeaderText = "Mã Khách Hàng"
            .Columns(1).HeaderText = "Tên Khách Hàng"
            .Columns(2).HeaderText = "Địa Chỉ"
            .Columns(3).HeaderText = "Số Điện Thoại"
            .Columns(3).Width = 250
        End With
    End Sub
End Class
