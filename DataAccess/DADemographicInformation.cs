using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class DADemographicInformation
    {

        public static DataSet GetDemographicsUsingWithConfig()
        {
            DataTable dt = new DataTable();
            DataSet demographicInfomation = new DataSet();

            SqlConnection cnn;
            var cs = ConfigurationManager.ConnectionStrings["DemographicsConnection_DEV"].ConnectionString;
            cnn = new SqlConnection(cs);

            cnn.Open();
            string sql = "Select * from InduvidualDemographics";

            SqlCommand command;

            command = new SqlCommand(sql, cnn);

            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();


            dt.Load(dataReader);

            demographicInfomation.Tables.Add(dt);


            dataReader.Close();
            command.Dispose();

            cnn.Close();

            return demographicInfomation;

        }


    }
}
