using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Factory
{
    public class GermanAloMundo : IAloMundo
    {
        public string FalaAlo()
        {
            return "Hallo Welt";
        }
    }
}
