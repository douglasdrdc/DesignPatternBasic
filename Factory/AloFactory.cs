using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Factory
{
    public enum Idioma
    {
        english,
        german,
        spanish
    }

    public class AloFactory
    {
        public IAloMundo CriaAloMundo(Idioma idioma )
        {
            switch (idioma)
            {
                case Idioma.english:
                    return new EnglishAloMundo();
                case Idioma.german:
                    return new GermanAloMundo();
                case Idioma.spanish:
                    return new SpanishAloMundo();
                default:
                    return null;
            }
        }
    }
}
