//crear una aplicacion que guarde los registros de notas de 25 estudiantes, debe presentar un menu con las siguientes opciones: 1. Agregar estudiante, 2. Mostrar estudiantes, 3. mostrar los primeros 3 lugares, 4.mostrar las notas en orden descendente, 5. salir

int[] notas = new int[25];

/*Agregar*/
Console.WriteLine("Ingrese las notas de los estudiantes:");
for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"Estudiante {i + 1}: ");
    notas[i] = int.Parse(Console.ReadLine());
}

/*Mostrar*/

/*3 primeros lugares*/

/*Mostrar notas en orden descendente*/
