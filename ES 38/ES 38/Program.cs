void controllo_cognome(string c, char[] cod)
{
    int n = 3, m = 0;
    for (int i = 0; i < c.Length; i++)
    {
        if (c[i] != 'a' && c[i] != 'e' && c[i] != 'i' && c[i] != 'o' && c[i] != 'u' && c[i] != 'y')
        {
            cod[m] = c[i];
            m++;
            n--;
            if (n == 0)
            {
                break;
            }
        }
    }
}
void controllo_nome(string c, char[] cod)
{
    int n = 3, m = 3, nc=0;
    bool lool = false;
    for (int i = 0; i < c.Length; i++)
    {
        if (c[i] != 'a' && c[i] != 'e' && c[i] != 'i' && c[i] != 'o' && c[i] != 'u' && c[i] != 'y')
        {
            nc++;
        }
    }
    if (nc >= 4)
    {
        lool = true;
    }
    for (int i = 0; i < c.Length; i++)
    {
        if (lool == true)
        {
            if (i == 2)
            {

            }
            else
            {
                if (c[i] != 'a' && c[i] != 'e' && c[i] != 'i' && c[i] != 'o' && c[i] != 'u' && c[i] != 'y')
                {
                    cod[m] = c[i];
                    m++;
                    n--;
                    if (n == 0)
                    {
                        break;
                    }
                }
            }
        }
        else
        {
            if (c[i] != 'a' && c[i] != 'e' && c[i] != 'i' && c[i] != 'o' && c[i] != 'u' && c[i] != 'y')
            {
                cod[m] = c[i];
                m++;
                n--;
                if (n == 0)
                {
                    break;
                }
            }
        }
    }
}
void controllo_anno(string data, char[] cod)
{
    cod[6] = data[8];
    cod[7] = data[9];
}
void controllo_mese(string data, char[] cod)
{
    char p = ' ';
    if (data[4] == '1') { if (data[3] == 1) { p = 's'; } else { p = 'a'; } }
    if (data[4] == '2') { if (data[3] == 1) { p = 't'; } else { p = 'b'; } }
    if (data[4] == '3') { p = 'c'; }
    if (data[4] == '4') { p = 'd'; }
    if (data[4] == '5') { p = 'e'; }
    if (data[4] == '6') { p = 'h'; }
    if (data[4] == '7') { p = 'l'; }
    if (data[4] == '8') { p = 'm'; }
    if (data[4] == '9') { p = 'p'; }
    if (data[4] == '0') { p = 'r'; }
    cod[8] = p;
}
void controllo_giorno(string data, char[] cod, string sex)
{
    /*   if (sex == "f")
       {
           cod[9] = int.Parse(data[0]);
           cod[10] = data[1];
       }*/
    cod[9] = data[0];
    cod[10] = data[1];

}
void view_cod(char[] cod){
    string loona="";
    for (int i = 0; i < 16; i++) 
    {
        loona += cod[i];
    }
    loona = loona.ToUpper();
    Console.WriteLine(loona);
}

Console.WriteLine("cognome:");
string cognome= Console.ReadLine();
cognome = cognome.ToLower();
Console.WriteLine("nome:");
string nome = Console.ReadLine();
nome = nome.ToLower();
Console.WriteLine("data di mascita (gg/mm/aaaa):");
string data = Console.ReadLine();
Console.WriteLine("sesso(f/m):");
string sex = Console.ReadLine();
sex = sex.ToLower();
Console.WriteLine("citta di nascita:");
string citta = Console.ReadLine();
citta = citta.ToLower();
char[] cod = new char[16];
controllo_cognome(cognome, cod);
controllo_nome(nome, cod);
controllo_anno(data, cod);
controllo_mese(data, cod);
controllo_giorno(data, cod, sex);
view_cod(cod);