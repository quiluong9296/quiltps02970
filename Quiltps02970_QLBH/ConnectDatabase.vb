Imports System.Data.SqlClient
Imports System.Data
Public Class ConnectDatabase
    Public Function Loadkhachang() As DataSet
        Dim chuoiketnoi As String = "workstation id=QuanlyBHQuiltps02970.mssql.somee.com;packet size=4096;user id=quiluong9296_SQLLogin_2;pwd=fckqhnbr5c;data source=QuanlyBHQuiltps02970.mssql.somee.com;persist security info=False;initial catalog=QuanlyBHQuiltps02970"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadKH As New SqlDataAdapter("select MaKH as 'Mã KH' ,TENKH as 'Tên Khách Hàng', DIACHI as 'Địa chỉ', SDT from KHACHHANG", conn)
        Dim LoadSP As New SqlDataAdapter("select MaSP as 'Mã SP' ,TenSP as 'Tên Sản Phẩm', DonGia as 'Đơn giá', MaLoaiSP from Ps02970_SP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadKH.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
