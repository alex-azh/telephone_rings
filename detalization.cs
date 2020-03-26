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
    public partial class detalization : Form
    {
        public detalization()
        {
            InitializeComponent();
        }

        private void btn_inn_Click(object sender, EventArgs e)
        {
            //на форме Abonents есть такие Label, как:
            //txt_inn, txt_address, txt_phone - это данные абонента по его ИНН из t_Abonents
            
            //Сделать: SQL-запрос в t_Abonents по домену "inn". Вывести всё в tbl_abon_rings

        }

        private void detalization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //рандомно заполните все таблицы так, чтобы: 
            //-был хотя бы 1 абонент
            //-хотя бы 1 город, в который звонил этот абонент
            //-два звонка этим абонентом
            //t_Sale просто создать
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            //вывести полностью таблицу t_Rings в tbl_rings
        }
    }
}
