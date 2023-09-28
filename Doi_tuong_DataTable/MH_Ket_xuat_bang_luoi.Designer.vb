<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Ket_xuat_bang_luoi
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
        CType(Luoi_loai_phong, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(130, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(495, 29)
        Label1.TabIndex = 0
        Label1.Text = "Minh họa kết xuất đối tượng với DataGridView"
        ' 
        ' Luoi_loai_phong
        ' 
        Luoi_loai_phong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Luoi_loai_phong.Location = New Point(12, 94)
        Luoi_loai_phong.Name = "Luoi_loai_phong"
        Luoi_loai_phong.RowHeadersWidth = 62
        Luoi_loai_phong.RowTemplate.Height = 33
        Luoi_loai_phong.Size = New Size(720, 362)
        Luoi_loai_phong.TabIndex = 1
        ' 
        ' MH_Ket_xuat_bang_luoi
        ' 
        AutoScaleDimensions = New SizeF(14F, 29F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(744, 468)
        Controls.Add(Luoi_loai_phong)
        Controls.Add(Label1)
        Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 3, 4, 3)
        Name = "MH_Ket_xuat_bang_luoi"
        Text = "MH_Ket_xuat_bang_luoi"
        CType(Luoi_loai_phong, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Luoi_loai_phong As DataGridView
End Class
