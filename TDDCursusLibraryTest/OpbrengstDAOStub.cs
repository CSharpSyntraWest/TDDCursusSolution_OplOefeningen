using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    public class OpbrengstDAOStub : IOpbrengstDAO
    {
        public decimal TotaleOpbrengst()
        {
            return 200m;
        }
    }
}
