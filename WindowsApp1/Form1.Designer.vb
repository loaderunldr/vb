<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vb_botz
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vb_botz))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Logotxt = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.Label()
        Me.LinkGithub = New System.Windows.Forms.LinkLabel()
        Me.cright = New System.Windows.Forms.Label()
        Me.LinkAbout = New System.Windows.Forms.LinkLabel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0, 0, 5, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Logotxt
        '
        Me.Logotxt.AutoSize = True
        Me.Logotxt.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Logotxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Logotxt.Location = New System.Drawing.Point(108, 9)
        Me.Logotxt.Name = "Logotxt"
        Me.Logotxt.Size = New System.Drawing.Size(87, 24)
        Me.Logotxt.TabIndex = 1
        Me.Logotxt.Text = "VB_botz"
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Location = New System.Drawing.Point(112, 37)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(144, 56)
        Me.Description.TabIndex = 2
        Me.Description.Text = "It is a Visual-basic Windows" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Forms application with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bots, that I wish will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hel" &
    "p you."
        '
        'LinkGithub
        '
        Me.LinkGithub.AutoSize = True
        Me.LinkGithub.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkGithub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkGithub.LinkColor = System.Drawing.Color.Navy
        Me.LinkGithub.Location = New System.Drawing.Point(17, 111)
        Me.LinkGithub.Name = "LinkGithub"
        Me.LinkGithub.Size = New System.Drawing.Size(75, 14)
        Me.LinkGithub.TabIndex = 3
        Me.LinkGithub.TabStop = True
        Me.LinkGithub.Text = "See on Github"
        Me.LinkGithub.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'cright
        '
        Me.cright.AutoSize = True
        Me.cright.Location = New System.Drawing.Point(12, 378)
        Me.cright.Name = "cright"
        Me.cright.Size = New System.Drawing.Size(122, 14)
        Me.cright.TabIndex = 4
        Me.cright.Text = "Created by LDR with <3"
        '
        'LinkAbout
        '
        Me.LinkAbout.AutoSize = True
        Me.LinkAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkAbout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkAbout.LinkColor = System.Drawing.Color.Navy
        Me.LinkAbout.Location = New System.Drawing.Point(236, 378)
        Me.LinkAbout.Name = "LinkAbout"
        Me.LinkAbout.Size = New System.Drawing.Size(36, 14)
        Me.LinkAbout.TabIndex = 5
        Me.LinkAbout.TabStop = True
        Me.LinkAbout.Text = "About"
        Me.LinkAbout.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button3.Location = New System.Drawing.Point(0, 173)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(284, 60)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "John Doe"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 239)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(284, 60)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Crypto"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'vb_botz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(284, 401)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.LinkAbout)
        Me.Controls.Add(Me.cright)
        Me.Controls.Add(Me.LinkGithub)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Logotxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "vb_botz"
        Me.Text = "Hello World!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Logotxt As Label
    Friend WithEvents Description As Label
    Friend WithEvents LinkGithub As LinkLabel
    Friend WithEvents cright As Label
    Friend WithEvents LinkAbout As LinkLabel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class
