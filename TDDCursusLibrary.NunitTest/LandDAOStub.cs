using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

using NUnit.Framework;

namespace TDDCursusLibrary.NunitTest
{
    public class LandDAOStub : ILandDAO
    {
        public Land Read(string landcode)
        {
            return new Land { Landcode = landcode, Oppervlakte = 5 };
        }
        public int OppervlakteAlleLanden()
        {
            return 20;
        }
    }
}
