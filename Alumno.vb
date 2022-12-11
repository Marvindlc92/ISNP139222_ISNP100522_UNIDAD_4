﻿Public Class Alumno
    Dim c As New conexion

    Private codigoAlumno As String
    Private nombreAlumno As String
    Private apellidoAlumno As String
    Private pagina As Page

    Public Property codAlumno() As String
        Get
            Return codigoAlumno
        End Get
        Set(value As String)
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
            .Connection = c.srtcon
            .CommandText = "SELECT codAlumno, nomAlumno, apeAlumno FROM alumno"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function


End Class
