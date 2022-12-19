using System.Text.RegularExpressions;
internal class Program
{
    private static void Main(string[] args)
    {
        string patrolReal = @"[+-]?((\d+)|(\d[.,]\d+))([eE][+-]?\d+)?";
        string patrolComplejo = $@"^({patrolReal}\s[+-]\s*)?({patrolReal})[ij]?$";
        Console.Write("Introduce un numero complejo: ");
        string numero = Console.ReadLine() ?? "";
        Console.WriteLine(Regex.IsMatch(numero, patrolComplejo) ? "Numero correcto" : "Numero incorreto");
    }
}