# MasterDev
Praktyki zdalne
Aby utworzyc baze danych trzeba utworzyc baze Test iw konsoli SQl wkleić ten kod
CREATE TABLE Klienci(
    id int GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    name varchar(50),
    surname varchar(50),
    pesel varchar(11),
    birthyear int,
    płeć int
)
a w pliku appsettings.json w tej linii "DefaultConnectionString": "Host=localhost;Port=5432;Database=Test;Username=postgres;Password=Tutaj twoje hasło;" ustawic swoje hasło
