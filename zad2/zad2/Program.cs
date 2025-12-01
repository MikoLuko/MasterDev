Console.Write("Podaj nazwe pliku: ");
string filename = Console.ReadLine();
string path = "C:\\test\\" + filename;
if (File.Exists(path + ".txt"))
{
    string tekst = File.ReadAllText(path + ".txt");
    string[] tekst_tab = tekst.Split("praca");
    if (tekst_tab.Length-1 == 5)
    {
        tekst = tekst.Replace("praca", "job");
        string data = DateTime.Now.ToString("dd.MM.yyyy");
        data = data.Replace(".", "");
        File.WriteAllText(path + "_changed-" + data+".txt",tekst);
    }
    else
    {
        Console.WriteLine("Plik nie spełnia warunków");
    }
}

