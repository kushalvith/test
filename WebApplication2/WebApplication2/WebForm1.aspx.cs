using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

            con.Open();
            string query = "select * from ContactDet";
            SqlDataAdapter adp  = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();
            adp.Fill(ds,"ContactDet");
            con.Close();
            show.DataSource = ds.Tables[0];
            show.DataBind();            
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd= new SqlCommand("insert into ContactDet (Name,Mobile,Address) values ('"+Name.Text+"','"+Mobile.Text+"','"+Address.Text+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("https://www.google.com/");



        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ContactDet where  Name= '" + Name.Text + "'", con); 
            cmd.ExecuteNonQuery();
            con.Close();




        }

        protected void show_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}