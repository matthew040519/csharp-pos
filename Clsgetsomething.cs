using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Threading;

namespace POS_SYSTEM
{
    class Clsgetsomething
    {
        public string plsGetProductCode, plsGetAutoNumber, plsGetProductDesc, plsGetUnitPrice, plsBranchName, plsBranchAddress;
        connection mysqlconnection = new connection();
        MySqlConnection myconnection;
        MySqlDataReader dr;
        MySqlCommand mycommand;
        private readonly Random _random = new Random();

        public string clsGeProductCode(string strProductCode)
        {

            int randomNum = _random.Next(10000000, 99999999);
            myconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            myconnection.Open();
            mycommand = new MySqlCommand("SELECT product_code FROM tblproduct WHERE product_code=" + strProductCode, myconnection);
            dr = mycommand.ExecuteReader();
            plsGetProductCode = Convert.ToInt32(dr.HasRows) > 0 ? clsGeProductCode(randomNum.ToString()) : randomNum.ToString();

            dr.Close();
            myconnection.Close();

            return plsGetProductCode;
        }


        /*public string UserDetails()
        {
            myconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            myconnection.Open();
            


            myconnection.Close();
        }*/

        public string VoucherAutoNumber(string argvoucher)
        {

                myconnection = new MySqlConnection(mysqlconnection.MyConnection2);
                myconnection.Open();


                mycommand = new MySqlCommand("SELECT COUNT(transaction_id) + 1 as DocNum1 FROM tbltransaction WHERE branch_id ='" + login.branch_code + "' AND Voucher = '" + argvoucher + "'", myconnection);
                dr = mycommand.ExecuteReader();
                if(dr.HasRows)
                {
                    
                    while (dr.Read())
                    {
                        string no1 = null;
                        int no2;
                        no1 = dr["DocNum1"].ToString();
                        no2 = (int.Parse(no1));
                        plsGetAutoNumber = Convert.ToString(no2).PadLeft(7, '0');
                    }
                }
                else
                {
                    plsGetAutoNumber = "0000001";
                }
                dr.Close();
                myconnection.Close();
                
                return plsGetAutoNumber;
        }

        public bool isProductCodeExist(string strProductCode)
        {
            myconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            myconnection.Open();

            mycommand = new MySqlCommand("SELECT product_id FROM tblproduct WHERE product_code ='" + strProductCode + "'", myconnection);
            dr = mycommand.ExecuteReader();

            bool isExist = Convert.ToInt32(dr.HasRows) > 0 ? true : false;

            return isExist;

        }
        public void branchDetails(string strBranch)
        {
            myconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            myconnection.Open();

            mycommand = new MySqlCommand("SELECT branch_name, branch_address FROM tblbranch WHERE branch_id ='" + strBranch + "'", myconnection);
            dr = mycommand.ExecuteReader();

            while (dr.Read())
            {
                plsBranchName = dr["branch_name"].ToString();
                plsBranchAddress = dr["branch_address"].ToString();
            }

        }

        public void getProductDetails(string strProductCode)
        {
            myconnection = new MySqlConnection(mysqlconnection.MyConnection2);
            myconnection.Open();

            mycommand = new MySqlCommand("SELECT * FROM tblproduct WHERE product_code ='" + strProductCode + "'", myconnection);
            dr = mycommand.ExecuteReader();
            while (dr.Read())
            {
                plsGetProductCode = dr["product_code"].ToString();
                plsGetProductDesc = dr["product_name"].ToString();
                plsGetUnitPrice = dr["unit_price"].ToString();
            }
            myconnection.Close();
        }

        public string ClsGetDefaultDate()
        {
            DateTime VarToday = DateTime.Today;
            return String.Format("{0:MM/dd/yyyy}", VarToday);
        }
    }
}
