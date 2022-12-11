Public Class Login
    Inherits System.Web.UI.Page
    Dim usuario As New Usuario

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Usuario.user = txtUsuario.Text
        Usuario.pass = txtClave.Text

        Dim dt As DataTable = Usuario.login
        If (dt.Rows.Count > 0) Then
            Session("usuario") = txtUsuario.Text
            Response.Redirect("Default.aspx")
        Else
            MsgBox("Datos Erroneos")
        End If
    End Sub
End Class