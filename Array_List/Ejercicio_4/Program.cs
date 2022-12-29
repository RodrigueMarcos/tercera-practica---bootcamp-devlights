Console.WriteLine("----Ejercicio 4----");
List<string> listaSuper = new List<string>();
listaSuper.Add("harina");
listaSuper.Add("banana");
listaSuper.Add("leche");
listaSuper.Add("pan dulce");
listaSuper.Add("dulce de leche");

List<string> listaSuperExcluida= new List<string>();
List<string> listaDeCompra = new List<string>();


string nombreProducto, seguir;
do
{
    Console.WriteLine("Ingrese el nombre del producto: ");
    nombreProducto = Console.ReadLine();
    if (!(listaSuper.Contains(nombreProducto)))
    {
        listaSuperExcluida.Add(nombreProducto);
        listaDeCompra.Add(nombreProducto);
        Console.WriteLine("El elemento " + nombreProducto + " no estaba en la lista. Se agrego!!!");
    }
    else
    {
        listaSuper.Remove(nombreProducto);
        listaDeCompra.Add(nombreProducto);
        Console.WriteLine("El elemento " + nombreProducto + " estaba en la lista. Se quito!!!");

    }
    Console.WriteLine("¿Desea seguir? Ingrese 'fin' para salir.");
    seguir = Console.ReadLine();
} while (seguir != "fin");

Console.WriteLine("Los elementos que no compro son: ");
foreach(string lista in listaSuper)
{
    Console.WriteLine(lista);
}
Console.WriteLine("Los elementos que compro pero no estaba en la lista del super son: ");
foreach (var lista in listaSuperExcluida)
{
    Console.WriteLine(lista);
}
Console.WriteLine("Todo los elementos que compro son: ");
foreach (string lista in listaDeCompra)
{
    Console.WriteLine(lista);
}