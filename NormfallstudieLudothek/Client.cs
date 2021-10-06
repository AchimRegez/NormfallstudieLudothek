using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormfallstudieLudothek
{
    class Client
    {
        private string name;
        private string lastName;

        public Client(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }

        public string GetName()
        {
            return this.name;
        }


        public override string ToString()
        {
            string tmp = this.name + " " + this.lastName;
            return tmp;
        }
    }
}
