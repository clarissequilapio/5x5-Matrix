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
        Me.components = New System.ComponentModel.Container()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.nameInfo = New System.Windows.Forms.TextBox()
        Me.ageInfo = New System.Windows.Forms.TextBox()
        Me.addressInfo = New System.Windows.Forms.TextBox()
        Me.txtbtn = New System.Windows.Forms.Button()
        Me.xmlbtn = New System.Windows.Forms.Button()
        Me.jsonbtn = New System.Windows.Forms.Button()
        Me.allInfo = New System.Windows.Forms.TextBox()
        Me.displayBtn = New System.Windows.Forms.Button()
        Me.clrDataBtn = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Bebas Neue", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.nameLabel.Location = New System.Drawing.Point(51, 37)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(68, 32)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "NAME:"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Font = New System.Drawing.Font("Bebas Neue", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.ageLabel.Location = New System.Drawing.Point(51, 93)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(52, 32)
        Me.ageLabel.TabIndex = 1
        Me.ageLabel.Text = "AGE:"
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Bebas Neue", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.addressLabel.Location = New System.Drawing.Point(51, 152)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(94, 32)
        Me.addressLabel.TabIndex = 2
        Me.addressLabel.Text = "ADDRESS:"
        '
        'nameInfo
        '
        Me.nameInfo.Font = New System.Drawing.Font("Louis George Café", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameInfo.Location = New System.Drawing.Point(167, 37)
        Me.nameInfo.Name = "nameInfo"
        Me.nameInfo.Size = New System.Drawing.Size(479, 33)
        Me.nameInfo.TabIndex = 3
        '
        'ageInfo
        '
        Me.ageInfo.Font = New System.Drawing.Font("Louis George Café", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ageInfo.Location = New System.Drawing.Point(167, 94)
        Me.ageInfo.MaxLength = 3
        Me.ageInfo.Name = "ageInfo"
        Me.ageInfo.Size = New System.Drawing.Size(479, 33)
        Me.ageInfo.TabIndex = 4
        '
        'addressInfo
        '
        Me.addressInfo.Font = New System.Drawing.Font("Louis George Café", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressInfo.Location = New System.Drawing.Point(167, 152)
        Me.addressInfo.Name = "addressInfo"
        Me.addressInfo.Size = New System.Drawing.Size(479, 33)
        Me.addressInfo.TabIndex = 5
        '
        'txtbtn
        '
        Me.txtbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.txtbtn.FlatAppearance.BorderSize = 0
        Me.txtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtbtn.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbtn.Location = New System.Drawing.Point(57, 448)
        Me.txtbtn.Name = "txtbtn"
        Me.txtbtn.Size = New System.Drawing.Size(102, 49)
        Me.txtbtn.TabIndex = 6
        Me.txtbtn.Text = "TXT"
        Me.txtbtn.UseVisualStyleBackColor = False
        '
        'xmlbtn
        '
        Me.xmlbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.xmlbtn.FlatAppearance.BorderSize = 0
        Me.xmlbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.xmlbtn.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xmlbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xmlbtn.Location = New System.Drawing.Point(308, 448)
        Me.xmlbtn.Name = "xmlbtn"
        Me.xmlbtn.Size = New System.Drawing.Size(102, 49)
        Me.xmlbtn.TabIndex = 7
        Me.xmlbtn.Text = "XML"
        Me.xmlbtn.UseVisualStyleBackColor = False
        '
        'jsonbtn
        '
        Me.jsonbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.jsonbtn.FlatAppearance.BorderSize = 0
        Me.jsonbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jsonbtn.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jsonbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.jsonbtn.Location = New System.Drawing.Point(544, 448)
        Me.jsonbtn.Name = "jsonbtn"
        Me.jsonbtn.Size = New System.Drawing.Size(102, 49)
        Me.jsonbtn.TabIndex = 8
        Me.jsonbtn.Text = "JSON"
        Me.jsonbtn.UseVisualStyleBackColor = False
        '
        'allInfo
        '
        Me.allInfo.Font = New System.Drawing.Font("Louis George Café", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allInfo.Location = New System.Drawing.Point(57, 250)
        Me.allInfo.Multiline = True
        Me.allInfo.Name = "allInfo"
        Me.allInfo.ReadOnly = True
        Me.allInfo.Size = New System.Drawing.Size(589, 181)
        Me.allInfo.TabIndex = 9
        Me.allInfo.Visible = False
        '
        'displayBtn
        '
        Me.displayBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(134, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.displayBtn.FlatAppearance.BorderSize = 0
        Me.displayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.displayBtn.Font = New System.Drawing.Font("Bebas Neue", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayBtn.Location = New System.Drawing.Point(236, 215)
        Me.displayBtn.Name = "displayBtn"
        Me.displayBtn.Size = New System.Drawing.Size(263, 29)
        Me.displayBtn.TabIndex = 10
        Me.displayBtn.Text = "Click Here to Display Text"
        Me.displayBtn.UseVisualStyleBackColor = False
        '
        'clrDataBtn
        '
        Me.clrDataBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.clrDataBtn.FlatAppearance.BorderSize = 0
        Me.clrDataBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clrDataBtn.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clrDataBtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.clrDataBtn.Location = New System.Drawing.Point(236, 538)
        Me.clrDataBtn.Name = "clrDataBtn"
        Me.clrDataBtn.Size = New System.Drawing.Size(263, 49)
        Me.clrDataBtn.TabIndex = 11
        Me.clrDataBtn.Text = "Clear Data"
        Me.clrDataBtn.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(698, 620)
        Me.Controls.Add(Me.clrDataBtn)
        Me.Controls.Add(Me.displayBtn)
        Me.Controls.Add(Me.allInfo)
        Me.Controls.Add(Me.jsonbtn)
        Me.Controls.Add(Me.xmlbtn)
        Me.Controls.Add(Me.txtbtn)
        Me.Controls.Add(Me.addressInfo)
        Me.Controls.Add(Me.ageInfo)
        Me.Controls.Add(Me.nameInfo)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.ageLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Information"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents nameInfo As TextBox
    Friend WithEvents ageInfo As TextBox
    Friend WithEvents addressInfo As TextBox
    Friend WithEvents txtbtn As Button
    Friend WithEvents xmlbtn As Button
    Friend WithEvents jsonbtn As Button
    Friend WithEvents allInfo As TextBox
    Friend WithEvents displayBtn As Button
    Friend WithEvents clrDataBtn As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
