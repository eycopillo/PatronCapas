using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Data.Common;



namespace CapaDatos

        
{
    public class D_Alumnos
    {
        SqlConnection conn = new SqlConnection ("Data Source = MSI\\PEPE;Initial Catalog = Consultoria_Alteña; Integrated Security = True");

        public DataTable D_Listado()
        {
            SqlCommand cmd = new SqlCommand("ObtenerListaAlumnos", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;



        
        }



    }
}