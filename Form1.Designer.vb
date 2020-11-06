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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chknasgor = New System.Windows.Forms.CheckBox()
        Me.chkobeng = New System.Windows.Forms.CheckBox()
        Me.chkmigor = New System.Windows.Forms.CheckBox()
        Me.chkagor = New System.Windows.Forms.CheckBox()
        Me.konfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pilih Makanan Yang Anda Ingin Order"
        '
        'chknasgor
        '
        Me.chknasgor.AutoSize = True
        Me.chknasgor.Location = New System.Drawing.Point(43, 78)
        Me.chknasgor.Name = "chknasgor"
        Me.chknasgor.Size = New System.Drawing.Size(85, 17)
        Me.chknasgor.TabIndex = 1
        Me.chknasgor.Text = "Nasi Goreng"
        Me.chknasgor.UseVisualStyleBackColor = True
        '
        'chkobeng
        '
        Me.chkobeng.AutoSize = True
        Me.chkobeng.Location = New System.Drawing.Point(43, 101)
        Me.chkobeng.Name = "chkobeng"
        Me.chkobeng.Size = New System.Drawing.Size(80, 17)
        Me.chkobeng.TabIndex = 2
        Me.chkobeng.Text = "Teh Obeng"
        Me.chkobeng.UseVisualStyleBackColor = True
        '
        'chkmigor
        '
        Me.chkmigor.AutoSize = True
        Me.chkmigor.Location = New System.Drawing.Point(43, 124)
        Me.chkmigor.Name = "chkmigor"
        Me.chkmigor.Size = New System.Drawing.Size(81, 17)
        Me.chkmigor.TabIndex = 3
        Me.chkmigor.Text = "Mie Goreng"
        Me.chkmigor.UseVisualStyleBackColor = True
        '
        'chkagor
        '
        Me.chkagor.AutoSize = True
        Me.chkagor.Location = New System.Drawing.Point(43, 147)
        Me.chkagor.Name = "chkagor"
        Me.chkagor.Size = New System.Drawing.Size(90, 17)
        Me.chkagor.TabIndex = 4
        Me.chkagor.Text = "Ayam Goreng"
        Me.chkagor.UseVisualStyleBackColor = True
        '
        'konfirm
        '
        Me.konfirm.Location = New System.Drawing.Point(43, 185)
        Me.konfirm.Name = "konfirm"
        Me.konfirm.Size = New System.Drawing.Size(75, 23)
        Me.konfirm.TabIndex = 5
        Me.konfirm.Text = "Konfirmasi"
        Me.konfirm.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 450)
        Me.Controls.Add(Me.konfirm)
        Me.Controls.Add(Me.chkagor)
        Me.Controls.Add(Me.chkmigor)
        Me.Controls.Add(Me.chkobeng)
        Me.Controls.Add(Me.chknasgor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chknasgor As CheckBox
    Friend WithEvents chkobeng As CheckBox
    Friend WithEvents chkmigor As CheckBox
    Friend WithEvents chkagor As CheckBox
    Friend WithEvents konfirm As Button
End Class
