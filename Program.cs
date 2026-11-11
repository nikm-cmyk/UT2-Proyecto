//Precios de los productos del menú de la cafetería Pausa
double precioCafe = 1.60;
double precioChocolate = 1.80;
double precioCola = 1.70;
double precioBollo = 1.25;
double precioDonut = 1.45;
double precioGalleta = 1.60;
double precioLeche = 0.20;
double precioSirope = 0.30;
double precioSalsa = 0.40;


// MENU PRINCIPAL CON OPCIONES
Console.WriteLine("Bienvenido al cafetería Pausa");
while (true){
    
    Console.WriteLine();
    Console.WriteLine("=== MENÚ PRINCIPAL ===");
    Console.WriteLine("1 - Realizar un pedido");
    Console.WriteLine("2 - Reservar una mesa");
    Console.WriteLine("3 - Consultar la estadística");
    Console.WriteLine("4 - Salir");
    
    Console.WriteLine("");
    Console.Write("Seleccione una opción: ");
    int opcion = int.Parse(Console.ReadLine());
    if (opcion < 1 || opcion > 4)
    {
        Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
        continue;
    }
    else
    {
        if (opcion == 4)
        {
            Console.WriteLine("Gracias por visitar la cafetería Pausa. ¡Hasta luego!");
            break;
        }

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Has seleccionado opción 1: Realizar un pedido");
                Console.WriteLine();
                Console.WriteLine("--- MENU ---"); 
                Console.WriteLine("1. Café: " + precioCafe + "€");
                Console.WriteLine("1. Chocolate caliente: " + precioChocolate + "€");
                Console.WriteLine("1. Coca-Cola: " + precioCola + "€");
                Console.WriteLine("1. Bollo: " + precioBollo + "€");
                Console.WriteLine("1. Donut: " + precioDonut + "€");
                Console.WriteLine("1. Galleta: " + precioGalleta + "€");
                Console.WriteLine("1. Leche extra: " + precioLeche + "€");
                Console.WriteLine("1. Sirope: " + precioSirope + "€");
                Console.WriteLine("1. Salsa de chocolate: " + precioSalsa + "€");
                Console.WriteLine();
                continue;
            case 2:
                Console.WriteLine("Has seleccionado opción 2: Reservar un mesa");
                continue;
            case 3:
                Console.WriteLine("Has seleccionado opción 3: Consultar la estadística");
                continue;
            default:
                Console.WriteLine("Opción no válida");
                continue;
        }
    }
}


