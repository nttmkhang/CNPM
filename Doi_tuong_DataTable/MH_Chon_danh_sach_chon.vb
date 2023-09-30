Public Class MH_Chon_danh_sach_chon
    Private Sub MH_Chon_danh_sach_chon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Bang_loai_phong As New DataTable("LOẠI_PHONG")
        Bang_loai_phong.Columns.Add("Ten", GetType(String))
        Bang_loai_phong.Columns.Add("Don_gia", GetType(Integer))
        Dim Loai_phong_1 As DataRow = Bang_loai_phong.NewRow
        Bang_loai_phong.Rows.Add(Loai_phong_1)
        Loai_phong_1("Ten") = "Loại A"
        Loai_phong_1("Don_gia") = 240000
        Dim Loai_phong_2 As DataRow = Bang_loai_phong.NewRow
        Bang_loai_phong.Rows.Add(Loai_phong_2)
        Loai_phong_2("Ten") = "Loại B"
        Loai_phong_2("Don_gia") = 220000
        Dim Loai_phong_3 As DataRow = Bang_loai_phong.NewRow
        Bang_loai_phong.Rows.Add(Loai_phong_3)
        Loai_phong_3("Ten") = "Loại C"
        Loai_phong_3("Don_gia") = 180000
        XL_BANG.Xuat(Bang_loai_phong, Danh_sach_chon_loai_phong, "Ten")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Loai_phong = Loại phòng được chọn
        Dim Loai_Phong As DataRow = XL_DONG.Chon(Danh_sach_chon_loai_phong)
        MessageBox.Show(XL_DONG.Tao_Chuoi(Loai_phong))
    End Sub

    Private Sub Danh_sach_chon_loai_phong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Danh_sach_chon_loai_phong.SelectedIndexChanged
        'Loai_phong = Loại phòng được chọn
        Dim Loai_Phong As DataRow = XL_DONG.Chon(Danh_sach_chon_loai_phong)
        MessageBox.Show(XL_DONG.Tao_Chuoi(Loai_Phong))
    End Sub
End Class