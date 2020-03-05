using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AsadMotorsProj1.Entites
{
    class MemberLeasesInfo
    {
        public string MPhone { get; set; }
        public string MName { get; set; }
        public string SEngineNo { get; set; }
        public int MLAdvance { get; set; }
        public DateTime MLDate { get; set; }
        public bool Validation(string CSEngine, string CMPhone)
        {
            if (GetMemberleasesInfo(CSEngine, CMPhone) == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public void InsertMemberLeaseInfo(MemberLeasesInfo memberLeasesInfo)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"insert into MemberlesesInfo(MPhone , MName , SEngineNo , LAdvance ,LDate ) 
                             values(@MPhone , @MName , @SEngineNo , @LAdvance , @LDate)";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "MPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = memberLeasesInfo.MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = memberLeasesInfo.MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = memberLeasesInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "LAdvance",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = memberLeasesInfo.MLAdvance
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "LDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = memberLeasesInfo.MLDate
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlCommand.ExecuteNonQuery();
        }
        public void UpdateMemberLeasesInfo(MemberLeasesInfo memberLeasesInfo, string CSEngine, string CMPhone)
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"Update  MemberlesesInfo set
                            MPhone = @MPhone , MName = @MName , SEngineNo = @SEngineNo
                            , LAdvance = @LAdvance ,LDate = @LDate 
                             where Mphone = @CMPhone and SEngineNo = @CSEngine";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "MPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = memberLeasesInfo.MPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "MName",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = memberLeasesInfo.MName
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "SEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = memberLeasesInfo.SEngineNo
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "LAdvance",
                SqlDbType = System.Data.SqlDbType.Int,
                Value = memberLeasesInfo.MLAdvance
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "LDate",
                SqlDbType = System.Data.SqlDbType.Date,
                Value = memberLeasesInfo.MLDate
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngine",
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
        public void DeleteMemberLeasesInfo(string CSEngine, string CMPhone)
        {

            SQLConn sQLConn = new SQLConn();
            string query = @"Delete from MemberLesesInfo 
                             where Mphone = @CMPhone and SEngineNo = @CSEngineNo";

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
                ParameterName = "CMPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);


            sqlCommand.ExecuteNonQuery();
        }
        public MemberLeasesInfo GetMemberleasesInfo(string CSEngine, string CMPhone)
        {
            SQLConn sQLConn = new SQLConn();

            string query = @"select * from memberlesesinfo where MPhone = @CMPhone and SEngineNo = @CSEngineNo";

            SqlCommand sqlCommand = new SqlCommand(query, sQLConn.GetConnToLocalDb());

            SqlParameter sqlParameter = new SqlParameter
            {
                ParameterName = "CMPhone",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CMPhone
            };

            sqlCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter
            {
                ParameterName = "CSEngineNo",
                SqlDbType = System.Data.SqlDbType.NVarChar,
                Value = CSEngine
            };

            sqlCommand.Parameters.Add(sqlParameter);

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                MemberLeasesInfo memberLeasesInfo = new MemberLeasesInfo
                {
                    MName = sqlDataReader[0].ToString(),
                    MPhone = sqlDataReader[1].ToString(),
                    SEngineNo = sqlDataReader[2].ToString(),
                    MLAdvance = Int32.Parse(sqlDataReader[3].ToString()),
                    MLDate = DateTime.Parse(sqlDataReader[4].ToString())

                };
                return memberLeasesInfo;
            }
            return null;
        }
        public BindingSource GetAllMemberLeasesInfo()
        {
            SQLConn sQLConn = new SQLConn();
            string query = @"select * from memberlesesinfo";
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
