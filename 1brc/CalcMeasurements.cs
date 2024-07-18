using System.Buffers;
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
        LerArquivo1(filePath);
        //LerArquivo2(filePath);


        return "ola";
    }

    private void LerArquivo1(string filename)
    {
        byte[] data = null;
        using (FileStream fs = File.OpenRead(filename))
        {
            data = new byte[fs.Length/16]; // Precisa dar um jeito nesse buffer
            fs.Read(data, 0, data.Length);
        }

        string fileContent = Encoding.UTF8.GetString(data);

        int count = 0;
        foreach (Char caractere in fileContent)
        {
            if (caractere == '\r') { count++; }
        }

        Console.WriteLine(count);
    }

    private void LerArquivo2(string filename)
    {
        string line;
        int count = 0;

        using (StreamReader file = new StreamReader(filename))
        {
            while ((line = file.ReadLine()) != null)
            {
                count++;
            }
        }

        Console.WriteLine(count);

    }

}

