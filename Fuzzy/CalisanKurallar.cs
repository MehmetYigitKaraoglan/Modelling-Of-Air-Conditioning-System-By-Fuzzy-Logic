using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class CalisanKurallar : Form
    {
        public CalisanKurallar()
        {
            InitializeComponent();
        }
        public string kuser;
        public string kuser2;
        public string kdiff;
        public string kdiff2;
        public string kdewpoint;
        public string kdewpoint2;
        public string kelectricity;
        public string kelectricity2;
        public static int listBoxSayisi;
        Durulastirma durulastirma = new Durulastirma();
        public void CalisanKurallar_Load(object sender, EventArgs e)
        {


            listBox1.Items.Add("If (User_Temperature is " + kuser + ") and (Tdiff is " + kdiff + ") " +
                        "and (DewPoint is " + kdewpoint + ") and (Electricity_Volt is " + kelectricity + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser, kdiff, kdewpoint, kelectricity) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser, kdiff, kdewpoint, kelectricity) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser, kdiff, kdewpoint, kelectricity) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser, kdiff, kdewpoint, kelectricity) + ")(1)");

            if (kuser2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser2 + ") and (Tdiff is " + kdiff + ") " +
                            "and (DewPoint is " + kdewpoint + ") and (Electricity_Volt is " + kelectricity + ") " +
                          "then (Compressor_Speed is " + compressorSpeedBul(kuser2, kdiff, kdewpoint, kelectricity) + ")" +
                          "(Fan_Speed is " + fanSpeedBul(kuser2, kdiff, kdewpoint, kelectricity) + ")" +
                          "(Mode_Of_Operation is " + modBul(kuser2, kdiff, kdewpoint, kelectricity) + " )" +
                          "(Fin_Direction is " + finDirectionBul(kuser2, kdiff, kdewpoint, kelectricity) + ")(1)");
            }

            if (kdiff2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser + ") and (Tdiff is " + kdiff2 + ") " +
                        "and (DewPoint is " + kdewpoint + ") and (Electricity_Volt is " + kelectricity + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser, kdiff2, kdewpoint, kelectricity) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser, kdiff2, kdewpoint, kelectricity) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser, kdiff2, kdewpoint, kelectricity) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser, kdiff2, kdewpoint, kelectricity) + ")(1)");
            }

            if (kdewpoint2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser + ") and (Tdiff is " + kdiff + ") " +
                       "and (DewPoint is " + kdewpoint2 + ") and (Electricity_Volt is " + kelectricity + ") " +
                     "then (Compressor_Speed is " + compressorSpeedBul(kuser, kdiff, kdewpoint2, kelectricity) + ")" +
                     "(Fan_Speed is " + fanSpeedBul(kuser, kdiff, kdewpoint2, kelectricity) + ")" +
                     "(Mode_Of_Operation is " + modBul(kuser, kdiff, kdewpoint2, kelectricity) + " )" +
                     "(Fin_Direction is " + finDirectionBul(kuser, kdiff, kdewpoint2, kelectricity) + ")(1)");
            }
            if (kelectricity2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser + ") and (Tdiff is " + kdiff + ") " +
                       "and (DewPoint is " + kdewpoint + ") and (Electricity_Volt is " + kelectricity2 + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser, kdiff, kdewpoint, kelectricity2) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser, kdiff, kdewpoint, kelectricity2) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser, kdiff, kdewpoint, kelectricity2) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser, kdiff, kdewpoint, kelectricity2) + ")(1)");
            }
            if (kuser2 != "" && kdiff2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser2 + ") and (Tdiff is " + kdiff2 + ") " +
                        "and (DewPoint is " + kdewpoint + ") and (Electricity_Volt is " + kelectricity + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser2, kdiff2, kdewpoint, kelectricity) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser2, kdiff2, kdewpoint, kelectricity) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser2, kdiff2, kdewpoint, kelectricity) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser2, kdiff2, kdewpoint, kelectricity) + ")(1)");
            }

            if (kuser2 != "" && kdewpoint2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser2 + ") and (Tdiff is " + kdiff + ") " +
                       "and (DewPoint is " + kdewpoint2 + ") and (Electricity_Volt is " + kelectricity + ") " +
                     "then (Compressor_Speed is " + compressorSpeedBul(kuser2, kdiff, kdewpoint2, kelectricity) + ")" +
                     "(Fan_Speed is " + fanSpeedBul(kuser2, kdiff, kdewpoint2, kelectricity) + ")" +
                     "(Mode_Of_Operation is " + modBul(kuser2, kdiff, kdewpoint2, kelectricity) + " )" +
                     "(Fin_Direction is " + finDirectionBul(kuser2, kdiff, kdewpoint2, kelectricity) + ")(1)");
            }

            if (kuser2 != "" && kelectricity2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser2 + ") and (Tdiff is " + kdiff + ") " +
                        "and (DewPoint is " + kdewpoint + ") and (Electricity_Volt is " + kelectricity2 + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser2, kdiff, kdewpoint, kelectricity2) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser2, kdiff, kdewpoint, kelectricity2) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser2, kdiff, kdewpoint, kelectricity2) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser2, kdiff, kdewpoint, kelectricity2) + ")(1)");
            }

            if (kdiff2 != "" && kdewpoint2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser + ") and (Tdiff is " + kdiff2 + ") " +
                        "and (DewPoint is " + kdewpoint2 + ") and (Electricity_Volt is " + kelectricity + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser, kdiff2, kdewpoint2, kelectricity) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser, kdiff2, kdewpoint2, kelectricity) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser, kdiff2, kdewpoint2, kelectricity) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser, kdiff2, kdewpoint2, kelectricity) + ")(1)");
            }

            if (kdiff2 != "" && kelectricity2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser + ") and (Tdiff is " + kdiff2 + ") " +
                       "and (DewPoint is " + kdewpoint + ") and (Electricity_Volt is " + kelectricity2 + ") " +
                     "then (Compressor_Speed is " + compressorSpeedBul(kuser, kdiff2, kdewpoint, kelectricity2) + ")" +
                     "(Fan_Speed is " + fanSpeedBul(kuser, kdiff2, kdewpoint, kelectricity2) + ")" +
                     "(Mode_Of_Operation is " + modBul(kuser, kdiff2, kdewpoint, kelectricity2) + " )" +
                     "(Fin_Direction is " + finDirectionBul(kuser, kdiff2, kdewpoint, kelectricity2) + ")(1)");
            }

            if (kdewpoint2 != "" && kelectricity2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser + ") and (Tdiff is " + kdiff + ") " +
                       "and (DewPoint is " + kdewpoint2 + ") and (Electricity_Volt is " + kelectricity2 + ") " +
                     "then (Compressor_Speed is " + compressorSpeedBul(kuser, kdiff, kdewpoint2, kelectricity2) + ")" +
                     "(Fan_Speed is " + fanSpeedBul(kuser, kdiff, kdewpoint2, kelectricity2) + ")" +
                     "(Mode_Of_Operation is " + modBul(kuser, kdiff, kdewpoint2, kelectricity2) + " )" +
                     "(Fin_Direction is " + finDirectionBul(kuser, kdiff, kdewpoint2, kelectricity2) + ")(1)");
            }

            if (kuser2 != "" && kdiff2 != "" && kdewpoint2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser2 + ") and (Tdiff is " + kdiff2 + ") " +
                       "and (DewPoint is " + kdewpoint2 + ") and (Electricity_Volt is " + kelectricity + ") " +
                     "then (Compressor_Speed is " + compressorSpeedBul(kuser2, kdiff2, kdewpoint2, kelectricity) + ")" +
                     "(Fan_Speed is " + fanSpeedBul(kuser2, kdiff2, kdewpoint2, kelectricity) + ")" +
                     "(Mode_Of_Operation is " + modBul(kuser2, kdiff2, kdewpoint2, kelectricity) + " )" +
                     "(Fin_Direction is " + finDirectionBul(kuser2, kdiff2, kdewpoint2, kelectricity) + ")(1)");
            }

            if (kuser2 != "" && kdiff2 != "" && kelectricity2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser2 + ") and (Tdiff is " + kdiff2 + ") " +
                        "and (DewPoint is " + kdewpoint + ") and (Electricity_Volt is " + kelectricity2 + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser2, kdiff2, kdewpoint, kelectricity2) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser2, kdiff2, kdewpoint, kelectricity2) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser2, kdiff2, kdewpoint, kelectricity2) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser2, kdiff2, kdewpoint, kelectricity2) + ")(1)");
            }

            if (kuser2 != "" && kdewpoint2 != "" && kelectricity2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser2 + ") and (Tdiff is " + kdiff + ") " +
                        "and (DewPoint is " + kdewpoint2 + ") and (Electricity_Volt is " + kelectricity2 + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser2, kdiff, kdewpoint2, kelectricity2) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser2, kdiff, kdewpoint2, kelectricity2) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser2, kdiff, kdewpoint2, kelectricity2) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser2, kdiff, kdewpoint2, kelectricity2) + ")(1)");
            }

            if (kdiff2 != "" && kdewpoint2 != "" && kelectricity2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser + ") and (Tdiff is " + kdiff2 + ") " +
                        "and (DewPoint is " + kdewpoint2 + ") and (Electricity_Volt is " + kelectricity2 + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser, kdiff2, kdewpoint2, kelectricity2) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser, kdiff2, kdewpoint2, kelectricity2) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser, kdiff2, kdewpoint2, kelectricity2) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser, kdiff2, kdewpoint2, kelectricity2) + ")(1)");
            }

            if (kuser2 != "" && kdiff2 != "" && kdewpoint2 != "" && kelectricity2 != "")
            {
                listBox1.Items.Add("If (User_Temperature is " + kuser2 + ") and (Tdiff is " + kdiff2 + ") " +
                        "and (DewPoint is " + kdewpoint2 + ") and (Electricity_Volt is " + kelectricity2 + ") " +
                      "then (Compressor_Speed is " + compressorSpeedBul(kuser2, kdiff2, kdewpoint2, kelectricity2) + ")" +
                      "(Fan_Speed is " + fanSpeedBul(kuser2, kdiff2, kdewpoint2, kelectricity2) + ")" +
                      "(Mode_Of_Operation is " + modBul(kuser2, kdiff2, kdewpoint2, kelectricity2) + " )" +
                      "(Fin_Direction is " + finDirectionBul(kuser2, kdiff2, kdewpoint2, kelectricity2) + ")(1)");



            }
        }


        public static string compressorSpeedBul(string x, string y, string z, string t)
        {
            if (x == "Low")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }
            }
            else if (x == "Optimal")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Medium";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Medium";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }
            }
            else if (x == "High")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Medium";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Medium";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Medium";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }
            }

            return "";
        }
        public static string fanSpeedBul(string x, string y, string z, string t)
        {
            if (x == "Low")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }
            }
            else if (x == "Optimal")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Medium";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Medium";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }
            }
            else if (x == "High")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Low";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Medium";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Medium";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Low";
                        }
                        else if (t == "High")
                        {
                            return "Fast";
                        }
                    }
                }
            }

            return "";
        }
        public static string modBul(string x, string y, string z, string t)
        {
            if (x == "Low")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "Dehumidifier";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                }
            }
            else if (x == "Optimal")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "Dehumidifier";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "Dehumidifier";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                }
            }
            else if (x == "High")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "Dehumidifier";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "Dehumidifier";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "AC";
                        }
                        else if (t == "High")
                        {
                            return "AC";
                        }
                    }
                }
            }

            return "";
        }
        public static string finDirectionBul(string x, string y, string z, string t)
        {
            if (x == "Low")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Away";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }
            }
            else if (x == "Optimal")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Away";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Away";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }
            }
            else if (x == "High")
            {
                if (y == "Negative")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Away";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Away";
                        }
                    }
                }

                else if (y == "Zero")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Away";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }

                else if (y == "Positive")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }

                else if (y == "Large")
                {
                    if (z == "Optimal")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                    else if (z == "Humid")
                    {
                        if (t == "Low")
                        {
                            return "Away";
                        }
                        else if (t == "High")
                        {
                            return "Toward";
                        }
                    }
                }
            }

            return "";
        }



    }
}
