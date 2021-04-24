using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace controlEscolar.Frontal
{
    public partial class Principal : System.Web.UI.Page
    {
        private Datos.ConectaBD cbd = new Datos.ConectaBD();

        private string bol_alu;
        private string nom_alu;
        private string apa_alu;
        private string ama_alu;
        private string sex_alu;
        private string fnac_alu;
        private string email_alu;
        private string tel_alu;

        private Int16 id_alu;
        private Int16 tipsan_alu;
        private Int16 car_alu;

        private float prom_alu;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnADD_Click(object sender, EventArgs e)
        {
            leerDatos();
            cbd.ActualizaDatosSP(id_alu,bol_alu,nom_alu,apa_alu,ama_alu,sex_alu,fnac_alu,email_alu,tel_alu,tipsan_alu,car_alu,prom_alu,1);
        }

        public void leerDatos()
        {
            id_alu = Int16.Parse(txtID.Text);
            bol_alu = txtBol.Text;
            nom_alu = txtNom.Text;
            apa_alu = txtApa.Text;
            ama_alu = txtAma.Text;
            sex_alu = txtSex.Text;
            fnac_alu = calFNac.SelectedDate.ToString("yyyy-MM-dd");
            email_alu = txtMail.Text;
            tel_alu = txtCel.Text;
            tipsan_alu = Int16.Parse(txtSan.Text);
            car_alu = Int16.Parse(txtCar.Text);
            prom_alu = float.Parse(txtProm.Text);
        }

        protected void BtnRegUno_Click(object sender, EventArgs e)
        {
            if(txtID.Text != null)
            {
                obtenAlumnos(Int16.Parse(txtID.Text), 1);
            }
            else
            {
                Console.WriteLine("Debe ingresar el id de alumno");
            }
        }

        private void obtenAlumnos(Int16 id_alu, Int16 tipOper)
        {
            string datRecib = "";
            string segCad = "", segReg = "";
            int lonCad = 0, lonReg = 0, caso = 0;

           
            datRecib = cbd.RegresaDatosSP(id_alu, tipOper);

            lonCad = datRecib.Length;

            while(lonCad > 1)
            {
                segReg = datRecib.Substring(0, datRecib.IndexOf("$"));
                datRecib = datRecib.Substring(datRecib.IndexOf("$") + 1);

                lonReg = segReg.Length;
                //caso = 0;
                while (lonReg > 1)
                {
                    segCad = segReg.Substring(0,segReg.IndexOf("|"));
                    segReg = segReg.Substring(segReg.IndexOf("|") + 1);

                    if(tipOper == 1)
                    {
                        switch (caso)
                        {
                            case 0:
                                txtID.Text = segCad;
                                break;
                            
                            case 1:
                                txtBol.Text = segCad;
                                break;
                            
                            case 2:
                                txtNom.Text = segCad;
                                break;
                            
                            case 3:
                                txtApa.Text = segCad;
                                break;
                            
                            case 4:
                                txtAma.Text = segCad;
                                break;

                            case 5:
                                txtSex.Text = segCad;
                                break;

                            case 6:
                                calFNac.SelectedDate = Convert.ToDateTime(segCad).Date;
                                break;

                            case 7:
                                txtMail.Text = segCad;
                                break;

                            case 8:
                                txtCel.Text = segCad;
                                break;

                            case 9:
                                txtSan.Text = segCad;
                                break;

                            case 10:
                                txtCar.Text = segCad;
                                break;

                            case 11:
                                txtProm.Text = segCad;
                                break;
                        }
                        caso++;
                    }
                    else
                    {
                        // agregar c{odigo con muchos registro
                    }

                    lonReg = segReg.Length;
                }

                lonCad = datRecib.Length;
            }
           
        }
    }
}