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
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.nameInfo = New System.Windows.Forms.TextBox()
        Me.ageInfo = New System.Windows.Forms.TextBox()
        Me.addressInfo = New System.Windows.Forms.TextBox()
        Me.txtbtn = New System.Windows.Forms.Button()
        Me.xmlbtn = New System.Windows.Forms.Button()
        Me.jsonbtn = New System.Windows.Forms.Button()
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
        Me.ageLabel.Location = New System.Drawing.Point(51, 127)
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
        Me.addressLabel.Location = New System.Drawing.Point(51, 213)
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
        Me.ageInfo.Location = New System.Drawing.Point(167, 128)
        Me.ageInfo.Name = "ageInfo"
        Me.ageInfo.Size = New System.Drawing.Size(479, 33)
        Me.ageInfo.TabIndex = 4
        '
        'addressInfo
        '
        Me.addressInfo.Font = New System.Drawing.Font("Louis George Café", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressInfo.Location = New System.Drawing.Point(167, 213)
        Me.addressInfo.Name = "addressInfo"
        Me.addressInfo.Size = New System.Drawing.Size(479, 33)
        Me.addressInfo.TabIndex = 5
        '
        'txtbtn
        '
        Me.txtbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.txtbtn.FlatAppearance.BorderSize = 0
        Me.txtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtbtn.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtbtn.Location = New System.Drawing.Point(57, 294)
        Me.txtbtn.Name = "txtbtn"
        Me.txtbtn.Size = New System.Drawing.Size(102, 49)
        Me.txtbtn.TabIndex = 6
        Me.txtbtn.Text = "TXT"
        Me.txtbtn.UseVisualStyleBackColor = False
        '
        'xmlbtn
        '
        Me.xmlbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.xmlbtn.FlatAppearance.BorderSize = 0
        Me.xmlbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.xmlbtn.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xmlbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.xmlbtn.Location = New System.Drawing.Point(304, 294)
        Me.xmlbtn.Name = "xmlbtn"
        Me.xmlbtn.Size = New System.Drawing.Size(102, 49)
        Me.xmlbtn.TabIndex = 7
        Me.xmlbtn.Text = "XML"
        Me.xmlbtn.UseVisualStyleBackColor = False
        '
        'jsonbtn
        '
        Me.jsonbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.jsonbtn.FlatAppearance.BorderSize = 0
        Me.jsonbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jsonbtn.Font = New System.Drawing.Font("Bebas Neue", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jsonbtn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.jsonbtn.Location = New System.Drawing.Point(544, 294)
        Me.jsonbtn.Name = "jsonbtn"
        Me.jsonbtn.Size = New System.Drawing.Size(102, 49)
        Me.jsonbtn.TabIndex = 8
        Me.jsonbtn.Text = "JSON"
        Me.jsonbtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(698, 376)
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
End Class
