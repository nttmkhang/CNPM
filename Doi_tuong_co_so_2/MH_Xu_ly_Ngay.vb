Imports System.Diagnostics.Eventing.Reader
Imports System.Security.Cryptography

Public Class MH_Xu_ly_Ngay
	Private Sub MH_Xu_ly_Ngay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'Khai báo 1 ngày Ngay
		Dim Ngay As New Date(1980, 3, 6)
		'====Trích rút thông tin=====
		'Ng = Số thứ tự ngày của Ngay
		Dim Ng As Integer = Ngay.Day
		'Th = Số thứ tự tháng của Ngay
		Dim Th As Integer = Ngay.Month
		'Nm = Số thứ tự năm của Ngay
		Dim Nm As Integer = Ngay.Year
		'n = số thứ tự trong năm của Ngay
		Dim n As Integer = Ngay.DayOfYear
		'Thu = Thứ trong tuần lễ của Ngay
		Dim Thu As String = Ngay.DayOfWeek
		'Ngay_lon_nhat= Ngày lớn nhất
		Dim Ngay_lon_nhat As Date = Date.MaxValue
		'Ngay_nho_nhat = Ngày nhỏ nhất 
		Dim Ngay_nho_nhat As Date = Date.MinValue
		'===========Hàm xử lý tính toán============
		'Ngay_hom_sau = Ngày hôm sau của Ngay
		Dim Ngay_hom_sau As Date = Ngay.AddDays(1)
		'Ngay_hom_Qua = Ngyaf hôm qua của Ngay
		Dim Ngay_hom_qua As Date = Ngay.AddDays(-1)
		'd = Khoảng cách theo ngày từ Ngay đến 11/3/1981
		Dim Thoi_gian As TimeSpan = New Date(1981, 3, 11) - Ngay
		Dim d As Integer = Thoi_gian.Days






		'Ghi chú :
		'Phải có kiểm tra dữ liệu nhập 

	End Sub





	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		'Bài tập 1
		'Nhập vào số tiền gởi, Ngày gởi, Ngày rút, Lãi suất năm của một sổ tiết kiệm
		Dim Chuoi_loi As String = Kiem_tra()
		'Dim So_tien_goi As Integer = 2000000
		'Dim Ngay_goi As New Date(1990, 10, 2)
		'Dim Ngay_rut As New Date(2000, 10, 2)
		'Dim Lai_suat_nam As Double = 0.5
		If Chuoi_loi = "" Then
			Dim So_tien_goi As Integer = Th_So_tien_gui.Text
			Dim Ngay_goi As Date = Th_Ngay_gui.Text
			Dim Ngay_rut As Date = Th_Ngay_rut.Text
			Dim Lai_suat_nam As Double = Th_Lai_suat_nam.Text

			Dim Lai_suat_ngay As Double = Lai_suat_nam / 365
			Dim So_ngay_goi As TimeSpan = Ngay_rut - Ngay_goi
			Dim Tien_lai As Double = So_ngay_goi.Days * Lai_suat_ngay
			Dim Tien_rut As Double = So_tien_goi + Tien_lai
			Th_So_tien_rut.Text = Tien_rut.ToString()

			MessageBox.Show("Đã nhập liệu và xử lý")
		Else
			Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf & Chuoi_loi 'vbCrLf là lệnh để xuống dòng
			MessageBox.Show(Thong_bao)
		End If

		'Tính và xuất tiền rút theo công thức 
		'Tiền rút = Số tiền gởi + Tiền lãi
		'Tiền lãi = Số Ngày gởi + Lãi suất ngày
		'Số ngày gởi = Khoảng cách từ ngày rút đến ngày gởi 
		'Lãi suất ngày =  Lãi suất năm/365 
	End Sub
	Function Kiem_tra() As String
		Dim kq As String = "" 'Khong co loi 
		Dim Hop_le As Boolean
		'Số tiền gửi lớn hơn 0 
		Dim i As Integer
		If Th_So_tien_gui.Text.Trim = "" Then
			kq = kq & "Số tiền gửi không được để trống" & vbCrLf
		Else
			Dim k As Integer = Integer.TryParse(Th_So_tien_gui.Text, i)
			Hop_le = i > 0
			If Not Hop_le Then
				kq = kq & "Số tiền gửi phải có giá trị lớn hơn 0 " & vbCrLf
			End If
		End If


		Dim l As Double
		If Th_Lai_suat_nam.Text.Trim = "" Then
			kq = kq & "Số lãi suất năm không được để trống" & vbCrLf
		Else
			Dim n As Double = Double.TryParse(Th_Lai_suat_nam.Text, l)
			Hop_le = l > 0
			If Not Hop_le Then
				kq = kq & "Lãi suất năm phải lơn hơn 0 " & vbCrLf
			End If
		End If



		Dim d1 As Date
		Dim d2 As Date
		Dim Ngay_gui As Boolean = Date.TryParse(Th_Ngay_gui.Text, d1)
		Dim Ngay_rut As Boolean = Date.TryParse(Th_Ngay_rut.Text, d2)
		If (Th_Ngay_gui.Text.Trim = "") Then
			kq = kq & "Ngày gửi không được để trống"
		Else
			If (Th_Ngay_rut.Text.Trim = "") Then
				kq = kq & "Ngày rút không được để trống"
			Else
				Dim time As TimeSpan = d2 - d1
				Hop_le = time.Days > 0
				If Not Hop_le Then
					kq = kq & "Ngày rút tiền phải lơn hơn số ngày gửi tiền" & vbCrLf
				End If
			End If
		End If



		'Bài tập 2
		'Nhập vào một năm Nm. Tính và xuất ngày thứ sáu 13 tây đầu tiên của năm Nm
		If (Th_nam_kiem_tra.Text.Trim = "") Then
		Else
			Dim k As Integer
			Dim Ngay_kiem_tra As Date
			Dim d = Integer.TryParse(Th_nam_kiem_tra.Text, k)
			Dim found As Boolean = False

			For index As Integer = 1 To 12
				Ngay_kiem_tra = New Date(k, index, 13)
				If Ngay_kiem_tra.DayOfWeek = DayOfWeek.Friday Then
					Th_Ngay.Text = Ngay_kiem_tra.ToShortDateString()
					found = True
					Exit For
				End If

			Next
			If Not found Then
				MessageBox.Show("Không tìm thấy thứ 6 ngày 13 trong năm này")
			End If
		End If
		Return kq
	End Function

End Class