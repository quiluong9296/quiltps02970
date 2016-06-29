<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KhácHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SảnPhẩmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiênHệToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GiớiThiệuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YoutubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KhácHàngToolStripMenuItem, Me.SảnPhẩmToolStripMenuItem, Me.LiênHệToolStripMenuItem, Me.GiớiThiệuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(378, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KhácHàngToolStripMenuItem
        '
        Me.KhácHàngToolStripMenuItem.Image = CType(resources.GetObject("KhácHàngToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KhácHàngToolStripMenuItem.Name = "KhácHàngToolStripMenuItem"
        Me.KhácHàngToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.KhácHàngToolStripMenuItem.Text = "Sản Phẩm"
        '
        'SảnPhẩmToolStripMenuItem
        '
        Me.SảnPhẩmToolStripMenuItem.Image = CType(resources.GetObject("SảnPhẩmToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SảnPhẩmToolStripMenuItem.Name = "SảnPhẩmToolStripMenuItem"
        Me.SảnPhẩmToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.SảnPhẩmToolStripMenuItem.Text = "Khách Hàng"
        '
        'LiênHệToolStripMenuItem
        '
        Me.LiênHệToolStripMenuItem.Image = CType(resources.GetObject("LiênHệToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LiênHệToolStripMenuItem.Name = "LiênHệToolStripMenuItem"
        Me.LiênHệToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.LiênHệToolStripMenuItem.Text = "Hoá Đơn"
        '
        'GiớiThiệuToolStripMenuItem
        '
        Me.GiớiThiệuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GameToolStripMenuItem, Me.YoutubeToolStripMenuItem})
        Me.GiớiThiệuToolStripMenuItem.Image = CType(resources.GetObject("GiớiThiệuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GiớiThiệuToolStripMenuItem.Name = "GiớiThiệuToolStripMenuItem"
        Me.GiớiThiệuToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.GiớiThiệuToolStripMenuItem.Text = "Giải trí"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'YoutubeToolStripMenuItem
        '
        Me.YoutubeToolStripMenuItem.Name = "YoutubeToolStripMenuItem"
        Me.YoutubeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.YoutubeToolStripMenuItem.Text = "Youtube"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 43)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(354, 106)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Họ và tên: Lương Trọng Quí"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "MSSV: PS02970"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 202)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Giáo viên hướng dẫn: Lê Văn Phụng"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmHome"
        Me.Text = "Trang Chủ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KhácHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SảnPhẩmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiênHệToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GiớiThiệuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YoutubeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
