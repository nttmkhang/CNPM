Public Class MH_Xu_ly_bien_logic
    Private Sub MH_Xu_ly_bien_logic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		'Khai báo 2 biến logic f,g
		Dim f As Boolean = True
		Dim g As Boolean = False
		'====Các phép tính cơ bản ====
		'Giao = kết quả phép giao f,g
		Dim Giao As Boolean = f And g
		'Hop = kết quả hợp f,g
		Dim Hop As Boolean = f Or g
		'Phu_dinh = Phủ định của f 
		Dim Phu_dinh As Boolean = Not f
		'===Gán giá trị====
		Dim m As Integer = 10
		Dim n As Integer = 13

		Dim Hop_le_1 As Boolean = m > n
		Dim Hop_le_2 As Boolean = m <= n
		Dim Hop_le_3 As Boolean = m = n
		Dim Hop_le_4 As Boolean = m <> n

		Me.Close()
	End Sub
End Class