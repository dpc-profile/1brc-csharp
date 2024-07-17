namespace _1brc;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            args = new string[] { @"C:\Users\user05\Downloads\measurements1b.txt" };
        }

        string retorno = new CalcMeasurements(args[0]).RetornoCalculos;

        Console.WriteLine(retorno);
    }
}