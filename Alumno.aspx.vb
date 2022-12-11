
Imports System.Data
Public Class Alumno1
    Inherits System.Web.UI.Page
    Dim alumno As New Alumno


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim dt As DataTable = alumno.listarRegistros()
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
                Dim codigo As Integer = dt.Rows(i).Item("CodAlumno")

                html.Append("<tr>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("codAlumno"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("nomAlumno"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("apeAlumno"))
                html.Append("</td>")


                html.Append("<td>")
                html.Append("<a href = 'EditarAlumno.aspx?Alumno=" & codigo & "' dt.Rows(i).Item('codigo') >Editar</a>")
                html.Append("</td>")
                html.Append("<td>")
                html.Append("<a href = 'EliminarAlumno.aspx?Alumno=" & codigo & "'>Eliminar</a>")
                html.Append("</td>")



                html.Append("</tr>")
            Next

            html.Append("</tbody>")
            html.Append("</table>")

            estudiantes.Controls.Add(New Literal() With {
            .Text = html.ToString()
            })
        End If


    End Sub

End Class