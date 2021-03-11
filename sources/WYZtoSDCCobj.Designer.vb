<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WYZtoSDCCobj
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WYZtoSDCCobj))
        Me.Inst_Label = New System.Windows.Forms.Label()
        Me.MUSasm_TextBox = New System.Windows.Forms.TextBox()
        Me.Config_GroupBox = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.DeleteMUS_Button = New System.Windows.Forms.Button()
        Me.AddMUS_Button = New System.Windows.Forms.Button()
        Me.MUS_ListBox = New System.Windows.Forms.ListBox()
        Me.Songs_Label = New System.Windows.Forms.Label()
        Me.AddAsmButton = New System.Windows.Forms.Button()
        Me.OutputData_GroupBox = New System.Windows.Forms.GroupBox()
        Me.CreateOBJ_Button = New System.Windows.Forms.Button()
        Me.SaveAsButton = New System.Windows.Forms.Button()
        Me.CopyAllButton = New System.Windows.Forms.Button()
        Me.OutputText = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Config_GroupBox.SuspendLayout()
        Me.OutputData_GroupBox.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Inst_Label
        '
        Me.Inst_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Inst_Label.Location = New System.Drawing.Point(15, 21)
        Me.Inst_Label.Name = "Inst_Label"
        Me.Inst_Label.Size = New System.Drawing.Size(160, 22)
        Me.Inst_Label.TabIndex = 0
        Me.Inst_Label.Text = "Instruments (.mus.asm)"
        '
        'MUSasm_TextBox
        '
        Me.MUSasm_TextBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MUSasm_TextBox.ForeColor = System.Drawing.Color.Black
        Me.MUSasm_TextBox.Location = New System.Drawing.Point(180, 21)
        Me.MUSasm_TextBox.MaxLength = 32
        Me.MUSasm_TextBox.Name = "MUSasm_TextBox"
        Me.MUSasm_TextBox.ReadOnly = True
        Me.MUSasm_TextBox.Size = New System.Drawing.Size(360, 22)
        Me.MUSasm_TextBox.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.MUSasm_TextBox, "up to 32 characters")
        '
        'Config_GroupBox
        '
        Me.Config_GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Config_GroupBox.Controls.Add(Me.ClearButton)
        Me.Config_GroupBox.Controls.Add(Me.DeleteMUS_Button)
        Me.Config_GroupBox.Controls.Add(Me.AddMUS_Button)
        Me.Config_GroupBox.Controls.Add(Me.MUS_ListBox)
        Me.Config_GroupBox.Controls.Add(Me.Songs_Label)
        Me.Config_GroupBox.Controls.Add(Me.AddAsmButton)
        Me.Config_GroupBox.Controls.Add(Me.Inst_Label)
        Me.Config_GroupBox.Controls.Add(Me.MUSasm_TextBox)
        Me.Config_GroupBox.Location = New System.Drawing.Point(13, 11)
        Me.Config_GroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Config_GroupBox.Name = "Config_GroupBox"
        Me.Config_GroupBox.Size = New System.Drawing.Size(653, 164)
        Me.Config_GroupBox.TabIndex = 8
        Me.Config_GroupBox.TabStop = False
        Me.Config_GroupBox.Text = "Output config"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(543, 102)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(71, 23)
        Me.ClearButton.TabIndex = 74
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Delete all Songs")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'DeleteMUS_Button
        '
        Me.DeleteMUS_Button.Location = New System.Drawing.Point(543, 78)
        Me.DeleteMUS_Button.Name = "DeleteMUS_Button"
        Me.DeleteMUS_Button.Size = New System.Drawing.Size(71, 23)
        Me.DeleteMUS_Button.TabIndex = 73
        Me.DeleteMUS_Button.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.DeleteMUS_Button, "Delete selected Song")
        Me.DeleteMUS_Button.UseVisualStyleBackColor = True
        '
        'AddMUS_Button
        '
        Me.AddMUS_Button.Location = New System.Drawing.Point(543, 54)
        Me.AddMUS_Button.Name = "AddMUS_Button"
        Me.AddMUS_Button.Size = New System.Drawing.Size(71, 23)
        Me.AddMUS_Button.TabIndex = 72
        Me.AddMUS_Button.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.AddMUS_Button, "Add some WYZ Tracker export song secuence data file (.mus)")
        Me.AddMUS_Button.UseVisualStyleBackColor = True
        '
        'MUS_ListBox
        '
        Me.MUS_ListBox.FormattingEnabled = True
        Me.MUS_ListBox.ItemHeight = 14
        Me.MUS_ListBox.Items.AddRange(New Object() {"Item 1", "Item 2"})
        Me.MUS_ListBox.Location = New System.Drawing.Point(180, 55)
        Me.MUS_ListBox.Name = "MUS_ListBox"
        Me.MUS_ListBox.Size = New System.Drawing.Size(360, 102)
        Me.MUS_ListBox.TabIndex = 71
        '
        'Songs_Label
        '
        Me.Songs_Label.Location = New System.Drawing.Point(15, 58)
        Me.Songs_Label.Name = "Songs_Label"
        Me.Songs_Label.Size = New System.Drawing.Size(160, 30)
        Me.Songs_Label.TabIndex = 70
        Me.Songs_Label.Text = "Songs (.MUS)"
        Me.Songs_Label.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'AddAsmButton
        '
        Me.AddAsmButton.Location = New System.Drawing.Point(543, 20)
        Me.AddAsmButton.Name = "AddAsmButton"
        Me.AddAsmButton.Size = New System.Drawing.Size(71, 23)
        Me.AddAsmButton.TabIndex = 69
        Me.AddAsmButton.Text = "Add"
        Me.ToolTip1.SetToolTip(Me.AddAsmButton, "Add WYZ Tracker export instruments data file (.mus.asm)")
        Me.AddAsmButton.UseVisualStyleBackColor = True
        '
        'OutputData_GroupBox
        '
        Me.OutputData_GroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputData_GroupBox.Controls.Add(Me.CreateOBJ_Button)
        Me.OutputData_GroupBox.Controls.Add(Me.SaveAsButton)
        Me.OutputData_GroupBox.Controls.Add(Me.CopyAllButton)
        Me.OutputData_GroupBox.Controls.Add(Me.OutputText)
        Me.OutputData_GroupBox.Location = New System.Drawing.Point(12, 182)
        Me.OutputData_GroupBox.Name = "OutputData_GroupBox"
        Me.OutputData_GroupBox.Size = New System.Drawing.Size(700, 300)
        Me.OutputData_GroupBox.TabIndex = 9
        Me.OutputData_GroupBox.TabStop = False
        Me.OutputData_GroupBox.Text = "Output Data"
        '
        'CreateOBJ_Button
        '
        Me.CreateOBJ_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateOBJ_Button.BackColor = System.Drawing.Color.Silver
        Me.CreateOBJ_Button.Enabled = False
        Me.CreateOBJ_Button.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateOBJ_Button.Location = New System.Drawing.Point(345, 263)
        Me.CreateOBJ_Button.Name = "CreateOBJ_Button"
        Me.CreateOBJ_Button.Size = New System.Drawing.Size(107, 32)
        Me.CreateOBJ_Button.TabIndex = 9
        Me.CreateOBJ_Button.Text = "Create OBJ"
        Me.CreateOBJ_Button.UseVisualStyleBackColor = False
        '
        'SaveAsButton
        '
        Me.SaveAsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveAsButton.BackColor = System.Drawing.Color.Silver
        Me.SaveAsButton.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveAsButton.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.save3_x24
        Me.SaveAsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SaveAsButton.Location = New System.Drawing.Point(458, 263)
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Padding = New System.Windows.Forms.Padding(2, 5, 3, 3)
        Me.SaveAsButton.Size = New System.Drawing.Size(123, 32)
        Me.SaveAsButton.TabIndex = 7
        Me.SaveAsButton.Text = "Save WYZ.s"
        Me.SaveAsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.SaveAsButton, "Save Output Data to .s file")
        Me.SaveAsButton.UseVisualStyleBackColor = False
        '
        'CopyAllButton
        '
        Me.CopyAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CopyAllButton.BackColor = System.Drawing.Color.Silver
        Me.CopyAllButton.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CopyAllButton.Location = New System.Drawing.Point(587, 263)
        Me.CopyAllButton.Name = "CopyAllButton"
        Me.CopyAllButton.Size = New System.Drawing.Size(107, 32)
        Me.CopyAllButton.TabIndex = 8
        Me.CopyAllButton.Text = "Copy All"
        Me.ToolTip1.SetToolTip(Me.CopyAllButton, "Copy Output Data to Clipboard")
        Me.CopyAllButton.UseVisualStyleBackColor = False
        '
        'OutputText
        '
        Me.OutputText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputText.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputText.Location = New System.Drawing.Point(18, 21)
        Me.OutputText.Multiline = True
        Me.OutputText.Name = "OutputText"
        Me.OutputText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.OutputText.Size = New System.Drawing.Size(676, 236)
        Me.OutputText.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.IsBalloon = True
        '
        'AboutButton
        '
        Me.AboutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutButton.Image = Global.mSXdevtools.WYZtoSDCCobj.My.Resources.Resources.about_24
        Me.AboutButton.Location = New System.Drawing.Point(680, 17)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(32, 32)
        Me.AboutButton.TabIndex = 71
        Me.ToolTip1.SetToolTip(Me.AboutButton, "About this App")
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 489)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(724, 22)
        Me.StatusStrip1.TabIndex = 70
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel1.Text = "mSX·devtool"
        '
        'WYZtoSDCCobj
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(724, 511)
        Me.Controls.Add(Me.AboutButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.OutputData_GroupBox)
        Me.Controls.Add(Me.Config_GroupBox)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MinimumSize = New System.Drawing.Size(740, 500)
        Me.Name = "WYZtoSDCCobj"
        Me.Text = "WYZtoSDCCobj"
        Me.Config_GroupBox.ResumeLayout(False)
        Me.Config_GroupBox.PerformLayout()
        Me.OutputData_GroupBox.ResumeLayout(False)
        Me.OutputData_GroupBox.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Inst_Label As Label
    Friend WithEvents MUSasm_TextBox As TextBox
    Friend WithEvents Config_GroupBox As GroupBox
    Friend WithEvents OutputData_GroupBox As GroupBox
    Friend WithEvents SaveAsButton As Button
    Friend WithEvents CopyAllButton As Button
    Friend WithEvents OutputText As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents AboutButton As Button
    Friend WithEvents AddMUS_Button As Button
    Friend WithEvents MUS_ListBox As ListBox
    Friend WithEvents Songs_Label As Label
    Friend WithEvents AddAsmButton As Button
    Friend WithEvents DeleteMUS_Button As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents CreateOBJ_Button As Button
End Class
