using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsadMotorsProj1.Entites
{
    class OutsiderLeasesInfo
    {
        public string OLCnic { get; set; }
        public string OLName { get; set; }
        public string OLAddress { get; set; }
        public string OLPhone { get; set; }
        public string SEngineNo { get; set; }
        public int OLAdvance { get; set; }
        public int OLAmount { get; set; }
        public int OLDuration { get; set; }
        public int OLInstallment { get; set; }
        public DateTime OLDate { get; set; }

        public bool Validation(string COLPhone, string CSEngine)
        {
            if (GetOutsiderLeasesInfo(COLPhone, CSEngine) != null)
                return true;
            return false;
        }
        public OutsiderLeasesInfo GetOutsiderLeasesInfo(string COLPhone, string CSEngine)
        {

            SQLConn sQLConn = new SQLConn();

            string query = @"select * from OutsiderLeasesInfo where 
                                SEngineNo = @CSEngineNo and OLPhone = @COLPhone";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngine
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "COLPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = COLPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                OutsiderLeasesInfo outsiderLeasesInfo = new OutsiderLeasesInfo
                {
                    OLCnic = sqlDataReader[0].ToString(),
                    OLName = sqlDataReader[1].ToString(),
                    OLPhone = sqlDataReader[2].ToString(),
                    OLAddress = sqlDataReader[3].ToString(),
                    SEngineNo = sqlDataReader[4].ToString(),
                    OLAmount = Int32.Parse(sqlDataReader[5].ToString()),
                    OLDuration = Int32.Parse(sqlDataReader[6].ToString()),
                    OLAdvance = Int32.Parse(sqlDataReader[7].ToString()),
                    OLInstallment = Int32.Parse(sqlDataReader[8].ToString()),
                    OLDate = DateTime.Parse(sqlDataReader[9].ToString()),
                };
                return outsiderLeasesInfo;
            }
            return null;
        }
        public void InsertOutsiderLeasesInfo(OutsiderLeasesInfo outsiderLeasesInfo)
        {
            SQLConn sQLConn = new SQLConn();

            string query = @"insert into OutsiderLeasesInfo (OLCnic , OLName , OLPhone , OLAddress,
                            SEngineNo , OLAmount , OLDuration , OLAdvance , OLInstallment , OLDate) 
                            values(@OLCnic , @OLName , @OLPhone , @OLAddress , 
                           @SEngineNo , @OLAmount , @OLDuration , @OLAdvance , @OLInstallment , @OLDate)";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "OLCnic",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.OLCnic
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.OLName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.OLPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLAddress",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.OLAddress
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLAmount",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = outsiderLeasesInfo.OLAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLDuration",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = outsiderLeasesInfo.OLDuration
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLAdvance",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = outsiderLeasesInfo.OLAdvance
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLInstallment",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = outsiderLeasesInfo.OLInstallment
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = outsiderLeasesInfo.OLDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteOutsiderLeasesInfo(string COLPhone, string CSEngine)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Delete from OutsiderLeasesInfo 
                              where OLPhone= @COLPhone and SEngineNo = @CSEngineNo";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter();

            sqlParameter = new SqlParameter
            {
                ParameterName = "COLPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = COLPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngine
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();
        }
        public void UpdateOutsiderLeasesInfo(OutsiderLeasesInfo outsiderLeasesInfo, string COLPhone, string CSEngine)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Update OutsiderLeasesInfo set
                           OLCnic = @OLCnic, OLName = @OLName, OLPhone = @OLPhone
                           , OLAdvance = @OLAdvance, OLAmount = @OLAmount , OLDuration = @OLDuration,
                           OLInstallment = @OLInstallment , OLDate = @OLDate
                             where OLPhone = @COLPhone and SEngineNo = @CSEngineNo";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "OLCnic",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.OLCnic
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.OLName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLInstallment",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.OLInstallment
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.OLPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLAddress",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.OLAddress
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLAmount",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = outsiderLeasesInfo.OLAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLDuration",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = outsiderLeasesInfo.OLDuration
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLAdvance",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = outsiderLeasesInfo.OLAdvance
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = outsiderLeasesInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "OLDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = outsiderLeasesInfo.OLDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "COLPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = COLPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = CSEngine
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlCommand.ExecuteNonQuery();
        }
        public BindingSource GetAllOutsiderLeasesInfo()
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from OutsiderLeasesInfo";
            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
            {
                SelectCommand = sqlCommand
            };
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource
            {
                DataSource = dataTable
            };
            sqlDataAdapter.Update(dataTable);
            return bindingSource;
        }


    }
}
