internal class Program
{
    private static void Main(string[] args)
    {
        int mayor = 0, posicion;
        Random semilla = new Random();
        int[] nuevo = new int[10];
        for (int i = 0; i < nuevo.Length; i++)
        {
            int num = semilla.Next(0, 101);
            nuevo[i] = num;
            if (nuevo[i] > mayor)
                mayor = nuevo[i];
        }
        posicion = Array.IndexOf(nuevo, mayor);
        Console.WriteLine($"El numero mas grande es el {mayor} y esta en la posicion {posicion}");
    }
}