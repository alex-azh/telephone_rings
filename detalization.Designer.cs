namespace Telephone_Ring
{
    partial class detalization
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
            this.tbl_rings = new System.Windows.Forms.DataGridView();
            this.City_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summary_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_inn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_inn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_rings)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_rings
            // 
            this.tbl_rings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbl_rings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_rings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City_name,
            this.datetime,
            this.minutes,
            this.time_day,
            this.summary_sale,
            this.cost});
            this.tbl_rings.Location = new System.Drawing.Point(-2, 65);
            this.tbl_rings.Name = "tbl_rings";
            this.tbl_rings.ReadOnly = true;
            this.tbl_rings.RowHeadersWidth = 51;
            this.tbl_rings.RowTemplate.Height = 24;
            this.tbl_rings.Size = new System.Drawing.Size(1021, 482);
            this.tbl_rings.TabIndex = 16;
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
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(129, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 37);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Обновить";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(12, 12);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(99, 37);
            this.btn_menu.TabIndex = 18;
            this.btn_menu.Text = "Назад";
            this.btn_menu.UseVisualStyleBackColor = true;
            // 
            // btn_inn
            // 
            this.btn_inn.Location = new System.Drawing.Point(708, 12);
            this.btn_inn.Name = "btn_inn";
            this.btn_inn.Size = new System.Drawing.Size(258, 37);
            this.btn_inn.TabIndex = 21;
            this.btn_inn.Text = "Вывести инф-ию об абоненте";
            this.btn_inn.UseVisualStyleBackColor = true;
            this.btn_inn.Click += new System.EventHandler(this.btn_inn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ИНН:";
            // 
            // txt_inn
            // 
            this.txt_inn.Location = new System.Drawing.Point(572, 22);
            this.txt_inn.Name = "txt_inn";
            this.txt_inn.Size = new System.Drawing.Size(130, 22);
            this.txt_inn.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 37);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить в БД записи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // detalization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_inn);
            this.Controls.Add(this.btn_inn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tbl_rings);
            this.Name = "detalization";
            this.Text = "Детализация переговоров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.detalization_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_rings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView tbl_rings;
        public System.Windows.Forms.DataGridViewTextBoxColumn City_name;
        public System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        public System.Windows.Forms.DataGridViewTextBoxColumn minutes;
        public System.Windows.Forms.DataGridViewTextBoxColumn time_day;
        public System.Windows.Forms.DataGridViewTextBoxColumn summary_sale;
        public System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_inn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_inn;
        private System.Windows.Forms.Button button1;
    }
}