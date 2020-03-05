using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsadMotorsProj1.Entites
{
    class ExpensesInfo
    {
        public int ID { get; set; }
        public int EAmount { get; set; }
        public string EDescription { get; set; }
        public DateTime EDate { get; set; }
        public DateTime DDate { get; set; }
        public bool Validation(int CId)
        {
            if (GetExpensesInfo(CId) != null)
                return true;
            return false;
        }
        public ExpensesInfo GetExpensesInfo(int CId)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from ExpensesInfo 
                              where ID= @CId";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter();

            sqlParameter = new SqlParameter
            {
                ParameterName = "CId",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = CId
            };
            ExpensesInfo expensesInfo = new ExpensesInfo();
            sqlCommand.Parameters.Add(sqlParameter);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                expensesInfo.ID = Int32.Parse(sqlDataReader[0].ToString());
                expensesInfo.EAmount = Int32.Parse(sqlDataReader[1].ToString());
                expensesInfo.EDescription = sqlDataReader[2].ToString();
                expensesInfo.EDate = DateTime.Parse(sqlDataReader[3].ToString());

            }
            return expensesInfo;
        }
        public BindingSource GetExpensesInfoByDate(DateTime EDate)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from ExpensesInfo";
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
        public BindingSource GetExpensesInfoByMonth(int CMonth, int CYear)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from ExpensesInfo  where Month(@CMonth) and Year(@CYear)";
            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CMonth",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = CMonth
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CYear",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = CYear
            };

            sqlCommand.Parameters.Add(sqlParameter);

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
        public BindingSource GetExpensesInfoByYear(int CYear)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from ExpensesInfo  where Year(@CYear)";
            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());
            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CYear",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = CYear
            };

            sqlCommand.Parameters.Add(sqlParameter);

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
        public void InsertExpensesInfo(ExpensesInfo expensesInfo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"insert into expensesinfo(@Amount , @EDescription , @EDate , @DDate)";
            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "Amount",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = expensesInfo.EAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "EDescription",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = expensesInfo.EDescription
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "EDate",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = expensesInfo.EDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "DDate",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = expensesInfo.DDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteExpensesInfo(int CId)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Delete from ExpensesInfo 
                              where ID= @CId";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter();

            sqlParameter = new SqlParameter
            {
                ParameterName = "CId",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = CId
            };

            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.ExecuteNonQuery();
        }
        public void UpdateExpensesInfo(ExpensesInfo expensesInfo, int CId)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Update ExpensesInfo  set Amount = @Amount , EDescription = @EDescription ,
                             EDate = @EDate , DDate = @DDate
                              where ID= @CId";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "Amount",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = expensesInfo.EAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "EDescription",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = expensesInfo.EDescription
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "EDate",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = expensesInfo.EDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "DDate",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = expensesInfo.DDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();
            sqlParameter = new SqlParameter
            {
                ParameterName = "CId",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = CId
            };

            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.ExecuteNonQuery();
        }

    }
}
