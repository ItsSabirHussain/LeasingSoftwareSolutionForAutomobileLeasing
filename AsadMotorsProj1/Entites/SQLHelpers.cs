using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsadMotorsProj1.Entites
{
    class SQLHelpers : SQLConn, IDisposable
    {
        public void Dispose()
        {
            ConnClose();
        }


        public void InsertMembersInfo(MembersInfo membersInfo)
        {
            string query = @"insert into MembersInfo(MCnic , MName , MAddress , MPhone ) values(@MCnic , @MName , @MAddress , @MPhone)";

            SqlCommand sqlCommand = new SqlCommand(query, GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "MCnic",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = membersInfo.MCnic
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = membersInfo.MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MAddress",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = membersInfo.MAddress
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = membersInfo.MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();

        }
        public MembersInfo GetMembersInfo(string MPhone, string MName)
        {
            SQLConn sQLConn = new SQLConn();

            string query = @"select * from membersinfo where MPhone = @MPhone and MName = @MName";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "MPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                MembersInfo membersInfo = new MembersInfo
                {
                    MCnic = sqlDataReader[0].ToString(),
                    MName = sqlDataReader[1].ToString(),
                    MAddress = sqlDataReader[2].ToString(),
                    MPhone = sqlDataReader[3].ToString()

                };
                return membersInfo;
            }
            return null;
        }
        public void UpdateMembersInfo(MembersInfo membersInfo, string CName, string CPhone)
        {
            string query = @"update MembersInfo set MCnic=@MCnic , MName=@MName , MAddress=@MAddress , MPhone=@MPhone Where MPhone = @CPhone and MName = @CName";

            SqlCommand sqlCommand = new SqlCommand(query, GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MCnic",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = membersInfo.MCnic
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = membersInfo.MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MAddress",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = membersInfo.MAddress
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = membersInfo.MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();

        }
        public BindingSource GetAllMembers()
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from membersinfo";
            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            sqlDataAdapter.Fill(dataTable);
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            sqlDataAdapter.Update(dataTable);
            return bindingSource;
        }
        public void DeleteMembersInfo(string CPhone, string CName)
        {
            string query = @"delete from MembersInfo Where MPhone = @CPhone and MName = @CName";
            SqlCommand sqlCommand = new SqlCommand(query, GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CName
            };
            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();

        }

        public BindingSource GetAllDailyCommittee(DateTime CCDate)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select MPhone , MName , CAmount , CDate from committeeinfo
                             where ddate = @ccdate";
            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = new SqlParameter
            {
                ParameterName = "CCDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = CCDate
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

        public string GetDailyCommitteeSum(DateTime CCDate)
        {
            string query = @"select sum(camount) from committeeinfo 
                             Where DDate = @CCDate";
            SqlCommand sqlCommand = new SqlCommand(query, GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CCDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = CCDate
            };

            sqlCommand.Parameters.Add(sqlParameter);


            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
              return sqlDataReader[0].ToString();
            }
            return null;

        }

        public BindingSource GetAllMonthlyCommittee(string CMonth, string CYear)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select MPhone , MName , CAmount , CDate from committeeinfo
                             where Month(CDate)=@CMonth and Year(CDate) = @CYear";
            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CMonth",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Int32.Parse(CMonth)
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlParameter = new SqlParameter
            {
                ParameterName = "CYear",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Int32.Parse(CYear)
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

        public string GetMonthlyCommitteeSum(string CMonth , string CYear)
        {
            string query = @"select sum(camount) from committeeinfo 
                             Where Month(CDate)=@CMonth and Year(CDate) = @CYear";
            SqlCommand sqlCommand = new SqlCommand(query, GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CMonth",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Int32.Parse(CMonth)
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlParameter = new SqlParameter
            {
                ParameterName = "CYear",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Int32.Parse(CYear)
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                return sqlDataReader[0].ToString();
            }
            return null;

        }

        public CommitteeInfo GetMCommitteeDateWise(string CMPHone, string CMName, DateTime CCDate)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from CommitteeInfo 
                             where  ddate = @ccdate and MPhone = @CMPhone and MName = @CMName ";

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
                SqlDbType = System.Data.SqlDbType.Date,
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

        public BindingSource GetMCommitteeMonthWise(string CMPhone , string CMName , string CMonth , string CYear)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select MPhone , MName , CAmount , CDate from committeeinfo
                             where MPhone = @CMPhone and MName = @CMName and Month(CDate) = @CMonth and Year(CDate) = @CYear";
            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = new SqlParameter
            {
                ParameterName = "CMonth",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Int32.Parse(CMonth)
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CYear",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Int32.Parse(CYear)
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
        public string GetMCommitteeSumMonthWise(string CMPhone, string CMName, string CMonth, string CYear)
        {
            string query = @"select sum(camount) from committeeinfo
                             where MPhone = @CMPhone and MName = @CMName and Month(CDate) = @CMonth and Year(CDate) = @CYear";
            SqlCommand sqlCommand = new SqlCommand(query, GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CMonth",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Int32.Parse(CMonth)
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlParameter = new SqlParameter
            {
                ParameterName = "CYear",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = Int32.Parse(CYear)
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

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                return sqlDataReader[0].ToString();
            }
            return null;

        }

        public string GetMCommitteeTotalSum(string CMPhone, string CMName)
        {
            string query = @"select sum(camount) from committeeinfo
                             where MPhone = @CMPhone and MName = @CMName";
            SqlCommand sqlCommand = new SqlCommand(query, GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
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

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                return sqlDataReader[0].ToString();
            }
            return null;

        }

        public BindingSource AllSellingInfo(int CMonth, int CYear) 
        {
            string query = @"select SEngineNo as 'Engine No' ,
                             SDate as 'Buy Date' , CDate as 'Sell Date' from StockInfo natural join netsellinginfo
                             where Month(CDate) = @CMonth and Year(CDate) = @CYear ";
            SqlCommand sqlCommand = new SqlCommand(query, GetConnToLocalDb());

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


    }
}
