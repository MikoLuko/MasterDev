using System.Text.Json;
using System;
using System.Net.Http;
using System.Text.Json;


class Program
{
    static async Task Main()
    {
        Console.Write("Podaj kwotę w PLN: ");
        decimal.TryParse(Console.ReadLine(), out decimal pln);
        using HttpClient Klient = new HttpClient();
        string url = "https://api.nbp.pl/api/exchangerates/rates/A/USD/?format=json";
        string klient = await Klient.GetStringAsync(url);

        var data = JsonSerializer.Deserialize<NBPOdpoiedz>(klient);
        decimal rate = data.rates[0].mid;

        decimal usd = pln / rate;
        Console.WriteLine($"{pln} PLN = {usd:F2} USD");


    }
}

public class NBPOdpoiedz
{
    public string tabela { get; set; }
    public string Waluta { get; set; }
    public string code { get; set; }
    public Rate[] rates { get; set; }
}

public class Rate
{
    public string no { get; set; }
    public string effectiveDate { get; set; }
    public decimal mid { get; set; }
}