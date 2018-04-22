<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crypto
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crypto))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPageName = New System.Windows.Forms.Label()
        Me.txtMsg = New System.Windows.Forms.TextBox()
        Me.btnCeaserSet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnASCIISet = New System.Windows.Forms.Button()
        Me.btnA1Z26Set = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnCeaserMin = New System.Windows.Forms.Button()
        Me.btnCeaserPlus = New System.Windows.Forms.Button()
        Me.txtCeaser = New System.Windows.Forms.TextBox()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.txtEnc = New System.Windows.Forms.TextBox()
        Me.Encrypt = New System.Windows.Forms.Button()
        Me.Decrypt = New System.Windows.Forms.Button()
        Me.setVal = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblPageName
        '
        Me.lblPageName.AutoSize = True
        Me.lblPageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPageName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPageName.Location = New System.Drawing.Point(49, 21)
        Me.lblPageName.Name = "lblPageName"
        Me.lblPageName.Size = New System.Drawing.Size(54, 18)
        Me.lblPageName.TabIndex = 2
        Me.lblPageName.Text = "Crypto"
        '
        'txtMsg
        '
        Me.txtMsg.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtMsg.Location = New System.Drawing.Point(13, 345)
        Me.txtMsg.Multiline = True
        Me.txtMsg.Name = "txtMsg"
        Me.txtMsg.Size = New System.Drawing.Size(259, 44)
        Me.txtMsg.TabIndex = 7
        '
        'btnCeaserSet
        '
        Me.btnCeaserSet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCeaserSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCeaserSet.Location = New System.Drawing.Point(79, 77)
        Me.btnCeaserSet.Name = "btnCeaserSet"
        Me.btnCeaserSet.Size = New System.Drawing.Size(57, 23)
        Me.btnCeaserSet.TabIndex = 9
        Me.btnCeaserSet.Text = "Ceasar"
        Me.btnCeaserSet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 22)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Choose mode"
        '
        'btnASCIISet
        '
        Me.btnASCIISet.BackColor = System.Drawing.Color.Maroon
        Me.btnASCIISet.Cursor = System.Windows.Forms.Cursors.No
        Me.btnASCIISet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnASCIISet.Location = New System.Drawing.Point(142, 77)
        Me.btnASCIISet.Name = "btnASCIISet"
        Me.btnASCIISet.Size = New System.Drawing.Size(59, 23)
        Me.btnASCIISet.TabIndex = 11
        Me.btnASCIISet.Text = "ASCII"
        Me.btnASCIISet.UseVisualStyleBackColor = False
        '
        'btnA1Z26Set
        '
        Me.btnA1Z26Set.BackColor = System.Drawing.Color.Maroon
        Me.btnA1Z26Set.Cursor = System.Windows.Forms.Cursors.No
        Me.btnA1Z26Set.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA1Z26Set.Location = New System.Drawing.Point(207, 77)
        Me.btnA1Z26Set.Name = "btnA1Z26Set"
        Me.btnA1Z26Set.Size = New System.Drawing.Size(66, 23)
        Me.btnA1Z26Set.TabIndex = 12
        Me.btnA1Z26Set.Text = "A1-Z26"
        Me.btnA1Z26Set.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(3, 62)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'btnCeaserMin
        '
        Me.btnCeaserMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCeaserMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCeaserMin.Location = New System.Drawing.Point(80, 108)
        Me.btnCeaserMin.Name = "btnCeaserMin"
        Me.btnCeaserMin.Size = New System.Drawing.Size(25, 25)
        Me.btnCeaserMin.TabIndex = 14
        Me.btnCeaserMin.Text = "-"
        Me.btnCeaserMin.UseVisualStyleBackColor = True
        Me.btnCeaserMin.Visible = False
        '
        'btnCeaserPlus
        '
        Me.btnCeaserPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCeaserPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCeaserPlus.Location = New System.Drawing.Point(152, 107)
        Me.btnCeaserPlus.Name = "btnCeaserPlus"
        Me.btnCeaserPlus.Size = New System.Drawing.Size(25, 25)
        Me.btnCeaserPlus.TabIndex = 15
        Me.btnCeaserPlus.Text = "+"
        Me.btnCeaserPlus.UseVisualStyleBackColor = True
        Me.btnCeaserPlus.Visible = False
        '
        'txtCeaser
        '
        Me.txtCeaser.Location = New System.Drawing.Point(111, 111)
        Me.txtCeaser.MaxLength = 2
        Me.txtCeaser.Name = "txtCeaser"
        Me.txtCeaser.Size = New System.Drawing.Size(35, 20)
        Me.txtCeaser.TabIndex = 16
        Me.txtCeaser.Text = "1"
        Me.txtCeaser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCeaser.Visible = False
        '
        'lblMode
        '
        Me.lblMode.AutoSize = True
        Me.lblMode.Location = New System.Drawing.Point(105, 25)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(31, 13)
        Me.lblMode.TabIndex = 18
        Me.lblMode.Text = "none"
        '
        'txtEnc
        '
        Me.txtEnc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtEnc.HideSelection = False
        Me.txtEnc.Location = New System.Drawing.Point(12, 150)
        Me.txtEnc.Multiline = True
        Me.txtEnc.Name = "txtEnc"
        Me.txtEnc.ReadOnly = True
        Me.txtEnc.Size = New System.Drawing.Size(261, 147)
        Me.txtEnc.TabIndex = 19
        '
        'Encrypt
        '
        Me.Encrypt.Location = New System.Drawing.Point(13, 304)
        Me.Encrypt.Name = "Encrypt"
        Me.Encrypt.Size = New System.Drawing.Size(123, 35)
        Me.Encrypt.TabIndex = 20
        Me.Encrypt.Text = "Encrypt"
        Me.Encrypt.UseVisualStyleBackColor = True
        '
        'Decrypt
        '
        Me.Decrypt.Location = New System.Drawing.Point(149, 304)
        Me.Decrypt.Name = "Decrypt"
        Me.Decrypt.Size = New System.Drawing.Size(123, 35)
        Me.Decrypt.TabIndex = 21
        Me.Decrypt.Text = "Decrypt"
        Me.Decrypt.UseVisualStyleBackColor = True
        '
        'setVal
        '
        Me.setVal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.setVal.Location = New System.Drawing.Point(183, 109)
        Me.setVal.Name = "setVal"
        Me.setVal.Size = New System.Drawing.Size(89, 23)
        Me.setVal.TabIndex = 22
        Me.setVal.TabStop = False
        Me.setVal.Text = "Set as Value"
        Me.setVal.UseVisualStyleBackColor = True
        '
        'Crypto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(284, 401)
        Me.Controls.Add(Me.setVal)
        Me.Controls.Add(Me.Decrypt)
        Me.Controls.Add(Me.Encrypt)
        Me.Controls.Add(Me.txtEnc)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.txtCeaser)
        Me.Controls.Add(Me.btnCeaserPlus)
        Me.Controls.Add(Me.btnCeaserMin)
        Me.Controls.Add(Me.btnA1Z26Set)
        Me.Controls.Add(Me.btnASCIISet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCeaserSet)
        Me.Controls.Add(Me.txtMsg)
        Me.Controls.Add(Me.lblPageName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Crypto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPageName As Label
    Friend WithEvents txtMsg As TextBox
    Friend WithEvents btnCeaserSet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnASCIISet As Button
    Friend WithEvents btnA1Z26Set As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnCeaserMin As Button
    Friend WithEvents btnCeaserPlus As Button
    Friend WithEvents txtCeaser As TextBox
    Friend WithEvents lblMode As Label
    Friend WithEvents txtEnc As TextBox
    Friend WithEvents Encrypt As Button
    Friend WithEvents Decrypt As Button
    Friend WithEvents setVal As Button
End Class
