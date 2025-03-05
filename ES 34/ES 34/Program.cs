bool controllo_palindromo(char[] v)
{
    char[] c = new char[v.Length];
    int m = v.Length;
    bool lools=false;
    for (int i = 0; i < v.Length; i++)
    {
        c[i] = v[i];
    }
    for (int i = 0; i <= v.Length-1; i++)
    {
        m--;
        Console.WriteLine(v[i]);
        Console.WriteLine(" ");
        Console.WriteLine(c[m]);

        if (v[i] == c[m])
        {
            lools = true;
        }
        else if (v[i] != c[m])
        {
            lools = false;
        }
    }
    return lools;
}

Console.WriteLine("dimmi la frase");
string r = Console.ReadLine();
char[] v = new char[r.Length];

Console.WriteLine(" ");
for (int i = 0; i < v.Length; i++)
{
    v[i] = r[i];
    
}
Console.WriteLine(controllo_palindromo(v));
