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
            

        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
            var dp = new data_provider();
            if (!(txt_login.Text == "" || txt_pass.Text == ""))
            {
                byte[] cp = dp.CalcHash(txt_pass.Text);
                if (dp.authorization(txt_login.Text, cp))
                {
                    detalization f2 = new detalization();
                    f2.Show();
                    this.Hide();
                }
                else
                { MessageBox.Show("Невалидный login or pass"); }
            }
            else
            {
                MessageBox.Show("Не оставляйте поля пустыми!");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            detalization f2 = new detalization();
            f2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(850, 400);
        }
    }
}
