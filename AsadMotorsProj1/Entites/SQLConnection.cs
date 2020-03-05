using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;

namespace AsadMotorsProj1.Entites
{
    class SQLConn 
    {
        private string connString = System.Configuration.ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
        private SqlConnection sqlConnection = new SqlConnection();
        
        /// <summary>
        /// For closing conncetion
        /// </summary>
        public void ConnClose()
        {
            if(sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
        /// <summary>
        /// Get connection methon to local db
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetConnToLocalDb()
        {
            sqlConnection.ConnectionString = connString;
            sqlConnection.Open();
            return sqlConnection;


        }
    }
}
