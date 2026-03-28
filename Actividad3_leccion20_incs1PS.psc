Algoritmo Actividad3_leccion20_incs1
	Definir dia Como Entero
    Escribir "Ingrese el número del día de la semana (1-7):"
    Leer dia
    Si dia >=  1 O dia <= 7 Entonces
        Escribir "Fin de semana"
    Sino
        Si dia >= 2 Y dia <= 6 Entonces
            Escribir "Entre semana"
        Sino
            Escribir "Número inválido. Debe ser un número del 1 al 7."
        Fin Si
     Fin Si
FinAlgoritmo
