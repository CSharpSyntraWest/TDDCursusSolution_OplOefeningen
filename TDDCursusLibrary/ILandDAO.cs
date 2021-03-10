using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public interface ILandDAO
    {
        Land Read(string landcode);
        int OppervlakteAlleLanden();
    }
}
