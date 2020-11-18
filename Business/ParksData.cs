using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Business
{
    public class ParksData
    {
        public static List<Park> GetParksInformation()
        {
            Park ParkInfo = new Park();
            var ParksList = new List<Park>();
            DataSet parksDataSet = new DataSet();

            // 2nd Assignment - Get Parks from DB with Config in Web.config file
            //parksDataSet = ParkDA.GetParksWithoutDB();

            // From DB configured in Web.config
            parksDataSet = ParkDA.GetParksWithConfig();

            // From DB hardcoded connection string
            //parksDataSet = ParkDA.GetParksWithOutConfig();

            if (parksDataSet.Tables.Count > 0)
            {
                ParksList = parksDataSet.Tables[0].AsEnumerable().Select(m => new Park
                {
                    //Left side is Model Object - Right Side is Database columns
                    Id = Convert.ToInt32(m["Id"]),
                    Name = Convert.ToString(m["Name"]),
                    Location = Convert.ToString(m["Location"]),
                    Description = Convert.ToString(m["Description"]),
                    Rank = Convert.ToInt32(m["Rank"]),
                    PhotoPath = Convert.ToString(m["PhotoPath"])
                }).ToList();
            }
            return ParksList;
          
        }
    }
}
