using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_FuzzyRules_Click(object sender, EventArgs e)
        {
            Fuzzy_Rules Fuzzy_Rules = new Fuzzy_Rules();
            Fuzzy_Rules.ShowDialog();
        }

        string user_uyelik = null;
        string user_uyelik2 = null;
        string difference_uyelik = null;
        string difference_uyelik2 = null;
        string dewpoint_uyelik = null;
        string dewpoint_uyelik2 = null;
        string electricity_uyelik = null;
        string electricity_uyelik2 = null;
        double user_derece = 0;
        double user_derece2 = 0;
        double difference_derece = 0;
        double difference_derece2 = 0;
        double dewpoint_derece = 0;
        double dewpoint_derece2 = 0;
        double electricity_derece = 0;
        double electricity_derece2 = 0;
        private void btn_Bulaniklastirma_Click(object sender, EventArgs e)
        {
            double user = 0;
            double difference = 0;
            double dewpoint = 0;
            double electricity = 0;
            if (txt_User.Text != "")
            {
                user = Convert.ToDouble(txt_User.Text);
            }
            if (txt_Difference.Text != "")
            {
                difference = Convert.ToDouble(txt_Difference.Text);
            }
            if (txt_DewPoint.Text != "")
            {
                dewpoint = Convert.ToDouble(txt_DewPoint.Text);
            }
            if (txt_Electricity.Text != "")
            {
                electricity = Convert.ToDouble(txt_Electricity.Text);
            }


            if (user < 18.0d || user > 30.0d)
            {
                MessageBox.Show("Lütfen 'User Temperature' değerini belirtilen değerler arasında giriniz ! (18~30)");
            }
            else if (difference < -1.0d || difference > 3.0d)
            {
                MessageBox.Show("Lütfen 'Temperature Difference' değerini belirtilen değerler arasında giriniz ! (-1~3)");
            }
            else if (dewpoint < 10.0d || dewpoint > 18.0d)
            {
                MessageBox.Show("Lütfen 'Dew Point Temperature' değerini belirtilen değerler arasında giriniz ! (10~18)");
            }
            else if (electricity < 130.0d || electricity > 220.0d)
            {
                MessageBox.Show("Lütfen 'Electricity Volt' değerini belirtilen değerler arasında giriniz ! (130~220)");
            }
            else
            {
                //User Bulanıklaştırma
                if (user <= 22.0d)
                {
                    user_uyelik = "Low";
                    user_derece = 1.0d;
                    user_uyelik2 = "";
                    user_derece2 = 0;
                }
                else if (user > 22.0d && user < 25.0d)
                {
                    user_uyelik = "Low";
                    user_derece = Math.Round((25 - user) / 3, 1);
                    user_uyelik2 = "Optimal";
                    user_derece2 = Math.Round((user - 22) / 3, 1);

                }
                else if (user == 25.0d)
                {
                    user_uyelik = "Optimal";
                    user_derece = Math.Round((28 - user) / 3, 1);
                    user_uyelik2 = "";
                    user_derece2 = 0;

                }
                else if (user > 25.0d && user < 28)
                {
                    user_uyelik = "Optimal";
                    user_derece = Math.Round((28 - user) / 3, 1);
                    user_uyelik2 = "High";
                    user_derece2 = Math.Round((user - 25) / 3, 1);

                }
                else if (user >= 28)
                {
                    user_uyelik = "High";
                    user_derece = 1.0d;
                    user_uyelik2 = "";
                    user_derece2 = 0;

                }
                else
                {
                    user_uyelik = "";
                    user_derece = 0;
                    user_uyelik2 = "";
                    user_derece2 = 0;
                }

                //Difference Bulanıklaştırma
                if (difference >= -1.0d && difference <= -0.9d)
                {
                    difference_uyelik = "Negative";
                    difference_derece = 1.0d;
                    difference_uyelik2 = "";
                    difference_derece2 = 0;

                }
                else if (difference > -0.9d && difference <= -0.5d)
                {
                    difference_uyelik = "Negative";
                    difference_derece = Math.Round(-0.9 * difference, 1);
                    difference_uyelik2 = "";
                    difference_derece2 = 0;

                }
                else if (difference > -0.5d && difference < 0.0d)
                {
                    difference_uyelik = "Negative";
                    difference_derece = Math.Round(-0.9 * difference, 1);
                    difference_uyelik2 = "Zero";
                    difference_derece2 = Math.Round(2 * (difference + 0.5), 1);

                }
                else if (difference == 0.0d)
                {
                    difference_uyelik = "Zero";
                    difference_derece = 1;

                }
                else if (difference > 0.0d && difference < 1.0d)
                {
                    difference_uyelik = "Zero";
                    difference_derece = Math.Round(1 - difference, 1);
                    difference_uyelik2 = "Positive";
                    difference_derece2 = Math.Round(difference, 1);

                }
                else if (difference == 1)
                {
                    difference_uyelik = "Positive";
                    difference_derece = Math.Round(difference, 1);
                    difference_uyelik2 = "";
                    difference_derece2 = 0;
                }
                else if (difference > 1.0d && difference < 2.0d)
                {
                    difference_uyelik = "Positive";
                    difference_derece = Math.Round(2 - difference, 1);
                    difference_uyelik2 = "Large";
                    difference_derece2 = Math.Round(difference - 1, 1);

                }
                else if (difference >= 2.0d)
                {
                    difference_uyelik = "Large";
                    difference_derece = 1;
                    difference_uyelik2 = "";
                    difference_derece2 = 0;

                }
                else
                {
                    difference_uyelik = "";
                    difference_derece = 0;
                    difference_uyelik2 = "";
                    difference_derece2 = 0;
                }


                //Dew Point Bulanıklaştırma
                if (dewpoint >= 10.0d && dewpoint <= 11.0d)
                {
                    dewpoint_uyelik = "Optimal";
                    dewpoint_derece = 1;
                    dewpoint_uyelik2 = "";
                    dewpoint_derece2 = 0;

                }
                else if (dewpoint > 11.0d && dewpoint < 14.0d)
                {
                    dewpoint_uyelik = "Optimal";
                    dewpoint_derece = Math.Round(((14 - dewpoint) / 3), 1);
                    dewpoint_uyelik2 = "Humid";
                    dewpoint_derece2 = Math.Round(((dewpoint - 11) / 3), 1);

                }
                else if (dewpoint >= 14)
                {
                    dewpoint_uyelik = "Humid";
                    dewpoint_derece = 1;
                    dewpoint_uyelik2 = "";
                    dewpoint_derece2 = 0;

                }
                else
                {
                    dewpoint_uyelik = "";
                    dewpoint_derece = 0;
                    dewpoint_uyelik2 = "";
                    dewpoint_derece2 = 0;
                }


                //Electricity Bulanıklaştırma
                if (electricity >= 130.0d && electricity <= 160.0d)
                {
                    electricity_uyelik = "Low";
                    electricity_derece = 1;
                    electricity_uyelik2 = "";
                    electricity_derece2 = 0;

                }
                else if (electricity > 160.0d && electricity < 180.0d)
                {
                    electricity_uyelik = "Low";
                    electricity_derece = Math.Round((180 - electricity) / 20, 1);
                    electricity_uyelik2 = "High";
                    electricity_derece2 = Math.Round((electricity - 160) / 20, 1);

                }
                else if (electricity >= 180.0d)
                {
                    electricity_uyelik = "High";
                    electricity_derece = 1;
                    electricity_uyelik2 = "";
                    electricity_derece2 = 0;

                }
                else
                {
                    electricity_uyelik = "";
                    electricity_derece = 0;
                    electricity_uyelik2 = "";
                    electricity_derece2 = 0;

                }


                Bulaniklastirma bulaniklastirma = new Bulaniklastirma();
                bulaniklastirma.buser = user_derece + " " + user_uyelik;
                bulaniklastirma.buser2 = user_derece2 + " " + user_uyelik2;
                bulaniklastirma.bdiff = difference_derece + " " + difference_uyelik;
                bulaniklastirma.bdiff2 = difference_derece2 + " " + difference_uyelik2;
                bulaniklastirma.bdewpoint = dewpoint_derece + " " + dewpoint_uyelik;
                bulaniklastirma.bdewpoint2 = dewpoint_derece2 + " " + dewpoint_uyelik2;
                bulaniklastirma.belectricity = electricity_derece + " " + electricity_uyelik;
                bulaniklastirma.belectricity2 = electricity_derece2 + " " + electricity_uyelik2;
                bulaniklastirma.ShowDialog();


                CalisanKurallar calisankurallar = new CalisanKurallar();
                calisankurallar.kuser = user_uyelik;
                calisankurallar.kuser2 = user_uyelik2;
                calisankurallar.kdiff = difference_uyelik;
                calisankurallar.kdiff2 = difference_uyelik2;
                calisankurallar.kdewpoint = dewpoint_uyelik;
                calisankurallar.kdewpoint2 = dewpoint_uyelik2;
                calisankurallar.kelectricity = electricity_uyelik;
                calisankurallar.kelectricity2 = electricity_uyelik2;
                calisankurallar.ShowDialog();



            }



        }


        private void btn_Durulastirma_Click(object sender, EventArgs e)
        {
            Durulastirma durulastirma = new Durulastirma();
            durulastirma.duser = user_derece;
            durulastirma.duser2 = user_derece2;
            durulastirma.ddiff = difference_derece;
            durulastirma.ddiff2 = difference_derece2;
            durulastirma.ddewpoint = dewpoint_derece;
            durulastirma.ddewpoint2 = dewpoint_derece2;
            durulastirma.delectricity = electricity_derece;
            durulastirma.delectricity2 = electricity_derece2;
            durulastirma.duseruyelik = user_uyelik;
            durulastirma.duseruyelik2 = user_uyelik2;
            durulastirma.ddiffuyelik = difference_uyelik;
            durulastirma.ddiffuyelik2 = difference_uyelik2;
            durulastirma.ddewuyelik = dewpoint_uyelik;
            durulastirma.ddewuyelik2 = dewpoint_uyelik2;
            durulastirma.delecuyelik = electricity_uyelik;
            durulastirma.delecuyelik2 = electricity_uyelik2;
            durulastirma.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz?", "Fuzzy", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private bool kaydir;
        private Point baslangic = new Point(0, 0);
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            kaydir = true;
            baslangic = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (kaydir)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangic.X, p.Y - this.baslangic.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            kaydir = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
