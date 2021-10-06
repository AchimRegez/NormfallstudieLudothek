using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormfallstudieLudothek
{
    public class Clients
    {
        private static Clients _instance;

        // Generiert Klientenliste
        private List<string> clientsList = new List<string>()
        {
            "Hans Nötig",
            "Max Muster",
            "Anna Lasskrache",
            "Doreen Eichmann",
            "Sara Baer",
            "Johanna Koenig",
            "Petra Sommer",
            "Ulrike Fleischer",
            "Dieter Maurer",
            "Leon Schulz",
            "Andrea Pfeiffer",
            "Vanessa Abend",
            "Mario Schmitz",
            "Marko Hoover",
            "Kristian Baumgartner",
        };

        
        private List<Client> cl = new List<Client>();

        // Macht aus Klientenliste ein Objekt
        public Clients()
        {
            foreach (var client in clientsList)
            {
                string[] tmp = client.Split(" ");
                Client c = new Client(tmp[0], tmp[1]);
                cl.Add(c);
            }
        }
	

        // Initialisiere Klientenliste
        public void InitializeListOfClients()
        {
            //clientsList.Sort();
            var sortedcl = this.cl.OrderBy(x => x.GetName());
            foreach (var c in sortedcl)
                Console.WriteLine(c);
        }

        // Hinzufügen eines neuen Klienten in Liste
        public void AddNewClientToList()
        {
            Console.WriteLine("Bitte geben Sie den Namen ein: ");
            string newClientName = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie den Nachnamen ein: ");
            string newClientLastName = Console.ReadLine();

            //Client a = new Client(newClientName, newClientLastName);
            //cl.Add(a);

            cl.Add(new Client(newClientName, newClientLastName));

            Console.WriteLine("Neuer Kunde {0} {1} wurde hinzugefügt.", newClientName, newClientLastName);
        }
    }
}
