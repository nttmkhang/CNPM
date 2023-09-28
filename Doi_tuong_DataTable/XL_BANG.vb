Public Class XL_BANG
    Public Shared Sub Xuat(ByVal Bang As DataTable, ByVal Luoi As DataGridView)
        'Phiên bản 0 ===> Sẽ cải tiến
        Luoi.DataSource = Bang
        Luoi.ReadOnly = True
        Luoi.AllowUserToAddRows = False
        Luoi.AllowUserToDeleteRows = False
        Luoi.AllowUserToOrderColumns = False
        Luoi.RowHeadersVisible = False
    End Sub
    Public Shared Sub Xuat(ByVal Bang As DataTable, ByVal Danh_sach_chon As ComboBox, ByVal Ten_cot_the_hien As String)
        'Phiên bản 0 ===> Sẽ cải tiến
        Danh_sach_chon.DataSource = Bang
        Danh_sach_chon.DisplayMember = Ten_cot_the_hien
    End Sub
End Class
