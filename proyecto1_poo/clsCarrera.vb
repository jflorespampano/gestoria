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
	
End Class
