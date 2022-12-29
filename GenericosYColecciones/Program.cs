//ayuda ahorarr codigo

int[] enteros = { 1, 2, 3 };
string[] nombres = { "Felipe", "Claudia", "Pedro", "Juana" };

DateTime[] fechas = { DateTime.Today, DateTime.Today.AddDays(1) };


Console.WriteLine($"Logituf de arreglos de entero{calcularLongitudArreglo<int>(enteros)}");

int calcularLongitudArreglo<T>(T[] arreglo)
{
    return arreglo.Length;
}

T? primerElementoOvalorPorDefecto<T>(T[] arreglo) 
{
    if(arreglo.Length == 0)
    {
        return default;
    }
    return arreglo[0];

}

Console.WriteLine(primerElementoOvalorPorDefecto(nombres));

//listas

int[] enteros2 = {1,2, 3 };

//enteros2.Add(4);

List<int> enterosLista = new List<int>();
enterosLista.Add(1);
enterosLista.Add(2);


foreach (var item in enterosLista)
{
    Console.WriteLine(item);
}
  


