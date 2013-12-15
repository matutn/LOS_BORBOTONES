using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DTO
{

    public class MedicamentoDTO
    {

        public static String nombreTabla = "LOS_BORBOTONES.Receta";
        public static String primaryKey = "med_IdMedicamento";
        public static List<String> primaryKeys;
        public string med_IdMedicamento { get; set; }
        public string med_Descripcion { get; set; }
        public string cantidadMedic { get; set; }
 




        //---------Constructores-------------
        public MedicamentoDTO() { }


        public MedicamentoDTO(string IdMed,
                        string Descrip,
                        string cant)
        {

            this.med_IdMedicamento = IdMed;
            this.med_Descripcion = Descrip;
            this.cantidadMedic = cant;
        }

     
    }
}

