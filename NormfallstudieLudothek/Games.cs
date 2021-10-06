using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormfallstudieLudothek
{
    public class Games
    {
        private static Games _instance;
        public List<DefaultGame> gamesList { get; set; }
        

        // Initialisiert Liste mit Spielen
        public void InitializeGamesList()
        {
            DefaultGame game = new DefaultGame("Labyrinth", "Brettspiel", 4, 6);
            DefaultGame game1 = new DefaultGame("Schach", "Brettspiel", 2, 6);
            DefaultGame game2 = new DefaultGame("Cluedo", "Suchspiel", 6, 8);
            DefaultGame game3 = new DefaultGame("Tomy Pop-Up Pirate!", "Geschicklichkeitsspiel", 4, 4);
            DefaultGame game4 = new DefaultGame("Hasbro Monopoly: Star Wars - Das Kind", "Brettspiel", 4, 8);
            DefaultGame game5 = new DefaultGame("Die Siedler von Catan: Das schnelle Kartenspiel", "Kartenspiel", 4, 8);

            _instance.gamesList.Add(game1);
            _instance.gamesList.Add(game2);
            _instance.gamesList.Add(game3);
            _instance.gamesList.Add(game4);
            _instance.gamesList.Add(game5);
        }

        public static Games GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Games();
                _instance.gamesList = new List<DefaultGame>();
            }
            return _instance;
        }   
    }
}
