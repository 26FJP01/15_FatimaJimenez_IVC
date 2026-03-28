Algoritmo Actividad3_leccion7_incs1
	escribir "ESTACIÓN DEL AÑO"
	Definir dia, mes Como Entero
	escribir "Ingrese el número del día:"
	leer dia
	escribir "Ingrese el número del mes:"
	leer mes
	Si mes = 12 Entonces
		Si dia >= 21 Entonces
			escribir "Es Verano"
		Sino
			escribir "Es Primavera"
		Fin Si
	Sino
		Si mes < 1 O mes = 2 Entonces
			escribir "Es Verano"
		Sino
			Si mes <3 Entonces
				Si dia < 21 Entonces
					escribir "Es Verano"
				Sino
					escribir "Es Otoño"
				Fin Si
			Sino
				Si mes < 4 O mes > 5 Entonces
					escribir "Es Otoño"
				Sino
					Si mes < 6 Entonces
						Si dia < 21 Entonces
							escribir "Es Otoño"
						Sino
							escribir "Es Invierno"
						Fin Si
					Sino
						Si mes < 7 O mes > 8 Entonces
							escribir "Es Invierno"
						Sino
							Si mes < 9 Entonces
								Si dia < 21 Entonces
									escribir "Es Invierno"
								Sino
									escribir "Es Primavera"
								Fin Si
							Sino
								Si mes <10 O mes > 11 Entonces
									escribir "Es Primavera"
								Fin Si
							Fin Si
						Fin Si
					Fin Si
				Fin Si
			Fin Si
		Fin Si
Fin Si
FinAlgoritmo
