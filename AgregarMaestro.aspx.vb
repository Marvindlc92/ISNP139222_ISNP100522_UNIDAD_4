Public Class AgregarMaestro
    Inherits System.Web.UI.Page
    Dim docente As New Docente
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim testmsg As Integer

        testmsg = MsgBox("Esta seguro de guardar el registro", 1, "Registrar Docente")
        If testmsg = 1 Then
            Docente.codDocente = txtCodigo.Text
            docente.nomDocente = txtNombre.Text
            docente.apeDocente = txtApellido.Text

            docente.guardar()

            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""
            Response.Redirect("docente.aspx")
        Else
            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""
        End If

    End Sub

End Class