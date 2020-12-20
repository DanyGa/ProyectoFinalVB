<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Colas
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
        Me.lblCola = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.btnDesencolar = New System.Windows.Forms.Button()
        Me.btnEncolar = New System.Windows.Forms.Button()
        Me.btnBorrarC = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(300, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(266, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'lblCola
        '
        Me.lblCola.AutoSize = True
        Me.lblCola.Location = New System.Drawing.Point(337, 167)
        Me.lblCola.Name = "lblCola"
        Me.lblCola.Size = New System.Drawing.Size(51, 17)
        Me.lblCola.TabIndex = 2
        Me.lblCola.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'txtNodo
        '
        Me.txtNodo.Location = New System.Drawing.Point(374, 270)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(100, 22)
        Me.txtNodo.TabIndex = 4
        '
        'btnDesencolar
        '
        Me.btnDesencolar.Location = New System.Drawing.Point(75, 167)
        Me.btnDesencolar.Name = "btnDesencolar"
        Me.btnDesencolar.Size = New System.Drawing.Size(75, 23)
        Me.btnDesencolar.TabIndex = 5
        Me.btnDesencolar.Text = "Button1"
        Me.btnDesencolar.UseVisualStyleBackColor = True
        '
        'btnEncolar
        '
        Me.btnEncolar.Location = New System.Drawing.Point(109, 121)
        Me.btnEncolar.Name = "btnEncolar"
        Me.btnEncolar.Size = New System.Drawing.Size(75, 23)
        Me.btnEncolar.TabIndex = 6
        Me.btnEncolar.Text = "Button2"
        Me.btnEncolar.UseVisualStyleBackColor = True
        '
        'btnBorrarC
        '
        Me.btnBorrarC.Location = New System.Drawing.Point(83, 196)
        Me.btnBorrarC.Name = "btnBorrarC"
        Me.btnBorrarC.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrarC.TabIndex = 7
        Me.btnBorrarC.Text = "Button3"
        Me.btnBorrarC.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(505, 270)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 8
        Me.btnCargar.Text = "Button4"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(447, 121)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 9
        Me.btnConsultar.Text = "Button5"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(505, 199)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Button6"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(614, 313)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 11
        Me.btnMenu.Text = "Button7"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Colas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnBorrarC)
        Me.Controls.Add(Me.btnEncolar)
        Me.Controls.Add(Me.btnDesencolar)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblCola)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Colas"
        Me.Text = "Colas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCola As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNodo As TextBox
    Friend WithEvents btnDesencolar As Button
    Friend WithEvents btnEncolar As Button
    Friend WithEvents btnBorrarC As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnMenu As Button
End Class
