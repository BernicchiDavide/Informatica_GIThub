Console.WriteLine("dimmi la frase");
string r =  Console.ReadLine();
char[] v = new char[r.Length];
for (int i = 0; i < v.Length; i++)
{
    v[i]= r[i];
}
Console.WriteLine(" ");
for (int i = 0; i < v.Length / 2; i++)
{
    Console.Write(v[i]);
}

Console.WriteLine("\n ");
for (int i = v.Length/ 2; i < v.Length; i++)
{
    Console.Write(v[i]);
}

Console.WriteLine(" ");