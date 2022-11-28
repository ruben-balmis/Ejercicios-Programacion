internal class Program
{
    private static bool ArraysCharEquals(char[] array1, char[] array2)
    {
        if(array1.Length != array2.Length) return false;
        for(int i = 0; i < array1.Length; i++)
        {
            if(char.ToLower(array1[i]) != char.ToLower(array2[i]))
                return false;
        }
        return true;
    }
    private static int BuscarPais(char[][] paises, char[] pais)
    {
        for(int i = 0; i < paises.Length; i++)
        {
            if(ArraysCharEquals(paises[i], pais))
                return i;
        }
        return -1;
    }
    private static void MostrarPaises(char[][] paises)
    {
        foreach(char[] p in paises)
        {
            Console.WriteLine(p);
        }
    }
    private static char[][] OrdenarPaises(char[][] paises)
    {
        char[][] arrayOrdenado = new char[paises.GetLength(0)][];
        Array.Copy(paises, arrayOrdenado, paises.GetLength(0));
        for(int i = 0; i < arrayOrdenado.GetLength(0); i++)
        {
            for(int j = i + 1; j < arrayOrdenado.GetLength(0); j++)
            {
                if(new string(arrayOrdenado[i]).CompareTo(new string((arrayOrdenado[j]))) > 0)
                    (arrayOrdenado[i], arrayOrdenado[j]) = (arrayOrdenado[j], arrayOrdenado[i]);
            }
        }
        return arrayOrdenado;
    }
    private static void AñadirPrefijo(ref char[][] paises)
    {
        Console.Write("Introduce un pais para buscar: ");
        string pais           = Console.ReadLine() ?? "";
        int    paisEncontrado = BuscarPais(paises, pais.ToCharArray());
        if(paisEncontrado == -1)
        {
            Console.WriteLine("No se ha encontrado este pais en la lista");
            return;
        }
        Console.Write("Introduce un prefijo para el pais de 2 caracteres: ");
        string prefijo = Console.ReadLine() ?? "";
        if(prefijo.Length == 2)
        {
            Array.Resize(ref paises[paisEncontrado], paises[paisEncontrado].Length + 3);
            for(int i = paises[paisEncontrado].Length - 2; i < paises[paisEncontrado].Length; i++)
            {
                paises[paisEncontrado][i] = prefijo.ToCharArray()[i - (paises[paisEncontrado].Length - 2)];
            }
            return;
        }
        Console.WriteLine("Prefijo introducido no valido.");
    }
    private static void CreaArray()
    {
        char[][] paises = 
        {
            "España".ToCharArray(),
            "Alemania".ToCharArray(),
            "Francia".ToCharArray(),
            "Portugal".ToCharArray(),
            "Canada".ToCharArray(),
            "Italaia".ToCharArray(),
            "Japon".ToCharArray(),
            "Argentina".ToCharArray(),
            "Arabia Saudí".ToCharArray(),
            "Australia".ToCharArray(),
            "Brasil".ToCharArray(),
            "China".ToCharArray(),
            "Corea del Sur".ToCharArray(),
            "India".ToCharArray(),
            "Indonesia".ToCharArray(),
            "México".ToCharArray(),
            "Sudáfrica".ToCharArray(),
            "Turquía".ToCharArray(),
            "Reino Unido".ToCharArray(),
            "Rusia".ToCharArray()
        };
        int opcion;
        do
        {
            Console.WriteLine("1. Buscar un país.\n2. Mostrar países.\n3. Ordenar países.\n4. Añadir prefijo a un país.\n5. Salir");
            opcion = int.Parse(Console.ReadKey(true).KeyChar.ToString());
            switch(opcion)
            {
                case 1:
                    Console.Write("Introduce un pais para buscar: ");
                    string pais = Console.ReadLine() ?? "";
                    Console.WriteLine(BuscarPais(paises, pais.ToCharArray()) != -1 ? "Pais encontrado en la lista" : "No se ha encontrado este pais en la lista");
                    break;
                case 2:
                    MostrarPaises(paises);
                    break;
                case 3:
                    paises = OrdenarPaises(paises);
                    break;
                case 4:
                    AñadirPrefijo(ref paises);
                    break;
                case 5:
                    Console.Write("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opccion incorrecta. Introduce una opcion valida.");
                    break;
            }
        } while(opcion != 5);
    }
    private static void Main()
    {
        CreaArray();
        //Console.ReadLine();
    }
}
