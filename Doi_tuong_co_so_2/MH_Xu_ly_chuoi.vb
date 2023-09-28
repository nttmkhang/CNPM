Public Class MH_Xu_ly_chuoi
    Private Sub MH_Xu_ly_chuoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'khai báo chuỗi Ho_ten
		Dim Ho_ten As String = "Trần Văn Long"
		'====Một số xử lý cơ bản=====
		'f = Điều kiện Ho_ten có chứa chuỗi "Nguyễn"
		'n = Chỉ số của chuỗi Long tromg Ho_ten
		Dim n As Integer = Ho_ten.IndexOf("Long")
		'Xoa = Chuỗi sau khi xóa chuỗi n trong Ho_ten
		Dim Xoa As String = Ho_ten.Replace("n", "")
		'Thay_the = Chuỗi sau khi thay thế Trần bởi Lê 
		Dim Thay_the As String = Ho_ten.Replace("Trần", "Lê")
		'Bo_sung = Chuỗi sau khi bổ sung vào vị trí thứ 4 chuỗi Ngọc
		Dim Bo_sung As String = Ho_ten.Insert(4, " Ngọc")
		'Ho = họ của chuỗi Ho_ten
		Dim M As String() = Split(Ho_ten, " ")
		Dim Ho As String = M(0)

		Dim S As String = " 4x + 15 - 6 "
		Dim Phan_cach As String() = New String() {"+", "-"}
		Dim p As String() = S.Split(Phan_cach, StringSplitOptions.None)

		Me.Close()

	End Sub
End Class