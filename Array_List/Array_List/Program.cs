// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

Console.WriteLine("----Ejercicio 1----");
decimal[] notas = new decimal[] { 10, 6, 3, 8, (decimal)5.5, 7, 10, 7, 5, 9 };
decimal promedio = 0;
Console.WriteLine("Notas del alumno: ");
foreach (decimal i in notas)
{
    promedio += i;
    Console.WriteLine(i);
}
Console.WriteLine("El promedio del alumno es: " + Convert.ToString(promedio / notas.Count()));

Console.WriteLine("----Ejercicio 2----");
int[] edades = new int[] { 10, 17, 50, 35, 25, 65, 44, 6, 15, 11, 18, 38, 20, 74, 29, 55, 43, 78, 31, 14 };
int mayor = 0, menor = 0;
foreach (int i in edades)
{
    if (i >= 18)
    {
        mayor++;
    }
    else
    {
        menor++;
    }
}
Console.WriteLine("Las cantidad de mayores de edad son :" + Convert.ToString(mayor));
Console.WriteLine("Las cantidad de menores de edad son :" + Convert.ToString(menor));

Console.WriteLine("----Ejercicio 3----");
string[] nombres = new string[] { "Marcos", "Juan", "Pedro", "Leandro", "Cristobal", "Ian", "Gonzalo" };
int indexMayor = 0;
int indexMenor = 0;
int cantidadLetrasMayor = nombres[0].Length;
int cantidadLetraMenor = nombres[0].Length;

for (int i = 1; i < nombres.Length; i++)
{
    if (nombres[i].Length > cantidadLetrasMayor)
    {
        indexMayor = i;
        cantidadLetrasMayor = nombres[i].Length;
    }
    if (nombres[i].Length < cantidadLetraMenor)
    {
        indexMenor = i;
        cantidadLetraMenor = nombres[i].Length;
    }
}
Console.WriteLine("El nombre con mas letras es: " + nombres[indexMayor]);
Console.WriteLine("El nombre con menos letras es: " + nombres[indexMenor]);

Console.WriteLine("----Ejercicio 5----");

char[,] matriz = new char[5,5];

for(int i = 0; i< 5; i++)
{
    Console.Write("Fila " + (i + 1)+" :");
    for(int j = 0; j<5; j++)
    {
        if ((i + j) % 2 == 0)
        {
            matriz[i, j] = 'P';
            Console.Write("P ");
        }
        else
        {
            matriz[i, j] = 'I';
            Console.Write("I ");
        }
        
    }
    Console.WriteLine("");
}

Console.WriteLine("----Ejercicio 6----");

int[,] temperatura = new int[5, 7];

for (int i = 0; i < 5; i++)
{
    
    for (int j = 0; j < 7; j++)
    {
        temperatura[i, j] = new Random().Next(7, 38);
    }
    
}
//dias del mes siguiente
temperatura[4, 3] = 0;
temperatura[4, 4] = 0;
temperatura[4, 5] = 0;
temperatura[4, 6] = 0;

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Semana " + (i + 1));
    for (int j = 0; j < 7; j++)
    {
        Console.WriteLine(temperatura[i, j]);
    }
}
    //calculamos los dias mas alto y bajo de la semana
    int altaTemperatura = 0, bajaTemperatura = 60, posicionAlta = 0, posicionBaja = 0, acumulador = 0;
    int altaTemperaturaDelMes = 0, diaAltaTemDelmes = 0;

for (int i = 0; i < 5; i++)
{
   

    for (int j = 0; j < 7; j++)
    {
        acumulador += temperatura[i, j];
        if (temperatura[i,j] > altaTemperatura)
        {
            altaTemperatura = temperatura[i,j];
            posicionAlta = j;
        }
        if (temperatura[i,j] != 0)
        {
            if (temperatura[i, j] < bajaTemperatura)
            {
                bajaTemperatura = temperatura[i, j];
                posicionBaja = j;
            }
        }
        if (temperatura[i,j]> altaTemperaturaDelMes)
        {
            altaTemperaturaDelMes = temperatura[i, j];
            diaAltaTemDelmes = j;
        }
        
    }
    Console.WriteLine("Semana: " + (i + 1));
    Console.WriteLine("La temperatura mas alta es de " + altaTemperatura+" grados del dia "+ diaDeLaSemana(posicionAlta));
    Console.WriteLine("La temperatura mas baja es de " + bajaTemperatura + " grados del dia " + diaDeLaSemana(posicionBaja));
    Console.WriteLine("Promedio de temperatura de la semana es "+ (acumulador / divisor(i)) + " grados");
    Console.WriteLine("El dia del Mes con temperatura mas alta es " + diaDeLaSemana(diaAltaTemDelmes) + " con " + altaTemperaturaDelMes + " grados.");
    
    altaTemperatura = 0;
    bajaTemperatura = 60;
    posicionAlta = 0;
    posicionBaja = 0;
    acumulador = 0;
}

Console.WriteLine("----Ejercicio 6----");
int[,] tabla = new int[10,10];

for(int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        if(i == 0)
        {
            tabla[i, j] = j;
        }
        if(j == 0)
        {
            tabla[i, j] = i;
        }
        if (i != 0 && j != 0)
        {
            tabla[i, j] = i*j;
        }
    }
}

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(" "+tabla[i, j]);
    }
    Console.WriteLine(" ");
}





string diaDeLaSemana(int p_dia)
{
    switch (p_dia)
    {
        case 0:
            return "Lunes";
            break;
        case 1:
            return "Martes";
            break;
        case 2:
            return "Miercoles";
            break;
        case 3:
            return "Jueves";
            break;
        case 4:
            return "Viernes";
            break;
        case 5:
            return "Sabado";
            break;
        case 6:
            return "Domingo";
            break;
        default:
            return "Error";

    }
}
    int divisor(int i)
    {
        if (i == 4)
        {
            return 3;
        }
        else
        {
            return 7;
        }
    }

