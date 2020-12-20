<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuListas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDoble = New System.Windows.Forms.Button()
        Me.btnSCircular = New System.Windows.Forms.Button()
        Me.btnDCircular = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(336, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Snow
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(325, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Snow
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.Firebrick
        Me.Button1.Location = New System.Drawing.Point(133, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 66)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Lista Simple"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnDoble
        '
        Me.btnDoble.BackColor = System.Drawing.Color.Snow
        Me.btnDoble.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDoble.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDoble.Location = New System.Drawing.Point(133, 286)
        Me.btnDoble.Name = "btnDoble"
        Me.btnDoble.Size = New System.Drawing.Size(154, 66)
        Me.btnDoble.TabIndex = 3
        Me.btnDoble.Text = "Lista Doble"
        Me.btnDoble.UseVisualStyleBackColor = False
        '
        'btnSCircular
        '
        Me.btnSCircular.BackColor = System.Drawing.Color.Snow
        Me.btnSCircular.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSCircular.ForeColor = System.Drawing.Color.Firebrick
        Me.btnSCircular.Location = New System.Drawing.Point(369, 181)
        Me.btnSCircular.Name = "btnSCircular"
        Me.btnSCircular.Size = New System.Drawing.Size(154, 66)
        Me.btnSCircular.TabIndex = 4
        Me.btnSCircular.Text = "Lista Simple Circular"
        Me.btnSCircular.UseVisualStyleBackColor = False
        '
        'btnDCircular
        '
        Me.btnDCircular.BackColor = System.Drawing.Color.Snow
        Me.btnDCircular.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnDCircular.ForeColor = System.Drawing.Color.Firebrick
        Me.btnDCircular.Location = New System.Drawing.Point(369, 286)
        Me.btnDCircular.Name = "btnDCircular"
        Me.btnDCircular.Size = New System.Drawing.Size(154, 66)
        Me.btnDCircular.TabIndex = 5
        Me.btnDCircular.Text = "Lista Doble Circular"
        Me.btnDCircular.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Snow
        Me.btnMenu.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.Firebrick
        Me.btnMenu.Location = New System.Drawing.Point(534, 392)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(107, 53)
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'MenuListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.MenuListas
        Me.ClientSize = New System.Drawing.Size(730, 464)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnDCircular)
        Me.Controls.Add(Me.btnSCircular)
        Me.Controls.Add(Me.btnDoble)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MenuListas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnDoble As Button
    Friend WithEvents btnSCircular As Button
    Friend WithEvents btnDCircular As Button
    Friend WithEvents btnMenu As Button
End Class
