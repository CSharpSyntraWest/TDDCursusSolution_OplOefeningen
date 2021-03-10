using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    public class KostDAOStub : IKostDAO
    {
        public decimal TotaleKost()
        {
            return 169m;
        }
    }
}
