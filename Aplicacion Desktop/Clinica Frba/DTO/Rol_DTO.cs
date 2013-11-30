﻿using System;
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

        public Rol_DTO() {}

        //---------Setter General-------------
        public Rol_DTO(string rol_CodRol,
                       string Nombre){

            this.rol_CodRol = rol_CodRol;
            this.rol_Nombre = Nombre;
        }



    }
}