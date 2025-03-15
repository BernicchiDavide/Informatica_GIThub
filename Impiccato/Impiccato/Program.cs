string par = "ParoleImpiccato.txt";
StreamReader sr = new StreamReader(par);
string line = sr.ReadLine();
/*while (line != null)
{
    Console.WriteLine(line);
    line = sr.ReadLine();
}
Console.WriteLine("Citta, animali, oggetti?");
string n = Console.ReadLine().ToLower();
if (n == "animali")
{
    Console.WriteLine("-- ANIMALI --");
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
}
if (n == "citta")
{
    Console.WriteLine("-- CITTA --");
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
}
if (n == "oggetti")
{
    Console.WriteLine("-- OGGETTI --");
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine(line);
        line = sr.ReadLine();
    }
    sr.Close();
}*/
bool controllo(string n, char[] p, char[] ris)
{
    bool alastro = false;
    char[] a = n.ToCharArray();
    for (int i = 0; i<p.Length; i++)
    {
        if (a[0] == p[i])
        {
            ris[i] = a[0];
        }
    }
    for (int j = 0; j < p.Length; j++)
    {
        Console.Write(ris[j]);
        if (ris[j] != '_')
        {
            alastro = true;
        }
        else if (ris[j] == '_')
        {
            alastro = false;
        }
    }
    return alastro;
}
char[] p = {'l', 'o', 'o', 'n', 'a'};
char[] ris = new char[p.Length];
for (int i = 0; i < p.Length; i++)
{
    ris[i] = '_';
}
bool Alastor= false;
while (Alastor == false)
{
    Console.WriteLine("\ndimmi la lettera");
    string n = Console.ReadLine().ToLower();
    if (controllo(n, p, ris)== true)
    {
        Alastor = true;
    }
}