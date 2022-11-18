internal class Program
{
    private static void Main(string[] args)
    {
        int limite = 0;
        do
        {
            Console.Write("Cuantos alumnos hay en la clase(maximo 25): ");
            limite = int.Parse(Console.ReadLine() ?? "");
            if (limite > 25)
                Console.WriteLine("Has introducido un numero de alumnos mayor que 25, vuelve a intentarlo");
        } while (limite > 25);
        int[] notas = new int[limite];
        int[] frecuenciaNotas = new int[11];
        int nota, cont = 0, aux = 0, contNotas = 0;
        do
        {
            Console.Write("Introduce la nota: ");
            nota = int.Parse(Console.ReadLine() ?? "");
            notas[cont] = nota;
            cont++;
        } while (cont != limite && nota >= 0 && nota <= 10);

        for (int i = 0; i < frecuenciaNotas.Length; i++)
        {
            for (int j = 0; j < notas.Length; j++)
            {
                if (notas[j] == aux)
                    contNotas++;
            }
            frecuenciaNotas[i] = contNotas;
            contNotas = 0;
            aux++;
        }
        Console.WriteLine("--------------------------FRECUENCIA DE CADA NOTA--------------------------");
        Console.Write("0 1 2 3 4 5 6 7 8 9 10\n");
        foreach (int num in frecuenciaNotas)
        {
            Console.Write(num + " ");
        }
    }
}