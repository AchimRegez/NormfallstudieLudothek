using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormfallstudieLudothek
{
    class GameFactory : IFactoryMethod
    {
        // Concrete Creator
        public DefaultGame CreateInstance(string title, string type, int numberOfPlayers, int minimumAge)
        {
            return new DefaultGame(title, type, numberOfPlayers, minimumAge);
        }
    }
}
