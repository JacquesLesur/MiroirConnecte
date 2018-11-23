using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroirConnecte.Model
{
    class KaamelottResponse
    {
        public int status { get; set; }
        public Citation Citation { get; set; }

    }
    public class Infos
    {

        public string auteur { get; set; }
        public string acteur { get; set; }
        public string personnage { get; set; }
        public string saison { get; set; }
        public string episode { get; set; }
    }
    public class Citation
    {
        public string citation { get; set; }
        public Infos infos { get; set; }
    }
    
}
