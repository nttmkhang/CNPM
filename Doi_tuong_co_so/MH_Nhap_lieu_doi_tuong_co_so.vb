Public Class MH_Nhap_lieu_doi_tuong_co_so
    Private Sub Xl_Dong_y_Click(sender As Object, e As EventArgs) Handles Xl_Dong_y.Click
        'Kiểm tra dữ liệu nhập
        'Nếu hợp lệ
        ' Khai báo ...
        ' Nhập liệu
        ' Xử lý ...
        ' Kết xuất ...
        'Ngược lại
        ' Thông báo lỗi
        Dim Chuoi_loi As String = Kiem_tra()
        If Chuoi_loi = "" Then
            Dim Ho_ten As String = Th_Ho_ten.Text
            Dim Gioi_tinh As Boolean = Th_Gioi_tinh.Checked
            Dim Ngay_sinh As Date = Th_Ngay_sinh.Value
            Dim Dia_chi As String = Th_Dia_chi.Text
            Dim So_ngay_vang As String = Th_So_ngay_vang.Text
            Dim Diem_trung_binh As String = Th_Diem_trung_binh.Text

            MessageBox.Show("Đã nhập liệu và xử lý")
        Else
            Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf & Chuoi_loi 'vbCrLf là lệnh để xuống dòng
            MessageBox.Show(Thong_bao)
        End If
    End Sub
    Function Kiem_tra() As String
        Dim Kq As String = "" 'Không có lỗi
        Dim Hop_le As Boolean
        'Họ tên khác trống
        Hop_le = Th_Ho_ten.Text.Trim <> ""
        If Not Hop_le Then
            Kq = Kq & "Họ tên phải khác trống" & vbCrLf
        End If
        'Ngày sinh tương ứng tuổi từ 18 đến 60
        Dim Tuoi As Integer = Today.Year - Th_Ngay_sinh.Value.Year
        Hop_le = Tuoi >= 18 And Tuoi <= 60
        If Not Hop_le Then
            Kq = Kq & "Tuổi từ 18 đến 60" & vbCrLf
        End If
        'Địa chỉ khác rỗng
        Hop_le = Th_Dia_chi.Text.Trim <> ""
        If Not Hop_le Then
            Kq = Kq & "Địa chỉ phải khác trống" & vbCrLf
        End If
        'Số ngày vắng là số nguyên >=0
        Dim n As Integer
        Hop_le = Integer.TryParse(Th_So_ngay_vang.Text, n) And n >= 0
        If Not Hop_le Then
            Kq = Kq & "Số ngày vắng là số nguyên >= 0" & vbCrLf
        End If
        'Điểm trung bình là số thực >=0 và <=10
        Dim x As Double
        Hop_le = Double.TryParse(Th_Diem_trung_binh.Text, x)
        If Hop_le Then
            Hop_le = x >= 0 And x <= 10
        End If
        If Not Hop_le Then
            Kq = Kq & "Điểm trung bình là số thực từ 0 đến 10" & vbCrLf
        End If
        Return Kq
    End Function

    Private Sub MH_Nhap_lieu_doi_tuong_co_so_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class