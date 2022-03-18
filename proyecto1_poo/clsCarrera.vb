'
' Created by SharpDevelop.
' User: Docente
' Date: 18/03/2022
' Time: 12:33 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class clsCarrera
	Private _clave As String
	Private _nombre As String 
	Private listaMaterias As New List(Of clsMateria)
	Private listaAlumnos As New List(Of clsAlumno) 'act1
	Sub New(clave As String , nombre As String )
		Me._clave=clave
		Me._nombre=nombre
		Me.listaMaterias.Clear
	End Sub
	readonly Property clave As String 
		Get
			Return Me._clave
		End Get
	End Property
	readonly Property nombre As String
		Get
			Return Me._nombre
		End Get
	End Property
	Public Function cuantasMateriasHay() As Integer
		Return Me.listaMaterias.Count
	End Function
	Public Sub agregarMateria(m As clsMateria)
		Me.listaMaterias.Add(m)
	End Sub
	Public Sub muestraMaterias()
		For Each materia As clsMateria In Me.listaMaterias
			console.writeline("materia {0} con clave {1}",materia.nombre, materia.clave)
		next
	End Sub
	Public Function cuantosAlumnosHay() As Integer 'act1
		Return Me.listaAlumnos.Count
	End Function
	Public Sub agregarAlumno(a As clsAlumno) 'act1
		Me.listaAlumnos.Add(a)
	End Sub
	Public Sub muestraAlumnos() 'act1
		For Each alumno As clsAlumno In Me.listaAlumnos
			console.writeline("alumno {0} con matricula {1}",alumno.nombre, alumno.matricula)
		next
	End Sub
End Class
