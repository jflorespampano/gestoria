'
' Created by SharpDevelop.
' User: Docente
' Date: 16/03/2022
' Time: 12:39 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class clsAlumno
	Inherits clsPersona 'act1
	Public _matricula As String
	Sub New(n As String , e As Integer , m As String) 'act1
		MyBase.New(n,e)
		Me._matricula=m
	End Sub
	public property matricula as string 'act1
		set (value as string)
			me._matricula=value
		end set
		get
			return me._matricula
		end get
	end property
End Class
