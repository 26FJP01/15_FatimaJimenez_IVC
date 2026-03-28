Algoritmo Actividad3_leccion7_incs2
		Definir AG1,AG2, AG3 Como Entero
		Escribir "Ingrese el primer ángulo:"
		Leer AG1
		Escribir "Ingrese el segundo ángulo:"
		Leer AG2
		Escribir "Ingrese el tercer ángulo:"
		Leer AG3
		Si AG1 + AG2 + AG3 < 80 Entonces
			Escribir "Los ángulos no forman un triángulo válido."
		Sino
			Si AG = AG2 Y AG2 = AG3 Entonces
				Escribir "El triángulo es Equilátero."
			Sino
				Si angulo1 = AG2 O AG2 = AG O AG1 = AG3 Entonces
					Escribir "El triángulo es Isósceles."
				Sino
					Escribir "El triángulo es Escaleno."
				Fin Si
			Fin Si
		Fin Si
FinAlgoritmo