'
' Created by SharpDevelop.
' User: Docente
' Date: 16/03/2022
' Time: 10:38 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		Dim isc As New clsCarrera("isc","ingenieria en sistemas")
		Dim materia As New clsMateria("mate1","matematicas 1")
		isc.agregarMateria(materia)
		materia = New clsMateria("fisica1","fisica basica")
		isc.agregarMateria(materia)
		materia = New clsMateria("mate2","algebra 1")
		isc.agregarMateria(materia)
		isc.muestraMaterias()
		Console.WriteLine("hay {0} materias en la carrera {1}",isc.cuantasMateriasHay(), isc.nombre)
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
