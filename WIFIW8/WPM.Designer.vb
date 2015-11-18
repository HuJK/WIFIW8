<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WPM
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WPM))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Showinfo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoveToTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Removeprof = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExporttoXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowProfileInfomationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Showpd = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ButtonMU = New System.Windows.Forms.Button()
        Me.ButtonMD = New System.Windows.Forms.Button()
        Me.ButtonM2 = New System.Windows.Forms.Button()
        Me.ButtonXML = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonINFO = New System.Windows.Forms.Button()
        Me.M2Menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StripM2T = New System.Windows.Forms.ToolStripMenuItem()
        Me.StripM2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.XMLMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StripExportXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.StripImportXML = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonMENU = New System.Windows.Forms.Button()
        Me.ButtonPWD = New System.Windows.Forms.Button()
        Me.Showinfo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.M2Menu.SuspendLayout()
        Me.XMLMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.ContextMenuStrip = Me.Showinfo
        Me.ListBox1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(22, 81)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(564, 345)
        Me.ListBox1.TabIndex = 0
        '
        'Showinfo
        '
        Me.Showinfo.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Showinfo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToTop, Me.MoveUp, Me.MoveDown, Me.MoveTo, Me.ToolStripSeparator1, Me.Removeprof, Me.ToolStripSeparator2, Me.ExporttoXML, Me.ImportXML, Me.ToolStripSeparator3, Me.ShowProfileInfomationToolStripMenuItem, Me.Showpd})
        Me.Showinfo.Name = "ContextMenuStrip1"
        Me.Showinfo.Size = New System.Drawing.Size(305, 274)
        '
        'MoveToTop
        '
        Me.MoveToTop.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MoveToTop.Name = "MoveToTop"
        Me.MoveToTop.Size = New System.Drawing.Size(304, 28)
        Me.MoveToTop.Text = "Move to top"
        '
        'MoveUp
        '
        Me.MoveUp.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MoveUp.Name = "MoveUp"
        Me.MoveUp.Size = New System.Drawing.Size(304, 28)
        Me.MoveUp.Text = "Move Up"
        '
        'MoveDown
        '
        Me.MoveDown.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MoveDown.Name = "MoveDown"
        Me.MoveDown.Size = New System.Drawing.Size(304, 28)
        Me.MoveDown.Text = "Move Down"
        '
        'MoveTo
        '
        Me.MoveTo.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MoveTo.Name = "MoveTo"
        Me.MoveTo.Size = New System.Drawing.Size(304, 28)
        Me.MoveTo.Text = "Move to ..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(301, 6)
        '
        'Removeprof
        '
        Me.Removeprof.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Removeprof.Name = "Removeprof"
        Me.Removeprof.Size = New System.Drawing.Size(304, 28)
        Me.Removeprof.Text = "Remove"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(301, 6)
        '
        'ExporttoXML
        '
        Me.ExporttoXML.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ExporttoXML.Name = "ExporttoXML"
        Me.ExporttoXML.Size = New System.Drawing.Size(304, 28)
        Me.ExporttoXML.Text = "Export to XML"
        '
        'ImportXML
        '
        Me.ImportXML.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ImportXML.Name = "ImportXML"
        Me.ImportXML.Size = New System.Drawing.Size(304, 28)
        Me.ImportXML.Text = "Import XML"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(301, 6)
        '
        'ShowProfileInfomationToolStripMenuItem
        '
        Me.ShowProfileInfomationToolStripMenuItem.Font = New System.Drawing.Font("Microsoft JhengHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ShowProfileInfomationToolStripMenuItem.Name = "ShowProfileInfomationToolStripMenuItem"
        Me.ShowProfileInfomationToolStripMenuItem.Size = New System.Drawing.Size(304, 28)
        Me.ShowProfileInfomationToolStripMenuItem.Text = "Show Profile Infomation"
        '
        'Showpd
        '
        Me.Showpd.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Showpd.Image = Global.WIFIW8.My.Resources.Resources.w7uacshield1
        Me.Showpd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Showpd.Name = "Showpd"
        Me.Showpd.Size = New System.Drawing.Size(304, 28)
        Me.Showpd.Text = "Show Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SSID"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'JToolStripMenuItem
        '
        Me.JToolStripMenuItem.Name = "JToolStripMenuItem"
        Me.JToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.JToolStripMenuItem.Text = "Command Record"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(533, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ButtonMU
        '
        Me.ButtonMU.Location = New System.Drawing.Point(90, 34)
        Me.ButtonMU.Name = "ButtonMU"
        Me.ButtonMU.Size = New System.Drawing.Size(56, 38)
        Me.ButtonMU.TabIndex = 5
        Me.ButtonMU.Text = "MU"
        Me.ButtonMU.UseVisualStyleBackColor = True
        '
        'ButtonMD
        '
        Me.ButtonMD.Location = New System.Drawing.Point(152, 34)
        Me.ButtonMD.Name = "ButtonMD"
        Me.ButtonMD.Size = New System.Drawing.Size(56, 38)
        Me.ButtonMD.TabIndex = 6
        Me.ButtonMD.Text = "MD"
        Me.ButtonMD.UseVisualStyleBackColor = True
        '
        'ButtonM2
        '
        Me.ButtonM2.Location = New System.Drawing.Point(214, 34)
        Me.ButtonM2.Name = "ButtonM2"
        Me.ButtonM2.Size = New System.Drawing.Size(56, 38)
        Me.ButtonM2.TabIndex = 7
        Me.ButtonM2.Text = "M2..."
        Me.ButtonM2.UseVisualStyleBackColor = True
        '
        'ButtonXML
        '
        Me.ButtonXML.Location = New System.Drawing.Point(338, 34)
        Me.ButtonXML.Name = "ButtonXML"
        Me.ButtonXML.Size = New System.Drawing.Size(56, 38)
        Me.ButtonXML.TabIndex = 8
        Me.ButtonXML.Text = "XML"
        Me.ButtonXML.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(276, 34)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(56, 38)
        Me.ButtonDelete.TabIndex = 9
        Me.ButtonDelete.Text = "Rm"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonINFO
        '
        Me.ButtonINFO.Location = New System.Drawing.Point(400, 34)
        Me.ButtonINFO.Name = "ButtonINFO"
        Me.ButtonINFO.Size = New System.Drawing.Size(56, 38)
        Me.ButtonINFO.TabIndex = 10
        Me.ButtonINFO.Text = "Info"
        Me.ButtonINFO.UseVisualStyleBackColor = True
        '
        'M2Menu
        '
        Me.M2Menu.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.M2Menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StripM2T, Me.StripM2})
        Me.M2Menu.Name = "M2Menu"
        Me.M2Menu.ShowImageMargin = False
        Me.M2Menu.Size = New System.Drawing.Size(286, 116)
        '
        'StripM2T
        '
        Me.StripM2T.Name = "StripM2T"
        Me.StripM2T.Size = New System.Drawing.Size(285, 56)
        Me.StripM2T.Text = "Move to top"
        '
        'StripM2
        '
        Me.StripM2.Name = "StripM2"
        Me.StripM2.Size = New System.Drawing.Size(285, 56)
        Me.StripM2.Text = "Move to ..."
        '
        'XMLMenu
        '
        Me.XMLMenu.Font = New System.Drawing.Font("Segoe UI", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XMLMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StripExportXML, Me.StripImportXML})
        Me.XMLMenu.Name = "M2Menu"
        Me.XMLMenu.ShowImageMargin = False
        Me.XMLMenu.Size = New System.Drawing.Size(315, 116)
        '
        'StripExportXML
        '
        Me.StripExportXML.Name = "StripExportXML"
        Me.StripExportXML.Size = New System.Drawing.Size(314, 56)
        Me.StripExportXML.Text = "Export to XML"
        '
        'StripImportXML
        '
        Me.StripImportXML.Name = "StripImportXML"
        Me.StripImportXML.Size = New System.Drawing.Size(314, 56)
        Me.StripImportXML.Text = "Import XML"
        '
        'ButtonMENU
        '
        Me.ButtonMENU.ForeColor = System.Drawing.Color.Green
        Me.ButtonMENU.Location = New System.Drawing.Point(90, 34)
        Me.ButtonMENU.Name = "ButtonMENU"
        Me.ButtonMENU.Size = New System.Drawing.Size(53, 38)
        Me.ButtonMENU.TabIndex = 12
        Me.ButtonMENU.Text = "Menu"
        Me.ButtonMENU.UseVisualStyleBackColor = True
        Me.ButtonMENU.Visible = False
        '
        'ButtonPWD
        '
        Me.ButtonPWD.BackgroundImage = Global.WIFIW8.My.Resources.Resources.w7uacshield1
        Me.ButtonPWD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonPWD.Cursor = System.Windows.Forms.Cursors.Default
        Me.ButtonPWD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPWD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ButtonPWD.Location = New System.Drawing.Point(462, 34)
        Me.ButtonPWD.Name = "ButtonPWD"
        Me.ButtonPWD.Size = New System.Drawing.Size(56, 38)
        Me.ButtonPWD.TabIndex = 11
        Me.ButtonPWD.Text = "Pwd"
        Me.ButtonPWD.UseVisualStyleBackColor = True
        '
        'WPM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 479)
        Me.Controls.Add(Me.ButtonMENU)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonPWD)
        Me.Controls.Add(Me.ButtonINFO)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonXML)
        Me.Controls.Add(Me.ButtonM2)
        Me.Controls.Add(Me.ButtonMD)
        Me.Controls.Add(Me.ButtonMU)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(16, 203)
        Me.Name = "WPM"
        Me.Text = "WIFI Profile Manager"
        Me.Showinfo.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.M2Menu.ResumeLayout(False)
        Me.XMLMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Showinfo As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Removeprof As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Showpd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowProfileInfomationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveToTop As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveUp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveDown As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoveTo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExporttoXML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportXML As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ButtonMU As Button
    Friend WithEvents ButtonMD As Button
    Friend WithEvents ButtonM2 As Button
    Friend WithEvents ButtonXML As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonINFO As Button
    Friend WithEvents ButtonPWD As Button
    Friend WithEvents M2Menu As ContextMenuStrip
    Friend WithEvents StripM2T As ToolStripMenuItem
    Friend WithEvents StripM2 As ToolStripMenuItem
    Friend WithEvents XMLMenu As ContextMenuStrip
    Friend WithEvents StripExportXML As ToolStripMenuItem
    Friend WithEvents StripImportXML As ToolStripMenuItem
    Friend WithEvents ButtonMENU As Button
End Class
