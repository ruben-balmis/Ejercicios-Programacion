internal class Program
{

    public static int[,] VentaEntradas(int[,]compradas)
    {
        int entradas, sesion;
        int salaFinal;
        char sala;
        Console.Write("Cuantas entradas quieres comprar: ");
        entradas = int.Parse(Console.ReadLine() ?? "");
        Console.Write("En que sala(A,B,C): ");
        sala = char.ToUpper(char.Parse(Console.ReadLine() ?? ""));
        Console.Write("En que sesion(1,2,3): ");
        sesion = int.Parse(Console.ReadLine() ?? "");
        sesion -= 1; 
        salaFinal = sala switch
        {
            'A' => 0,
            'B' => 1,
            'C' => 2,
            _ => 3
        };
        if (salaFinal == 3)
            Console.WriteLine("\nLa sala que has introducido es erronea, vuelve a intentarlo");
        else
            compradas[salaFinal,sesion] =  entradas;

        return compradas;
    }
    public static int[,] MuestraAforo(int[,]salas, int[,]compradas)
    {
        string salida;
        int cont = 1;
        for (int i = 0; i < salas.GetLength(0); i++)
        {
            for (int j = 0; j < salas.GetLength(1); j++)
            {
                salas[i,j] = salas[i,j] - compradas[i,j];
            }
        }
        Console.WriteLine("         Sesión 1   Sesión 2   Sesión 3");
        foreach (int num in salas)
        {
            salida = cont switch
            {
                1 => $"SALA A {num,7} ",
                4 => $"SALA B {num,7} ",
                7 => $"SALA C {num,7} ",
                2 or 5 or 8 => $"{num,11} ",
                3 or 6 or 9 => $"{num,9} \n",
                _ => ""
            };
            Console.Write(salida);
            cont++;
        }

        return salas;
    }
    public static void Menu(int[,]salas, int[,]compradas)
    {
        int opcion;
        Console.WriteLine("Introduce una opcion");
        Console.WriteLine("1.- Venta de entradas");
        Console.WriteLine("2.- Estadisticas de aforo");
        opcion = int.Parse(Console.ReadLine() ?? "");
        switch (opcion)
        {
            case 1: compradas = VentaEntradas(compradas);
                break;
            case 2: salas = MuestraAforo(salas, compradas);
                break;
        }
    }
    private static void Main(string[] args)
    {
        
        int[,] salas = 
        {
            {200, 200, 200},
            {150, 150, 150},
            {125, 125, 125}
        };
        int[,] compradas = new int[3,3];
        do
        {
            Menu(salas, compradas);
            Console.WriteLine("Pulsa ESC para terminar");
        }while(Console.ReadKey().Key != ConsoleKey.Escape);
    }
}