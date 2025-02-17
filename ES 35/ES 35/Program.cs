bool controllo_parentesi(string e)
{
    bool lool=false;
    int p=0;
    for (int i=0; i<e.Length; i++)
    {
        if (e[i] == '(')
        {
            p++;
        }
        if (e[i] == ')')
        {
            p--;
        }
    }
    if (p == 0)
    {
        lool= true;
    }
    return lool;
}
Console.WriteLine("Dimmi l'espressione");
string e= Console.ReadLine();
Console.WriteLine($"parentesi = {controllo_parentesi(e)}");