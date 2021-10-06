using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormfallstudieLudothek
{
    // Product
    interface IGenericGame
    {
        string title { get; set; }
        string type { get; set; }
        int numberOfPlayers { get; set; }
        int minimumAge { get; set; }
        
    }
}
