using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsadMotorsProj1.Entites
{
    class StockInfo
    {
        public string SEngineNo { get; set; }
        public string SChassisNo { get; set; }
        public string SCompany { get; set; }
        public string SModel { get; set; }
        public int SAmount { get; set; }
        public string SRegNo { get; set; }
        public string SFileNo { get; set; }
        public DateTime SDate { get; set; }
        public int CopyRecived { get; set; }
        public int LetterRecived { get; set; }

        public bool StockValidation(string SCEngineNo)
        {
            if (GetStockInfo(SCEngineNo) == null)
            {
                return false;
            }
            else
                return true;
        }
        public void InsertStockInfo(StockInfo stockInfo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"insert into StockInfo(
                           SEngineNo , SChassisNo , SCompany , SModel , SAmount , SRegNo
                           , SFileNo , SDate , CopyRecived , LetterRecived ) 
                           values(@SEngineNo , @SChassisNo , @SCompany , @SModel , @SAmount , @SRegNo 
                           , @SFileNo , @SDate , @CopyRecived , @LetterRecived)";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SChassisNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SChassisNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SCompany",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SCompany
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SModel",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SModel
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SAmount",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = stockInfo.SAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SRegNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SRegNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SFileNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SFileNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = stockInfo.SDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CopyRecived",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = stockInfo.CopyRecived
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "LetterRecived",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = stockInfo.LetterRecived
            };

            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.ExecuteNonQuery();

        }
        public StockInfo GetStockInfo(string SEngine)
        {
            SQLConn sQLConn = new SQLConn();

            string query = @"select * from stockinfo where SEngineNo = @SEngineNo";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = SEngine
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                StockInfo stockInfo = new StockInfo()
                {
                    SEngineNo = sqlDataReader[0].ToString(),
                    SChassisNo = sqlDataReader[1].ToString(),
                    SCompany = sqlDataReader[2].ToString(),
                    SModel = sqlDataReader[3].ToString(),
                    SAmount = Int32.Parse(sqlDataReader[4].ToString()),
                    SRegNo = sqlDataReader[5].ToString(),
                    SFileNo = sqlDataReader[6].ToString(),
                    SDate = DateTime.Parse(sqlDataReader[7].ToString()),
                    CopyRecived = Int32.Parse(sqlDataReader[8].ToString()),
                    LetterRecived = Int32.Parse(sqlDataReader[9].ToString()),
                };
                return stockInfo;
            }
            return null;
        }
        public void UpdateRecord(StockInfo stockInfo, string CSEngineNo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"update stockinfo set
                            SEngineNo = @SEngineNo , SChassisNo = @SChassisNo , SCompany = @SCompany
                            , SModel = SModel , SAmount = SAmount , SRegNo = SRegNo
                            , SFileNo = @SFileNo , SDate = @SDate , CopyRecived = @CopyRecived
                            , LetterRecived = @LetterRecived  Where SEngineNo = @CSEngineNo";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SEngineNo
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
                ParameterName = "SChassisNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SChassisNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SCompany",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SCompany
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SModel",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SModel
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SAmount",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = stockInfo.SAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SRegNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SRegNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SFileNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = stockInfo.SFileNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = stockInfo.SDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CopyRecived",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = stockInfo.CopyRecived
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "LetterRecived",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = stockInfo.LetterRecived
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();

        }
        public void DeleteRcord(string CSEngine)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"delete from StockInfo Where SEngineNo = @SCEngineNo";
            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "SCEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngine
            };

            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.ExecuteNonQuery();

        }
        public BindingSource GetAllRecords()
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from StockInfo";
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
