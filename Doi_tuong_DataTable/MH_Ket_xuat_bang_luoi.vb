Imports System.Net.NetworkInformation

Public Class MH_Ket_xuat_bang_luoi
    Private Sub MH_Ket_xuat_bang_luoi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '4 Khai báo Bang_loai_phong
        'tương ứng bảng đơn giá thuê phòng của khách sạn như sau
        'Loại phòng
        'Đơn giá
        'Loại A
        '240.000
        'Loại B
        '220.000
        'Loại C
        '180.000
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
        XL_BANG.Xuat(Bang_loai_phong, Luoi_loai_phong)
        Luoi_loai_phong.Columns("Ten").HeaderText = "Loại phòng"
        Luoi_loai_phong.Columns("Ten").Width = 150
        Luoi_loai_phong.Columns("Don_gia").HeaderText = "Đơn giá"
        Luoi_loai_phong.Columns("Don_gia").Width = 100
        Luoi_loai_phong.Width = 150 + 100 + 5
    End Sub
End Class