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
    public partial class Abonents : Form
    {
        public Abonents()
        {
            InitializeComponent();
        }

        private void Abonents_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            txt_address.Parent = pictureBox1;
            txt_address.BackColor = Color.Transparent;
            txt_inn.Parent = pictureBox1;
            txt_inn.BackColor = Color.Transparent;
            txt_phone.Parent = pictureBox1;
            txt_phone.BackColor = Color.Transparent;
        }

       
    }
}
