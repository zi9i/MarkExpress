using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Manager;

namespace MarkExpress
{
    public partial class Form1 : MetroForm{

        public ctrlEtudiants ctrlE;

        public Form1()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
                ctrlE = new ctrlEtudiants();
                ctrlE.Parent = this;
                ctrlE.Location = new Point(223, 63);
                ctrlE.Show();
        }
    }
}
