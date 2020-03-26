using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Ring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //при успешной авторизации запихнуть код:
            bool auth_true = true;
            if (auth_true)
            {
                detalization f2 = new detalization();
                f2.Show();
                this.Hide();
            }

        }
    }
}
