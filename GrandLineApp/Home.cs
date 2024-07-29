using DockeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindowsForm
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonOpenFormGrandLine_Click(object sender, EventArgs e)
        {
            Hide();
            GrandLineForm grandLineForm = new();
            grandLineForm.ShowDialog();
            Show();
        }

        private void buttonOpenFormDocke_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();

                var login = ConfigurationManager.AppSettings["Login"];
                var password = ConfigurationManager.AppSettings["Password"];

                Docke docke = new(login!, password!);

                DockeForm dockeForm = new(docke);
                dockeForm.ShowDialog();
                Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                Show();
            }
            
        }
    }
}
