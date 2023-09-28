Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class XL_DONG
    Public Shared Function Tao_Chuoi(ByVal Dong As DataRow) As String
        Dim Kq As String = ""
        For Each Cot As DataColumn In Dong.Table.Columns
            Dim Ten_cot As String = Cot.ColumnName
            Kq &= Ten_cot & ": "
            Kq &= Dong(Ten_cot) & vbCrLf
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

    Public Shared Sub Nhap(ByVal Dong As DataRow, ByVal Th_Dong As Panel)
        'Phiên bản 0 ===> Sẽ cải tiến
        'Vòng lặp trên các thể hiện Th thuộc Th_Dong 
        '   Ten_cot = Tên cột tương ứng
        '   Nhập giá trị của Dong với thuộc tính Ten_cot vào Th
        '     (Tùy theo loại thể hiện)
        For Each Th As Control In Th_Dong.Controls
            Dim Ten_cot As String = Th.Name.Replace("Th_", "")
            If TypeOf Th Is TextBox Then
                Dim Th_Chuoi As TextBox = Th
                Dong(Ten_cot) = Th_Chuoi.Text
            ElseIf TypeOf Th Is CheckBox Then
                Dim Th_Logic As CheckBox = Th
                Dong(Ten_cot) = Th_Logic.Checked
            ElseIf TypeOf Th Is DateTimePicker Then
                Dim Th_Ngay As DateTimePicker = Th
                Dong(Ten_cot) = Th_Ngay.Value
            End If
        Next
    End Sub
End Class
