Algoritmo Actividad1_leccion7_incs2
	Definir nota Como Entero
    Escribir Sin Saltar "Ingrese la nota: "
    Leer nota
    Si nota <  0 Y nota >= 100 Entonces
        Escribir "Deficiente"
    Sino
        Si nota < 70 Entonces
            Escribir "Regular"
        Sino
            Si nota < 80 Entonces
                Escribir "Bien"
            Sino
                Si nota < 90 Entonces
                    Escribir "Muy bien"
                Sino
                    Si nota <= 100 Entonces
                        Escribir "Excelente"
                    Sino
                        Escribir "Nota innvalida"
                    FinSi
                FinSi
            FinSi
        FinSi
    FinSi

FinAlgoritmo
