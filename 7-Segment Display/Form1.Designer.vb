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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.seg_a = New System.Windows.Forms.Button()
        Me.seg_f = New System.Windows.Forms.Button()
        Me.seg_b = New System.Windows.Forms.Button()
        Me.seg_g = New System.Windows.Forms.Button()
        Me.seg_d = New System.Windows.Forms.Button()
        Me.seg_c = New System.Windows.Forms.Button()
        Me.seg_e = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'seg_a
        '
        Me.seg_a.BackColor = System.Drawing.Color.DimGray
        Me.seg_a.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.seg_a.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seg_a.Location = New System.Drawing.Point(92, 42)
        Me.seg_a.Name = "seg_a"
        Me.seg_a.Size = New System.Drawing.Size(110, 15)
        Me.seg_a.TabIndex = 0
        Me.seg_a.UseVisualStyleBackColor = False
        '
        'seg_f
        '
        Me.seg_f.BackColor = System.Drawing.Color.DimGray
        Me.seg_f.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.seg_f.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seg_f.Location = New System.Drawing.Point(70, 57)
        Me.seg_f.Name = "seg_f"
        Me.seg_f.Size = New System.Drawing.Size(15, 110)
        Me.seg_f.TabIndex = 1
        Me.seg_f.UseVisualStyleBackColor = False
        '
        'seg_b
        '
        Me.seg_b.BackColor = System.Drawing.Color.DimGray
        Me.seg_b.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.seg_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seg_b.Location = New System.Drawing.Point(210, 57)
        Me.seg_b.Name = "seg_b"
        Me.seg_b.Size = New System.Drawing.Size(15, 110)
        Me.seg_b.TabIndex = 2
        Me.seg_b.UseVisualStyleBackColor = False
        '
        'seg_g
        '
        Me.seg_g.BackColor = System.Drawing.Color.DimGray
        Me.seg_g.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.seg_g.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seg_g.Location = New System.Drawing.Point(92, 174)
        Me.seg_g.Name = "seg_g"
        Me.seg_g.Size = New System.Drawing.Size(110, 15)
        Me.seg_g.TabIndex = 3
        Me.seg_g.UseVisualStyleBackColor = False
        '
        'seg_d
        '
        Me.seg_d.BackColor = System.Drawing.Color.DimGray
        Me.seg_d.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.seg_d.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seg_d.Location = New System.Drawing.Point(92, 304)
        Me.seg_d.Name = "seg_d"
        Me.seg_d.Size = New System.Drawing.Size(110, 15)
        Me.seg_d.TabIndex = 6
        Me.seg_d.UseVisualStyleBackColor = False
        '
        'seg_c
        '
        Me.seg_c.BackColor = System.Drawing.Color.DimGray
        Me.seg_c.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.seg_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seg_c.Location = New System.Drawing.Point(210, 192)
        Me.seg_c.Name = "seg_c"
        Me.seg_c.Size = New System.Drawing.Size(15, 110)
        Me.seg_c.TabIndex = 5
        Me.seg_c.UseVisualStyleBackColor = False
        '
        'seg_e
        '
        Me.seg_e.BackColor = System.Drawing.Color.DimGray
        Me.seg_e.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.seg_e.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.seg_e.Location = New System.Drawing.Point(70, 192)
        Me.seg_e.Name = "seg_e"
        Me.seg_e.Size = New System.Drawing.Size(15, 110)
        Me.seg_e.TabIndex = 4
        Me.seg_e.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "developed by"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(107, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Harold Abejaron"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(62, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Polytechnic University of the Philippines"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 421)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "https://github.com/169cmharu"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.seg_d)
        Me.Controls.Add(Me.seg_c)
        Me.Controls.Add(Me.seg_e)
        Me.Controls.Add(Me.seg_g)
        Me.Controls.Add(Me.seg_b)
        Me.Controls.Add(Me.seg_f)
        Me.Controls.Add(Me.seg_a)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "7-Segment Display"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents seg_a As Button
    Friend WithEvents seg_f As Button
    Friend WithEvents seg_b As Button
    Friend WithEvents seg_g As Button
    Friend WithEvents seg_d As Button
    Friend WithEvents seg_c As Button
    Friend WithEvents seg_e As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
