using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{

    public class LandService
    {
        private readonly ILandDAO landDAO;
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
        public decimal VindVerhoudingOppervlakteLandTovOppervlakteAlleLanden(string landcode)
        {
            //throw new NotImplementedException();
            var land = landDAO.Read(landcode);
            var oppervlakteAlleLanden = landDAO.OppervlakteAlleLanden();
            return (decimal)land.Oppervlakte / oppervlakteAlleLanden;
        }
    }


}
