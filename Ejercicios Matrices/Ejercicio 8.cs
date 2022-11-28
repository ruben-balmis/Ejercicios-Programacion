internal class Program
{
    private static void Main(string[] args)
    {
        int[][][] dentada= new int[2][][];
        int num1;
        Random semilla = new Random();
        Console.Write("Introduce numero de Arrays: ");
        num1 = int.Parse(Console.ReadLine() ?? "");
        for (int i = 0; i < dentada.Length; i++)
        {
            dentada[i] = new int[num1][];
            for (int j = 0; j < dentada[i].Length; j++)
            {
                Console.Write($"Introduce la cantidad de numeros del array [{i}][{j}]: ");
                int num2 = int.Parse(Console.ReadLine() ?? "");
                dentada[i][j] = new int[num2];
                for (int k = 0; k < dentada[i][j].Length; k++)
                {
                    dentada[i][j][k] = semilla.Next(1,11);
                }
            }
        }
        foreach (int[][] array1 in dentada)
        {
            foreach (int[] array2 in array1)
            {
                foreach (int num in array2)
                {
                    Console.Write(num + ",");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}