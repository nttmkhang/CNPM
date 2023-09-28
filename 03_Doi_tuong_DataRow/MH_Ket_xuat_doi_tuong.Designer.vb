<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Ket_xuat_doi_tuong
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Th_Ho_ten = New System.Windows.Forms.TextBox()
        Me.Th_Gioi_tinh = New System.Windows.Forms.CheckBox()
        Me.Th_Ngay_sinh = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Th_Dia_chi = New System.Windows.Forms.TextBox()
        Me.Th_Nhan_vien = New System.Windows.Forms.Panel()
        Me.Th_Chuoi_nhan_vien = New System.Windows.Forms.TextBox()
        Me.Th_Nhan_vien.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(152, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 40)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Minh họa kết xuất đối tượng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(38, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Họ tên"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(38, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Ngày sinh"
        '
        'Th_Ho_ten
        '
        Me.Th_Ho_ten.Location = New System.Drawing.Point(182, 38)
        Me.Th_Ho_ten.Name = "Th_Ho_ten"
        Me.Th_Ho_ten.Size = New System.Drawing.Size(211, 39)
        Me.Th_Ho_ten.TabIndex = 16
        '
        'Th_Gioi_tinh
        '
        Me.Th_Gioi_tinh.AutoSize = True
        Me.Th_Gioi_tinh.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Th_Gioi_tinh.Location = New System.Drawing.Point(597, 38)
        Me.Th_Gioi_tinh.Name = "Th_Gioi_tinh"
        Me.Th_Gioi_tinh.Size = New System.Drawing.Size(90, 33)
        Me.Th_Gioi_tinh.TabIndex = 17
        Me.Th_Gioi_tinh.Text = "Nam"
        Me.Th_Gioi_tinh.UseVisualStyleBackColor = True
        '
        'Th_Ngay_sinh
        '
        Me.Th_Ngay_sinh.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Th_Ngay_sinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Th_Ngay_sinh.Location = New System.Drawing.Point(182, 118)
        Me.Th_Ngay_sinh.Name = "Th_Ngay_sinh"
        Me.Th_Ngay_sinh.Size = New System.Drawing.Size(152, 39)
        Me.Th_Ngay_sinh.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(38, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 29)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Địa chỉ"
        '
        'Th_Dia_chi
        '
        Me.Th_Dia_chi.Location = New System.Drawing.Point(182, 204)
        Me.Th_Dia_chi.Multiline = True
        Me.Th_Dia_chi.Name = "Th_Dia_chi"
        Me.Th_Dia_chi.Size = New System.Drawing.Size(490, 101)
        Me.Th_Dia_chi.TabIndex = 20
        '
        'Th_Nhan_vien
        '
        Me.Th_Nhan_vien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Ho_ten)
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Dia_chi)
        Me.Th_Nhan_vien.Controls.Add(Me.Label2)
        Me.Th_Nhan_vien.Controls.Add(Me.Label4)
        Me.Th_Nhan_vien.Controls.Add(Me.Label3)
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Ngay_sinh)
        Me.Th_Nhan_vien.Controls.Add(Me.Th_Gioi_tinh)
        Me.Th_Nhan_vien.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Th_Nhan_vien.Location = New System.Drawing.Point(89, 84)
        Me.Th_Nhan_vien.Name = "Th_Nhan_vien"
        Me.Th_Nhan_vien.Size = New System.Drawing.Size(783, 332)
        Me.Th_Nhan_vien.TabIndex = 21
        '
        'Th_Chuoi_nhan_vien
        '
        Me.Th_Chuoi_nhan_vien.Location = New System.Drawing.Point(894, 84)
        Me.Th_Chuoi_nhan_vien.Multiline = True
        Me.Th_Chuoi_nhan_vien.Name = "Th_Chuoi_nhan_vien"
        Me.Th_Chuoi_nhan_vien.Size = New System.Drawing.Size(490, 332)
        Me.Th_Chuoi_nhan_vien.TabIndex = 22
        '
        'MH_Ket_xuat_doi_tuong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1455, 516)
        Me.Controls.Add(Me.Th_Chuoi_nhan_vien)
        Me.Controls.Add(Me.Th_Nhan_vien)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MH_Ket_xuat_doi_tuong"
        Me.Text = "MH_Ket_xuat_doi_tuong"
        Me.Th_Nhan_vien.ResumeLayout(False)
        Me.Th_Nhan_vien.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Th_Ho_ten As TextBox
    Friend WithEvents Th_Gioi_tinh As CheckBox
    Friend WithEvents Th_Ngay_sinh As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Th_Dia_chi As TextBox
    Friend WithEvents Th_Nhan_vien As Panel
    Friend WithEvents Th_Chuoi_nhan_vien As TextBox
End Class
