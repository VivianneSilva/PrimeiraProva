using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaFarmacia
{
    public class RemediosRepository
    {
               
            public static Remedios[] InitializeRemedios()
            {
                return new Remedios[]
                {
                    new Remedios ("DORFLEX"),
                    new Remedios ("CONCARDIO"),
                    new Remedios ("ABLOK"),
                    new Remedios ("NEOSALDINA"),
                    new Remedios ("NEOSORO"),
                    new Remedios ("IVERMECTINA")

                };
            }
        
    }
}
