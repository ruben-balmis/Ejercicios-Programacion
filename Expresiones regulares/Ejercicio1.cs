using System.Text.RegularExpressions;
internal class Program
{
    public static void MuestraFecha(Regex patron, string fecha)
    {
        int dia, mes, año;
        string separador;
        Match muestra = patron.Match(fecha);
        if (muestra.Success)
        {
            dia = int.Parse(muestra.Groups["dia"].Value);
            mes = int.Parse(muestra.Groups["mes"].Value);
            año = int.Parse(muestra.Groups["año"].Value);
            separador = muestra.Groups["separador"].Value;
            Console.WriteLine($"Fecha: {dia}{separador}{mes}{separador}{año}");
        }
        else
            Console.WriteLine("Fecha incorrecta");
    }
    public static void MuestraMatricula(Regex patron1, Regex patron2, string matricula)
    {
        string letras, letras1, letras2, separador1, separador2, separador;
        int numeros;
        Match muestra1 = patron1.Match(matricula);
        Match muestra2 = patron2.Match(matricula);
        
        if (muestra1.Success)
        {
            letras1 = muestra1.Groups["letras1"].Value;
            letras2 = muestra1.Groups["letras2"].Value;
            numeros = int.Parse(muestra1.Groups["numeros"].Value);
            separador1 = muestra1.Groups["separador1"].Value;
            separador2 = muestra1.Groups["separador2"].Value;
            Console.WriteLine($"Matricula: {letras1}{separador1}{numeros}{separador2}{letras2}");
        }
        else if (muestra2.Success)
        {
            letras = muestra2.Groups["letras"].Value;
            numeros = int.Parse(muestra2.Groups["numeros"].Value);
            separador = muestra2.Groups["separador"].Value;
            Console.WriteLine($"Matricula: {numeros}{separador}{letras}");
        }
        else
            Console.WriteLine("Matricula incorrecta");
    }
    public static void MuestraExponente(Regex patron, string exponente)
    {
        double num1;
        int num2;
        string signo, expo;
        Match muestra = patron.Match(exponente);
        if (muestra.Success)
        {
            num1 = double.Parse(muestra.Groups["numeros1"].Value);
            num2 = int.Parse(muestra.Groups["numeros2"].Value);
            signo = muestra.Groups["signo"].Value;
            expo = muestra.Groups["expo"].Value;
            Console.WriteLine($"Numero esponencial: {num1}{signo}{expo}{num2}");
        }
        else
            Console.WriteLine("Numero exponencial incorrecto");
    }
    public static (Regex, Regex, Regex, Regex) CreaPatron(string fecha, string matricula, string exponente)
    {
        Regex patronFecha = new Regex (@"^(?<dia>\d{1,2})(?<separador1>\/|\s|\-)(?<mes>\d{1,2})(?<separador2>\/|\s|\-)(?<año>\d{1,4})$");
        Regex patronMatricula1 = new Regex (@"^(?<letras1>[A-Z]{2})(?<separador1>\s|\-)(?<numeros>\d{4})(?<separador2>\s|\-)(?<letras2>[A-Z]{2})$");
        Regex patronMatricula2 = new Regex (@"(?<numeros>\d{4})(?<separador>\s|\-)(?<letras>[A-Z]{3})$");
        Regex patronExponente = new Regex (@"(?<numeros1>(\d+)|(\d+\,\d+))(?<expo>[eE]{1})(?<signo>((\+)|(\-)){0,1})(?<numeros2>\d+)$");
        
        return (patronFecha, patronMatricula1, patronMatricula2, patronExponente);
    }
    public static (string, string, string) PideDatos()
    {
        string fecha, matricula, exponente;
        Console.WriteLine("Introduce una fecha separada por esapacio o / o -");
        fecha = Console.ReadLine() ?? "";
        Console.WriteLine("Introduce una matricula valida");
        matricula = Console.ReadLine() ?? "";
        Console.WriteLine("Introduce un numero exponencial valido");
        exponente = Console.ReadLine() ?? "";

        return (fecha, matricula, exponente);
    }
    private static void Main(string[] args)
    {
        string fecha="", matricula="", exponente="";
        Regex patronFecha, patronMatricula1, patronMatricula2, patronExponente;
        (fecha, matricula, exponente) = PideDatos();
        (patronFecha, patronMatricula1, patronMatricula2, patronExponente) = CreaPatron(fecha, matricula, exponente);
        MuestraFecha(patronFecha, fecha);
        MuestraMatricula(patronMatricula1, patronMatricula2, matricula);
        MuestraExponente(patronExponente, exponente);
    }
}