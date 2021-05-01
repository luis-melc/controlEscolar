using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
using System.Xml.Linq;



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

        public string tablaPres;

        private XmlDocument docXML = null;
        private XmlElement rootXML = null;
        private XmlElement alumXML = null;
        private XmlElement IdAluXML = null;
        private XmlElement BolXML = null;
        private XmlElement NomXML = null;
        private XmlElement ApatXML = null;
        private XmlElement AmaXML = null;
        private XmlElement SexXML = null;
        private XmlElement FNaXML = null;
        private XmlElement MailXML = null;
        private XmlElement TelXML = null;
        private XmlElement SanXML = null;
        private XmlElement CartXML = null;
        private XmlElement ProXML = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnADD_Click(object sender, EventArgs e)
        {
            leerDatos();
            cbd.ActualizaDatosSP(id_alu,bol_alu,nom_alu,apa_alu,ama_alu,sex_alu,fnac_alu,email_alu,tel_alu,tipsan_alu,car_alu,prom_alu,1);
            LimpiarControles();
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
            int lonCad = 0, lonReg = 0, caso = 0, nRegXML = 0;

            if (tipOper == 2) tablaPres = "<table>";
           
            datRecib = cbd.RegresaDatosSP(id_alu, tipOper);

            lonCad = datRecib.Length;

            while(lonCad > 1)
            {
                segReg = datRecib.Substring(0, datRecib.IndexOf("$"));
                datRecib = datRecib.Substring(datRecib.IndexOf("$") + 1);

                lonReg = segReg.Length;

                if (tipOper == 2) tablaPres += "<tr>";

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
                        if (tipOper == 2)
                        {
                            tablaPres += "<td>" + segCad + "</td>";

                        }
                        else
                        {
                            generaXML(segCad, nRegXML);
                            nRegXML++;
                            if (nRegXML > 11) nRegXML = 0; 
                        }
                    }
                    lonReg = segReg.Length;
                }
                if(tipOper == 2) tablaPres += "</tr>";
                lonCad = datRecib.Length;
            }
            if (tipOper == 2) tablaPres += "</table>";
        }

        protected void BtnList_Click(object sender, EventArgs e)
        {
            //obtenAlumnos(-1,2);
            cargarDatos(-1, 2);
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            cbd.ActualizaDatosSP(Int16.Parse(txtID.Text),"","","","","","2021-04-03","","",0,0,0,3);
            LimpiarControles();
        }

        public void LimpiarControles()
        {
            txtID.Text = "";
            txtBol.Text = "";
            txtNom.Text = "";
            txtApa.Text = "";
            txtAma.Text = "";
            txtSex.Text = "";
            txtMail.Text = "";
            txtSan.Text = "";
            txtCar.Text = "";
            txtProm.Text = "";
            txtCel.Text = "";

        }

        protected void BtnAct_Click(object sender, EventArgs e)
        {
            leerDatos();
            cbd.ActualizaDatosSP(id_alu, bol_alu, nom_alu, apa_alu, ama_alu, sex_alu, fnac_alu, email_alu, tel_alu, tipsan_alu, car_alu, prom_alu, 2);
            LimpiarControles();
        }

        private void cargarDatos(Int16 id_alu, Int16 tipOper)
        {
            DataTable datos = new DataTable();

            datos = cbd.devuelveDatos(id_alu,tipOper);
            DatosReja.DataSource = datos;
            DatosReja.DataBind();
        }

        protected void btnXML_Click(object sender, EventArgs e)
        {
            docXML = new XmlDocument();
            rootXML = docXML.CreateElement("Alumnos");
            docXML.AppendChild(rootXML);
            alumXML = docXML.CreateElement("Estudiante");
            rootXML.AppendChild(alumXML);

            obtenAlumnos(-1, 3);
            docXML.Save("C:\\Users\\lr880\\Documents\\David\\IPN\\7º Semestre\\baseDeDatos\\proyectoConexion\\controlEscolar\\XML\\Alumnos.xml");
        }

        private void generaXML(string valXML, int numInsDato)
        {
            switch (numInsDato)
            {
                case 0:
                    IdAluXML = docXML.CreateElement("id_alu");
                    IdAluXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(IdAluXML);
                    break;
                case 1:
                    BolXML = docXML.CreateElement("bol_alu");
                    BolXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(BolXML);
                    break;
                case 2:
                    NomXML = docXML.CreateElement("nom_alu");
                    NomXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(NomXML);
                    break;
                case 3:
                    ApatXML = docXML.CreateElement("apa_alu");
                    ApatXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(ApatXML);
                    break;
                case 4:
                    AmaXML = docXML.CreateElement("ama_alu");
                    AmaXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(AmaXML);
                    break;
                case 5:
                    SexXML = docXML.CreateElement("sex_alu");
                    SexXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(SexXML);
                    break;
                case 6:
                    FNaXML = docXML.CreateElement("fna_alu");
                    FNaXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(FNaXML);
                    break;
                case 7:
                    MailXML = docXML.CreateElement("mail_alu");
                    MailXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(MailXML);
                    break;

                case 8:
                    TelXML = docXML.CreateElement("tel_alu");
                    TelXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(TelXML);
                    break;
                case 9:
                    SanXML = docXML.CreateElement("tipo_san_alu");
                    SanXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(SanXML);
                    break;
                case 10:
                    CartXML = docXML.CreateElement("carrera_alu");
                    CartXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(CartXML);
                    break;
                case 11:
                    ProXML = docXML.CreateElement("prom_alu");
                    ProXML.AppendChild(docXML.CreateTextNode(valXML));
                    alumXML.AppendChild(ProXML);
                    break;
            }
        }

        
    }
}