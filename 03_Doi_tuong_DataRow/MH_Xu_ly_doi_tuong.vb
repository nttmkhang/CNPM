Public Class MH_Xu_ly_doi_tuong
    Private Sub MH_Xu_ly_doi_tuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Khai bao nhan vien
        'Tao bang_nhan_vien (DataTable)
        Dim Bang_nhan_vien As New DataTable("NHAN_VIEN")
        Bang_nhan_vien.Columns.Add("Ho_ten", GetType(String))
        Bang_nhan_vien.Columns.Add("Gioi_tinh", GetType(Boolean))
        Bang_nhan_vien.Columns.Add("Ngay_sinh", GetType(Date))
        Bang_nhan_vien.Columns.Add("Dia_chi", GetType(String))

        Dim Nhan_vien As DataRow = Bang_nhan_vien.NewRow
        Bang_nhan_vien.Rows.Add(Nhan_vien)
        Nhan_vien("Ho_ten") = "Tran Van Long"
        Nhan_vien("Gioi_tinh") = True
        Nhan_vien("Ngay_sinh") = New Date(1987, 4, 5)
        Nhan_vien("Dia_chi") = "112 Hung Vuong"
        '===== Trích rút thông tin =====
        'Bang = Bảng chứa Nhan_vien
        Dim Bang As DataTable = Nhan_vien.Table
        'Ten_bang = Tên của bảng Nhan_vien
        Dim Ten_bang As String = Nhan_vien.Table.TableName
        'Danh_sach = Danh sách các tên cột(thuộc tính) của Nhan_vien
        Dim Danh_sach As New ArrayList
        'Vòng lặp Cot thuộc các cột của Bang chứa Nhan_vien
        '   Ten_cot = tên của Cot
        '   Bổ sung Ten_cot vào Danh_sach
        For Each Cot As DataColumn In Nhan_vien.Table.Columns
            Dim Ten_cot As String = Cot.ColumnName
            Danh_sach.Add(Ten_cot)
        Next
        'Kết xuất nhanh Nhan_vien
        Dim Chuoi As String = "Thông tin về nhân viên" & vbCrLf
        Chuoi &= XL_DONG.Tao_Chuoi(Nhan_vien)
        Me.Close()
    End Sub
End Class