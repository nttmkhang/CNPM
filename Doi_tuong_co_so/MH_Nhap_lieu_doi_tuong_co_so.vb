Public Class MH_Nhap_lieu_doi_tuong_co_so
    Private Sub Dong_y_Click(sender As Object, e As EventArgs) Handles Dong_y.Click
        Dim Chuoi_loi As String = Kiem_tra()
        If Chuoi_loi = "" Then
            Dim Ho_ten = th_Ho_ten.Text
            Dim Gioi_tinh = Th_Gioi_tinh.Checked
            Dim Ngay_sinh = Th_Ngay_sinh.Text
            Dim Dia_chi = th_Dia_chi.Text
            Dim So_ngay_vang = Th_So_ngay_vang.Text
            Dim Diem_trung_binh = Th_Diem_trung_binh.Text
            MessageBox.Show("Đã nhập liệu và xử lý")
        Else
            Dim Thong_bao As String = "Lỗi nhập liệu" & vbCrLf & Chuoi_loi
            MessageBox.Show(Thong_bao)
        End If


    End Sub

    Function Kiem_tra() As String
        Dim Kq As String = "" 'Không có lỗi

    End Function


End Class