Imports System.Data.OleDb
Public Class MH_Doc_bang
    Private Sub MH_Doc_bang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Bang_loai_phong = Dữ liệu đọc của bảng LOAI_PHONG
        'Khai báo Bang_loai_phong
        Dim Bang_loai_phong As New DataTable
        'Tạo Chuoi_ket_noi
        Dim Chuoi_ket_noi As String = "Provier = Microsoft.ACE.OLEDB.12.0;Data Source = QLKS.accdb"
        'Tạo Chuoi_lenh
        Dim Chuoi_Lenh As String = "Select* From LOAI_PHONG"
        'Khai báo Bo_thich_ung
        Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_Lenh, Chuoi_ket_noi)
        'Sữ dụng Bo_thich_ung để đọc dữ liệu
        Bo_thich_ung.Fill(Bang_loai_phong)

        MessageBox.Show()
    End Sub
End Class