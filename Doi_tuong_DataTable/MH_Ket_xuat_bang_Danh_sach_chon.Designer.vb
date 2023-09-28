<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Ket_xuat_bang_Danh_sach_chon
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
        Label1 = New Label()
        Label2 = New Label()
        Danh_sach_chon_loai_phong = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(52, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(362, 25)
        Label1.TabIndex = 1
        Label1.Text = "Minh họa kết xuất đối tượng với ComboBox"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 25)
        Label2.TabIndex = 2
        Label2.Text = "Loại phòng"
        ' 
        ' Danh_sach_chon_loai_phong
        ' 
        Danh_sach_chon_loai_phong.FormattingEnabled = True
        Danh_sach_chon_loai_phong.Location = New Point(159, 50)
        Danh_sach_chon_loai_phong.Name = "Danh_sach_chon_loai_phong"
        Danh_sach_chon_loai_phong.Size = New Size(182, 33)
        Danh_sach_chon_loai_phong.TabIndex = 3
        ' 
        ' MH_Ket_xuat_bang_Danh_sach_chon
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(476, 117)
        Controls.Add(Danh_sach_chon_loai_phong)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "MH_Ket_xuat_bang_Danh_sach_chon"
        Text = "MH_Ket_xuat_bang_Danh_sach_chon"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Danh_sach_chon_loai_phong As ComboBox
End Class
