using System;
using System.Collections;
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
            
            var dp = new data_provider();
            Abonents f2 = new Abonents();
            try
            {
                var dtAbon_info = dp.info_abon(txt_inn.Text); //загрузка данных абонента из t_Abonents
                foreach (DataRow lo_row in dtAbon_info.Rows)
                {
                    f2.txt_address.Text = Convert.ToString(lo_row["address"]);
                    f2.txt_inn.Text = Convert.ToString(lo_row["inn"]);
                    f2.txt_phone.Text = Convert.ToString(lo_row["phone"]);
                }
                var dtAbon_rings = dp.abon_rings(txt_inn.Text);//исключения не нужно, т.к. абонент уже существует
                foreach (DataRow lo_row in dtAbon_rings.Rows)
                {
                    f2.tbl_abon_rings.Rows.Add(lo_row["City_name"], lo_row["datetime"], lo_row["minutes"], lo_row["time_of_day"], lo_row["sale"], lo_row["cost"]);
                }
                f2.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
                

        }
    

        private void detalization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            var dp = new data_provider();
            tbl_rings.Rows.Clear();
            var dtRings = dp.update();
            foreach (DataRow lo_row in dtRings.Rows)
            {
                tbl_rings.Rows.Add(lo_row["inn"], lo_row["City_name"],lo_row["datetime"], lo_row["minutes"], lo_row["time_of_day"], lo_row["sale"], lo_row["cost"]);
            }
        }

        private void detalization_Load(object sender, EventArgs e)
        {
            //стилистические настройки
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            btn_update_Click(null, null);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var dp = new data_provider();
            dp.delete();
            tbl_rings.Rows.Clear();
        }

        private void btn_ring_Click(object sender, EventArgs e)
        {
            var tg = new to_generate();
            try
            {
                string a = tg.adding();
                var dp = new data_provider();
                dp.new_call(a);
                btn_update_Click(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
