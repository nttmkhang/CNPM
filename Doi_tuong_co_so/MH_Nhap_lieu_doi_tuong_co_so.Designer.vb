<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Nhap_lieu_doi_tuong_co_so
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Th_Diem_trung_binh = New TextBox()
        Label6 = New Label()
        Th_So_ngay_vang = New TextBox()
        Label5 = New Label()
        Th_Ngay_sinh = New DateTimePicker()
        Th_Gioi_tinh = New CheckBox()
        th_Dia_chi = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        th_Ho_ten = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Dong_y = New Button()
        SuspendLayout()
        ' 
        ' Th_Diem_trung_binh
        ' 
        Th_Diem_trung_binh.Location = New Point(561, 363)
        Th_Diem_trung_binh.Name = "Th_Diem_trung_binh"
        Th_Diem_trung_binh.Size = New Size(143, 27)
        Th_Diem_trung_binh.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(402, 369)
        Label6.Name = "Label6"
        Label6.Size = New Size(117, 20)
        Label6.TabIndex = 23
        Label6.Text = "Điểm trung bình"
        ' 
        ' Th_So_ngay_vang
        ' 
        Th_So_ngay_vang.Location = New Point(256, 363)
        Th_So_ngay_vang.Name = "Th_So_ngay_vang"
        Th_So_ngay_vang.Size = New Size(108, 27)
        Th_So_ngay_vang.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(97, 369)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 21
        Label5.Text = "Số ngày vắng"
        ' 
        ' Th_Ngay_sinh
        ' 
        Th_Ngay_sinh.Location = New Point(256, 176)
        Th_Ngay_sinh.Name = "Th_Ngay_sinh"
        Th_Ngay_sinh.Size = New Size(266, 27)
        Th_Ngay_sinh.TabIndex = 20
        ' 
        ' Th_Gioi_tinh
        ' 
        Th_Gioi_tinh.AutoSize = True
        Th_Gioi_tinh.Location = New Point(528, 126)
        Th_Gioi_tinh.Name = "Th_Gioi_tinh"
        Th_Gioi_tinh.Size = New Size(87, 24)
        Th_Gioi_tinh.TabIndex = 19
        Th_Gioi_tinh.Text = "Giới tính"
        Th_Gioi_tinh.UseVisualStyleBackColor = True
        ' 
        ' th_Dia_chi
        ' 
        th_Dia_chi.Location = New Point(256, 222)
        th_Dia_chi.Multiline = True
        th_Dia_chi.Name = "th_Dia_chi"
        th_Dia_chi.Size = New Size(448, 108)
        th_Dia_chi.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 20)
        Label4.TabIndex = 17
        Label4.Text = "Địa chỉ"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(97, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 20)
        Label3.TabIndex = 16
        Label3.Text = "Ngày sinh"
        ' 
        ' th_Ho_ten
        ' 
        th_Ho_ten.Location = New Point(256, 126)
        th_Ho_ten.Name = "th_Ho_ten"
        th_Ho_ten.Size = New Size(266, 27)
        th_Ho_ten.TabIndex = 15
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(97, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 14
        Label2.Text = "Họ tên"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(97, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(523, 39)
        Label1.TabIndex = 13
        Label1.Text = "Minh họa kết xuất đối tượng cơ sở"
        ' 
        ' Dong_y
        ' 
        Dong_y.Location = New Point(337, 402)
        Dong_y.Name = "Dong_y"
        Dong_y.Size = New Size(94, 36)
        Dong_y.TabIndex = 25
        Dong_y.Text = "Đồng ý"
        Dong_y.UseVisualStyleBackColor = True
        ' 
        ' MH_Nhap_lieu_doi_tuong_co_so
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Dong_y)
        Controls.Add(Th_Diem_trung_binh)
        Controls.Add(Label6)
        Controls.Add(Th_So_ngay_vang)
        Controls.Add(Label5)
        Controls.Add(Th_Ngay_sinh)
        Controls.Add(Th_Gioi_tinh)
        Controls.Add(th_Dia_chi)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(th_Ho_ten)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "MH_Nhap_lieu_doi_tuong_co_so"
        Text = "MH_Nhap_lieu_doi_tuong_co_so"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Th_Diem_trung_binh As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Th_So_ngay_vang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Th_Ngay_sinh As DateTimePicker
    Friend WithEvents Th_Gioi_tinh As CheckBox
    Friend WithEvents th_Dia_chi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents th_Ho_ten As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Dong_y As Button
End Class
