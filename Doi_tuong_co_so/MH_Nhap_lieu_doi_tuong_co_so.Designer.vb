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
        Th_Dia_chi = New TextBox()
        Label4 = New Label()
        Th_Ngay_sinh = New DateTimePicker()
        Th_Gioi_tinh = New CheckBox()
        Th_Ho_ten = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Xl_Dong_y = New Button()
        SuspendLayout()
        ' 
        ' Th_Diem_trung_binh
        ' 
        Th_Diem_trung_binh.Location = New Point(821, 477)
        Th_Diem_trung_binh.Name = "Th_Diem_trung_binh"
        Th_Diem_trung_binh.Size = New Size(95, 35)
        Th_Diem_trung_binh.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(659, 480)
        Label6.Name = "Label6"
        Label6.Size = New Size(182, 29)
        Label6.TabIndex = 23
        Label6.Text = "Điểm trung bình"
        ' 
        ' Th_So_ngay_vang
        ' 
        Th_So_ngay_vang.Location = New Point(424, 480)
        Th_So_ngay_vang.Name = "Th_So_ngay_vang"
        Th_So_ngay_vang.Size = New Size(95, 35)
        Th_So_ngay_vang.TabIndex = 22
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(280, 480)
        Label5.Name = "Label5"
        Label5.Size = New Size(157, 29)
        Label5.TabIndex = 21
        Label5.Text = "Số ngày vắng"
        ' 
        ' Th_Dia_chi
        ' 
        Th_Dia_chi.Location = New Point(424, 321)
        Th_Dia_chi.Multiline = True
        Th_Dia_chi.Name = "Th_Dia_chi"
        Th_Dia_chi.Size = New Size(490, 101)
        Th_Dia_chi.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(280, 321)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 29)
        Label4.TabIndex = 19
        Label4.Text = "Địa chỉ"
        ' 
        ' Th_Ngay_sinh
        ' 
        Th_Ngay_sinh.CalendarFont = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Th_Ngay_sinh.Format = DateTimePickerFormat.Short
        Th_Ngay_sinh.Location = New Point(424, 235)
        Th_Ngay_sinh.Name = "Th_Ngay_sinh"
        Th_Ngay_sinh.Size = New Size(152, 35)
        Th_Ngay_sinh.TabIndex = 18
        ' 
        ' Th_Gioi_tinh
        ' 
        Th_Gioi_tinh.AutoSize = True
        Th_Gioi_tinh.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Th_Gioi_tinh.Location = New Point(839, 155)
        Th_Gioi_tinh.Name = "Th_Gioi_tinh"
        Th_Gioi_tinh.Size = New Size(90, 33)
        Th_Gioi_tinh.TabIndex = 17
        Th_Gioi_tinh.Text = "Nam"
        Th_Gioi_tinh.UseVisualStyleBackColor = True
        ' 
        ' Th_Ho_ten
        ' 
        Th_Ho_ten.Location = New Point(424, 155)
        Th_Ho_ten.Name = "Th_Ho_ten"
        Th_Ho_ten.Size = New Size(211, 35)
        Th_Ho_ten.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(280, 235)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 29)
        Label3.TabIndex = 15
        Label3.Text = "Ngày sinh"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(280, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 29)
        Label2.TabIndex = 14
        Label2.Text = "Họ tên"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(424, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(609, 40)
        Label1.TabIndex = 13
        Label1.Text = "Minh họa nhập liệu đối tượng cơ sở"
        ' 
        ' Xl_Dong_y
        ' 
        Xl_Dong_y.BackColor = SystemColors.ButtonHighlight
        Xl_Dong_y.BackgroundImageLayout = ImageLayout.None
        Xl_Dong_y.Location = New Point(548, 558)
        Xl_Dong_y.Name = "Xl_Dong_y"
        Xl_Dong_y.Size = New Size(144, 46)
        Xl_Dong_y.TabIndex = 25
        Xl_Dong_y.Text = "Đồng ý"
        Xl_Dong_y.UseVisualStyleBackColor = False
        ' 
        ' MH_Nhap_lieu_doi_tuong_co_so
        ' 
        AutoScaleDimensions = New SizeF(14F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 643)
        Controls.Add(Xl_Dong_y)
        Controls.Add(Th_Diem_trung_binh)
        Controls.Add(Label6)
        Controls.Add(Th_So_ngay_vang)
        Controls.Add(Label5)
        Controls.Add(Th_Dia_chi)
        Controls.Add(Label4)
        Controls.Add(Th_Ngay_sinh)
        Controls.Add(Th_Gioi_tinh)
        Controls.Add(Th_Ho_ten)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "MH_Nhap_lieu_doi_tuong_co_so"
        Text = "MH_Nhap_lieu_doi_tuong_co_so"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Th_Diem_trung_binh As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Th_So_ngay_vang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Th_Dia_chi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Th_Ngay_sinh As DateTimePicker
    Friend WithEvents Th_Gioi_tinh As CheckBox
    Friend WithEvents Th_Ho_ten As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Xl_Dong_y As Button
End Class
