<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Search"
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Items.AddRange(New Object() {"Mã Khách Hàng", "Tên Khách Hàng", "Địa Chỉ", "Số Điện Thoại"})
        Me.cmbSearch.Location = New System.Drawing.Point(58, 6)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(184, 21)
        Me.cmbSearch.TabIndex = 20
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(295, 6)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(208, 20)
        Me.txtSearch.TabIndex = 21
        '
        'dgvSearch
        '
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Location = New System.Drawing.Point(15, 39)
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.Size = New System.Drawing.Size(488, 210)
        Me.dgvSearch.TabIndex = 22
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 261)
        Me.Controls.Add(Me.dgvSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmSearch"
        Me.Text = "Search"
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvSearch As DataGridView
End Class
