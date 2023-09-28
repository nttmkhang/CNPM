Public Class MH_Xu_ly_So_thuc
    Private Sub MH_Xu_ly_So_thuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Khai báo 2 số thực m,n 
		Dim m As Double = 15.5
		Dim n As Double = 5.5
		'==== Các phép tính cơ bản
		'Tong = m + n 
		Dim Tong As Double = m + n
		'Hieu = m-2 
		Dim Hieu As Double = m - n
		'Tich= m*n 
		Dim Tich As Double = m * n
		'Thuong = m/n
		Dim Thuong As Double = m / n
		'Phan_du = Số dư khi chia m cho n (3)
		Dim Phan_du As Double = m Mod n
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
		Dim So_lon_nhat As Double = Double.MaxValue
		Dim So_nho_nhat As Double = Double.MinValue


		Me.Close()
	End Sub
End Class