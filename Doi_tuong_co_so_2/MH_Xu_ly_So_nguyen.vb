Public Class MH_Xu_ly_So_nguyen
    Private Sub MH_Xu_ly_So_nguyen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Khai báo 2 số nguyên m,n 
		Dim m As Integer = 23
		Dim n As Integer = 4
		'==== Các phép tính cơ bản
		'Tong = m + n 
		Dim Tong As Integer = m + n
		'Hieu = m-2 
		Dim Hieu As Integer = m - n
		'Tich= m*n 
		Dim Tich As Integer = m * n
		'Thuong = m/n
		Dim Thuong As Double = m / n
		'Phan_du = Số dư khi chia m cho n (3)
		Dim Phan_du As Integer = m Mod n
		'Phan_nguyen = Số nguyên khi chia m cho n (5)
		Dim Phan_nguyen As Integer = m \ n
		'======Các hàm thư viện cơ bản =======
		'x= căn bậc hai của m
		Dim x As Double = Math.Sqrt(m)
		'y= m lũy thừa 4
		Dim y As Double = Math.Pow(m, 4)
		'z=x sau khi làm tròn đến 2 số thập phân 
		Dim z As Double = Math.Round(x, 2)
		'======Một số hàm xử lý khác======
		Dim So_lon_nhat As Integer = Integer.MaxValue
		Dim So_nho_nhat As Integer = Integer.MinValue


		Me.Close()
	End Sub
End Class