using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class DADemographicInformation
    {

        public static DataSet GetDemographicsUsingWithOutDB()
        {
            DataSet demographicInfomation = new DataSet();

            demographicInfomation.DataSetName = "Demographics";
            DataTable dt = new DataTable("Basic Information");

            dt.Clear();

            dt.Columns.Add(new DataColumn("FirstName", typeof(string)));
            dt.Columns.Add(new DataColumn("LastName", typeof(string)));
            dt.Columns.Add(new DataColumn("Age", typeof(int)));
            dt.Columns.Add(new DataColumn("Address", typeof(string)));

            DataRow dr = dt.NewRow();
            dr["FirstName"] = "John";
            dr["LastName"] = "Doe";
            dr["Age"] = 45;
            dr["Address"] = "1 station Landing";

            dt.Rows.Add(dr);

            demographicInfomation.Tables.Add(dt);

            return demographicInfomation;

        }

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
