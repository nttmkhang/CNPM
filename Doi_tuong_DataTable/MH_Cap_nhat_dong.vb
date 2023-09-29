Public Class MH_Cap_nhat_dong
    Private Sub MH_Cap_nhat_dong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bang_loai_phong = Dữ liệu đọc của bảng LOAI_PHONG
        'Khai báo Bang_loai_phong
        Dim Bang_loai_phong As DataTable = XL_BANG.Doc("Select* From LOAI_PHONG")
        'Kết xuất Bang_loai_phong
        MessageBox.Show(XL_BANG.Tao_Chuoi(Bang_loai_phong))
        'Cập nhật tên loại phòng thứ 4
        Dim Loai_phong As DataRow = Bang_loai_phong.Rows(2)
        Loai_phong("Ten") = "Loai Y"
        Dim So_dong_ghi As Integer = XL_BANG.Ghi(Bang_loai_phong, "LOAI_PHONG")
        MessageBox.Show(So_dong_ghi)
    End Sub
End Class