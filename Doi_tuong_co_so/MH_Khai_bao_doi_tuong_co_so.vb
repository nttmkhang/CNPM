Public Class MH_Khai_bao_doi_tuong_co_so
    Private Sub MH_Khai_bao_doi_tuong_co_so_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Khai báo chuoi ho ten
        'Khai bao gia tri logic Gioi_tinh
        'Khai bao ngay Ngay_sinh
        'Khai bao so nguyen So_ngay_vang
        'Khai bao so thuc Diem_trung_binh
        'Khai bao chuoi Ho_ten
        Dim Ho_ten As String = "Nguyễn Minh Pháp"
        'Khai bao giá trị logic Gioi_tinh
        Dim Gioi_tinh As Boolean = True
        'Khai báo ngày Ngay_sinh
        Dim Ngay_sinh As Date = New Date(2003, 12, 17)
        'Khai báo chuỗi Dia_chi
        Dim Dia_chi As String = "ktxA Đại học quốc gia"
        'Khai báo số nguyên So_ngay_vang
        Dim So_ngay_vang As Integer = 0
        'Khai báo số thực Diem_trung_binh
        Dim Diem_trung_binh As Double = 9.9
        'Ket_xuat_Ho_ten
        th_Ho_ten.Text = Ho_ten
        'Ket_xuat_Gioi_tinh
        Th_Gioi_tinh.Checked = Gioi_tinh
        'Ket_xuat_Ngay_sinh
        Th_Ngay_sinh.Value = Ngay_sinh
        'Ket_xuat_Dia_chi
        th_Dia_chi.Text = Dia_chi
        'Ket_xuat_So_ngay_vang
        Th_So_ngay_vang.Text = So_ngay_vang
        'Ket_xuat_Diem_trung_binh
        Th_Diem_trung_binh.Text = Diem_trung_binh



        MessageBox.Show("Ket thuc khai báo biến")

    End Sub
End Class