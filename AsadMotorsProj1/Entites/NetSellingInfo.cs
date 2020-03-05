using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsadMotorsProj1.Entites
{
    class NetSellingInfo
    {
        public string CCnic { get; set; }
        public string CName { get; set; }
        public string CAddress { get; set; }
        public string CPhone { get; set; }
        public string SEngineNo { get; set; }
        public DateTime CDate { get; set; }
        public int CAmount { get; set; }

        public bool Validation(string CCPhone, string CSEngineNo)
        {
            if (GetNetSellingInfo(CCPhone, CSEngineNo) == null)
                return false;
            return true;

        }


        public void InsertNetSellingInfo(NetSellingInfo netSellingInfo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"insert into NetSellingInfo(CCnic , CName , CAddress , CPhone ,
                            SEngineNo , CDate, CAmount) values(@CCnic , @CName , @CAddress ,
                            @CPhone , @SEngineNo , @CDate , @CAmount)";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CCnic",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.CCnic
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.CName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CAmount",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = netSellingInfo.CAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = netSellingInfo.CDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CAddress",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.CAddress
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.CPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteNetSellingInfo(string CCPhone, string CSEngineNo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"delete from NetSellingInfo 
                             where CPhone = @CCPhone 
                             and SEngineNo = @CSEngineNo";

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
                ParameterName = "CCPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CCPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();


        }
        public void UpdateNetSellingInfo(NetSellingInfo netSellingInfo, string CCPhone, string CSEngineNo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"update  NetSellingInfo 
                             set CCnic = @CCnic , CName = @CName , CAddress = @CAddress ,
                             CPhone = @CPhone , SEngineNo = @SEngineNo , CDate = @CDate ,
                             CAmount = @CAmount
                             where CPhone = @CCPhone 
                             and SEngineNo = @CSEngineNo";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CCnic",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.CCnic
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.CName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CAmount",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = netSellingInfo.CAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = netSellingInfo.CDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CAddress",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.CAddress
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = netSellingInfo.CPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CCPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CCPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();
        }
        public NetSellingInfo GetNetSellingInfo(string CCPhone, string CSEngineNo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Select * From NetSellingInfo Where CPhone = @CCPhone 
                             and SEngineNo = @CSEngineNo";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());


            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CCPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CCPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                NetSellingInfo netSellingInfo = new NetSellingInfo
                {
                    CCnic = sqlDataReader[0].ToString(),
                    CName = sqlDataReader[1].ToString(),
                    CAddress = sqlDataReader[2].ToString(),
                    CPhone = sqlDataReader[3].ToString(),
                    SEngineNo = sqlDataReader[4].ToString(),
                    CDate = DateTime.Parse(sqlDataReader[5].ToString()),
                    CAmount = Int32.Parse(sqlDataReader[6].ToString())
                };

                return netSellingInfo;
            }
            return null;
        }
        public BindingSource GetAllNetSellingInfo()
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from NetSellingInfo";
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
