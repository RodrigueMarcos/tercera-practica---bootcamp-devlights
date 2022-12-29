char[,] array = new char[10, 10];

//40 lugares o menos
for (int i = 0; i < 10; i++)
{
	for (int j = 0; j < 10; j++)
	{
		array[i, j] = '*';
	}
}
int x;
int y;
int bucle = 0;
while(bucle < 40)
{
	x = new Random().Next(0, 10);
	y = new Random().Next(0, 10);
	array[x, y] = 'X';
	bucle++;
}

Console.WriteLine("Debes ingresar la celda de la matriz en dondes creas que esta marcada con una X. Que comience el juego ");
string answer, answer2;
int fila, columna, intentos = 3;

while (intentos > 0)
{
    do
    {
        Console.WriteLine("Ingrese el indice de la fila");
        answer = Console.ReadLine();
        if (!(Char.IsNumber(answer, 0)))
        {
            Console.WriteLine("El dato ingresado no es aceptado. Debes ingresar un numero del 0 al 9.");
            fila = 403;
        }
        else
        {
            fila = Convert.ToInt32(answer);
        }
        if (fila > 9)
        {
            Console.WriteLine("Solo se acepta valores numericos del 0 al 9!.");
        }

    } while (fila > 9);

    do
    {
        Console.WriteLine("Ingrese el indice de la columna");
        answer2 = Console.ReadLine();
        if (!(Char.IsNumber(answer2, 0)))
        {
            Console.WriteLine("El dato ingresado no es aceptado. Debes ingresar un numero del 0 al 9.");
            columna = 403;
        }
        else
        {
            columna = Convert.ToInt32(answer2);
        }
        if (columna > 9)
        {
            Console.WriteLine("Solo se acepta valores numericos del 0 al 9!.");
        }
    } while (columna > 9);

    if (array[fila, columna] == 'X')
    {
        Console.WriteLine("Felicidades acertaste!!!");
    }
    else
    {
        intentos--;
        Console.WriteLine("Segui intentando. Te queda " + intentos + " intentos.");
    }

}

Console.WriteLine("La tabla era: ");
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(" " + array[i, j]);
    }
    Console.WriteLine(" ");
}
