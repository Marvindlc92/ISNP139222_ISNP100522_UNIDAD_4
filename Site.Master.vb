Public Class SiteMaster
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If (Session("usuario") = "") Then
            Response.Redirect("login.aspx")
        Else
            lblUser.text = Session("usuario")
        End If
    End Sub
End Class