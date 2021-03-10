using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDCursusLibrary
{


    public class Statistiek
    {
        public static decimal Gemiddelde(decimal[] getallen)
        {
            if (getallen == null)
                throw new ArgumentNullException();
            if (getallen.Length == 0)
                throw new ArgumentException();
            var totaal = decimal.Zero;
            foreach (var getal in getallen)
                totaal += getal;
            return totaal / getallen.Length;
            //of met de linq methode: return getallen.Average();
        }
    }
}
