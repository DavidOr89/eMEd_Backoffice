<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSalir)
        Me.GroupBox1.Controls.Add(Me.BtnIngresar)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.TxtContraseña)
        Me.GroupBox1.Controls.Add(Me.TxtUsuario)
        Me.GroupBox1.Controls.Add(Me.LblContraseña)
        Me.GroupBox1.Controls.Add(Me.LblUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(797, 276)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtContraseña
        '
        Me.TxtContraseña.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(508, 106)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.Size = New System.Drawing.Size(240, 38)
        Me.TxtContraseña.TabIndex = 3
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(508, 55)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(240, 38)
        Me.TxtUsuario.TabIndex = 2
        '
        'LblContraseña
        '
        Me.LblContraseña.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(351, 108)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(159, 37)
        Me.LblContraseña.TabIndex = 1
        Me.LblContraseña.Text = "Contraseña"
        '
        'LblUsuario
        '
        Me.LblUsuario.Font = New System.Drawing.Font("Cooper Black", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.Location = New System.Drawing.Point(351, 59)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(151, 37)
        Me.LblUsuario.TabIndex = 0
        Me.LblUsuario.Text = "Usuario"
        '
        'BtnSalir
        '
        Me.BtnSalir.Image = Global.eMEdBackOffice.My.Resources.Resources.salida
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(553, 185)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(148, 56)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Image = Global.eMEdBackOffice.My.Resources.Resources.if_f_check_256_282474__1_
        Me.BtnIngresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnIngresar.Location = New System.Drawing.Point(381, 184)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(148, 56)
        Me.BtnIngresar.TabIndex = 5
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.eMEdBackOffice.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(10, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(335, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents LblContraseña As Label
    Friend WithEvents LblUsuario As Label
End Class
