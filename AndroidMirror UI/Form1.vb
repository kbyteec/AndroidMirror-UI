Public Class Form1

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        cfgAutomatica()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_conectar.Click

        Dim parametros As String
        parametros = ""

        If cb_maximizado.Checked Then
            parametros = parametros + " --fullscreen"
        End If

        If cb_touces.Checked Then
            parametros = parametros + " --show-touches"
        End If

        If cb_encendido.Checked Then
            parametros = parametros + " --stay-awake"
        End If

        If rb_sd.Checked Then
            parametros = parametros + " --max-size 640"
        End If

        If rb_hd.Checked Then
            parametros = parametros + " --max-size 1280"
        End If

        If rb_fhd.Checked Then
            parametros = parametros + " --max-size 1920"
        End If

        If rb_uhd.Checked Then
            parametros = parametros + " --max-size 3840"
        End If


        If rb_24fps.Checked Then
            parametros = parametros + " --max-fps 24"
        End If

        If rb_30fps.Checked Then
            parametros = parametros + " --max-fps 30"
        End If

        If rb_60fps.Checked Then
            parametros = parametros + " --max-fps 60"
        End If

        If rb_120fps.Checked Then
            parametros = parametros + " --max-fps 120"
        End If

        Dim p As New Process()
        p.StartInfo.FileName = GetPath() + "\Mirror\scrcpy.exe"
        p.StartInfo.Arguments = parametros
        p.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Function cfgAutomatica()

        'Enable
        cb_maximizado.Enabled = False
        cb_touces.Enabled = False
        cb_encendido.Enabled = False

        rb_sd.Enabled = False
        rb_hd.Enabled = False
        rb_fhd.Enabled = False
        rb_uhd.Enabled = False

        rb_24fps.Enabled = False
        rb_30fps.Enabled = False
        rb_60fps.Enabled = False
        rb_120fps.Enabled = False

        'Checked
        cb_maximizado.Checked = False
        cb_touces.Checked = True
        cb_encendido.Checked = True

        rb_hd.Checked = True
        rb_30fps.Checked = True
    End Function

    Private Function cfgManual()
        cb_maximizado.Enabled = True
        cb_touces.Enabled = True
        cb_encendido.Enabled = True

        rb_sd.Enabled = True
        rb_hd.Enabled = True
        rb_fhd.Enabled = True
        rb_uhd.Enabled = True

        rb_24fps.Enabled = True
        rb_30fps.Enabled = True
        rb_60fps.Enabled = True
        rb_120fps.Enabled = True
    End Function

    Private Function GetPath() As String
        Dim ruta As String = System.Reflection.Assembly.GetExecutingAssembly.Location.ToString
        Return ruta.Remove(ruta.LastIndexOf("\"), ruta.Length - ruta.LastIndexOf("\"))
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        cfgAutomatica()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        cfgManual()
    End Sub
End Class