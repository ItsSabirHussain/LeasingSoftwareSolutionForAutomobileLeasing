using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsadMotorsProj1.Entites
{
    class InstallmentInfo
    {
        public string OLPhone { get; set; }
        public string SEngineNo { get; set; }
        public int IAmount { get; set; }
        public DateTime DDate { get; set; }
        public DateTime IDate { get; set; }

        public bool Validation(string COLPhone, string CSEngine)
        {
            if (GetInstallmentInfo(COLPhone, CSEngine) != null)
                return true;
            return false;
        }
        public void InsertInstallmentInfo(InstallmentInfo installmentInfo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"insert into InstallmentInfo(@OLPhone , @SEnglineNo , @IAmount , @DDate , @IDate)";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "OLPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = installmentInfo.OLPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = installmentInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "IAmount",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = installmentInfo.IAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "DDate",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = installmentInfo.DDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "IDate",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = installmentInfo.IDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();
        }
        public void UpdateLuckyMemberInfo(InstallmentInfo installmentInfo, string COLPhone, string CSEngineNo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Update installmentinfo set 
                            OLPhone = @OLPhone , SEngineNo = @SEngineNo , IAmount = @IAmount
                            , DDate = @DDate , IDate = @IDate
                            where OLPhone = @COLPhone and SEngineNo = @CSEngine";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "OLPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = installmentInfo.OLPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = installmentInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "IAmount",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = installmentInfo.IAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "DDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = installmentInfo.DDate
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlParameter = new SqlParameter
            {
                ParameterName = "IDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = installmentInfo.IDate
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
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteLuckyMemberInfo(string COLPhone, string CSEngineNo)
        {

            SQLConn sQLConn = new SQLConn();
            string query = @"Delete from installmentinfo 
                             where OLPhone = @COLPhone and SEngineNo = @CSEngineNo";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter();

            sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CMPhoe",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = COLPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlCommand.ExecuteNonQuery();
        }
        public InstallmentInfo GetInstallmentInfo(string COLPhone, string CSEngineNo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from InstallmentInfo 
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
                Value = CSEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                InstallmentInfo installmentInfo = new InstallmentInfo
                {
                    OLPhone = sqlDataReader[0].ToString(),
                    SEngineNo = sqlDataReader[0].ToString(),
                    IAmount = Int32.Parse(sqlDataReader[0].ToString()),
                    DDate = DateTime.Parse(sqlDataReader[0].ToString()),
                    IDate = DateTime.Parse(sqlDataReader[0].ToString()),

                };
                return installmentInfo;

            }
            return null;
        }
        public BindingSource GetAllRecords()
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from installmentinfo";
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
