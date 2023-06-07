using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace POS_SYSTEM
{
    class ClsComboBox
    {
        public ArrayList ALCategory = new ArrayList();
        public ArrayList ALSupplier = new ArrayList();
        public ArrayList ALProduct = new ArrayList();
        connection mysqlconnection = new connection();
        MySqlConnection myconnection;
        MySqlDataReader dr;
        MySqlCommand mycommand;

        public void ClsBuildCategory()
        {
            try
            {
                myconnection = new MySqlConnection(mysqlconnection.MyConnection2);
                myconnection.Open();
                mycommand = new MySqlCommand("SELECT category_id, category_name FROM tblcategory", myconnection);
                dr = mycommand.ExecuteReader();

                while (dr.Read())
                {
                    ALCategory.Add(new Clsaddvalue(dr.GetString(1), dr.GetString(0)));
                }
                dr.Close();
                myconnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                myconnection.Close();
            }
        }

        public void ClsBuildSupplier()
        {
            try
            {
                myconnection = new MySqlConnection(mysqlconnection.MyConnection2);
                myconnection.Open();
                mycommand = new MySqlCommand("SELECT supplier_id, supplier_name FROM tblsupplier", myconnection);
                dr = mycommand.ExecuteReader();

                while (dr.Read())
                {
                    ALSupplier.Add(new Clsaddvalue(dr.GetString(1), dr.GetString(0)));
                }
                dr.Close();
                myconnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                myconnection.Close();
            }
        }

        public void ClsBuildProduct()
        {
            try
            {
                myconnection = new MySqlConnection(mysqlconnection.MyConnection2);
                myconnection.Open();
                mycommand = new MySqlCommand("SELECT product_code, product_name FROM tblproduct", myconnection);
                dr = mycommand.ExecuteReader();

                while (dr.Read())
                {
                    ALProduct.Add(new Clsaddvalue(dr.GetString(1), dr.GetString(0)));
                }
                dr.Close();
                myconnection.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                myconnection.Close();
            }
        }
    }
}
