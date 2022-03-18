'
' Created by SharpDevelop.
' User: Docente
' Date: 18/03/2022
' Time: 12:25 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class clsPersona
	private _nombre as string
	Private _edad As Integer
	Sub New(n As String , e As Integer) 'act1
		Me._nombre=n
		Me._edad=e
	End Sub
	public property edad as integer
		set (value as integer)
			me._edad=value
		end set
		get
			return me._edad
		end get
	end property
	public property nombre as string
		set (value as string)
			me._nombre=value
		end set
		get
			return me._nombre
		end get
	end property
End Class
