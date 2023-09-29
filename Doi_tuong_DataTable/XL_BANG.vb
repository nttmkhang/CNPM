Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Data.OleDb
Public Class XL_BANG
    Public Shared Chuoi_ket_noi As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source = QLKS.accdb"
    Public Shared Function Tao_Chuoi(ByVal Bang As DataTable) As String
        Dim Kq As String = ""
        ' Lặp qua từng dòng trong bảng
        For Each Dong As DataRow In Bang.Rows
            ' Lặp qua từng cột trong dòng
            For Each Cot As DataColumn In Dong.Table.Columns
                Dim Ten_cot As String = Cot.ColumnName
                Kq &= Ten_cot & ": "
                Kq &= Dong(Ten_cot) & vbCrLf
            Next
            Kq &= vbCrLf ' Thêm dòng trống sau mỗi dòng dữ liệu
        Next

        Return Kq
    End Function


    Public Shared Sub Xuat(ByVal Dong As DataRow, ByVal Th_Dong As Panel)
        'Phiên bản 0 ===> Sẽ cải tiến
        'Vòng lặp trên các thể hiện Th thuộc Th_Dong 
        '   Ten_cot = Tên cột tương ứng
        '   Xuất giá trị của Dong với thuộc tính Ten_cot vào Th
        '     (Tùy theo loại thể hiện)
        For Each Th As Control In Th_Dong.Controls
            Dim Ten_cot As String = Th.Name.Replace("Th_", "")
            If TypeOf Th Is TextBox Then
                Dim Th_Chuoi As TextBox = Th
                Th_Chuoi.Text = Dong(Ten_cot)
            ElseIf TypeOf Th Is CheckBox Then
                Dim Th_Logic As CheckBox = Th
                Th_Logic.Checked = Dong(Ten_cot)
            ElseIf TypeOf Th Is DateTimePicker Then
                Dim Th_Ngay As DateTimePicker = Th
                Th_Ngay.Value = Dong(Ten_cot)
            End If
        Next
    End Sub
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
    Public Shared Function Doc(ByVal Chuoi_Lenh As String) As DataTable
        'Phiên bản 0 ===> Sẽ cải tiến
        Dim Kq As New DataTable
        Try

            ''Tạo Chuoi_lenh
            'Dim Chuoi_Lenh As String = "Select* From LOAI_PHONG"
            'Khai báo Bo_thich_ung
            Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_Lenh, Chuoi_ket_noi)
            'Sữ dụng Bo_thich_ung để đọc cau truc va noi dung
            Bo_thich_ung.FillSchema(Kq, SchemaType.Source)
            Bo_thich_ung.Fill(Kq)

        Catch loi As Exception
            MessageBox.Show(loi.Message)
        End Try
        Return Kq
    End Function
    Public Shared Function Doc_cau_truc(ByVal Chuoi_Lenh As String) As DataTable
        'Phiên bản 0 ===> Sẽ cải tiến
        Dim Kq As New DataTable
        Try

            ''Tạo Chuoi_lenh
            'Dim Chuoi_Lenh As String = "Select* From LOAI_PHONG"
            'Khai báo Bo_thich_ung
            Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_Lenh, Chuoi_ket_noi)
            'Sữ dụng Bo_thich_ung để đọc cau truc va noi dung
            Bo_thich_ung.FillSchema(Kq, SchemaType.Source)
            Bo_thich_ung.Fill(Kq)
        Catch loi As Exception
            MessageBox.Show(loi.Message)
        End Try
        Return Kq
    End Function
    Public Shared Function Ghi(Bang As DataTable, Ten_bang As String) As Integer
        Dim Kq As Integer = 0 'Số dòng ghi bằng 0
        Try
            'Tạo Bo_thich_ung
            Dim Chuoi_lenh As String = "Select*From" & Ten_bang
            Dim Bo_thich_ung As New OleDbDataAdapter(Chuoi_lenh, Chuoi_ket_noi)
            Dim Phat_sinh_lenh As New OleDbCommandBuilder(Bo_thich_ung)
            'Sứ dụng Bo_thich_ung để ghi bảng
            Kq = Bo_thich_ung.Update(Bang)

        Catch Loi As Exception
            MessageBox.Show(Loi.Message)
        End Try
        Return Kq
    End Function
End Class
