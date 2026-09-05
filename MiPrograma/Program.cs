int contador = 10;

while (contador > 0)
{
    if (contador == 5)
    {
        Console.WriteLine("¡Llegamos a la mitad!");
    }
    else
    {
        Console.WriteLine("Contando: " + contador);
    }
    contador--;
}

Console.WriteLine("Cuenta regresiva terminada");
