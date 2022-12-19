using System.Text.RegularExpressions;
internal class Program
{
    public static void MuestraCuenta(string cuenta, Regex patron)
    {
        string cod;
        int num1, num2, num3, num4;
        Match muestra = patron.Match(cuenta);
        if (muestra.Success)
        {
            cod = muestra.Groups["codigo"].Value;
            num1 = int.Parse(muestra.Groups["banco"].Value);
            num2 = int.Parse(muestra.Groups["sucursal"].Value);
            num3 = int.Parse(muestra.Groups["control"].Value);
            num4 = int.Parse(muestra.Groups["cuenta"].Value);
            Console.WriteLine($"Codigo IBAN: {cod}\nNumero banco: {num1}\nNumero sucursal: {num2}\nNumero de control: {num3}\nNumero de cuenta: {num4}");
        }
        else
            Console.WriteLine("El numero de cuenta que has introducido es incorrecto");
    }
    private static void Main(string[] args)
    {
        string cuenta;
        Console.Write("Introduce cuenta bancaria: ");
        cuenta = Console.ReadLine() ?? "";
        Regex compruebaCuenta = new Regex (@"^(?<codigo>[A-Z]{2}\d{2})(?<banco>\d{4})(?<sucursal>\d{4})(?<control>\d{2})(?<cuenta>\d{10})$");
        MuestraCuenta(cuenta, compruebaCuenta);
    }
}