<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Nhap_lieu_doi_tuong
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
        Th_Nhan_vien = New Panel()
        Th_Ho_ten = New TextBox()
        Th_Dia_chi = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Th_Ngay_sinh = New DateTimePicker()
        Th_Gioi_tinh = New CheckBox()
        Label1 = New Label()
        Xl_Dong_y = New Button()
        Th_Nhan_vien.SuspendLayout()
        SuspendLayout()
        ' 
        ' Th_Nhan_vien
        ' 
        Th_Nhan_vien.BackgroundImageLayout = ImageLayout.None
        Th_Nhan_vien.Controls.Add(Th_Ho_ten)
        Th_Nhan_vien.Controls.Add(Th_Dia_chi)
        Th_Nhan_vien.Controls.Add(Label2)
        Th_Nhan_vien.Controls.Add(Label4)
        Th_Nhan_vien.Controls.Add(Label3)
        Th_Nhan_vien.Controls.Add(Th_Ngay_sinh)
        Th_Nhan_vien.Controls.Add(Th_Gioi_tinh)
        Th_Nhan_vien.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Th_Nhan_vien.Location = New Point(287, 103)
        Th_Nhan_vien.Name = "Th_Nhan_vien"
        Th_Nhan_vien.Size = New Size(783, 376)
        Th_Nhan_vien.TabIndex = 22
        ' 
        ' Th_Ho_ten
        ' 
        Th_Ho_ten.Location = New Point(181, 61)
        Th_Ho_ten.Name = "Th_Ho_ten"
        Th_Ho_ten.Size = New Size(211, 39)
        Th_Ho_ten.TabIndex = 16
        ' 
        ' Th_Dia_chi
        ' 
        Th_Dia_chi.Location = New Point(181, 227)
        Th_Dia_chi.Multiline = True
        Th_Dia_chi.Name = "Th_Dia_chi"
        Th_Dia_chi.Size = New Size(490, 101)
        Th_Dia_chi.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(37, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 29)
        Label2.TabIndex = 14
        Label2.Text = "Họ tên"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(37, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 29)
        Label4.TabIndex = 19
        Label4.Text = "Địa chỉ"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(37, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 29)
        Label3.TabIndex = 15
        Label3.Text = "Ngày sinh"
        ' 
        ' Th_Ngay_sinh
        ' 
        Th_Ngay_sinh.CalendarFont = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Th_Ngay_sinh.Format = DateTimePickerFormat.Short
        Th_Ngay_sinh.Location = New Point(181, 141)
        Th_Ngay_sinh.Name = "Th_Ngay_sinh"
        Th_Ngay_sinh.Size = New Size(152, 39)
        Th_Ngay_sinh.TabIndex = 18
        ' 
        ' Th_Gioi_tinh
        ' 
        Th_Gioi_tinh.AutoSize = True
        Th_Gioi_tinh.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Th_Gioi_tinh.Location = New Point(596, 61)
        Th_Gioi_tinh.Name = "Th_Gioi_tinh"
        Th_Gioi_tinh.Size = New Size(90, 33)
        Th_Gioi_tinh.TabIndex = 17
        Th_Gioi_tinh.Text = "Nam"
        Th_Gioi_tinh.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(400, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(486, 40)
        Label1.TabIndex = 23
        Label1.Text = "Minh họa kết xuất đối tượng"
        ' 
        ' Xl_Dong_y
        ' 
        Xl_Dong_y.BackColor = SystemColors.ButtonHighlight
        Xl_Dong_y.BackgroundImageLayout = ImageLayout.None
        Xl_Dong_y.Location = New Point(600, 521)
        Xl_Dong_y.Name = "Xl_Dong_y"
        Xl_Dong_y.Size = New Size(144, 46)
        Xl_Dong_y.TabIndex = 26
        Xl_Dong_y.Text = "Đồng ý"
        Xl_Dong_y.UseVisualStyleBackColor = False
        ' 
        ' MH_Nhap_lieu_doi_tuong
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1507, 707)
        Controls.Add(Xl_Dong_y)
        Controls.Add(Label1)
        Controls.Add(Th_Nhan_vien)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "MH_Nhap_lieu_doi_tuong"
        Text = "MH_Nhap_lieu_doi_tuong"
        Th_Nhan_vien.ResumeLayout(False)
        Th_Nhan_vien.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Th_Nhan_vien As Panel
    Friend WithEvents Th_Ho_ten As TextBox
    Friend WithEvents Th_Dia_chi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Th_Ngay_sinh As DateTimePicker
    Friend WithEvents Th_Gioi_tinh As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Xl_Dong_y As Button
End Class
