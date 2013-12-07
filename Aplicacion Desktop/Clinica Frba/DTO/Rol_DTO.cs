using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DTO {

    public class Rol_DTO {

        public static String nombreTabla = "LOS_BORBOTONES.Rol";
        public static String primaryKey = "rol_CodRol";
        public static List<String> primaryKeys;
        public string rol_CodRol { get; set; }
        public string rol_Nombre { get; set; }




        //---------Constructores-------------
        public Rol_DTO() {}

        
        public Rol_DTO(string rol_CodRol,
                       string Nombre){

            this.rol_CodRol = rol_CodRol;
            this.rol_Nombre = Nombre;
        }

<<<<<<< HEAD
        public override string ToString()
        {
            return rol_Nombre;
        }
=======

        ///PRUEBA EN GIT Comentario mati
>>>>>>> fdb04937829614f6ad85aed48e16b3e6def6bae2
    }
}




