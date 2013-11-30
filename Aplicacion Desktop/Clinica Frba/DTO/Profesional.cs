using System;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Clinica_Frba.DTO {

    public class Profesional {
        
        public static String nombreTabla = "LOS_BORBOTONES.Profesional";
        public static String primaryKey = "prof_IdProfesional";
        public static String campoDeCambioDeEstado;
        public static String valorCampoDeCambioDeEstado;
        public static List<String> primaryKeys;
        public String prof_NombreUsuario;
        public String prof_Matricula;
        public String prof_Dni;
        public String prof_Nombre;
        public String prof_Apellido;
        public String prof_Direccion;
        public String prof_Telefono;
        public String prof_Mail;
        public String prof_FechaNacimiento;
        public String prof_Sexo;
        public String Eliminado;

        public Profesional() { }

        public Profesional
        (
             String prof_NombreUsuario,
             String prof_Matricula,
             String prof_Dni,
             String prof_Nombre,
             String prof_Apellido,
             String prof_Direccion,
             String prof_Telefono,
             String prof_Mail,
             String prof_FechaNacimiento,
             String prof_Sexo
        )
        {
            this.prof_NombreUsuario = prof_NombreUsuario;
            this.prof_Matricula = prof_Matricula;
            this.prof_Dni = prof_Dni;
            this.prof_Nombre = prof_Nombre;
            this.prof_Apellido = prof_Apellido;
            this.prof_Direccion = prof_Direccion;
            this.prof_Telefono = prof_Telefono;
            this.prof_Mail = prof_Mail;
            this.prof_FechaNacimiento = prof_FechaNacimiento;
            this.prof_Sexo = prof_Sexo;
        }
        

    }
}
