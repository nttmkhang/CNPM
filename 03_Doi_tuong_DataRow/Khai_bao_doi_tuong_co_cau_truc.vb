Public Class Khai_bao_doi_tuong_co_cau_truc
    Private Sub Khai_bao_doi_tuong_co_cau_truc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Khai bao nhan vien
        'Tao bang_nhan_vien (DataTable)
        Dim Bang_nhan_vien As New DataTable
        Bang_nhan_vien.Columns.Add("Ho_ten", GetType(String))
        Bang_nhan_vien.Columns.Add("Gioi_tinh", GetType(Boolean))
        Bang_nhan_vien.Columns.Add("Ngay_sinh", GetType(Date))
        Bang_nhan_vien.Columns.Add("Dia_chi", GetType(String))

        Dim Nhan_vien As DataRow = Bang_nhan_vien.NewRow
        Nhan_vien("Ho_ten") = "Tran Van Long"
        Nhan_vien("Gioi_tinh") = True
        Nhan_vien("Ngay_sinh") = New Date(1987, 4, 5)
        Nhan_vien("Dia_chi") = "112 Hung Vuong"

        Me.Close()
    End Sub
End Class