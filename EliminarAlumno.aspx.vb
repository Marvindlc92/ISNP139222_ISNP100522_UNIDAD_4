Public Class EliminarAlumno
    Inherits System.Web.UI.Page
    Dim alumno As New Alumno
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        alumno.codAlumno = Request.QueryString("Alumno")

        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea eliminar registro", 1, "Eliminar Alumno")
        If testmsg = 1 Then
            alumno.eliminar()

            Response.Redirect("Alumno.aspx")
        Else
            Response.Redirect("Alumno.aspx")
        End If
    End Sub


End Class