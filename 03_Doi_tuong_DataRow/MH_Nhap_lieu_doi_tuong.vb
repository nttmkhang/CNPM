Public Class MH_Nhap_lieu_doi_tuong
    Private Sub Xl_Dong_y_Click(sender As Object, e As EventArgs) Handles Xl_Dong_y.Click
        Dim Chuoi_loi As String = Kiem_tra()
        If Chuoi_loi = "" Then
            'Khai báo nhân viên Nhan_vien
            Dim Bang_nhan_vien As New DataTable
            Bang_nhan_vien.Columns.Add("Ho_ten", GetType(String))
            Bang_nhan_vien.Columns.Add("Gioi_tinh", GetType(Boolean))
            Bang_nhan_vien.Columns.Add("Ngay_sinh", GetType(Date))
            Bang_nhan_vien.Columns.Add("Dia_chi", GetType(String))

            Dim Nhan_vien As DataRow = Bang_nhan_vien.NewRow
            Bang_nhan_vien.Rows.Add(Nhan_vien)
            'Nhập liệu cho Nhan_vien
            XL_DONG.Nhap(Nhan_vien, Th_Nhan_vien)
            'Xuất thông báo đã nhập Nhan_vien
            MessageBox.Show(XL_DONG.Tao_Chuoi(Nhan_vien))
            Dim Ho_ten As String = Th_Ho_ten.Text
            Dim Gioi_tinh As Boolean = Th_Gioi_tinh.Checked
            Dim Ngay_sinh As Date = Th_Ngay_sinh.Value
            Dim Dia_chi As String = Th_Dia_chi.Text
            MessageBox.Show("Đã nhập liệu và xử lý")
        Else
            'Xuất thông báo lỗi
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
        'Ngày sinh hợp lệ tuổi lao động
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
        'Giới tính không trống
        Hop_le = Th_Gioi_tinh.Checked
        If Not Hop_le Then
            Kq = Kq & "Giới tính không được trống" & vbCrLf
        End If
        Return Kq
    End Function

    Private Sub MH_Nhap_lieu_doi_tuong_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class