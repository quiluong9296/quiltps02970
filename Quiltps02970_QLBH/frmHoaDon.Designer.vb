<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Me.btnXOA = New System.Windows.Forms.Button()
        Me.btnLUU = New System.Windows.Forms.Button()
        Me.btnSUA = New System.Windows.Forms.Button()
        Me.btnTHEM = New System.Windows.Forms.Button()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.dgvHoadon = New System.Windows.Forms.DataGridView()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtMAHD = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgvHoadon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnXOA
        '
        Me.btnXOA.Location = New System.Drawing.Point(641, 41)
        Me.btnXOA.Name = "btnXOA"
        Me.btnXOA.Size = New System.Drawing.Size(75, 23)
        Me.btnXOA.TabIndex = 41
        Me.btnXOA.Text = "Xóa"
        Me.btnXOA.UseVisualStyleBackColor = True
        '
        'btnLUU
        '
        Me.btnLUU.Location = New System.Drawing.Point(641, 10)
        Me.btnLUU.Name = "btnLUU"
        Me.btnLUU.Size = New System.Drawing.Size(75, 23)
        Me.btnLUU.TabIndex = 40
        Me.btnLUU.Text = "Thêm"
        Me.btnLUU.UseVisualStyleBackColor = True
        '
        'btnSUA
        '
        Me.btnSUA.Location = New System.Drawing.Point(551, 42)
        Me.btnSUA.Name = "btnSUA"
        Me.btnSUA.Size = New System.Drawing.Size(75, 23)
        Me.btnSUA.TabIndex = 39
        Me.btnSUA.Text = "Sửa"
        Me.btnSUA.UseVisualStyleBackColor = True
        '
        'btnTHEM
        '
        Me.btnTHEM.Location = New System.Drawing.Point(551, 10)
        Me.btnTHEM.Name = "btnTHEM"
        Me.btnTHEM.Size = New System.Drawing.Size(75, 23)
        Me.btnTHEM.TabIndex = 38
        Me.btnTHEM.Text = "Load"
        Me.btnTHEM.UseVisualStyleBackColor = True
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(103, 48)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(146, 20)
        Me.txtMaKH.TabIndex = 36
        '
        'dgvHoadon
        '
        Me.dgvHoadon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHoadon.Location = New System.Drawing.Point(12, 90)
        Me.dgvHoadon.Name = "dgvHoadon"
        Me.dgvHoadon.Size = New System.Drawing.Size(704, 280)
        Me.dgvHoadon.TabIndex = 35
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(364, 12)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(172, 20)
        Me.txtDate.TabIndex = 34
        '
        'txtMAHD
        '
        Me.txtMAHD.Location = New System.Drawing.Point(103, 13)
        Me.txtMAHD.Name = "txtMAHD"
        Me.txtMAHD.Size = New System.Drawing.Size(146, 20)
        Me.txtMAHD.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Mã Khách Hàng"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Ngày Xuất Hoá Đơn"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Mã Hoá Đơn"
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 377)
        Me.Controls.Add(Me.btnXOA)
        Me.Controls.Add(Me.btnLUU)
        Me.Controls.Add(Me.btnSUA)
        Me.Controls.Add(Me.btnTHEM)
        Me.Controls.Add(Me.txtMaKH)
        Me.Controls.Add(Me.dgvHoadon)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtMAHD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Name = "frmHoaDon"
        Me.Text = "Hoá Đơn"
        CType(Me.dgvHoadon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnXOA As Button
    Friend WithEvents btnLUU As Button
    Friend WithEvents btnSUA As Button
    Friend WithEvents btnTHEM As Button
    Friend WithEvents txtMaKH As TextBox
    Friend WithEvents dgvHoadon As DataGridView
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtMAHD As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
