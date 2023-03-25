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
    public partial class Bulaniklastirma : Form
    {
        public Bulaniklastirma()
        {
            InitializeComponent();
        }
        public string buser;
        public string buser2;
        public string bdiff;
        public string bdiff2;
        public string bdewpoint;
        public string bdewpoint2;
        public string belectricity;
        public string belectricity2;
        private void Bulaniklastirma_Load(object sender, EventArgs e)
        {

            
                
            txt_BUser.Text = buser;
            txt_BUser2.Text = buser2;
            txt_BDiff.Text = bdiff;
            txt_BDiff2.Text = bdiff2;
            txt_BDewPoint.Text = bdewpoint;
            txt_BDewPoint2.Text = bdewpoint2;
            txt_BElectricity.Text = belectricity;
            txt_BElectricity2.Text = belectricity2;


        }
    }
}
