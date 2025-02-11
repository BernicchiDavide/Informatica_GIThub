int binario(string m)
{
    int s = 0;
    for (int i = m.Length - 1; i >= 0; i--)
    {
        if (m[i] == '1')
        {
            s += (int)Math.Pow(2, m.Length - 1 - i);
        }
    }
    return s;
}

Console.WriteLine("dimmi il numero in binario:");
string m = Console.ReadLine();
Console.WriteLine($"\n-il numero binario equivale a: {binario(m)}");