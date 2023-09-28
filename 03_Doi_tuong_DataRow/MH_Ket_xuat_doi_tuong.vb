Public Class MH_Ket_xuat_doi_tuong
    Private Sub MH_Ket_xuat_doi_tuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Khai bao nhan vien
        'Tao bang_nhan_vien (DataTable)
        Dim Bang_nhan_vien As New DataTable
        Bang_nhan_vien.Columns.Add("Ho_ten", GetType(String))
        Bang_nhan_vien.Columns.Add("Gioi_tinh", GetType(Boolean))
        Bang_nhan_vien.Columns.Add("Ngay_sinh", GetType(Date))
        Bang_nhan_vien.Columns.Add("Dia_chi", GetType(String))
        'Khai bao Nhan_vien va bo sung vao Bang_nhan_vien
        Dim Nhan_vien As DataRow = Bang_nhan_vien.NewRow
        Nhan_vien("Ho_ten") = "Tran Van Long"
        Nhan_vien("Gioi_tinh") = True
        Nhan_vien("Ngay_sinh") = New Date(1987, 4, 5)
        Nhan_vien("Dia_chi") = "112 Hung Vuong"
        'Ket xuat Nhan_vien vào Th_Nhan_vien (dang nhap lieu)
        Th_Ho_ten.Text = Nhan_vien("Ho_ten")
        Th_Gioi_tinh.Checked = Nhan_vien("Gioi_tinh")
        Th_Ngay_sinh.Value = Nhan_vien("Ngay_sinh")
        Th_Dia_chi.Text = Nhan_vien("Dia_chi")
        'Ket xuat Nhan_vien vào Th_Chuoi_nhan_vien (dang xem)
        Dim Chuoi_nhan_vien As String = ""
        Chuoi_nhan_vien &= "Ho ten: " & Nhan_vien("Ho_ten") & vbCrLf
        Chuoi_nhan_vien &= "Gioi tinh: " & Nhan_vien("Gioi_tinh") & vbCrLf
        Chuoi_nhan_vien &= "Ngay sinh: " & Nhan_vien("Ngay_sinh") & vbCrLf
        Chuoi_nhan_vien &= "Dia chi: " & Nhan_vien("Dia_chi") & vbCrLf

        Th_Chuoi_nhan_vien.Text = Chuoi_nhan_vien
        MessageBox.Show(Chuoi_nhan_vien)
    End Sub
End Class