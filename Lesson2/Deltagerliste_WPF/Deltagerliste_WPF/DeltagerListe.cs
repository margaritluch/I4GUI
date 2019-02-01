using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deltagerliste_WPF
{
    public class DeltagerListe
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string StudieNummer { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Available { get; set; }
        public string Origin { get; set; }
        
        public DeltagerListe(string id, string name, string studieNummer, string email,string role, string available, string origin )
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
