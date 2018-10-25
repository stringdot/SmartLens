using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLens
{
    class Buletin
    {
        string CNP { get; set; }
        string Nume { get; set; }
        string Prenume { get; set; }
        string Cetatenie { get; set; }
        string PrenumeMama { get; set; }
        string PrenumeTata { get; set; }
        Domiciliu Domiciliu { get; set; }
        LoculNasterii LoculNasterii { get; set; }
        string EmisDePolitia { get; set; }
        string Valabilitate { get; set; }
    }

}
