Console.WriteLine("Ingrese tipo de fruta:");
Console.WriteLine("(1)Naranja");
Console.WriteLine("(2)Fresa");
Console.WriteLine("(3)Mango");
int fruta = int.Parse(Console.ReadLine());
Console.Write("Ingrese cantidad de cajas: ");
float caja = float.Parse(Console.ReadLine());
Console.Write("Ingrese distancia de entrega: ");
float dist = float.Parse(Console.ReadLine());
float precio = 0.00f;

if (dist < 30f)
{
    switch (fruta)
    {
        case 1:
            precio = 2.00f;
            break;
        case 2:
            precio = 6.00f;
            break;
        case 3:
            precio = 3.00f;
            break;
    }
}
else
{
    switch (fruta)
    {
        case 1:
            precio = 4.00f;
            break;
        case 2:
            precio = 9.00f;
            break;
        case 3:
            precio = 5.00f;
            break;
    }
}
precio *= caja;
Console.WriteLine("el precio es: " + precio);