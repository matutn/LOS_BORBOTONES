using System;
using System.Data.SqlClient;

namespace Clinica_Frba.DTO
{

    public class Funcionalidad
    {
        public static String nombreTabla = "LaMiScoGon.Funcionalidad";
        public String Nombre;

        public Funcionalidad() { }

        public Funcionalidad
        (
             String Nombre
        )
        {
            this.Nombre = Nombre;
        }

        public override bool Equals(System.Object obj)
        { 
            if (obj == null)
                return false;

            Funcionalidad f = obj as Funcionalidad;
            if ((System.Object)f == null)
                return false;

            return f.Nombre == this.Nombre;
        }

        public override int GetHashCode()
        {
            return int.Parse(this.Nombre);
        }
    }
}
