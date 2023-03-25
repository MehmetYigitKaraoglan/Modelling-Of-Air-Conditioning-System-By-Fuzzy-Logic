using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project
{
    public partial class Durulastirma : Form
    {
        public Durulastirma()
        {
            InitializeComponent();
        }
        public double duser;
        public double duser2;
        public double ddiff;
        public double ddiff2;
        public double ddewpoint;
        public double ddewpoint2;
        public double delectricity;
        public double delectricity2;
        public string duseruyelik;
        public string duseruyelik2;
        public string ddiffuyelik;
        public string ddiffuyelik2;
        public string ddewuyelik;
        public string ddewuyelik2;
        public string delecuyelik;
        public string delecuyelik2;
        public static string cikti1;
        public static string cikti2;
        public static string cikti3;
        public static string cikti4;
        public static double mindeger;
        public void Durulastirma_Load(object sender, EventArgs e)
        {

            txt_User1.Text = duser.ToString() + " " + duseruyelik;
            txt_User2.Text = duser2.ToString() + " " + duseruyelik2;
            txt_Diff1.Text = ddiff.ToString() + " " + ddiffuyelik;
            txt_Diff2.Text = ddiff2.ToString() + " " + ddiffuyelik2;
            txt_Dew1.Text = ddewpoint.ToString() + " " + ddewuyelik;
            txt_Dew2.Text = ddewpoint2.ToString() + " " + ddewuyelik2;
            txt_Electricity1.Text = delectricity.ToString() + " " + delecuyelik;
            txt_Electricity2.Text = delectricity2.ToString() + " " + delecuyelik2;

            cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik, ddiffuyelik, ddewuyelik, delecuyelik);
            cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik, ddiffuyelik, ddewuyelik, delecuyelik);
            cikti3 = CalisanKurallar.modBul(duseruyelik, ddiffuyelik, ddewuyelik, delecuyelik);
            cikti4 = CalisanKurallar.finDirectionBul(duseruyelik, ddiffuyelik, ddewuyelik, delecuyelik);
            mindeger = MinBul(duser, ddiff, ddewpoint, delectricity);
            listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
            listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            if (duser2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik2, ddiffuyelik, ddewuyelik, delecuyelik);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik2, ddiffuyelik, ddewuyelik, delecuyelik);
                cikti3 = CalisanKurallar.modBul(duseruyelik2, ddiffuyelik, ddewuyelik, delecuyelik);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik2, ddiffuyelik, ddewuyelik, delecuyelik);
                mindeger = MinBul(duser2, ddiff, ddewpoint, delectricity);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }

            if (ddiff2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik, ddiffuyelik2, ddewuyelik, delecuyelik);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik, ddiffuyelik2, ddewuyelik, delecuyelik);
                cikti3 = CalisanKurallar.modBul(duseruyelik, ddiffuyelik2, ddewuyelik, delecuyelik);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik, ddiffuyelik2, ddewuyelik, delecuyelik);
                mindeger = MinBul(duser, ddiff2, ddewpoint, delectricity);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }

            if (ddewpoint2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik, ddiffuyelik, ddewuyelik2, delecuyelik);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik, ddiffuyelik, ddewuyelik2, delecuyelik);
                cikti3 = CalisanKurallar.modBul(duseruyelik, ddiffuyelik, ddewuyelik2, delecuyelik);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik, ddiffuyelik, ddewuyelik2, delecuyelik);
                mindeger = MinBul(duser, ddiff, ddewpoint2, delectricity);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (delectricity2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik, ddiffuyelik, ddewuyelik, delecuyelik2);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik, ddiffuyelik, ddewuyelik, delecuyelik2);
                cikti3 = CalisanKurallar.modBul(duseruyelik, ddiffuyelik, ddewuyelik, delecuyelik2);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik, ddiffuyelik, ddewuyelik, delecuyelik2);
                mindeger = MinBul(duser, ddiff, ddewpoint, delectricity2);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (duser2.ToString() != "0" && ddiff2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik2, ddiffuyelik2, ddewuyelik, delecuyelik);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik2, ddiffuyelik2, ddewuyelik, delecuyelik);
                cikti3 = CalisanKurallar.modBul(duseruyelik2, ddiffuyelik2, ddewuyelik, delecuyelik);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik2, ddiffuyelik2, ddewuyelik, delecuyelik);
                mindeger = MinBul(duser2, ddiff2, ddewpoint, delectricity);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (duser2.ToString() != "0" && ddewpoint2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik2, ddiffuyelik, ddewuyelik2, delecuyelik);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik2, ddiffuyelik, ddewuyelik2, delecuyelik);
                cikti3 = CalisanKurallar.modBul(duseruyelik2, ddiffuyelik, ddewuyelik2, delecuyelik);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik2, ddiffuyelik, ddewuyelik2, delecuyelik);
                mindeger = MinBul(duser2, ddiff, ddewpoint2, delectricity);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (duser2.ToString() != "0" && delectricity2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik2, ddiffuyelik, ddewuyelik, delecuyelik2);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik2, ddiffuyelik, ddewuyelik, delecuyelik2);
                cikti3 = CalisanKurallar.modBul(duseruyelik2, ddiffuyelik, ddewuyelik, delecuyelik2);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik2, ddiffuyelik, ddewuyelik, delecuyelik2);
                mindeger = MinBul(duser2, ddiff, ddewpoint, delectricity2);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (ddiff2.ToString() != "0" && ddewpoint2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik, ddiffuyelik2, ddewuyelik2, delecuyelik);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik, ddiffuyelik2, ddewuyelik2, delecuyelik);
                cikti3 = CalisanKurallar.modBul(duseruyelik, ddiffuyelik2, ddewuyelik2, delecuyelik);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik, ddiffuyelik2, ddewuyelik2, delecuyelik);
                mindeger = MinBul(duser, ddiff2, ddewpoint2, delectricity);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (ddiff2.ToString() != "0" && delectricity2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik, ddiffuyelik2, ddewuyelik, delecuyelik2);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik, ddiffuyelik2, ddewuyelik, delecuyelik2);
                cikti3 = CalisanKurallar.modBul(duseruyelik, ddiffuyelik2, ddewuyelik, delecuyelik2);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik, ddiffuyelik2, ddewuyelik, delecuyelik2);
                mindeger = MinBul(duser, ddiff2, ddewpoint, delectricity2);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (ddewpoint2.ToString() != "0" && delectricity2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik, ddiffuyelik, ddewuyelik2, delecuyelik2);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik, ddiffuyelik, ddewuyelik2, delecuyelik2);
                cikti3 = CalisanKurallar.modBul(duseruyelik, ddiffuyelik, ddewuyelik2, delecuyelik2);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik, ddiffuyelik, ddewuyelik2, delecuyelik2);
                mindeger = MinBul(duser, ddiff, ddewpoint2, delectricity2);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (duser2.ToString() != "0" && ddiff2.ToString() != "0" && ddewpoint2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik2, ddiffuyelik2, ddewuyelik2, delecuyelik);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik2, ddiffuyelik2, ddewuyelik2, delecuyelik);
                cikti3 = CalisanKurallar.modBul(duseruyelik2, ddiffuyelik2, ddewuyelik2, delecuyelik);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik2, ddiffuyelik2, ddewuyelik2, delecuyelik);
                mindeger = MinBul(duser2, ddiff2, ddewpoint2, delectricity);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (duser2.ToString() != "0" && ddiff2.ToString() != "0" && delectricity2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik2, ddiffuyelik2, ddewuyelik, delecuyelik2);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik2, ddiffuyelik2, ddewuyelik, delecuyelik2);
                cikti3 = CalisanKurallar.modBul(duseruyelik2, ddiffuyelik2, ddewuyelik, delecuyelik2);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik2, ddiffuyelik2, ddewuyelik, delecuyelik2);
                mindeger = MinBul(duser2, ddiff2, ddewpoint, delectricity2);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (duser2.ToString() != "0" && ddewpoint2.ToString() != "0" && delectricity2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik2, ddiffuyelik, ddewuyelik2, delecuyelik2);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik2, ddiffuyelik, ddewuyelik2, delecuyelik2);
                cikti3 = CalisanKurallar.modBul(duseruyelik2, ddiffuyelik, ddewuyelik2, delecuyelik2);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik2, ddiffuyelik, ddewuyelik2, delecuyelik2);
                mindeger = MinBul(duser2, ddiff, ddewpoint2, delectricity2);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (ddiff2.ToString() != "0" && ddewpoint2.ToString() != "0" && delectricity2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik, ddiffuyelik2, ddewuyelik2, delecuyelik2);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik, ddiffuyelik2, ddewuyelik2, delecuyelik2);
                cikti3 = CalisanKurallar.modBul(duseruyelik, ddiffuyelik2, ddewuyelik2, delecuyelik2);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik, ddiffuyelik2, ddewuyelik2, delecuyelik2);
                mindeger = MinBul(duser, ddiff2, ddewpoint2, delectricity2);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger) + "    " + fanspeedUyelikBul(mindeger) + "    " + modUyelikBul(mindeger) + "    " + finUyelikBul(mindeger));
            }
            if (duser2.ToString() != "0" && ddiff2.ToString() != "0" && ddewpoint2.ToString() != "0" && delectricity2.ToString() != "0")
            {
                cikti1 = CalisanKurallar.compressorSpeedBul(duseruyelik2, ddiffuyelik2, ddewuyelik2, delecuyelik2);
                cikti2 = CalisanKurallar.fanSpeedBul(duseruyelik2, ddiffuyelik2, ddewuyelik2, delecuyelik2);
                cikti3 = CalisanKurallar.modBul(duseruyelik2, ddiffuyelik2, ddewuyelik2, delecuyelik2);
                cikti4 = CalisanKurallar.finDirectionBul(duseruyelik2, ddiffuyelik2, ddewuyelik2, delecuyelik2);
                mindeger = MinBul(duser2, ddiff2, ddewpoint2, delectricity2);
                listBox_Durulastirma.Items.Add(mindeger + cikti1 + " " + mindeger + cikti2 + " " + mindeger + cikti3 + " " + mindeger + cikti4);
                listBox1.Items.Add(compressorUyelikBul(mindeger)+"    "+fanspeedUyelikBul(mindeger)+ "    "+modUyelikBul(mindeger)+ "    "+finUyelikBul(mindeger));
            }
        }
        public static double MinBul(double a, double b, double c, double d)
        {
            double minDeger = a;
            minDeger = Math.Min(minDeger, b);
            minDeger = Math.Min(minDeger, c);
            minDeger = Math.Min(minDeger, d);
            return minDeger;
        }
        public static string compressorUyelikBul(double a)
        {
            string cikiscom1;
            string cikiscom2;
            if (cikti1=="Low")
            {
                cikiscom1 = (-1 * (20 * a - 50)).ToString();
               return "Compressor Speed x1: "+cikiscom1;
            }
            else if (cikti1=="Medium")
            {
                cikiscom1 =((20*a)+40).ToString();
                cikiscom2 = (-1 * ((20 * a) - 80)).ToString();
                return "Compressor Speed x1: " + cikiscom1+" , x2: "+cikiscom2;
            }
            else if (cikti1=="Fast")
            {
                cikiscom1=((20 * a) + 70).ToString();
                return "Compressor Speed x1: " + cikiscom1;
            }
            else
            {
                return "";
            }
        }
        public static string fanspeedUyelikBul(double a)
        {
            string cikisfan1;
            string cikisfan2;
            if (cikti2 == "Low")
            {
                cikisfan1 = (-1 * (20 * a - 50)).ToString();
                return "Fan Speed x1: " + cikisfan1;
            }
            else if (cikti2 == "Medium")
            {
                cikisfan1 = ((20 * a) + 40).ToString();
                cikisfan2 = (-1 * ((20 * a) - 80)).ToString();
                return "Fan Speed x1: " + cikisfan1 + " , x2: " + cikisfan2;
            }
            else if (cikti2 == "Fast")
            {
                cikisfan1 = ((20 * a) + 70).ToString();
                return "Fan Speed x1: " + cikisfan1;
            }
            else
            {
                return "";
            }
        }
        public static string modUyelikBul(double a)
        {
            string cikismod1;
            if (cikti3 == "Dehumidifier")
            {
                cikismod1 = (1-a).ToString();
                return "Mode of Operation x1: " + cikismod1;
            }
            else if (cikti3 == "AC")
            {
                cikismod1 = a.ToString();
                return "Mode of Operation x1: " + cikismod1;
            }
            else
            {
                return "";
            }
        }
        public static string finUyelikBul(double a)
        {
            string cikisfin1;
            if (cikti4 == "Toward")
            {
                cikisfin1 = (-1 * ((40 * a) - 70)).ToString();
                return "Fin Direction x1: " + cikisfin1;
            }
            else if (cikti4 == "Away")
            {
                cikisfin1 = ((40*a)+30).ToString();
                return "Fin Direction x1: " + cikisfin1;
            }
            else
            {
                return "";
            }
        }
    }
}
