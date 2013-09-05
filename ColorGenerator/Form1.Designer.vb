<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.pnlSelCol = New System.Windows.Forms.Panel()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtLabel = New System.Windows.Forms.TextBox()
        Me.nudR = New System.Windows.Forms.NumericUpDown()
        Me.nudG = New System.Windows.Forms.NumericUpDown()
        Me.nudB = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnOpenImage = New System.Windows.Forms.Button()
        Me.picDisplay = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pnlDisplay = New System.Windows.Forms.Panel()
        Me.btnLoadCol = New System.Windows.Forms.Button()
        Me.dgvColor = New System.Windows.Forms.DataGridView()
        Me.dgclLabel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgclColor = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dgclR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgclG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgclB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgclH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgclSat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgclVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNearest = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMousePos = New System.Windows.Forms.TextBox()
        Me.chkMarker = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.nudR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDisplay.SuspendLayout()
        CType(Me.dgvColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(33, 104)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 3
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'pnlSelCol
        '
        Me.pnlSelCol.Location = New System.Drawing.Point(114, 22)
        Me.pnlSelCol.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSelCol.Name = "pnlSelCol"
        Me.pnlSelCol.Size = New System.Drawing.Size(121, 74)
        Me.pnlSelCol.TabIndex = 4
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(144, 133)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "png"
        Me.SaveFileDialog1.Filter = "PNG Images|*.png"
        '
        'txtLabel
        '
        Me.txtLabel.Location = New System.Drawing.Point(69, 135)
        Me.txtLabel.Name = "txtLabel"
        Me.txtLabel.Size = New System.Drawing.Size(69, 20)
        Me.txtLabel.TabIndex = 4
        '
        'nudR
        '
        Me.nudR.Location = New System.Drawing.Point(33, 22)
        Me.nudR.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudR.Name = "nudR"
        Me.nudR.Size = New System.Drawing.Size(75, 20)
        Me.nudR.TabIndex = 0
        '
        'nudG
        '
        Me.nudG.Location = New System.Drawing.Point(33, 49)
        Me.nudG.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudG.Name = "nudG"
        Me.nudG.Size = New System.Drawing.Size(75, 20)
        Me.nudG.TabIndex = 1
        '
        'nudB
        '
        Me.nudB.Location = New System.Drawing.Point(33, 76)
        Me.nudB.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.nudB.Name = "nudB"
        Me.nudB.Size = New System.Drawing.Size(75, 20)
        Me.nudB.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "R"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "G"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "B"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Label"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(114, 184)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(254, 20)
        Me.txtDir.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Save Directory"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(114, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Modulus"
        '
        'btnOpenImage
        '
        Me.btnOpenImage.Location = New System.Drawing.Point(293, 230)
        Me.btnOpenImage.Name = "btnOpenImage"
        Me.btnOpenImage.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenImage.TabIndex = 16
        Me.btnOpenImage.Text = "Open Image"
        Me.btnOpenImage.UseVisualStyleBackColor = True
        '
        'picDisplay
        '
        Me.picDisplay.Location = New System.Drawing.Point(0, 0)
        Me.picDisplay.Name = "picDisplay"
        Me.picDisplay.Size = New System.Drawing.Size(358, 384)
        Me.picDisplay.TabIndex = 17
        Me.picDisplay.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pnlDisplay
        '
        Me.pnlDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDisplay.AutoScroll = True
        Me.pnlDisplay.Controls.Add(Me.picDisplay)
        Me.pnlDisplay.Location = New System.Drawing.Point(374, 7)
        Me.pnlDisplay.Name = "pnlDisplay"
        Me.pnlDisplay.Size = New System.Drawing.Size(406, 601)
        Me.pnlDisplay.TabIndex = 18
        '
        'btnLoadCol
        '
        Me.btnLoadCol.Location = New System.Drawing.Point(34, 230)
        Me.btnLoadCol.Name = "btnLoadCol"
        Me.btnLoadCol.Size = New System.Drawing.Size(75, 23)
        Me.btnLoadCol.TabIndex = 19
        Me.btnLoadCol.Text = "Load Colors"
        Me.btnLoadCol.UseVisualStyleBackColor = True
        '
        'dgvColor
        '
        Me.dgvColor.AllowUserToAddRows = False
        Me.dgvColor.AllowUserToDeleteRows = False
        Me.dgvColor.AllowUserToResizeRows = False
        Me.dgvColor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvColor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvColor.BackgroundColor = System.Drawing.Color.White
        Me.dgvColor.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.dgvColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvColor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgclLabel, Me.dgclColor, Me.dgclR, Me.dgclG, Me.dgclB, Me.dgclH, Me.dgclSat, Me.dgclVal})
        Me.dgvColor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvColor.Location = New System.Drawing.Point(15, 259)
        Me.dgvColor.MultiSelect = False
        Me.dgvColor.Name = "dgvColor"
        Me.dgvColor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvColor.RowHeadersVisible = False
        Me.dgvColor.Size = New System.Drawing.Size(353, 349)
        Me.dgvColor.TabIndex = 20
        '
        'dgclLabel
        '
        Me.dgclLabel.HeaderText = "Label"
        Me.dgclLabel.Name = "dgclLabel"
        '
        'dgclColor
        '
        Me.dgclColor.HeaderText = "Color"
        Me.dgclColor.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.dgclColor.Name = "dgclColor"
        '
        'dgclR
        '
        Me.dgclR.HeaderText = "R"
        Me.dgclR.Name = "dgclR"
        '
        'dgclG
        '
        Me.dgclG.HeaderText = "G"
        Me.dgclG.Name = "dgclG"
        '
        'dgclB
        '
        Me.dgclB.HeaderText = "B"
        Me.dgclB.Name = "dgclB"
        '
        'dgclH
        '
        Me.dgclH.HeaderText = "Hue"
        Me.dgclH.Name = "dgclH"
        '
        'dgclSat
        '
        Me.dgclSat.HeaderText = "Sat"
        Me.dgclSat.Name = "dgclSat"
        '
        'dgclVal
        '
        Me.dgclVal.HeaderText = "Val"
        Me.dgclVal.Name = "dgclVal"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(235, 22)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 74)
        Me.Panel1.TabIndex = 5
        '
        'txtNearest
        '
        Me.txtNearest.Location = New System.Drawing.Point(242, 135)
        Me.txtNearest.Name = "txtNearest"
        Me.txtNearest.ReadOnly = True
        Me.txtNearest.Size = New System.Drawing.Size(114, 20)
        Me.txtNearest.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(239, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Nearest"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(156, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Mouse Position"
        '
        'txtMousePos
        '
        Me.txtMousePos.Location = New System.Drawing.Point(254, 207)
        Me.txtMousePos.Name = "txtMousePos"
        Me.txtMousePos.ReadOnly = True
        Me.txtMousePos.Size = New System.Drawing.Size(114, 20)
        Me.txtMousePos.TabIndex = 24
        '
        'chkMarker
        '
        Me.chkMarker.AutoSize = True
        Me.chkMarker.Location = New System.Drawing.Point(275, 161)
        Me.chkMarker.Name = "chkMarker"
        Me.chkMarker.Size = New System.Drawing.Size(59, 17)
        Me.chkMarker.TabIndex = 25
        Me.chkMarker.Text = "Marker"
        Me.chkMarker.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 620)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.chkMarker)
        Me.Controls.Add(Me.txtMousePos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNearest)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvColor)
        Me.Controls.Add(Me.btnLoadCol)
        Me.Controls.Add(Me.pnlDisplay)
        Me.Controls.Add(Me.btnOpenImage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudB)
        Me.Controls.Add(Me.nudG)
        Me.Controls.Add(Me.nudR)
        Me.Controls.Add(Me.txtLabel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.pnlSelCol)
        Me.Controls.Add(Me.btnGenerate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDisplay.ResumeLayout(False)
        CType(Me.dgvColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents pnlSelCol As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtLabel As System.Windows.Forms.TextBox
    Friend WithEvents nudR As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudG As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudB As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnOpenImage As System.Windows.Forms.Button
    Friend WithEvents picDisplay As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlDisplay As System.Windows.Forms.Panel
    Friend WithEvents btnLoadCol As System.Windows.Forms.Button
    Friend WithEvents dgvColor As System.Windows.Forms.DataGridView
    Friend WithEvents dgclLabel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgclColor As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dgclR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgclG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgclB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgclH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgclSat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgclVal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtNearest As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMousePos As System.Windows.Forms.TextBox
    Friend WithEvents chkMarker As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
