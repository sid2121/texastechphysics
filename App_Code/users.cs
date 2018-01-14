using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;
/// <summary>
/// Summary description for users
/// </summary>

public class users
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
    public bool login_valid(string username, string password)
    {

        SqlCommand login = new SqlCommand("select count(*) from loginusers where username=@Username and password=@Password",
            con);
        login.Parameters.AddWithValue("@Username", username);
        login.Parameters.AddWithValue("@Password", password);
        con.Open();


        int count = Convert.ToInt32(login.ExecuteScalar());
        con.Close();
        if (count > 0)
        {
            return true;


        }
        else
        {
            return false;
        }



    }
}
    
