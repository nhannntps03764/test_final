Imports System.Data.SqlClient
Imports System.Data
Public Class Class1

    Public Function Loadsanpham() As DataSet
        Dim chuoiketnoi As String = "workstation id=ps03764.mssql.somee.com;packet size=4096;user id=ps03764_SQLLogin_1;pwd=mhzqynwrs5;data source=ps03764.mssql.somee.com;persist security info=False;initial catalog=ps03764"
        Dim conn As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim LoadSP As New SqlDataAdapter("select SANPHAM.MASP as 'Mã sản phẩm',SANPHAM.TENSP as 'Tên sản phẩm', LOAISANPHAM.MALOAI as 'Mã Loại', LOAISANPHAM.TENLOAI as 'Tên Loại',SANPHAM.SOLUONG as 'Số lượng' from SANPHAM inner join LOAISANPHAM on SANPHAM.MASP = LOAISANPHAM.MASP", conn)
        Dim db As New DataSet
        conn.Open()
        LoadSP.Fill(db)
        conn.Close()
        Return db
    End Function
End Class
