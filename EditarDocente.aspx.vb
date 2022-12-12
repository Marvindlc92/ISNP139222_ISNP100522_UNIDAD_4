Public Class EditarDocente
    Inherits System.Web.UI.Page
    Dim Docente As New Docente
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Docente.codDocente = Request.QueryString("Docente")

        If Not Me.IsPostBack Then

            Dim dt As DataTable = Docente.mostrarRegistro()

            For i = 0 To dt.Rows.Count - 1
                txtCodigo.Text = dt.Rows(i).Item("codDocente")
                txtNombre.Text = dt.Rows(i).Item("nomDocente")
                txtApellido.Text = dt.Rows(i).Item("apeDocente")
            Next

        End If

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea Actualizar registro", 1, "Actualizar Docente")
        If testmsg = 1 Then

            Docente.codDocente = txtCodigo.Text
            Docente.nomDocente = txtNombre.Text
            Docente.apeDocente = txtApellido.Text

            Docente.editar()

            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""

            Response.Redirect("Docente.aspx")
        Else
            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""
        End If

    End Sub

End Class