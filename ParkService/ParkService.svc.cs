using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using DataAccess;
namespace ParkService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ParkService : IParkService
    {
        public DataSet GetParksWithConfig()
        {
            return ParkDA.GetParksWithConfig();

        }

        public DataSet GetParksWithOutConfig()
        {
            return ParkDA.GetParksWithOutConfig();
        }

        public DataSet GetParksWithoutDB()
        {
            return ParkDA.GetParksWithoutDB();
        }
    }
}
