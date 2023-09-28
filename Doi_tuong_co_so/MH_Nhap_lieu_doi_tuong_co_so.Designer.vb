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
        Me.Th_Diem_trung_binh = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Th_So_ngay_vang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Th_Dia_chi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Th_Ngay_sinh = New System.Windows.Forms.DateTimePicker()
        Me.Th_Gioi_tinh = New System.Windows.Forms.CheckBox()
        Me.Th_Ho_ten = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Xl_Dong_y = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Th_Diem_trung_binh
        '
        Me.Th_Diem_trung_binh.Location = New System.Drawing.Point(821, 477)
        Me.Th_Diem_trung_binh.Name = "Th_Diem_trung_binh"
        Me.Th_Diem_trung_binh.Size = New System.Drawing.Size(95, 35)
        Me.Th_Diem_trung_binh.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(659, 480)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 29)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Điểm trung bình"
        '
        'Th_So_ngay_vang
        '
        Me.Th_So_ngay_vang.Location = New System.Drawing.Point(424, 480)
        Me.Th_So_ngay_vang.Name = "Th_So_ngay_vang"
        Me.Th_So_ngay_vang.Size = New System.Drawing.Size(95, 35)
        Me.Th_So_ngay_vang.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 480)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 29)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Số ngày vắng"
        '
        'Th_Dia_chi
        '
        Me.Th_Dia_chi.Location = New System.Drawing.Point(424, 321)
        Me.Th_Dia_chi.Multiline = True
        Me.Th_Dia_chi.Name = "Th_Dia_chi"
        Me.Th_Dia_chi.Size = New System.Drawing.Size(490, 101)
        Me.Th_Dia_chi.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(280, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 29)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Địa chỉ"
        '
        'Th_Ngay_sinh
        '
        Me.Th_Ngay_sinh.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Th_Ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Th_Ngay_sinh.Location = New System.Drawing.Point(424, 235)
        Me.Th_Ngay_sinh.Name = "Th_Ngay_sinh"
        Me.Th_Ngay_sinh.Size = New System.Drawing.Size(152, 35)
        Me.Th_Ngay_sinh.TabIndex = 18
        '
        'Th_Gioi_tinh
        '
        Me.Th_Gioi_tinh.AutoSize = True
        Me.Th_Gioi_tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Th_Gioi_tinh.Location = New System.Drawing.Point(839, 155)
        Me.Th_Gioi_tinh.Name = "Th_Gioi_tinh"
        Me.Th_Gioi_tinh.Size = New System.Drawing.Size(90, 33)
        Me.Th_Gioi_tinh.TabIndex = 17
        Me.Th_Gioi_tinh.Text = "Nam"
        Me.Th_Gioi_tinh.UseVisualStyleBackColor = True
        '
        'Th_Ho_ten
        '
        Me.Th_Ho_ten.Location = New System.Drawing.Point(424, 155)
        Me.Th_Ho_ten.Name = "Th_Ho_ten"
        Me.Th_Ho_ten.Size = New System.Drawing.Size(211, 35)
        Me.Th_Ho_ten.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(280, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Ngày sinh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(280, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Họ tên"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(424, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(609, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Minh họa nhập liệu đối tượng cơ sở"
        '
        'Xl_Dong_y
        '
        Me.Xl_Dong_y.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Xl_Dong_y.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Xl_Dong_y.Location = New System.Drawing.Point(548, 558)
        Me.Xl_Dong_y.Name = "Xl_Dong_y"
        Me.Xl_Dong_y.Size = New System.Drawing.Size(144, 46)
        Me.Xl_Dong_y.TabIndex = 25
        Me.Xl_Dong_y.Text = "Đồng ý"
        Me.Xl_Dong_y.UseVisualStyleBackColor = False
        '
        'MH_Nhap_lieu_doi_tuong_co_so
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 643)
        Me.Controls.Add(Me.Xl_Dong_y)
        Me.Controls.Add(Me.Th_Diem_trung_binh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Th_So_ngay_vang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Th_Dia_chi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Th_Ngay_sinh)
        Me.Controls.Add(Me.Th_Gioi_tinh)
        Me.Controls.Add(Me.Th_Ho_ten)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MH_Nhap_lieu_doi_tuong_co_so"
        Me.Text = "MH_Nhap_lieu_doi_tuong_co_so"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
