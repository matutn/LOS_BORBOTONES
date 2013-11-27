using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DataTransferObjects
{
    class Rol
    {
        public static String nombreTabla = "LaMiScoGon.Rol";
        public static String primaryKey = "Nombre";
        public static String campoDeCambioDeEstado;
        public static String valorCampoDeCambioDeEstado;
        public static List<String> primaryKeys;
        public static String operacionComplejaRelacionada;
        public String Nombre;
        public String Habilitado;
        public String Eliminado;

        public Rol() { }

        public Rol
        (
             String Nombre
        )
        {
            this.Nombre = Nombre;
        }
    }
}
