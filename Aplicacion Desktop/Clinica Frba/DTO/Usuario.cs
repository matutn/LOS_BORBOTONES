using System;
using System.Data.SqlClient;

namespace Clinica_Frba.DataTransferObjects
{

    public class Usuario
    {
        public static String operacionComplejaRelacionada;
        public static String nombreUsuario;
        public static String contraseña;
        public static String nombreTabla = "LOS_BORBOTONES.Usuario";
        public static String primaryKey = "Nombre_Usuario";
        public String Nombre_Usuario;
        public String Clave;
        public String Cantidad_Intentos;

        public Usuario() { }

        public Usuario
        (
             String Nombre_Usuario
        )
        {
            this.Nombre_Usuario = Nombre_Usuario;
        }
    }
}
