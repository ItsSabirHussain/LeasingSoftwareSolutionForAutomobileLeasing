using System;
using System.Data.SqlClient;

namespace AsadMotorsProj1.Entites
{
    class CommitteeInfo
    {
        public string MPhone { get; set; }
        public string MName { get; set; }
        public int CAmount { get; set; }
        public DateTime CDate { get; set; }
        public DateTime DDate { get; set; }

        public void InsertCommitteeInfo(CommitteeInfo committeeInfo)
        {
            SQLConn sQLConn = new SQLConn();

            string query = @"insert into CommitteeInfo(MPhone , MName , CAmount , CDate , DDate) values(@MPhone , @MName , @CAmount , @CDate , @DDate)";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "MPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = committeeInfo.MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = committeeInfo.MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CAmount",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = committeeInfo.CAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = committeeInfo.CDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "DDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = committeeInfo.DDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();

        }
        public bool CheckExistence(CommitteeInfo committeeInfo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from CommitteeInfo 
                             where MPhone = @CMPhone and MName = @CMName and CDate = @CCDate and CAmount = @CAmount";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CMPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = committeeInfo.MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CMName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = committeeInfo.MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CCDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = committeeInfo.CDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CAmount",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = committeeInfo.CAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                return true;
            }
            return false;
        }
        public CommitteeInfo GetCommitteeInfo(string CMPHone, string CMName, DateTime CCDate)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from CommitteeInfo 
                             where MPhone = @CMPhone and MName = @CMName and CDate = @CCDate";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CMPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMPHone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CMName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CCDate",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CCDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.Read())
            {
                CommitteeInfo committeeInfo = new CommitteeInfo
                {
                    MPhone = sqlDataReader[0].ToString(),
                    MName = sqlDataReader[1].ToString(),
                    CAmount = Int32.Parse(sqlDataReader[2].ToString()),
                    DDate = DateTime.Parse(sqlDataReader[3].ToString()),
                    CDate = DateTime.Parse(sqlDataReader[4].ToString())
                };

                return committeeInfo;
            }
            return null;
        }

        public void UpdateCommitteInfo(int CCAmount, string CMPhone, string CMName, DateTime CCDate)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Update CommitteeInfo  set
                             CAmount = @CAmount
                              where MPhone = @CMPhone and MName = @CMName and CDate = @CCDate";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = new SqlParameter
            {
                ParameterName = "CAmount",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = CCAmount
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CCDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = CCDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CMPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMPhone
            };
            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CMName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMName
            };

            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteExpensesInfo(string CMPhone, string CMName, DateTime CCDate)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Delete from CommitteeInfo 
                              where MPhone= @CMPhone and MName = @CMName and CDate = @CCDate";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter();

            sqlParameter = new SqlParameter
            {
                ParameterName = "CMName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CMPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMPhone
            };


            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CCDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = CCDate
            };


            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.ExecuteNonQuery();
        }

    }
}

