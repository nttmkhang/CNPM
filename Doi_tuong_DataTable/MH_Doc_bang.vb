Imports System.Data.OleDb
Public Class MH_Doc_bang
    Private Sub MH_Doc_bang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bang_loai_phong = Dữ liệu đọc của bảng LOAI_PHONG
        'Khai báo Bang_loai_phong
        Dim Bang_loai_phong As DataTable = XL_BANG.Doc("Select* From LOAI_PHONG")
        MessageBox.Show(XL_BANG.Tao_Chuoi(Bang_loai_phong))
    End Sub
End Class