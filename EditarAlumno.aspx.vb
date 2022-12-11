Public Class EditarAlumno
    Inherits System.Web.UI.Page

    Dim alumno As New Alumno

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        alumno.codAlumno = Request.QueryString("Alumno")

        If Not Me.IsPostBack Then

            Dim dt As DataTable = alumno.mostrarRegistro()

            For i = 0 To dt.Rows.Count - 1
                txtCodigo.Text = dt.Rows(i).Item("codAlumno")
                txtNombre.text = dt.Rows(i).Item("nomAlumno")
                txtApellido.text = dt.Rows(i).Item("apeAlumno")
            Next

        End If

    End Sub

    Protected Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea Actualizar registro", 1, "Actualizar Alumno")
        If testmsg = 1 Then

            alumno.codAlumno = txtCodigo.Text
            alumno.nomAlumno = txtNombre.Text
            alumno.apeAlumno = txtApellido.Text

            alumno.editar()

            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""

            Response.Redirect("Alumno.aspx")
        Else
            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""
        End If

    End Sub
End Class