
Public Class AgregarAlumno
    Inherits System.Web.UI.Page
    Dim alumno As New Alumno
    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim testmsg As Integer

        testmsg = MsgBox("Esta seguro de guardar el registro", 1, "Registrar Alumno")
        If testmsg = 1 Then
            alumno.codAlumno = txtCodigo.Text
            alumno.nomAlumno = txtNombre.Text
            alumno.apeAlumno = txtApellido.Text

            alumno.guardar()

            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""
            Response.Redirect("alumno.aspx")
        Else
            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtApellido.Text = ""
        End If

    End Sub
End Class