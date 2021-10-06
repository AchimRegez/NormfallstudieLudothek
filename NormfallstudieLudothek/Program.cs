using System;

namespace NormfallstudieLudothek
{
    class Program
    {
        static void Main(string[] args)
        {
            Clients clientList = new Clients();
            var initialized = false;
            while (true)
            {
                // Menue
                Console.WriteLine("Ludothek Langistrasse");
                Console.WriteLine("1 - Ausleihe");
                Console.WriteLine("2 - Kunde hinzufügen");
                Console.WriteLine("3 - Kundenliste abrufen");
                Console.WriteLine("4 - Liste der Wunschspiele mit Budget abgleichen");
                Console.WriteLine("5 - Spiel hinzufügen");
                Console.WriteLine("6 - Spiele Liste anzeigen");
                Console.WriteLine("7 - Programm beenden");
                Console.WriteLine("Bitte geben Sie die betreffende Zahl ein: ");
                int operation = Convert.ToInt32(Console.ReadLine());


                switch (operation)
                {
                    // Ausleihe
                    case 1:
                        Console.WriteLine("Ausleihe");
                        Console.WriteLine("Hans Nötig: ausgeliehene Titel: Cosmos, Crazy Tower, Mercado");
                        Console.WriteLine("Ausgeliehen am: 13.09.2021");
                        Console.WriteLine("Rückgabe der Spiele am: 11.10.2021");
                        Console.WriteLine("Überzogen des Ausleihdatums: Nein");
                        Console.WriteLine();
                        Console.WriteLine("Max Muster: ausgeliehene Titel: UNO, Schwarzer Peter");
                        Console.WriteLine("Ausgeliehen am: 30.08.2021");
                        Console.WriteLine("Rückgabe der Spiele am: 20.09.2021");
                        Console.WriteLine("Überzogen des Ausleihdatums: Ja");
                        Console.WriteLine("Senden der Mahnung!");
                        break;
                    // Kunde hinzufügen
                    case 2:
                        clientList.AddNewClientToList();
                        break;
                    // Kundenliste abrufen
                    case 3:
                        Console.WriteLine("Es sind folgende Kunden im System erfasst: ");
                        Console.WriteLine();
                        clientList.InitializeListOfClients();
                        break;
                    // Liste der Spiele mit Budget abgleichen
                    case 4:
                        Console.WriteLine("Liste der Spiele mit Budget abgleichen");
                        Wishlist wishlist = new Wishlist();
                        wishlist.GenerateWishlist();
                        break;
                    // Spiel zur Liste hinzufügen
                    case 5:
                        Console.WriteLine("Spiel hinzufügen");
                        //string title, string type, int numberOfPlayers, int minimumAge

                        Console.WriteLine("Bitte gebe den Namen des neuen Spiels ein: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Bitte gebe den Typ des neuen Spiels ein: ");
                        string type = Console.ReadLine();
                        Console.WriteLine("Bitte gebe die Anzahl Spieler des neuen Spiels ein: ");
                        int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Bitte gebe das Mindesalter des neuen Spiels ein: ");
                        int minimumAge = Convert.ToInt32(Console.ReadLine());
                        GameFactory factory = new GameFactory();
                        DefaultGame newGame = factory.CreateInstance(title, type, numberOfPlayers, minimumAge);
                        Games games = Games.GetInstance();
                        games.gamesList.Add(newGame);
                        Console.WriteLine("Das Spiel wurde hinzugefügt: ");
                        Console.WriteLine("Titel: " + newGame.title);
                        Console.WriteLine("Kategorie: " + newGame.type);
                        Console.WriteLine("Anzahl der Spieler: " + newGame.numberOfPlayers);
                        Console.WriteLine("Mindestalter: " + newGame.minimumAge + " Jahre");
                        break;
                    //Liste der Spiele anzeigen
                    case 6:
                        Games games2 = Games.GetInstance();
                        if (initialized == false)
                        {
                            games2.InitializeGamesList();
                            initialized = true;
                        }
                        foreach (var game in games2.gamesList)
                        {
                            Console.WriteLine($"Spiel: {game.title}, Kategorie: {game.type}, Anzahl der Spieler: {game.numberOfPlayers}, Mindestalter: {game.minimumAge} Jahre");
                        }
                        break;
                     // Applikation beenden
                    case 7:
                        Console.WriteLine("Das Programm wurde beendet!");
                        return;                        
                    default:
                        Console.WriteLine("Ungültige Operation! Bitte probieren Sie es nochmals.");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
