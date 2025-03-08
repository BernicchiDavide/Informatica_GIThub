void Metodo1()
{
    string PerFile = "Testo1.txt";
    StreamReader sr = new StreamReader(PerFile);
    string line = sr.ReadLine();
    while (line != null)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close();
}
void Metodo2()
{
    string PerFile = "Testo1.txt";
    string[]line = File.ReadAllLines(PerFile);
    for (int i = 0; i < line.Length; i++)
    {
        Console.WriteLine(line[i]);
    }
}

Console.WriteLine("1-2");
if (Console.ReadLine() == "1")
{
    Metodo1();
}
else if (Console.ReadLine() == "2")
{
    Metodo2();
}