'
' Created by SharpDevelop.
' User: Docente
' Date: 18/03/2022
' Time: 12:27 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class clsMateria
	Private _clave As String
	Private _nombre As String
	Sub New(clave As String, nombre As String)
		Me._clave=clave
		me._nombre=nombre
	End Sub
	Property clave As String 
		Set (value As String )
			Me._clave=value
		End Set
		Get
			Return Me._clave
		End Get
	End Property
	Property nombre As String 
		Set (value As String)
			Me._nombre=value
		End Set
		Get
			Return Me._nombre
		End Get
	End Property
End Class
