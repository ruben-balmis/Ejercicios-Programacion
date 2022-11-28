internal class Program
{
    public static int[,] CreaMatriz()
    {
        int[,] matriz = new int[10,10];
        for (int i = 1; i < matriz.GetLength(0)+1; i++)
        {
            for (int j = 1; j < matriz.GetLength(1)+1; j++)
            {
                matriz[i-1,j-1] = (i % 2 == 0) ? 1 : 0;   
            }
        }
        return matriz;
    }
    public static void MuestraMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"{matriz[i,j]} ");
            }
            Console.WriteLine("");
        }
    }
    private static void Main(string[] args)
    {
        int[,] matriz = CreaMatriz();
        MuestraMatriz(matriz);
    }
}