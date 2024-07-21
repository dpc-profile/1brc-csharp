using System.Diagnostics;

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
        LerArquivo3(filePath);
        //LendoEConvertendo(filePath);

        return "ola";
    }

    private void LerArquivo3(string filename)
    {
        int bufferSize = 1024 * (1024 * 16); // 16MB
        int count = 0;

        using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[bufferSize];
            int bytesRead;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                for (int i = 0; i < bytesRead; i++)
                {
                    if (buffer[i] == 59) // 59 é o valor ASCII para ';'
                        count++;
                }

            }
        }

        Console.WriteLine(count);
    }

    private void LendoEConvertendo(string filename)
    {
        int bufferSize = 1024 * (1024 * 12); // 8MB
        int count = 0;

        using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[bufferSize];
            int bytesRead;
            while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string text = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == ';')
                        count++;
                }

            }
        }

        Console.WriteLine(count);
    }
}

