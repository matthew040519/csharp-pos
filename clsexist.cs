using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    class Clsexist
    {
        public bool RecordExists(ref MySqlConnection _MysqlConnection, string _Sql)
        {
            MySqlDataReader _SqlDataReader = null;
            try
            {
                // Pass the connection to a command object  

                MySqlCommand _MysqlCommand

                        = new MySqlCommand(_Sql, _MysqlConnection);
                // get query results  
                _SqlDataReader = _MysqlCommand.ExecuteReader();
            }

            catch (Exception)
            {
                return false;
            }

            if (_SqlDataReader != null && _SqlDataReader.Read())
            {
                // close Sql reader before exit  

                if (_SqlDataReader != null)
                {
                    _SqlDataReader.Close();

                    _SqlDataReader.Dispose();

                }

                // record found  

                return true;
            }
            else
            {
                // close Sql reader before exit  

                if (_SqlDataReader != null)
                {
                    _SqlDataReader.Close();

                    _SqlDataReader.Dispose();
                }

                // record not found  
                return false;
            }


        }

    }
}
