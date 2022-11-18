internal class Program
{

    private static void Main(string[] args)
    {
        bool capicua;
        Console.Write("Introduce un numero para ver si es capicua: ");
        char[] numero = (Console.ReadLine() ?? "").ToCharArray();
        char[] original = new char[numero.Length];
        Array.Copy(numero, original, numero.Length);
        Array.Reverse(numero);
        capicua = original.SequenceEqual(numero);
        if (capicua == true)
            Console.WriteLine("El numero introducido es capicua");
        else
            Console.WriteLine("El numero introducido no es capicua");
    }
}