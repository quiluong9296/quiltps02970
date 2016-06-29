<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSP
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
        Me.btnXOA = New System.Windows.Forms.Button()
        Me.btnLUU = New System.Windows.Forms.Button()
        Me.btnSUA = New System.Windows.Forms.Button()
        Me.btnTHEM = New System.Windows.Forms.Button()
        Me.txtMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.dgvSP = New System.Windows.Forms.DataGridView()
        Me.txtTENSP = New System.Windows.Forms.TextBox()
        Me.txtMASP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXOA
        '
        Me.btnXOA.Location = New System.Drawing.Point(627, 40)
        Me.btnXOA.Name = "btnXOA"
        Me.btnXOA.Size = New System.Drawing.Size(75, 23)
        Me.btnXOA.TabIndex = 41
        Me.btnXOA.Text = "Xóa"
        Me.btnXOA.UseVisualStyleBackColor = True
        '
        'btnLUU
        '
        Me.btnLUU.Location = New System.Drawing.Point(627, 9)
        Me.btnLUU.Name = "btnLUU"
        Me.btnLUU.Size = New System.Drawing.Size(75, 23)
        Me.btnLUU.TabIndex = 40
        Me.btnLUU.Text = "Thêm"
        Me.btnLUU.UseVisualStyleBackColor = True
        '
        'btnSUA
        '
        Me.btnSUA.Location = New System.Drawing.Point(537, 41)
        Me.btnSUA.Name = "btnSUA"
        Me.btnSUA.Size = New System.Drawing.Size(75, 23)
        Me.btnSUA.TabIndex = 39
        Me.btnSUA.Text = "Sửa"
        Me.btnSUA.UseVisualStyleBackColor = True
        '
        'btnTHEM
        '
        Me.btnTHEM.Location = New System.Drawing.Point(537, 9)
        Me.btnTHEM.Name = "btnTHEM"
        Me.btnTHEM.Size = New System.Drawing.Size(75, 23)
        Me.btnTHEM.TabIndex = 38
        Me.btnTHEM.Text = "Load"
        Me.btnTHEM.UseVisualStyleBackColor = True
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(350, 42)
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(172, 20)
        Me.txtMaLoaiSP.TabIndex = 37
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(103, 47)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(146, 20)
        Me.txtDonGia.TabIndex = 36
        '
        'dgvSP
        '
        Me.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSP.Location = New System.Drawing.Point(12, 92)
        Me.dgvSP.Name = "dgvSP"
        Me.dgvSP.Size = New System.Drawing.Size(687, 277)
        Me.dgvSP.TabIndex = 35
        '
        'txtTENSP
        '
        Me.txtTENSP.Location = New System.Drawing.Point(350, 12)
        Me.txtTENSP.Name = "txtTENSP"
        Me.txtTENSP.Size = New System.Drawing.Size(172, 20)
        Me.txtTENSP.TabIndex = 34
        '
        'txtMASP
        '
        Me.txtMASP.Location = New System.Drawing.Point(103, 12)
        Me.txtMASP.Name = "txtMASP"
        Me.txtMASP.Size = New System.Drawing.Size(146, 20)
        Me.txtMASP.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(255, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Mã loại SP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Đơn giá"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Tên Sản Phẩm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Mã Sản Phẩm"
        '
        'frmSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 379)
        Me.Controls.Add(Me.btnXOA)
        Me.Controls.Add(Me.btnLUU)
        Me.Controls.Add(Me.btnSUA)
        Me.Controls.Add(Me.btnTHEM)
        Me.Controls.Add(Me.txtMaLoaiSP)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.dgvSP)
        Me.Controls.Add(Me.txtTENSP)
        Me.Controls.Add(Me.txtMASP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmSP"
        Me.Text = "Sản Phẩm"
        CType(Me.dgvSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnXOA As Button
    Friend WithEvents btnLUU As Button
    Friend WithEvents btnSUA As Button
    Friend WithEvents btnTHEM As Button
    Friend WithEvents txtMaLoaiSP As TextBox
    Friend WithEvents txtDonGia As TextBox
    Friend WithEvents dgvSP As DataGridView
    Friend WithEvents txtTENSP As TextBox
    Friend WithEvents txtMASP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
