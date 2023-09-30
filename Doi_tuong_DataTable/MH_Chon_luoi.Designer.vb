<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Chon_luoi
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
        Luoi_loai_phong = New DataGridView()
        Button1 = New Button()
        CType(Luoi_loai_phong, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(243, 41)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(297, 20)
        Label1.TabIndex = 5
        Label1.Text = "Minh họa chọn đối tượng với DataGridView"
        ' 
        ' Luoi_loai_phong
        ' 
        Luoi_loai_phong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Luoi_loai_phong.Location = New Point(74, 74)
        Luoi_loai_phong.Name = "Luoi_loai_phong"
        Luoi_loai_phong.RowHeadersWidth = 62
        Luoi_loai_phong.RowTemplate.Height = 33
        Luoi_loai_phong.Size = New Size(644, 285)
        Luoi_loai_phong.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(323, 386)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 7
        Button1.Text = "Đồng ý"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MH_Chon_luoi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(Luoi_loai_phong)
        Controls.Add(Label1)
        Name = "MH_Chon_luoi"
        Text = "MH_Chon_luoi"
        CType(Luoi_loai_phong, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Luoi_loai_phong As DataGridView
    Friend WithEvents Button1 As Button
End Class
