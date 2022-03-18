'
' Created by SharpDevelop.
' User: Docente
' Date: 18/03/2022
' Time: 12:26 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class clsAula
	Private _clave As String
	Private _tipo As String 
	Private _numComputadoras As Integer
	Sub New(cl As String , tipo As String , nc As Integer )
		Me._clave=cl
		Me._tipo=tipo
		Me._numComputadoras=nc
	End Sub
End Class
