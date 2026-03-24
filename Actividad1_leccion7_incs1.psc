//un algoritmo que determine si un alumno aprueba o
//reprueba una materia,basada en 
//el promedio de cinco calificaciones

Algoritmo Actividad1_leccion7_incs1
	escribir"==PROMEDIO DE CALIFICACIONES=="
	//variables
	definir materia Como Caracter
	definir n1,n2,n3,n4,n5 Como Entero
	definir promedio Como Real
	escribir"escriba la materia:"
	leer materia
	//solicitar el promedio
	escribir "dame 5 notas:"
	leer n1
	leer n2
	leer n3
	leer n4
	leer n5
	//promedio
	promediar=(n1+n2+n3+n4+n5)/5
	//evaluar si aprobo o reprobo
	Si Promedio>=70 Entonces
		escribir"El estudiante aprobo con",promedio
	SiNo
		escribir"El estudiante Reprobo con",promedio
	Fin Si
	
	
FinAlgoritmo
