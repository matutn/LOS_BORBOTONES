using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Clinica_Frba.DTO
{
    public class Usuario_DTO
    {
        public static String nombreTabla = "LOS_BORBOTONES.Usuario";
        public static String primaryKey = "usu_IdUsuario";
        public static List<String> primaryKeys;
        public string usu_IdUsuario { get; set; }
        public string usu_Password { get; set; }
        public string usu_IntentosFallidos { get; set; }
        public string usu_FechaBaja { get; set; }
        public string usu_Estado { get; set; }


        //---------Constructores-------------
        public Usuario_DTO() {}


        public Usuario_DTO(string IdU,
                           string Pass,
                           string IntentosF,
                           string FechaB,
                           string Est){

                           this.usu_IdUsuario = IdU;
                           this.usu_Password = Pass;
                           this.usu_IntentosFallidos = IntentosF;
                           this.usu_FechaBaja = FechaB;
                           this.usu_Estado = Est;
        }




    }
}