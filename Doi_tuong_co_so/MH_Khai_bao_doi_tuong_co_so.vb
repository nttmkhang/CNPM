Public Class MH_Khai_bao_doi_tuong_co_so
    Private Sub MH_Khai_bao_doi_tuong_co_so_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Khai báo chuỗi Ho_ten
        Dim Ho_ten As String = "Trương Nguyễn Phước Trí"
        'Khai báo giá trị logic Gioi_tinh
        Dim Gioi_tinh As Boolean = True
        'Khai báo ngày Ngay_sinh
        Dim Ngay_sinh As Date = New Date(2003, 6, 1)
        'Khai báo chuỗi Dia_chi
        Dim Dia_chi As String = "03 Điện Biên Phủ, Quận 1, Tp.HCM"
        'Khai báo số nguyên So_ngay_vang
        Dim So_ngay_vang As Integer = 4
        'Khai báo số thực Diem_trung_binh
        Dim Diem_trung_binh As Double = 8.2

        MessageBox.Show("Kết thúc khai báo biến")
    End Sub
End Class