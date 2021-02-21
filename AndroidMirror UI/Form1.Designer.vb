<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_conectar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_120fps = New System.Windows.Forms.RadioButton()
        Me.rb_60fps = New System.Windows.Forms.RadioButton()
        Me.rb_30fps = New System.Windows.Forms.RadioButton()
        Me.rb_24fps = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_uhd = New System.Windows.Forms.RadioButton()
        Me.rb_fhd = New System.Windows.Forms.RadioButton()
        Me.rb_hd = New System.Windows.Forms.RadioButton()
        Me.rb_sd = New System.Windows.Forms.RadioButton()
        Me.cb_encendido = New System.Windows.Forms.CheckBox()
        Me.cb_touces = New System.Windows.Forms.CheckBox()
        Me.cb_maximizado = New System.Windows.Forms.CheckBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_conectar
        '
        Me.btn_conectar.Location = New System.Drawing.Point(4, 286)
        Me.btn_conectar.Name = "btn_conectar"
        Me.btn_conectar.Size = New System.Drawing.Size(258, 34)
        Me.btn_conectar.TabIndex = 0
        Me.btn_conectar.Text = "&Conectar"
        Me.btn_conectar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(4, 326)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(258, 34)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cb_encendido)
        Me.GroupBox1.Controls.Add(Me.cb_touces)
        Me.GroupBox1.Controls.Add(Me.cb_maximizado)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(258, 274)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuración"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_120fps)
        Me.GroupBox3.Controls.Add(Me.rb_60fps)
        Me.GroupBox3.Controls.Add(Me.rb_30fps)
        Me.GroupBox3.Controls.Add(Me.rb_24fps)
        Me.GroupBox3.Location = New System.Drawing.Point(139, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(113, 123)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Fotogramas"
        '
        'rb_120fps
        '
        Me.rb_120fps.AutoSize = True
        Me.rb_120fps.Location = New System.Drawing.Point(11, 97)
        Me.rb_120fps.Name = "rb_120fps"
        Me.rb_120fps.Size = New System.Drawing.Size(62, 19)
        Me.rb_120fps.TabIndex = 12
        Me.rb_120fps.Text = "120 fps"
        Me.rb_120fps.UseVisualStyleBackColor = True
        '
        'rb_60fps
        '
        Me.rb_60fps.AutoSize = True
        Me.rb_60fps.Location = New System.Drawing.Point(11, 72)
        Me.rb_60fps.Name = "rb_60fps"
        Me.rb_60fps.Size = New System.Drawing.Size(56, 19)
        Me.rb_60fps.TabIndex = 11
        Me.rb_60fps.Text = "60 fps"
        Me.rb_60fps.UseVisualStyleBackColor = True
        '
        'rb_30fps
        '
        Me.rb_30fps.AutoSize = True
        Me.rb_30fps.Checked = True
        Me.rb_30fps.Location = New System.Drawing.Point(11, 47)
        Me.rb_30fps.Name = "rb_30fps"
        Me.rb_30fps.Size = New System.Drawing.Size(56, 19)
        Me.rb_30fps.TabIndex = 10
        Me.rb_30fps.TabStop = True
        Me.rb_30fps.Text = "30 fps"
        Me.rb_30fps.UseVisualStyleBackColor = True
        '
        'rb_24fps
        '
        Me.rb_24fps.AutoSize = True
        Me.rb_24fps.Location = New System.Drawing.Point(11, 22)
        Me.rb_24fps.Name = "rb_24fps"
        Me.rb_24fps.Size = New System.Drawing.Size(56, 19)
        Me.rb_24fps.TabIndex = 9
        Me.rb_24fps.Text = "24 fps"
        Me.rb_24fps.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_uhd)
        Me.GroupBox2.Controls.Add(Me.rb_fhd)
        Me.GroupBox2.Controls.Add(Me.rb_hd)
        Me.GroupBox2.Controls.Add(Me.rb_sd)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(115, 123)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resolución"
        '
        'rb_uhd
        '
        Me.rb_uhd.AutoSize = True
        Me.rb_uhd.Location = New System.Drawing.Point(6, 97)
        Me.rb_uhd.Name = "rb_uhd"
        Me.rb_uhd.Size = New System.Drawing.Size(70, 19)
        Me.rb_uhd.TabIndex = 7
        Me.rb_uhd.Text = "Ultra HD"
        Me.rb_uhd.UseVisualStyleBackColor = True
        '
        'rb_fhd
        '
        Me.rb_fhd.AutoSize = True
        Me.rb_fhd.Location = New System.Drawing.Point(6, 72)
        Me.rb_fhd.Name = "rb_fhd"
        Me.rb_fhd.Size = New System.Drawing.Size(64, 19)
        Me.rb_fhd.TabIndex = 6
        Me.rb_fhd.Text = "Full HD"
        Me.rb_fhd.UseVisualStyleBackColor = True
        '
        'rb_hd
        '
        Me.rb_hd.AutoSize = True
        Me.rb_hd.Checked = True
        Me.rb_hd.Location = New System.Drawing.Point(6, 47)
        Me.rb_hd.Name = "rb_hd"
        Me.rb_hd.Size = New System.Drawing.Size(42, 19)
        Me.rb_hd.TabIndex = 5
        Me.rb_hd.TabStop = True
        Me.rb_hd.Text = "HD"
        Me.rb_hd.UseVisualStyleBackColor = True
        '
        'rb_sd
        '
        Me.rb_sd.AutoSize = True
        Me.rb_sd.Location = New System.Drawing.Point(6, 22)
        Me.rb_sd.Name = "rb_sd"
        Me.rb_sd.Size = New System.Drawing.Size(39, 19)
        Me.rb_sd.TabIndex = 4
        Me.rb_sd.Text = "SD"
        Me.rb_sd.UseVisualStyleBackColor = True
        '
        'cb_encendido
        '
        Me.cb_encendido.AutoSize = True
        Me.cb_encendido.Checked = True
        Me.cb_encendido.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_encendido.Location = New System.Drawing.Point(19, 117)
        Me.cb_encendido.Name = "cb_encendido"
        Me.cb_encendido.Size = New System.Drawing.Size(136, 19)
        Me.cb_encendido.TabIndex = 13
        Me.cb_encendido.Text = "Mantener Encendido"
        Me.cb_encendido.UseVisualStyleBackColor = True
        '
        'cb_touces
        '
        Me.cb_touces.AutoSize = True
        Me.cb_touces.Checked = True
        Me.cb_touces.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_touces.Location = New System.Drawing.Point(19, 92)
        Me.cb_touces.Name = "cb_touces"
        Me.cb_touces.Size = New System.Drawing.Size(88, 19)
        Me.cb_touces.TabIndex = 12
        Me.cb_touces.Text = "Ver Touches"
        Me.cb_touces.UseVisualStyleBackColor = True
        '
        'cb_maximizado
        '
        Me.cb_maximizado.AutoSize = True
        Me.cb_maximizado.Location = New System.Drawing.Point(19, 67)
        Me.cb_maximizado.Name = "cb_maximizado"
        Me.cb_maximizado.Size = New System.Drawing.Size(91, 19)
        Me.cb_maximizado.TabIndex = 2
        Me.cb_maximizado.Text = "Maximizado"
        Me.cb_maximizado.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(145, 32)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(97, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Personalizada"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(19, 32)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(87, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Automática"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_conectar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " AndroidMirror UI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_conectar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents cb_maximizado As CheckBox
    Friend WithEvents rb_60fps As RadioButton
    Friend WithEvents rb_30fps As RadioButton
    Friend WithEvents rb_24fps As RadioButton
    Friend WithEvents rb_uhd As RadioButton
    Friend WithEvents rb_fhd As RadioButton
    Friend WithEvents rb_hd As RadioButton
    Friend WithEvents rb_sd As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cb_encendido As CheckBox
    Friend WithEvents cb_touces As CheckBox
    Friend WithEvents rb_120fps As RadioButton
End Class
