<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Chon_danh_sach_chon
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
        Danh_sach_chon_loai_phong = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Danh_sach_chon_loai_phong
        ' 
        Danh_sach_chon_loai_phong.FormattingEnabled = True
        Danh_sach_chon_loai_phong.Location = New Point(235, 97)
        Danh_sach_chon_loai_phong.Margin = New Padding(2)
        Danh_sach_chon_loai_phong.Name = "Danh_sach_chon_loai_phong"
        Danh_sach_chon_loai_phong.Size = New Size(146, 28)
        Danh_sach_chon_loai_phong.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(125, 103)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 20)
        Label2.TabIndex = 5
        Label2.Text = "Loại phòng"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(150, 64)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(279, 20)
        Label1.TabIndex = 4
        Label1.Text = "Minh họa chọn đối tượng với ComboBox"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(233, 177)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 7
        Button1.Text = "Đồng ý"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MH_Chon_danh_sach_chon
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Danh_sach_chon_loai_phong)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "MH_Chon_danh_sach_chon"
        Text = "MH_Chon_danh_sach_chon"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Danh_sach_chon_loai_phong As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
