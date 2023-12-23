using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EncuestasDillan
{
    public partial class Encuesta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                if (!IsPostBack) 
            {
                LlenarGrid();
            }

        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr)) 
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Encuestas"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt  = new DataTable())
                        {
                        sda.Fill(dt);
                            datagrid.DataSource = dt;
                            datagrid.Databind();
                        }
                    }
                }
            }
        }
            
        
        
    }

  
    
 }
