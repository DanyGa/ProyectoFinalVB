<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pilas
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
        Me.lblPila = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnBorrarP = New System.Windows.Forms.Button()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(172, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'lblPila
        '
        Me.lblPila.AutoSize = True
        Me.lblPila.Location = New System.Drawing.Point(267, 131)
        Me.lblPila.Name = "lblPila"
        Me.lblPila.Size = New System.Drawing.Size(51, 17)
        Me.lblPila.TabIndex = 2
        Me.lblPila.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'txtNodo
        '
        Me.txtNodo.Location = New System.Drawing.Point(293, 233)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(100, 22)
        Me.txtNodo.TabIndex = 4
        '
        'btnPush
        '
        Me.btnPush.Location = New System.Drawing.Point(53, 109)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(75, 23)
        Me.btnPush.TabIndex = 5
        Me.btnPush.Text = "Button1"
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'btnPop
        '
        Me.btnPop.Location = New System.Drawing.Point(53, 151)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(75, 23)
        Me.btnPop.TabIndex = 6
        Me.btnPop.Text = "Button2"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'btnBorrarP
        '
        Me.btnBorrarP.Location = New System.Drawing.Point(72, 232)
        Me.btnBorrarP.Name = "btnBorrarP"
        Me.btnBorrarP.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrarP.TabIndex = 7
        Me.btnBorrarP.Text = "Button3"
        Me.btnBorrarP.UseVisualStyleBackColor = True
        '
        'btnContar
        '
        Me.btnContar.Location = New System.Drawing.Point(458, 125)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(75, 23)
        Me.btnContar.TabIndex = 8
        Me.btnContar.Text = "Button4"
        Me.btnContar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(458, 173)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Button5"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(458, 232)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(75, 23)
        Me.btnCargar.TabIndex = 10
        Me.btnCargar.Text = "Button6"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Location = New System.Drawing.Point(556, 331)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMenu.TabIndex = 11
        Me.btnMenu.Text = "Button7"
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'Pilas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnContar)
        Me.Controls.Add(Me.btnBorrarP)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPila)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pilas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pilas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPila As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNodo As TextBox
    Friend WithEvents btnPush As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents btnBorrarP As Button
    Friend WithEvents btnContar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnMenu As Button
End Class
