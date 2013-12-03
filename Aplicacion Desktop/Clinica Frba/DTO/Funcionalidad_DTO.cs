using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_Frba.DTO
{
    public class Funcionalidad_DTO
    {
        public static String nombreTabla = "LOS_BORBOTONES.Funcionalidad";
        public static String primaryKey = "fun_CodFuncionalidad";
        public static List<String> primaryKeys;
        public string fun_CodFuncionalidad { get; set; }
        public string fun_Descripcion { get; set; }



        //---------Constructores-------------
        public Funcionalidad_DTO() { }


        public Funcionalidad_DTO(string Cod,
                           string Desc)
        {

            this.fun_CodFuncionalidad = Cod;
            this.fun_Descripcion = Desc;

        }

    }
}