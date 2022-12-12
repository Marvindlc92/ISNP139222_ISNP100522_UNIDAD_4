Public Class EliminarDocente
    Inherits System.Web.UI.Page
    Dim Docente As New Docente
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Docente.codDocente = Request.QueryString("Docente")

        Dim testmsg As Integer

        testmsg = MsgBox("Está seguro que desea eliminar registro", 1, "Eliminar Docente")
        If testmsg = 1 Then
            Docente.eliminar()

            Response.Redirect("Docente.aspx")
        Else
            Response.Redirect("Docente.aspx")
        End If
    End Sub

End Class