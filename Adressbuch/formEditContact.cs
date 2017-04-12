using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adressbuch
{
    public partial class formEditContact : Form
    {
        public formEditContact()
        {
            InitializeComponent();
        }


        private void formEditContact_Load(object sender, EventArgs e)
        {
            
        }

        // ofd and set contactPicture accordingly
        private void buttonKontaktBild_Click(object sender, EventArgs e)
        {
           if (ofdContactPicture.ShowDialog() == DialogResult.OK)
           {
                pictureBoxKontaktBild.ImageLocation = ofdContactPicture.FileName;
           }
        }//

        
    }
}