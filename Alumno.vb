Public Class Alumno
    Dim c As New Conexion

    Private codigoAlumno As Integer
    Private nombreAlumno As String
    Private apellidoAlumno As String
    Private pagina As Page

    Public Property codAlumno() As Integer
        Get
            Return codigoAlumno
        End Get
        Set(value As Integer)
            codigoAlumno = value
        End Set
    End Property

    Public Property nomAlumno() As String
        Get
            Return nombreAlumno
        End Get
        Set(value As String)
            nombreAlumno = value
        End Set
    End Property

    Public Property apeAlumno() As String
        Get
            Return apellidoAlumno
        End Get
        Set(value As String)
            apellidoAlumno = value
        End Set
    End Property

    Public Function listarRegistros() As DataTable
        c.strconexion.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT codAlumno, nomAlumno, apeAlumno FROM alumno"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function

    Public Sub guardar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "INSERT INTO alumno VALUES('" & codAlumno & "','" & nomAlumno & "','" & apeAlumno & "')"
                c.result = c.cmd.ExecuteNonQuery
            End With
            If c.result = 0 Then
                MsgBox("No se ha podido guardar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro guardado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(" No se ha podido guardar el Registro", MsgBoxStyle.Critical)
        End Try
        c.strcon.Close()
    End Sub

    Public Function mostrarRegistro() As DataTable
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT codAlumno,nomAlumno,apeAlumno FROM alumno WHERE codAlumno = '" & codAlumno & "'"
            'c.result = c.cmd.ExecuteNonQuery
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function

    Public Sub editar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "UPDATE alumno SET nomAlumno ='" & nomAlumno & "', apeAlumno = '" & apeAlumno & "' WHERE codAlumno = '" & codAlumno & "' "
                c.result = c.cmd.ExecuteNonQuery
            End With

            If c.result = 0 Then
                MsgBox("No se ha podido actualizar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        c.strcon.Close()
    End Sub

End Class
