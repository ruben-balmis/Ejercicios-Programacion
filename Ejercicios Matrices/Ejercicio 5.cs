internal class Program
{
    private static void Main(string[] args)
    {
        int cont = 0, rango = 0, compara = 0;
        int[][] m = new int[][]
        {
            new int [] {1,2,3,4},
            new int [] {5,6,7},
            new int [] {9,10,11,12,5},
            new int [] {9,10}
        };
        foreach (int[] num in m)
        {
            rango = num.Length;
            if (rango > compara)                                                        //busque en la tabla¿?
            {
                compara = rango;
                cont++;
            }   
        }
        Console.Write($"El array con mas elementos es el array numero {cont + 1}: ");
        foreach (int num in m[cont])
        {
            Console.Write(num + " ");
        }
    }
}