using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormfallstudieLudothek
{
    // Creator
    interface IFactoryMethod
    {
        abstract DefaultGame CreateInstance(string title, string type, int numberOfPlayers, int minimumAge);
    }
}
