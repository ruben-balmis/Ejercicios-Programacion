internal class Program
{
    public static int[,] CreaMatriz()
    {
        int[,] matriz = new int[5,5];
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i,j] = (i == j) ? 1 : 0;
            }
        }
        return matriz;
    }
    public static void MuestraMatriz(int[,] matriz)
    {
        int cont = 0;
        foreach (int num in matriz)
        {
            Console.Write($"{num} ");
            cont ++;
            if (cont == matriz.GetLength(0))
            {
                cont = 0;
                Console.WriteLine("");
            }
        }
    }
    private static void Main(string[] args)
    {
        int[,] matriz = CreaMatriz();
        MuestraMatriz(matriz);
    }
}