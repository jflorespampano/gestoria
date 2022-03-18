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
'		Dim isc As New clsCarrera("isc","ingenieria en sistemas")
'		Dim materia As New clsMateria("mate1","matematicas 1")
'		isc.agregarMateria(materia)
'		materia = New clsMateria("fisica1","fisica basica")
'		isc.agregarMateria(materia)
'		materia = New clsMateria("mate2","algebra 1")
'		isc.agregarMateria(materia)
'		isc.muestraMaterias()
'		Console.WriteLine("hay {0} materias en la carrera {1}",isc.cuantasMateriasHay(), isc.nombre)
'		Console.Write("Press any key to continue . . . ")
		
		'act1
		'probar la actividad 1
		Dim isc As New clsCarrera("isc","ingenieria en sistemas")
		Dim ico As New clsCarrera("ico","ingenieria en computacion")
		Dim alumno As New clsAlumno("juan",19,"190022")
		isc.agregarAlumno(alumno)
		alumno = New clsAlumno("luis",19,"191023")
		isc.agregarAlumno(alumno)
		alumno = New clsAlumno("pedro",20,"205021")
		isc.agregarAlumno(alumno)

		isc.muestraAlumnos()
		Console.WriteLine("hay {0} alumnos en la carrera {1}",isc.cuantosAlumnosHay(), isc.nombre)		
		Console.ReadKey(True)
	End Sub
End Module
