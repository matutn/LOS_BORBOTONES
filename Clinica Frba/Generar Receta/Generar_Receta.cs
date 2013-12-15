using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DTO;
using Clinica_Frba.Clases;
using System.IO;
using Clinica_Frba.ResultadoAtencion;

namespace Clinica_Frba.GenerarReceta

{  
    public partial class Generar_Receta : Form
    {
        public string IdCons;
        
        List<RecetaDTO> listadoRecetas = new List<RecetaDTO>();

        public Generar_Receta(string IdAfi, string IdConsulta)
        {
            InitializeComponent();

            textBox6.Text = IdAfi;
            textBox6.Enabled = false;
            IdCons = IdConsulta;

            DataTable tipoCanc = Clases.DB.ExecuteReader("Select med_IdMedicamento, med_Descripcion from LOS_BORBOTONES.Medicamento order by 2");
            //DataRow row = planes.NewRow();
            //row["plan_IdPlan"] = DBNull.Value;
            //planes.Rows.InsertAt(row, 0);
            comboBox1.DataSource = tipoCanc;
            comboBox1.DisplayMember = tipoCanc.Columns["med_Descripcion"].ToString();
            comboBox1.ValueMember = tipoCanc.Columns["med_Descripcion"].ToString();

            DataTable tipoCanc2 = Clases.DB.ExecuteReader("Select med_IdMedicamento, med_Descripcion from LOS_BORBOTONES.Medicamento order by 2");
            comboBox2.DataSource = tipoCanc2;
            comboBox2.DisplayMember = tipoCanc2.Columns["med_Descripcion"].ToString();
            comboBox2.ValueMember = tipoCanc2.Columns["med_Descripcion"].ToString();

            DataTable tipoCanc3 = Clases.DB.ExecuteReader("Select med_IdMedicamento, med_Descripcion from LOS_BORBOTONES.Medicamento order by 2");
            comboBox3.DataSource = tipoCanc3;
            comboBox3.DisplayMember = tipoCanc3.Columns["med_Descripcion"].ToString();
            comboBox3.ValueMember = tipoCanc3.Columns["med_Descripcion"].ToString();

            DataTable tipoCanc4 = Clases.DB.ExecuteReader("Select med_IdMedicamento, med_Descripcion from LOS_BORBOTONES.Medicamento order by 2");
            comboBox4.DataSource = tipoCanc4;
            comboBox4.DisplayMember = tipoCanc4.Columns["med_Descripcion"].ToString();
            comboBox4.ValueMember = tipoCanc4.Columns["med_Descripcion"].ToString();

            DataTable tipoCanc5 = Clases.DB.ExecuteReader("Select med_IdMedicamento, med_Descripcion from LOS_BORBOTONES.Medicamento order by 2");
            comboBox5.DataSource = tipoCanc5;
            comboBox5.DisplayMember = tipoCanc5.Columns["med_Descripcion"].ToString();
            comboBox5.ValueMember = tipoCanc5.Columns["med_Descripcion"].ToString();

            numericLetras(numericUpDown1.Value.ToString(), textBox1);
            numericLetras(numericUpDown2.Value.ToString(), textBox2);
            numericLetras(numericUpDown3.Value.ToString(), textBox3);
            numericLetras(numericUpDown4.Value.ToString(), textBox4);
            numericLetras(numericUpDown5.Value.ToString(), textBox5);
        }

        private void Generar_Receta_Load(object sender, EventArgs e)
        {
        
        }

        private void B_Generar_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
        }

        private void B_Validar_Click(object sender, EventArgs e)
        {
            DataTable BonoF = DB.ExecuteReader("Select * From LOS_BORBOTONES.Bono_Farmacia b, LOS_BORBOTONES.Afiliado a" +
                                                " Where b.bofa_IdBonoFarmacia = '" + txt_BonoF.Text + "' AND b.bofa_IdAfi = a.afi_IdAfiliado");

            if (BonoF.Rows[0]["bofa_IdPlan"] != BonoF.Rows[0]["afi_IdPlan"])
            {
                MessageBox.Show("El afiliado no tiene le mismo plan con el que el Bono Farmacia fue comprado");
                return;
            }


            if (BonoF.Rows.Count == 0)
            {
                MessageBox.Show("El Bono Nro. " + txt_BonoF.Text + " es inexistente.");
                return;
            }

            if (BonoF.Rows[0]["bofa_Estado"].ToString() == "true")
            {
                MessageBox.Show("El Bono es inutilizable. Caducó o ya fue utilizado.");
                return;
            }

            if (((Convert.ToDateTime(GetDateTime()).Year == Convert.ToDateTime(BonoF.Rows[0]["bofa_FechaVencBF"].ToString()).Year) && (Convert.ToDateTime(GetDateTime()).DayOfYear >= Convert.ToDateTime(BonoF.Rows[0]["bofa_FechaVencBF"].ToString()).DayOfYear)) || (Convert.ToDateTime(GetDateTime()).Year > Convert.ToDateTime(BonoF.Rows[0]["bofa_FechaVencBF"].ToString()).Year))
            {
                MessageBox.Show("El bono farmacia caducó");
                int updateBonoF = DB.ExecuteNonQuery("Update LOS_BORBOTONES.Bono_Farmacia set bofa_Estado = 'true' where bofa_IdBonoFarmacia = '" + txt_BonoF.Text + "'");
                return;
            }

            GB_Receta.Enabled = true;
            B_Generar.Enabled = true;
        }

        public string GetDateTime()
        {
            string path = "";

            StreamReader sr = new StreamReader(path + "fechaActual.txt");
            string aux = sr.ReadLine();

            sr.Close();
            sr.Dispose();

            return aux;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericLetras(numericUpDown1.Value.ToString(), textBox1);
         }
        

        public void numericLetras(string numeric, TextBox textBox)
        {
            switch (numeric)
            {
                case "0":
                    {
                        textBox.Text = "(Cero)";
                        break;
                    }
                case "1":
                    {
                        textBox.Text= "(Uno)";
                        break;
                    }
                case "2":
                    {
                        textBox.Text = "(Dos)";
                        break;
                    }
                case "3":
                    {
                        textBox.Text = "(Tres)";
                        break;
                    }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericLetras(numericUpDown2.Value.ToString(), textBox2);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericLetras(numericUpDown3.Value.ToString(), textBox3);
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericLetras(numericUpDown5.Value.ToString(), textBox5);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            numericLetras(numericUpDown4.Value.ToString(), textBox4);
        }

        //Botón Guardar
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text == "" && comboBox4.Text == "" && comboBox5.Text == "")
            {
                MessageBox.Show("Debe ingresar algún medicamento.");
                return;
            }

            if (numericUpDown1.Value.ToString() == "0" && numericUpDown2.Value.ToString() == "0" && numericUpDown3.Value.ToString() == "0" && numericUpDown4.Value.ToString() == "0" && numericUpDown1.Value.ToString() == "0")
            {
                MessageBox.Show("Debe ingresar alguna cantidad.");
                return;
            }



            if ((comboBox1.Text == comboBox2.Text && comboBox1.Text != "") || (comboBox1.Text == comboBox3.Text && comboBox1.Text != "") || (comboBox1.Text == comboBox4.Text && comboBox1.Text != "") || (comboBox1.Text == comboBox5.Text && comboBox1.Text != "") || (comboBox2.Text == comboBox3.Text && comboBox2.Text != "") || (comboBox2.Text == comboBox4.Text && comboBox2.Text != "") || (comboBox2.Text == comboBox5.Text && comboBox2.Text != "") || (comboBox3.Text == comboBox4.Text && comboBox3.Text != "") || (comboBox3.Text == comboBox5.Text && comboBox3.Text != "") || (comboBox4.Text == comboBox5.Text && comboBox4.Text != ""))
            {
                MessageBox.Show("No puede repetir el medicamento más de 1(Una) vez por receta. De ser necesario, Guarde y Genere una nueva receta.");
                return;
            }

            RecetaDTO receta = new RecetaDTO();
            List<MedicamentoDTO> listadoMedicamentos = new List<MedicamentoDTO>();
            receta.medicamentos = listadoMedicamentos;

            int idReceta = DB.ExecuteCardinal("insert into LOS_BORBOTONES.Receta (rece_Estado,rece_IdConsulta) Values ('false','"+IdCons+"'); select scope_identity()");

            receta.rece_IdReceta = idReceta.ToString();
            receta.rece_Estado = "false";
            receta.rece_IdConsulta = IdCons;


            if (comboBox1.Text != "" && numericUpDown1.Value.ToString() != "0")
            {
                MedicamentoDTO medic1 = new MedicamentoDTO();
                cargaReceta(receta, medic1, comboBox1, numericUpDown1);
            }
            else if((comboBox1.Text == "" && numericUpDown1.Value.ToString() != "0") || (comboBox1.Text != "" && numericUpDown1.Value.ToString() == "0"))
            {
                MessageBox.Show("Debe llenar el nombre del medicamento y la cantidad del medicamento 1");
                return;
            }


            if (comboBox2.Text != "" && numericUpDown2.Value.ToString() != "0")
            {
                MedicamentoDTO medic2 = new MedicamentoDTO();
                cargaReceta(receta, medic2, comboBox2, numericUpDown2);
            }
            else if((comboBox2.Text == "" && numericUpDown2.Value.ToString() != "0") || (comboBox2.Text != "" && numericUpDown2.Value.ToString() == "0"))
            {
                MessageBox.Show("Debe llenar el nombre del medicamento y la cantidad del medicamento 2");
                return;
            }

            if (comboBox3.Text != "" && numericUpDown3.Value.ToString() != "0")
            {
                MedicamentoDTO medic3 = new MedicamentoDTO();
                cargaReceta(receta, medic3, comboBox3, numericUpDown3);
            }
            else if ((comboBox3.Text == "" && numericUpDown3.Value.ToString() != "0") || (comboBox3.Text != "" && numericUpDown3.Value.ToString() == "0"))
            {
                MessageBox.Show("Debe llenar el nombre del medicamento y la cantidad del medicamento 3");
                return;
            }

            if (comboBox4.Text != "" && numericUpDown4.Value.ToString() != "0")
            {
                MedicamentoDTO medic4 = new MedicamentoDTO();
                cargaReceta(receta, medic4, comboBox4, numericUpDown4);
            }
            else if ((comboBox4.Text == "" && numericUpDown4.Value.ToString() != "0") || (comboBox4.Text != "" && numericUpDown4.Value.ToString() == "0"))
            {
                MessageBox.Show("Debe llenar el nombre del medicamento y la cantidad del medicamento 4");
                return;
            }

            if (comboBox5.Text != "" && numericUpDown5.Value.ToString() != "0")
            {
                MedicamentoDTO medic5 = new MedicamentoDTO();
                cargaReceta(receta, medic5, comboBox5, numericUpDown5);
            }
            else if ((comboBox5.Text == "" && numericUpDown5.Value.ToString() != "0") || (comboBox5.Text != "" && numericUpDown5.Value.ToString() == "0"))
            {
                MessageBox.Show("Debe llenar el nombre del medicamento y la cantidad del medicamento 5");
                return;
            }

            listadoRecetas.Add(receta);

            

            MessageBox.Show("La receta se guardó correctamente.");

            GB_Receta.Enabled = false;
            B_OtraReceta.Enabled = true;
            return;

        }

        public void cargaReceta(RecetaDTO receta, MedicamentoDTO medic, ComboBox comboBox, NumericUpDown numeric)
        {
            DataTable Med = Clases.DB.ExecuteReader("Select med_IdMedicamento, med_Descripcion from LOS_BORBOTONES.Medicamento");

            string idMed = "";

            foreach (DataRow dr in Med.Rows)
            {
                if (comboBox.Text == dr["med_Descripcion"].ToString())
                {
                    idMed = dr["med_IdMedicamento"].ToString();
                }
            }

            medic.med_IdMedicamento = idMed;
            medic.med_Descripcion = comboBox.Text;
            medic.cantidadMedic = numeric.Value.ToString();

            int insertMedic = DB.ExecuteNonQuery("insert into LOS_BORBOTONES.Medicamento_Receta (mere_IdMedicamento,mere_IdReceta,mere_CantMed) Values ('" + idMed + "','" + receta.rece_IdReceta + "','" + medic.cantidadMedic + "')");

            receta.medicamentos.Add(medic);

        }

        public void refreshTodo()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;

            numericLetras(numericUpDown1.Value.ToString(), textBox1);
            numericLetras(numericUpDown2.Value.ToString(), textBox2);
            numericLetras(numericUpDown3.Value.ToString(), textBox3);
            numericLetras(numericUpDown4.Value.ToString(), textBox4);
            numericLetras(numericUpDown5.Value.ToString(), textBox5);

        }

        private void B_OtraReceta_Click(object sender, EventArgs e)
        {
            refreshTodo();

            button2.Enabled = true;
            B_OtraReceta.Enabled = false;
            GB_Receta.Enabled = true;
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
