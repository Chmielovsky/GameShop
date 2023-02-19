# Temat: Sklep internetowy z grami

# Funkcjonalności:
-Logowanie, rejestracja,
-Przeglądanie oraz wyszukiwanie gier,
-Dodawanie gier do koszyka, przeglądanie oraz możliwość kasowania przedmiotów,
-Finalizacja zamówienia oraz przeglądanie zamówień w toku,
-ADMIN: Dodawanie gier oraz gatunków, modyfikacje oraz usuwanie gier

# Instalacja projektu


## Wymagane oprogramowanie
- Visual Studio 2019/2022
- Ms SQL Server

## Instalacja

- Uruchamiamy Ms SQL Server i kopiujemy nasz "server name"
- Uruchamiamy plik game_reviews.sln w VS
- Otwieramy plik appsettings.json i w 3 linijce w miejscu "Server" wklejamy naszą nazwe serwera.
- Wybieramy Narzędzia->Menedżer Pakietów NuGet -> Konsola menedżera pakietów
- W konsole wpisujemy 2 komendy:
- Add-Migration "Initial Create"
- Update-Database

## Wbudowane konto ADMINA:
-Login: admin@gmail.com
-Hasło: Admin123!




Autorzy: Adrian Bugaj, Tomasz Chmielarczyk
