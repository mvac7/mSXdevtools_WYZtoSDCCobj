<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WYZtoSDCCobj
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WYZtoSDCCobj))
        Me.OutputText = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MUSasm_TextBox = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ProjectToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ProjectNameTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.OutputToolsPanel = New System.Windows.Forms.Panel()
        Me.PiXelGroupBox1 = New mSXdevtools.WYZtoSDCCobj.piXelGroupBox()
        Me.Inst_Label = New System.Windows.Forms.Label()
        Me.Songs_Label = New System.Windows.Forms.Label()
        Me.MUS_ListBox = New System.Windows.Forms.ListBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DeleteMUS_Button = New System.Windows.Forms.Button()
        Me.AddAsmButton = New System.Windows.Forms.Button()
        Me.AddMUS_Button = New System.Windows.Forms.Button()
        Me.CopyAllButton = New System.Windows.Forms.Button()
        Me.SaveSourceButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.About_Button = New System.Windows.Forms.ToolStripButton()
        Me.Help_Button = New System.Windows.Forms.ToolStripButton()
        Me.ProjectToolStrip.SuspendLayout()
        Me.OutputToolsPanel.SuspendLayout()
        Me.PiXelGroupBox1.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutputText
        '
        Me.OutputText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputText.BackColor = System.Drawing.Color.WhiteSmoke
        Me.OutputText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputText.ForeColor = System.Drawing.Color.Black
        Me.OutputText.Location = New System.Drawing.Point(12, 308)
        Me.OutputText.Multiline = True
        Me.OutputText.Name = "OutputText"
        Me.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputText.Size = New System.Drawing.Size(740, 178)
        Me.OutputText.TabIndex = 7
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 10000
        Me.ToolTip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'MUSasm_TextBox
        '
        Me.MUSasm_TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MUSasm_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MUSasm_TextBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MUSasm_TextBox.ForeColor = System.Drawing.Color.Black
        Me.MUSasm_TextBox.Location = New System.Drawing.Point(177, 25)
        Me.MUSasm_TextBox.MaxLength = 32
        Me.MUSasm_TextBox.Name = "MUSasm_TextBox"
        Me.MUSasm_TextBox.ReadOnly = True
        Me.MUSasm_TextBox.Size = New System.Drawing.Size(456, 22)
        Me.MUSasm_TextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.MUSasm_TextBox, "up to 32 characters")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Silver
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(764, 22)
        Me.StatusStrip1.TabIndex = 70
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ProjectToolStrip
        '
        Me.ProjectToolStrip.BackColor = System.Drawing.Color.Gainsboro
        Me.ProjectToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ProjectToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.ProjectNameTextBox, Me.Help_Button, Me.About_Button})
        Me.ProjectToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ProjectToolStrip.Name = "ProjectToolStrip"
        Me.ProjectToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ProjectToolStrip.Size = New System.Drawing.Size(764, 31)
        Me.ProjectToolStrip.TabIndex = 0
        Me.ProjectToolStrip.Text = "ToolStrip1"
        '
        'ProjectNameTextBox
        '
        Me.ProjectNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProjectNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProjectNameTextBox.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProjectNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.ProjectNameTextBox.MaxLength = 128
        Me.ProjectNameTextBox.Name = "ProjectNameTextBox"
        Me.ProjectNameTextBox.Size = New System.Drawing.Size(330, 31)
        '
        'OutputToolsPanel
        '
        Me.OutputToolsPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OutputToolsPanel.BackColor = System.Drawing.Color.Transparent
        Me.OutputToolsPanel.Controls.Add(Me.CopyAllButton)
        Me.OutputToolsPanel.Controls.Add(Me.SaveSourceButton)
        Me.OutputToolsPanel.Location = New System.Drawing.Point(16, 492)
        Me.OutputToolsPanel.Name = "OutputToolsPanel"
        Me.OutputToolsPanel.Size = New System.Drawing.Size(736, 44)
        Me.OutputToolsPanel.TabIndex = 73
        '
        'PiXelGroupBox1
        '
        Me.PiXelGroupBox1.Controls.Add(Me.ClearButton)
        Me.PiXelGroupBox1.Controls.Add(Me.Inst_Label)
        Me.PiXelGroupBox1.Controls.Add(Me.Songs_Label)
        Me.PiXelGroupBox1.Controls.Add(Me.DeleteMUS_Button)
        Me.PiXelGroupBox1.Controls.Add(Me.MUS_ListBox)
        Me.PiXelGroupBox1.Controls.Add(Me.MUSasm_TextBox)
        Me.PiXelGroupBox1.Controls.Add(Me.AddAsmButton)
        Me.PiXelGroupBox1.Controls.Add(Me.AddMUS_Button)
        Me.PiXelGroupBox1.Location = New System.Drawing.Point(12, 127)
        Me.PiXelGroupBox1.Name = "PiXelGroupBox1"
        Me.PiXelGroupBox1.Padding = New System.Windows.Forms.Padding(10)
        Me.PiXelGroupBox1.Size = New System.Drawing.Size(742, 164)
        Me.PiXelGroupBox1.TabIndex = 74
        Me.PiXelGroupBox1.TabStop = False
        Me.PiXelGroupBox1.Text = "WYZTracker .MUS Files"
        '
        'Inst_Label
        '
        Me.Inst_Label.BackColor = System.Drawing.Color.Transparent
        Me.Inst_Label.Location = New System.Drawing.Point(3, 25)
        Me.Inst_Label.Name = "Inst_Label"
        Me.Inst_Label.Size = New System.Drawing.Size(169, 22)
        Me.Inst_Label.TabIndex = 99
        Me.Inst_Label.Text = "Instruments (.mus.asm)"
        Me.Inst_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Songs_Label
        '
        Me.Songs_Label.BackColor = System.Drawing.Color.Transparent
        Me.Songs_Label.Location = New System.Drawing.Point(3, 54)
        Me.Songs_Label.Name = "Songs_Label"
        Me.Songs_Label.Size = New System.Drawing.Size(169, 19)
        Me.Songs_Label.TabIndex = 99
        Me.Songs_Label.Text = "Songs (.mus)"
        Me.Songs_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MUS_ListBox
        '
        Me.MUS_ListBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MUS_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MUS_ListBox.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MUS_ListBox.ForeColor = System.Drawing.Color.Black
        Me.MUS_ListBox.FormattingEnabled = True
        Me.MUS_ListBox.ItemHeight = 16
        Me.MUS_ListBox.Items.AddRange(New Object() {"Item 1", "Item 2"})
        Me.MUS_ListBox.Location = New System.Drawing.Point(177, 55)
        Me.MUS_ListBox.Name = "MUS_ListBox"
        Me.MUS_ListBox.Size = New System.Drawing.Size(456, 98)
        Me.MUS_ListBox.TabIndex = 3
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Transparent
        Me.ClearButton.FlatAppearance.BorderSize = 0
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.button_clear
        Me.ClearButton.Location = New System.Drawing.Point(636, 109)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(90, 23)
        Me.ClearButton.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Delete all Songs")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'DeleteMUS_Button
        '
        Me.DeleteMUS_Button.BackColor = System.Drawing.Color.Transparent
        Me.DeleteMUS_Button.FlatAppearance.BorderSize = 0
        Me.DeleteMUS_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteMUS_Button.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.button_delete
        Me.DeleteMUS_Button.Location = New System.Drawing.Point(636, 82)
        Me.DeleteMUS_Button.Name = "DeleteMUS_Button"
        Me.DeleteMUS_Button.Size = New System.Drawing.Size(90, 23)
        Me.DeleteMUS_Button.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DeleteMUS_Button, "Delete selected Song")
        Me.DeleteMUS_Button.UseVisualStyleBackColor = False
        '
        'AddAsmButton
        '
        Me.AddAsmButton.BackColor = System.Drawing.Color.Transparent
        Me.AddAsmButton.FlatAppearance.BorderSize = 0
        Me.AddAsmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddAsmButton.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.button_add
        Me.AddAsmButton.Location = New System.Drawing.Point(636, 23)
        Me.AddAsmButton.Name = "AddAsmButton"
        Me.AddAsmButton.Size = New System.Drawing.Size(90, 23)
        Me.AddAsmButton.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.AddAsmButton, "Add WYZ Tracker export instruments data file (.mus.asm)")
        Me.AddAsmButton.UseVisualStyleBackColor = False
        '
        'AddMUS_Button
        '
        Me.AddMUS_Button.BackColor = System.Drawing.Color.Transparent
        Me.AddMUS_Button.FlatAppearance.BorderSize = 0
        Me.AddMUS_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddMUS_Button.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.button_add
        Me.AddMUS_Button.Location = New System.Drawing.Point(636, 55)
        Me.AddMUS_Button.Name = "AddMUS_Button"
        Me.AddMUS_Button.Size = New System.Drawing.Size(90, 23)
        Me.AddMUS_Button.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.AddMUS_Button, "Add some WYZ Tracker export song secuence data file (.mus)")
        Me.AddMUS_Button.UseVisualStyleBackColor = False
        '
        'CopyAllButton
        '
        Me.CopyAllButton.BackColor = System.Drawing.Color.Transparent
        Me.CopyAllButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CopyAllButton.FlatAppearance.BorderSize = 0
        Me.CopyAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CopyAllButton.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.button_CopyAll
        Me.CopyAllButton.Location = New System.Drawing.Point(377, 0)
        Me.CopyAllButton.Margin = New System.Windows.Forms.Padding(0)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Size = New System.Drawing.Size(155, 44)
        Me.CopyAllButton.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.CopyAllButton, "Copy Output Data to Clipboard")
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'SaveSourceButton
        '
        Me.SaveSourceButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveSourceButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SaveSourceButton.FlatAppearance.BorderSize = 0
        Me.SaveSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveSourceButton.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.button_savesource
        Me.SaveSourceButton.Location = New System.Drawing.Point(532, 0)
        Me.SaveSourceButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveSourceButton.Name = "SaveSourceButton"
        Me.SaveSourceButton.Padding = New System.Windows.Forms.Padding(4)
        Me.SaveSourceButton.Size = New System.Drawing.Size(204, 44)
        Me.SaveSourceButton.TabIndex = 9
        Me.SaveSourceButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.SaveSourceButton, "Save Output Data to .s file")
        Me.SaveSourceButton.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LogoPictureBox.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.WYZmus2sdccO_logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(295, 44)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(452, 75)
        Me.LogoPictureBox.TabIndex = 71
        Me.LogoPictureBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LogoPictureBox, "Yes!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I like to give weird names. ;)")
        '
        'NewButton
        '
        Me.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewButton.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.new_24
        Me.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(28, 28)
        Me.NewButton.Text = "ToolStripButton1"
        '
        'About_Button
        '
        Me.About_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.About_Button.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.about_24
        Me.About_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.About_Button.Name = "About_Button"
        Me.About_Button.Size = New System.Drawing.Size(28, 28)
        Me.About_Button.Text = "ToolStripButton1"
        '
        'Help_Button
        '
        Me.Help_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Help_Button.Enabled = False
        Me.Help_Button.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.help_x24
        Me.Help_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Help_Button.Name = "Help_Button"
        Me.Help_Button.Size = New System.Drawing.Size(28, 28)
        Me.Help_Button.Text = "ToolStripButton1"
        Me.Help_Button.ToolTipText = "Help"
        '
        'WYZtoSDCCobj
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(764, 561)
        Me.Controls.Add(Me.PiXelGroupBox1)
        Me.Controls.Add(Me.OutputToolsPanel)
        Me.Controls.Add(Me.OutputText)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.ProjectToolStrip)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximumSize = New System.Drawing.Size(780, 1920)
        Me.MinimumSize = New System.Drawing.Size(780, 500)
        Me.Name = "WYZtoSDCCobj"
        Me.Text = "WYZtoSDCCobj"
        Me.ProjectToolStrip.ResumeLayout(False)
        Me.ProjectToolStrip.PerformLayout()
        Me.OutputToolsPanel.ResumeLayout(False)
        Me.PiXelGroupBox1.ResumeLayout(False)
        Me.PiXelGroupBox1.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Inst_Label As Label
    Friend WithEvents MUSasm_TextBox As TextBox
    Friend WithEvents SaveSourceButton As Button
    Friend WithEvents CopyAllButton As Button
    Friend WithEvents OutputText As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents AddMUS_Button As Button
    Friend WithEvents MUS_ListBox As ListBox
    Friend WithEvents Songs_Label As Label
    Friend WithEvents AddAsmButton As Button
    Friend WithEvents DeleteMUS_Button As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ProjectToolStrip As ToolStrip
    Friend WithEvents NewButton As ToolStripButton
    Friend WithEvents About_Button As ToolStripButton
    Friend WithEvents ProjectNameTextBox As ToolStripTextBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents OutputToolsPanel As Panel
    Friend WithEvents PiXelGroupBox1 As piXelGroupBox
    Friend WithEvents Help_Button As ToolStripButton
End Class
