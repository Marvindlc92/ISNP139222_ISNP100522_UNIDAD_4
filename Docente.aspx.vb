Public Class Docente1
    Inherits System.Web.UI.Page
    Dim docente As New Docente
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim dt As DataTable = docente.listarRegistros()
            Dim html As New StringBuilder()

            html.Append("<table class='table table-striped'>")

            html.Append("<thead>")
            html.Append("<tr>")
            html.Append("<th>Codigo</th>")
            html.Append("<th>Nomre</th>")
            html.Append("<th>Apellido</th>")
            html.Append("</tr>")
            html.Append("</thead>")
            html.Append("</tbody>")

            For i = 0 To dt.Rows.Count - 1
                Dim codigo As Integer = dt.Rows(i).Item("CodDocente")

                html.Append("<tr>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("codDocente"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("nomDocente"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("apeDocente"))
                html.Append("</td>")


                html.Append("<td>")
                html.Append("<a href = 'EditarDocente.aspx?Docente=" & codigo & "' dt.Rows(i).Item('codigo') >Editar</a>")
                html.Append("</td>")
                html.Append("<td>")
                html.Append("<a href = 'EliminarDocente.aspx?Docente=" & codigo & "'>Eliminar</a>")
                html.Append("</td>")



                html.Append("</tr>")
            Next

            html.Append("</tbody>")
            html.Append("</table>")

            docentes.Controls.Add(New Literal() With {
            .Text = html.ToString()
            })
        End If


    End Sub


End Class