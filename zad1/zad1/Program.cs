using System;
int licznik = 0;
string path = "C:\\test\\test_Mikolaj_Lukomski.txt";
if (File.Exists(path))
{
    string tekst = File.ReadAllText(path);
    foreach(char c in tekst)
    {
        if(c == 'a' || c == 'A')
        {
            licznik = licznik + 1;
        }
    }
    Console.WriteLine(licznik);
}
else
{
   Console.WriteLine("Plik nie istnieje!!!!");
}

