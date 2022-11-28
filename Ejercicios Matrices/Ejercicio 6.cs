internal class Program
{
    private static void Main(string[] args)
    {
        int cont1 = -2, cont2 = 20;
        int[][][] tabla = new int[][][]
        {
            new int [][]
            {
                new int [] {1,2,3,4},
                new int [] {5,6,7},
                new int [] {9,10,11,12}
            },
            new int [][]
            {
                new int [] {13,14,15,16},
                new int [] {17,18,19,20},
                new int [] {21,22}
            },
        };
        for (int i = 0; i < tabla.Length; i++)
        {
            for (int j = 0; j < tabla[i].Length; j++)
            {
                for (int k = 0; k < tabla[i][j].Length; k++)
                {
                    if (i == 1)
                    {
                        Console.SetCursorPosition(cont2,cont1);
                        Console.Write(tabla[i][j][k]);
                        cont2 += 3;
                        Console.Write(",");
                    }
                    else if(k == tabla[i][j].Length - 1)
                        Console.Write(tabla[i][j][k]);
                    else
                        Console.Write(tabla[i][j][k] + ",");
                }
                cont1++;
                cont2 = 20;
                Console.WriteLine("");
            }
        }
    }
}