internal class Program
{
    public static void Menu()
    {
        Console.WriteLine("1.- Registrarse en el sistema.\n2.- Entrar al sistema.\n3.- Salir del programa.");
    }
    public static char[] Registrarse()
    {
        bool comprobacion;
        char[] contraseña1 = new char[20];
        char[] contraseña2 = new char[20];
        do
        {
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Registrarse: ");
            Console.Write("\nContraseña: ");
            contraseña1 = RecogeContraseña();
            Console.Write("\nComprobar contraseña: ");
            contraseña2 = RecogeContraseña();
            comprobacion = contraseña1.SequenceEqual(contraseña2);
            if (comprobacion == false)
                Console.WriteLine("\nLas dos contraseñas no coinciden, vuelvelo a intentar");
            Console.WriteLine("\n-------------------------------------------------------------------------");
        } while (comprobacion == false);

        return contraseña1;
    }
    public static void Entrar(char[] contraseña)
    {
        bool comprobacion;
        char[] contraseña2 = new char[20];
        Console.WriteLine("-------------------------------------------------------------------------");
        Console.WriteLine("Entrar: ");
        Console.Write("Introduce la contraseña: ");
        contraseña2 = RecogeContraseña();
        comprobacion = contraseña.SequenceEqual(contraseña2);
        if (comprobacion == false)
            Console.WriteLine("\nLa contraseña introducida es incorrecta");
        Console.WriteLine("\n-------------------------------------------------------------------------");

    }
    public static char[] RecogeContraseña()
    {
        ConsoleKeyInfo tecla;
        int cont = 0;
        char[] contraseña = new char[20];
        do
        {
            tecla = Console.ReadKey(true);
            if (tecla.Key != ConsoleKey.Enter)
            {
                Console.Write("*");
                char caracter = tecla.KeyChar;
                contraseña[cont] = caracter;
                cont++;
            }
        } while (tecla.Key != ConsoleKey.Enter);

        return contraseña;
    }
    private static void Main(string[] args)
    {
        char[] contraseña = new char[20];
        int opcion;
        do
        {
            Console.WriteLine("Elige una de las siguientes opciones: ");
            Menu();
            opcion = int.Parse(Console.ReadLine() ?? "");
            switch (opcion)
            {
                case 1:
                    contraseña = Registrarse();
                    break;
                case 2:
                    Entrar(contraseña);
                    break;
                case 3:
                    break;
            }
        } while (opcion != 3);

    }
}