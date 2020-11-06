<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb3 = New System.Windows.Forms.TextBox()
        Me.bil1 = New System.Windows.Forms.Label()
        Me.tb4 = New System.Windows.Forms.TextBox()
        Me.bil2 = New System.Windows.Forms.Label()
        Me.prs = New System.Windows.Forms.Button()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.bil3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Karyawan"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(158, 36)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(154, 20)
        Me.tb1.TabIndex = 1
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(158, 84)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(154, 20)
        Me.tb2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Jabatan"
        '
        'tb3
        '
        Me.tb3.Location = New System.Drawing.Point(158, 133)
        Me.tb3.Name = "tb3"
        Me.tb3.Size = New System.Drawing.Size(154, 20)
        Me.tb3.TabIndex = 5
        '
        'bil1
        '
        Me.bil1.AutoSize = True
        Me.bil1.Location = New System.Drawing.Point(40, 133)
        Me.bil1.Name = "bil1"
        Me.bil1.Size = New System.Drawing.Size(59, 13)
        Me.bil1.TabIndex = 4
        Me.bil1.Text = "Gaji Pokok"
        '
        'tb4
        '
        Me.tb4.Location = New System.Drawing.Point(158, 175)
        Me.tb4.Name = "tb4"
        Me.tb4.Size = New System.Drawing.Size(154, 20)
        Me.tb4.TabIndex = 7
        '
        'bil2
        '
        Me.bil2.AutoSize = True
        Me.bil2.Location = New System.Drawing.Point(41, 175)
        Me.bil2.Name = "bil2"
        Me.bil2.Size = New System.Drawing.Size(58, 13)
        Me.bil2.TabIndex = 6
        Me.bil2.Text = "Tunjangan"
        '
        'prs
        '
        Me.prs.Location = New System.Drawing.Point(44, 217)
        Me.prs.Name = "prs"
        Me.prs.Size = New System.Drawing.Size(75, 23)
        Me.prs.TabIndex = 8
        Me.prs.Text = "Proses"
        Me.prs.UseVisualStyleBackColor = True
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(158, 256)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(154, 20)
        Me.txtjumlah.TabIndex = 9
        '
        'bil3
        '
        Me.bil3.AutoSize = True
        Me.bil3.Location = New System.Drawing.Point(38, 259)
        Me.bil3.Name = "bil3"
        Me.bil3.Size = New System.Drawing.Size(61, 13)
        Me.bil3.TabIndex = 10
        Me.bil3.Text = "Jumlah Gaji"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 450)
        Me.Controls.Add(Me.bil3)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.prs)
        Me.Controls.Add(Me.tb4)
        Me.Controls.Add(Me.bil2)
        Me.Controls.Add(Me.tb3)
        Me.Controls.Add(Me.bil1)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tb3 As TextBox
    Friend WithEvents bil1 As Label
    Friend WithEvents tb4 As TextBox
    Friend WithEvents bil2 As Label
    Friend WithEvents prs As Button
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents bil3 As Label
End Class
