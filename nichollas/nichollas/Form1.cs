using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace nichollas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            #region Variáveis
            int a, b;
            a = 0;
            b = 2;

            #endregion

            #region Messagebox
            MessageBox.Show("#region");
            #endregion
            
            #region If-Else/Else-if
            

            if (a == 0 && b == 0)
            {
                MessageBox.Show("é igual");
            }
            else if (a == 0 && b == 1) {
                MessageBox.Show(" é diferente");
            }
            else
            {
                MessageBox.Show("nem um, nem outro");
            }
            #endregion
        }
    }
}
