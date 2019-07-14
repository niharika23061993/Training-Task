using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Data;

public partial class BankEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Submit_Click(object sender, EventArgs e)
    {
        SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-SG6T276;Initial Catalog=MX_CKB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        cn.Open();
        //string Query = "insert into Login(UserName,Password) values ('" + TextBox1.Text + "','" + TextBox2.Text + "')";
        //SqlCommand cmd = new SqlCommand(Query, cn);
        //cmd.ExecuteNonQuery();
        //cn.Close();
        //Response.Write("<h1>saved</h1>");
        string UserName = TextBox1.Text;
        string Password = TextBox2.Text;
        
        SqlCommand cmd = new SqlCommand("select UserName,Password from Login where UserName='" + TextBox1.Text + "'and Password='" + TextBox2.Text + "'", cn);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            Label2.Visible = false;
            Label1.Visible = true;
            
        }
        else
        {
            Label1.Visible = false;
            Label2.Visible = true;
            
        }
        cn.Close();

    }

    
}