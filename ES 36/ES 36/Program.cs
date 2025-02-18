using System.Runtime.CompilerServices;
void casuali(int[,] m)
{
    for (int i = 0; i < 5; i++)
    {
        Random random = new Random();
        int a = random.Next(0, 5);
        int b = random.Next(0, 5);
        m[a,b] = -1;
    }
}
void visualizza_matrice(int[,] m)
{
    for (int i = 0;i < m.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < m.GetLength(1); j++)
        {
            if (m[i,j] == 0)
            {
                Console.Write($"[ {m[i, j]}]");
            }
            if (m[i,j] == -1)
            {
                Console.Write($"[{m[i, j]}]");
            }
        }
    }
}

int[,] m = { {0,0,0,0,0},
             {0,0,0,0,0},
             {0,0,0,0,0},
             {0,0,0,0,0},
             {0,0,0,0,0}};
casuali(m);
visualizza_matrice(m);

