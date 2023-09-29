Public Class MH_Them_dong_moi
    Private Sub MH_Them_dong_moi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bang_loai_phong = Dữ liệu đọc của bảng LOAI_PHONG
        'Khai báo Bang_loai_phong
        Dim Bang_loai_phong As DataTable = XL_BANG.Doc_cau_truc("Select* From LOAI_PHONG")
        'Kết xuất Bang_loai_phong
        MessageBox.Show(XL_BANG.Tao_Chuoi(Bang_loai_phong))
        'Them loại phòng mới
        Dim Loai_phong As DataRow = Bang_loai_phong.NewRow
        Bang_loai_phong.Rows.Add(Loai_phong)
        Loai_phong("Ten") = "Loai_X"
        Loai_phong("Don_gia") = 190000
        Dim So_dong_ghi As Integer = XL_BANG.Ghi(Bang_loai_phong, "LOAI_PHONG")
        MessageBox.Show(So_dong_ghi)
    End Sub
End Class