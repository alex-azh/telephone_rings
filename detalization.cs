﻿using System;
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
            var dtAbon_info = dp.info_abon(txt_inn.Text);
            foreach (DataRow lo_row in dtAbon_info.Rows)
            {
                f2.txt_address.Text = Convert.ToString(lo_row["address"]);
                f2.txt_inn.Text = Convert.ToString(lo_row["inn"]);
                f2.txt_phone.Text = Convert.ToString(lo_row["phone"]);
            }
            var dtAbon_rings = dp.abon_rings(txt_inn.Text);
            foreach (DataRow lo_row in dtAbon_rings.Rows)
            {
                f2.tbl_abon_rings.Rows.Add(lo_row["City_name"], lo_row["datetime"], lo_row["minutes"], lo_row["time_of_day"], lo_row["sale"], lo_row["cost"]);
            }
            f2.ShowDialog();

        }
    

        private void detalization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new data_base();
            if (db.add_abon())
            {
                Stack<string> inn = db.inn, address = db.address, phone = db.phone;
                var dp = new data_provider();
                int tmp = inn.Count();
                while (!(tmp == 0))
                {
                    dp.reg_abon(ref inn, ref phone, ref address);
                    tmp--;
                }
                //button1.Enabled = false;
            }
            else { MessageBox.Show("Файлы повреждены: не совпадает кол-во строк или файлы пусты."); }
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
            btn_update_Click(null, null);
        }
    }
}
