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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detalization));
            this.tbl_rings = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_inn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_inn = new System.Windows.Forms.TextBox();
            this.inn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summary_sale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_ring = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_rings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_rings
            // 
            this.tbl_rings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbl_rings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_rings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inn,
            this.City_name,
            this.datetime,
            this.minutes,
            this.time_day,
            this.summary_sale,
            this.cost});
            this.tbl_rings.Location = new System.Drawing.Point(-1, 68);
            this.tbl_rings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbl_rings.Name = "tbl_rings";
            this.tbl_rings.ReadOnly = true;
            this.tbl_rings.RowHeadersWidth = 51;
            this.tbl_rings.RowTemplate.Height = 24;
            this.tbl_rings.Size = new System.Drawing.Size(1060, 512);
            this.tbl_rings.TabIndex = 16;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(12, 15);
            this.btn_update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(112, 37);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Обновить";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_inn
            // 
            this.btn_inn.Location = new System.Drawing.Point(708, 12);
            this.btn_inn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inn.Name = "btn_inn";
            this.btn_inn.Size = new System.Drawing.Size(351, 37);
            this.btn_inn.TabIndex = 21;
            this.btn_inn.Text = "Вывести информацию об абоненте";
            this.btn_inn.UseVisualStyleBackColor = true;
            this.btn_inn.Click += new System.EventHandler(this.btn_inn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(515, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "ИНН:";
            // 
            // txt_inn
            // 
            this.txt_inn.Location = new System.Drawing.Point(563, 22);
            this.txt_inn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_inn.Name = "txt_inn";
            this.txt_inn.Size = new System.Drawing.Size(129, 22);
            this.txt_inn.TabIndex = 22;
            // 
            // inn
            // 
            this.inn.Frozen = true;
            this.inn.HeaderText = "ИНН";
            this.inn.MinimumWidth = 6;
            this.inn.Name = "inn";
            this.inn.ReadOnly = true;
            this.inn.Width = 125;
            // 
            // City_name
            // 
            this.City_name.Frozen = true;
            this.City_name.HeaderText = "Город";
            this.City_name.MinimumWidth = 6;
            this.City_name.Name = "City_name";
            this.City_name.ReadOnly = true;
            this.City_name.Width = 125;
            // 
            // datetime
            // 
            this.datetime.Frozen = true;
            this.datetime.HeaderText = "Время звонка";
            this.datetime.MinimumWidth = 6;
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            this.datetime.Width = 125;
            // 
            // minutes
            // 
            this.minutes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.minutes.HeaderText = "Минуты";
            this.minutes.MinimumWidth = 6;
            this.minutes.Name = "minutes";
            this.minutes.ReadOnly = true;
            this.minutes.Width = 88;
            // 
            // time_day
            // 
            this.time_day.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.time_day.HeaderText = "Тариф";
            this.time_day.MinimumWidth = 6;
            this.time_day.Name = "time_day";
            this.time_day.ReadOnly = true;
            this.time_day.Width = 24;
            // 
            // summary_sale
            // 
            this.summary_sale.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.summary_sale.HeaderText = "Скидка";
            this.summary_sale.MinimumWidth = 6;
            this.summary_sale.Name = "summary_sale";
            this.summary_sale.ReadOnly = true;
            this.summary_sale.Width = 84;
            // 
            // cost
            // 
            this.cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cost.HeaderText = "Стоимость";
            this.cost.MinimumWidth = 6;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 107;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1062, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(339, 15);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(146, 37);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "Очистить звонки";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_ring
            // 
            this.btn_ring.Location = new System.Drawing.Point(158, 15);
            this.btn_ring.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ring.Name = "btn_ring";
            this.btn_ring.Size = new System.Drawing.Size(146, 37);
            this.btn_ring.TabIndex = 26;
            this.btn_ring.Text = "Совершить звонок";
            this.btn_ring.UseVisualStyleBackColor = true;
            this.btn_ring.Click += new System.EventHandler(this.btn_ring_Click);
            // 
            // detalization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 576);
            this.Controls.Add(this.btn_ring);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_inn);
            this.Controls.Add(this.btn_inn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tbl_rings);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1080, 800);
            this.MinimumSize = new System.Drawing.Size(1080, 620);
            this.Name = "detalization";
            this.Text = "Детализация переговоров";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.detalization_FormClosed);
            this.Load += new System.EventHandler(this.detalization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_rings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView tbl_rings;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_inn;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inn;
        private System.Windows.Forms.DataGridViewTextBoxColumn City_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn minutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_day;
        private System.Windows.Forms.DataGridViewTextBoxColumn summary_sale;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_ring;
    }
}