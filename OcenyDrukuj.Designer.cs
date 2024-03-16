namespace Dzienniczekv2
{
    partial class OcenyDrukuj
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_szukajOceny = new System.Windows.Forms.TextBox();
            this.button_szukaj = new System.Windows.Forms.Button();
            this.button_drukuj = new System.Windows.Forms.Button();
            this.DataGridView_Oceny = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Oceny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_szukajOceny
            // 
            this.textBox_szukajOceny.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.textBox_szukajOceny.Location = new System.Drawing.Point(755, 17);
            this.textBox_szukajOceny.Name = "textBox_szukajOceny";
            this.textBox_szukajOceny.Size = new System.Drawing.Size(152, 30);
            this.textBox_szukajOceny.TabIndex = 61;
            this.textBox_szukajOceny.TextChanged += new System.EventHandler(this.textBox_szukajOceny_TextChanged);
            // 
            // button_szukaj
            // 
            this.button_szukaj.Image = global::Dzienniczekv2.Properties.Resources.search_26px;
            this.button_szukaj.Location = new System.Drawing.Point(913, 10);
            this.button_szukaj.Name = "button_szukaj";
            this.button_szukaj.Size = new System.Drawing.Size(42, 37);
            this.button_szukaj.TabIndex = 60;
            this.button_szukaj.UseVisualStyleBackColor = true;
            this.button_szukaj.Click += new System.EventHandler(this.button_szukaj_Click);
            // 
            // button_drukuj
            // 
            this.button_drukuj.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.button_drukuj.Location = new System.Drawing.Point(784, 541);
            this.button_drukuj.Name = "button_drukuj";
            this.button_drukuj.Size = new System.Drawing.Size(171, 31);
            this.button_drukuj.TabIndex = 59;
            this.button_drukuj.Text = "Drukuj";
            this.button_drukuj.UseVisualStyleBackColor = true;
            this.button_drukuj.Click += new System.EventHandler(this.button_drukuj_Click);
            // 
            // DataGridView_Oceny
            // 
            this.DataGridView_Oceny.AllowUserToAddRows = false;
            this.DataGridView_Oceny.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_Oceny.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Oceny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_Oceny.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_Oceny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_Oceny.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Oceny.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Oceny.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Oceny.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Oceny.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Oceny.EnableHeadersVisualStyles = false;
            this.DataGridView_Oceny.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Oceny.Location = new System.Drawing.Point(12, 63);
            this.DataGridView_Oceny.Name = "DataGridView_Oceny";
            this.DataGridView_Oceny.RowHeadersVisible = false;
            this.DataGridView_Oceny.RowTemplate.Height = 50;
            this.DataGridView_Oceny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_Oceny.Size = new System.Drawing.Size(943, 464);
            this.DataGridView_Oceny.TabIndex = 58;
            this.DataGridView_Oceny.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Oceny.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Oceny.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Oceny.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Oceny.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Oceny.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Oceny.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Oceny.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_Oceny.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Oceny.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_Oceny.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Oceny.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_Oceny.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_Oceny.ThemeStyle.ReadOnly = false;
            this.DataGridView_Oceny.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Oceny.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Oceny.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_Oceny.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Oceny.ThemeStyle.RowsStyle.Height = 50;
            this.DataGridView_Oceny.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Oceny.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Oceny.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Oceny_CellContentClick);
            this.DataGridView_Oceny.Click += new System.EventHandler(this.DataGridView_Oceny_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dzienniczekv2.Properties.Resources.print_64px;
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(81, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 29);
            this.label7.TabIndex = 62;
            this.label7.Text = "Wydrukuj Listę";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(-5, 525);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 57);
            this.panel1.TabIndex = 64;
            // 
            // OcenyDrukuj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(967, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_szukajOceny);
            this.Controls.Add(this.button_szukaj);
            this.Controls.Add(this.button_drukuj);
            this.Controls.Add(this.DataGridView_Oceny);
            this.Controls.Add(this.panel1);
            this.Name = "OcenyDrukuj";
            this.Text = "OcenyDrukuj";
            this.Load += new System.EventHandler(this.OcenyDrukuj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Oceny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_szukajOceny;
        private System.Windows.Forms.Button button_szukaj;
        private System.Windows.Forms.Button button_drukuj;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Oceny;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}