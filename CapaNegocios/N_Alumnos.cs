using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class N_Alumnos
    {
        D_Alumnos objDatos = new D_Alumnos();

        public DataTable N_Listado()
        {
            return objDatos.D_Listado();
        }
    }
}