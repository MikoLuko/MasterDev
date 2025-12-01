using System;
using CsvHelper;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using System.Runtime.CompilerServices;
internal class program
{
    class User
    {
        public int LP { get; set; }
        public string imie { get; set; }
        public string nazwisko {  get; set; }
        public int data {  get; set; }

    };

    static void Main(string[] args)
    {
        Random rand = new Random();
        string[] imiona = { "Kasia", "Basia", "Zosia", "Ania" };
        string[] nazwiska = { "Kowalska", "Nowak" };
        var users = new List<User>();
        for (int i = 0; i < 100; i++)
        {
            User User1 = new();
            users.Add(new User()
            {
                LP = i + 1,
                imie = imiona[rand.Next(imiona.Length)],
                nazwisko = nazwiska[rand.Next(nazwiska.Length)],
                data = rand.Next(1990, 2001),

            });
            string data = DateTime.Now.ToString("dd.MM.yyyy.HH");
            data = data.Replace(".", "_");
            string path = "C:\\test\\users-" + data + ".csv";
            using (var streamWriter = File.CreateText(path))
            {
                var csvWriter = new CsvWriter(streamWriter, new CultureInfo("pl-PL"));
                csvWriter.WriteRecords(users);
            }
            ;
        }
    }
}


