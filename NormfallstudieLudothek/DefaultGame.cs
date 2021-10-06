using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormfallstudieLudothek
{
    public class DefaultGame : IGenericGame
    {
        // ConcreteProduct
        public string title { get; set; }
        public string type { get; set; }
        public int numberOfPlayers { get; set; }
        public int minimumAge { get; set; }

        public DefaultGame(string title, string type, int numberOfPlayers, int minimumAge)
        {
            this.title = title;
            this.type = type;
            this.numberOfPlayers = numberOfPlayers;
            this.minimumAge = minimumAge;
        }
    }
}
