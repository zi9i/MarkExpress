using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager
{
    public partial class UserControlAllMatieres : UserControl
    {
        MatiereManager MManager = new MatiereManager();
        public void Actualiser()
        {
                GridMatieres.DataSource = MManager.ListerAllMatieres().ToList();
        }
        public UserControlAllMatieres()
        {
            InitializeComponent();
            Actualiser();
        }

        
    }
}
