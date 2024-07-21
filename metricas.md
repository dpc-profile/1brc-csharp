## Lendo arquivo
#### Convertendo para string e contando semicolon usando for loop:
- Media 33.826ms
```csharp
string text = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);

for (int i = 0; i < text.Length; i++)
{
    if (text[i] == ';')
        count++;
}
```

#### Contando semicolon via caractere ASCII 
- Media 14.479ms
```csharp
for (int i = 0; i < bytesRead; i++)
{
    if (buffer[i] == 59) // 59 é o valor ASCII para ';'
        count++;
}
```


#### Fazendo nada apenas loopando
##### bufferSize | Medias
- 1MB = 1.678 ms
- 4MB = 1.617 ms
- 8MB = 1.634 ms

```csharp
using (FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read))
{
    byte[] buffer = new byte[bufferSize];
    int bytesRead;
    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
    {

    }
}
```
---