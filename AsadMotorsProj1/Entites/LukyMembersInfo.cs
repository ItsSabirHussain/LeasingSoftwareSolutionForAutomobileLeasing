using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsadMotorsProj1.Entites
{
    class LukyMembersInfo
    {
        public string MPhone { get; set; }
        public string MName { get; set; }
        public string SEngineNo { get; set; }
        public DateTime LDate { get; set; }
        public bool Validation(string CSEngine, string CMPhone)
        {
            if (GetLuckyMemberInfo(CSEngine, CMPhone) == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public void InsertLuckyMemberInfo(LukyMembersInfo lukyMembersInfo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"insert into LuckyMemberInfo(MPhone , MName , SEngineNo ,LDate ) 
                             values(@MPhone , @MName , @SEngineNo  , @LDate)";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "MPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = lukyMembersInfo.MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = lukyMembersInfo.MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = lukyMembersInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "LDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = lukyMembersInfo.LDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();
        }
        public void UpdateLuckyMemberInfo(LukyMembersInfo lukyMembersInfo, string CSEngine, string CMPhone)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Update LuckyMemberInfo set 
                            MPhone = @MPhone , MName = @MName , SEngineNo = @SEngineNo
                            ,LDate = @LDate 
                            where Mphone = @CMPhone and SEngineNo = @CSEngine";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "MPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = lukyMembersInfo.MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = lukyMembersInfo.MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = lukyMembersInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "LDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = lukyMembersInfo.LDate
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngine
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CMPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteLuckyMemberInfo(string CSEngine, string CMPhone)
        {

            SQLConn sQLConn = new SQLConn();
            string query = @"Delete from LuckyMemberInfo 
                             where Mphone = @CMPhone and SEngineNo = @CSEngine";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter();

            sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngine
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CMPhoe",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlCommand.ExecuteNonQuery();
        }
        public LukyMembersInfo GetLuckyMemberInfo(string CSEngine, string CMPhone)
        {
            SQLConn sQLConn = new SQLConn();

            string query = @"select * from luckymemberinfo where MPhone = @CMPhone and SEngine = @ESEngine";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CMPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                LukyMembersInfo luckyMembersInfo = new LukyMembersInfo
                {
                    MName = sqlDataReader[0].ToString(),
                    MPhone = sqlDataReader[1].ToString(),
                    SEngineNo = sqlDataReader[2].ToString(),
                    LDate = DateTime.Parse(sqlDataReader[4].ToString())

                };
                return luckyMembersInfo;
            }
            return null;
        }
        public BindingSource GetAllLuckyMemberInfo()
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from luckymemberinfo";
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
    }
}
