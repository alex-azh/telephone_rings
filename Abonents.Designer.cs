namespace Telephone_Ring
{
    partial class Abonents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.Label();
            this.tbl_abon_rings = new System.Windows.Forms.DataGridView();
            this.City_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summary_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_inn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_abon_rings)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ИНН:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Адрес:";
            // 
            // txt_phone
            // 
            this.txt_phone.AutoSize = true;
            this.txt_phone.Location = new System.Drawing.Point(84, 40);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(0, 17);
            this.txt_phone.TabIndex = 5;
            // 
            // txt_address
            // 
            this.txt_address.AutoSize = true;
            this.txt_address.Location = new System.Drawing.Point(60, 66);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(198, 17);
            this.txt_address.TabIndex = 6;
            this.txt_address.Text = "г.Пермь, ул.Г.Хасана 38, 132";
            // 
            // tbl_abon_rings
            // 
            this.tbl_abon_rings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbl_abon_rings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_abon_rings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City_name,
            this.datetime,
            this.minutes,
            this.time_day,
            this.summary_sale,
            this.cost});
            this.tbl_abon_rings.Location = new System.Drawing.Point(3, 100);
            this.tbl_abon_rings.Name = "tbl_abon_rings";
            this.tbl_abon_rings.ReadOnly = true;
            this.tbl_abon_rings.RowHeadersWidth = 51;
            this.tbl_abon_rings.RowTemplate.Height = 24;
            this.tbl_abon_rings.Size = new System.Drawing.Size(1021, 1155);
            this.tbl_abon_rings.TabIndex = 17;
            // 
            // City_name
            // 
            this.City_name.HeaderText = "Город";
            this.City_name.MinimumWidth = 6;
            this.City_name.Name = "City_name";
            this.City_name.ReadOnly = true;
            this.City_name.Width = 125;
            // 
            // datetime
            // 
            this.datetime.HeaderText = "Время звонка";
            this.datetime.MinimumWidth = 6;
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            this.datetime.Width = 125;
            // 
            // minutes
            // 
            this.minutes.HeaderText = "Минуты";
            this.minutes.MinimumWidth = 6;
            this.minutes.Name = "minutes";
            this.minutes.ReadOnly = true;
            this.minutes.Width = 125;
            // 
            // time_day
            // 
            this.time_day.HeaderText = "Тариф";
            this.time_day.MinimumWidth = 6;
            this.time_day.Name = "time_day";
            this.time_day.ReadOnly = true;
            this.time_day.Width = 125;
            // 
            // summary_sale
            // 
            this.summary_sale.HeaderText = "Скидка";
            this.summary_sale.MinimumWidth = 6;
            this.summary_sale.Name = "summary_sale";
            this.summary_sale.ReadOnly = true;
            this.summary_sale.Width = 125;
            // 
            // cost
            // 
            this.cost.HeaderText = "Стоимость";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 125;
            // 
            // txt_inn
            // 
            this.txt_inn.AutoSize = true;
            this.txt_inn.Location = new System.Drawing.Point(60, 12);
            this.txt_inn.Name = "txt_inn";
            this.txt_inn.Size = new System.Drawing.Size(0, 17);
            this.txt_inn.TabIndex = 18;
            // 
            // Abonents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 573);
            this.Controls.Add(this.txt_inn);
            this.Controls.Add(this.tbl_abon_rings);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Abonents";
            this.Text = "Абоненты";
            this.Load += new System.EventHandler(this.Abonents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_abon_rings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label txt_phone;
        public System.Windows.Forms.Label txt_address;
        public System.Windows.Forms.DataGridView tbl_abon_rings;
        public System.Windows.Forms.DataGridViewTextBoxColumn City_name;
        public System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        public System.Windows.Forms.DataGridViewTextBoxColumn minutes;
        public System.Windows.Forms.DataGridViewTextBoxColumn time_day;
        public System.Windows.Forms.DataGridViewTextBoxColumn summary_sale;
        public System.Windows.Forms.DataGridViewTextBoxColumn cost;
        public System.Windows.Forms.Label txt_inn;
    }
}