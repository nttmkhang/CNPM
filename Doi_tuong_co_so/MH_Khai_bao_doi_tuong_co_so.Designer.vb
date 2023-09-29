<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Khai_bao_doi_tuong_co_so
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        th_Ho_ten = New TextBox()
        Label3 = New Label()
        th_Dia_chi = New TextBox()
        Label4 = New Label()
        Th_Gioi_tinh = New CheckBox()
        Th_Ngay_sinh = New DateTimePicker()
        Th_So_ngay_vang = New TextBox()
        Label5 = New Label()
        Th_Diem_trung_binh = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(95, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(523, 39)
        Label1.TabIndex = 0
        Label1.Text = "Minh họa kết xuất đối tượng cơ sở"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(95, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 25)
        Label2.TabIndex = 1
        Label2.Text = "Họ tên"
        ' 
        ' th_Ho_ten
        ' 
        th_Ho_ten.Location = New Point(254, 141)
        th_Ho_ten.Name = "th_Ho_ten"
        th_Ho_ten.Size = New Size(266, 30)
        th_Ho_ten.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(95, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 3
        Label3.Text = "Ngày sinh"
        ' 
        ' th_Dia_chi
        ' 
        th_Dia_chi.Location = New Point(254, 237)
        th_Dia_chi.Multiline = True
        th_Dia_chi.Name = "th_Dia_chi"
        th_Dia_chi.Size = New Size(448, 108)
        th_Dia_chi.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(95, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 25)
        Label4.TabIndex = 5
        Label4.Text = "Địa chỉ"
        ' 
        ' Th_Gioi_tinh
        ' 
        Th_Gioi_tinh.AutoSize = True
        Th_Gioi_tinh.Location = New Point(526, 141)
        Th_Gioi_tinh.Name = "Th_Gioi_tinh"
        Th_Gioi_tinh.Size = New Size(104, 29)
        Th_Gioi_tinh.TabIndex = 7
        Th_Gioi_tinh.Text = "Giới tính"
        Th_Gioi_tinh.UseVisualStyleBackColor = True
        ' 
        ' Th_Ngay_sinh
        ' 
        Th_Ngay_sinh.Location = New Point(254, 191)
        Th_Ngay_sinh.Name = "Th_Ngay_sinh"
        Th_Ngay_sinh.Size = New Size(266, 30)
        Th_Ngay_sinh.TabIndex = 8
        ' 
        ' Th_So_ngay_vang
        ' 
        Th_So_ngay_vang.Location = New Point(254, 378)
        Th_So_ngay_vang.Name = "Th_So_ngay_vang"
        Th_So_ngay_vang.Size = New Size(108, 30)
        Th_So_ngay_vang.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(95, 384)
        Label5.Name = "Label5"
        Label5.Size = New Size(133, 25)
        Label5.TabIndex = 9
        Label5.Text = "Số ngày vắng"
        ' 
        ' Th_Diem_trung_binh
        ' 
        Th_Diem_trung_binh.Location = New Point(559, 378)
        Th_Diem_trung_binh.Name = "Th_Diem_trung_binh"
        Th_Diem_trung_binh.Size = New Size(143, 30)
        Th_Diem_trung_binh.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(400, 384)
        Label6.Name = "Label6"
        Label6.Size = New Size(148, 25)
        Label6.TabIndex = 11
        Label6.Text = "Điểm trung bình"
        ' 
        ' MH_Khai_bao_doi_tuong_co_so
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Name = "MH_Khai_bao_doi_tuong_co_so"
        Text = "MH_Khai_bao_doi_tuong_co_so"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents th_Ho_ten As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents th_Dia_chi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Th_Gioi_tinh As CheckBox
    Friend WithEvents Th_Ngay_sinh As DateTimePicker
    Friend WithEvents Th_So_ngay_vang As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Th_Diem_trung_binh As TextBox
    Friend WithEvents Label6 As Label
End Class
