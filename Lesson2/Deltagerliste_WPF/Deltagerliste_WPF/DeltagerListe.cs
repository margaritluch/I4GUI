using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltagerliste_WPF
{
    public class DeltagerListe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Available { get; set; }
        public string Origin { get; set; }
        public char StudieNummer { get; set; }
        public char Email { get; set; }

        public DeltagerListe(int id, string name, char studieNummer, char email,string role, string available, string origin )
        {
            ID = id;
            Name = name;
            StudieNummer = studieNummer;
            Email = email;
            Role = role;
            Available = available;
            Origin = origin;
        }
    }
}
