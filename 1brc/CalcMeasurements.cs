using System.Diagnostics;
using System.IO;
using System.Text;

namespace _1brc;

public class CalcMeasurements
{
    public string RetornoCalculos { get; private set; }

    public CalcMeasurements(string filePath)
    {
        Stopwatch watch = Stopwatch.StartNew();

        RetornoCalculos = CalcularTemperatura(filePath);

        watch.Stop();
        Console.WriteLine($"Tempo para ler arquivo: {watch.Elapsed.ToString("s\\.fff")} ms");
    }
    private string CalcularTemperatura(string filePath)
    {
        //LerArquivo(filePath);
        //var arquivoByte = Load(filePath);

        //string fileContent = Encoding.UTF8.GetString(arquivoByte);

        //int count = 0;
        //foreach (Char caractere in fileContent)
        //{
        //    if (caractere == '\r') { count++; }
        //}

        long count = CountCharacterInFile(filePath);

        Console.WriteLine(count);
        return "ola";
    }

    private byte[] Load(string filename)
    {
        byte[] data = null;
        using (FileStream fs = File.OpenRead(filename))
        {
            data = new byte[fs.Length]; // Precisa dar um jeito nesse buffer
            fs.Read(data, 0, data.Length);
        }
        return data;
    }

    private static long CountCharacterInFile(string filename)
    {
        long count = 0;

        using (FileStream fs = File.OpenRead(filename))
        using (StreamReader reader = new StreamReader(fs))
        {
            int currentChar;
            while ((currentChar = reader.Read()) != -1)
            {
                if (currentChar == '\r')
                {
                    count++;
                }
            }
        }

        return count;
    }
}

