namespace Dzienniczekv2
{
    partial class ZarzadzajOceny
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
            this.textBox_szukaj = new System.Windows.Forms.TextBox();
            this.button_usun = new System.Windows.Forms.Button();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_wyczysc = new System.Windows.Forms.Button();
            this.label_opis = new System.Windows.Forms.Label();
            this.textBox_opis = new System.Windows.Forms.TextBox();
            this.textBox_Ocena = new System.Windows.Forms.TextBox();
            this.label_Ocena = new System.Windows.Forms.Label();
            this.textBox_StudentId = new System.Windows.Forms.TextBox();
            this.label_StudentId = new System.Windows.Forms.Label();
            this.DataGridView_ZarzadzajOceny = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboBox_Wybierzkurs = new System.Windows.Forms.ComboBox();
            this.label_wybierzKurs = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_szukaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ZarzadzajOceny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_szukaj
            // 
            this.textBox_szukaj.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.textBox_szukaj.Location = new System.Drawing.Point(718, 18);
            this.textBox_szukaj.Multiline = true;
            this.textBox_szukaj.Name = "textBox_szukaj";
            this.textBox_szukaj.Size = new System.Drawing.Size(193, 30);
            this.textBox_szukaj.TabIndex = 65;
            // 
            // button_usun
            // 
            this.button_usun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_usun.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.button_usun.Location = new System.Drawing.Point(817, 475);
            this.button_usun.Name = "button_usun";
            this.button_usun.Size = new System.Drawing.Size(89, 40);
            this.button_usun.TabIndex = 63;
            this.button_usun.Text = "Usuń";
            this.button_usun.UseVisualStyleBackColor = false;
            this.button_usun.Click += new System.EventHandler(this.button_usun_Click);
            // 
            // button_dodaj
            // 
            this.button_dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_dodaj.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.button_dodaj.Location = new System.Drawing.Point(718, 524);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(188, 40);
            this.button_dodaj.TabIndex = 60;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = false;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // button_wyczysc
            // 
            this.button_wyczysc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_wyczysc.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.button_wyczysc.Location = new System.Drawing.Point(718, 475);
            this.button_wyczysc.Name = "button_wyczysc";
            this.button_wyczysc.Size = new System.Drawing.Size(89, 40);
            this.button_wyczysc.TabIndex = 59;
            this.button_wyczysc.Text = "Wyczyść";
            this.button_wyczysc.UseVisualStyleBackColor = false;
            this.button_wyczysc.Click += new System.EventHandler(this.button_wyczysc_Click);
            // 
            // label_opis
            // 
            this.label_opis.AutoSize = true;
            this.label_opis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_opis.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label_opis.Location = new System.Drawing.Point(288, 545);
            this.label_opis.Name = "label_opis";
            this.label_opis.Size = new System.Drawing.Size(44, 23);
            this.label_opis.TabIndex = 58;
            this.label_opis.Text = "Opis";
            // 
            // textBox_opis
            // 
            this.textBox_opis.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox_opis.Location = new System.Drawing.Point(338, 475);
            this.textBox_opis.Multiline = true;
            this.textBox_opis.Name = "textBox_opis";
            this.textBox_opis.Size = new System.Drawing.Size(352, 89);
            this.textBox_opis.TabIndex = 57;
            // 
            // textBox_Ocena
            // 
            this.textBox_Ocena.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox_Ocena.Location = new System.Drawing.Point(139, 508);
            this.textBox_Ocena.Name = "textBox_Ocena";
            this.textBox_Ocena.Size = new System.Drawing.Size(121, 27);
            this.textBox_Ocena.TabIndex = 56;
            // 
            // label_Ocena
            // 
            this.label_Ocena.AutoSize = true;
            this.label_Ocena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_Ocena.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label_Ocena.Location = new System.Drawing.Point(12, 508);
            this.label_Ocena.Name = "label_Ocena";
            this.label_Ocena.Size = new System.Drawing.Size(59, 23);
            this.label_Ocena.TabIndex = 55;
            this.label_Ocena.Text = "Ocena";
            // 
            // textBox_StudentId
            // 
            this.textBox_StudentId.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.textBox_StudentId.Location = new System.Drawing.Point(139, 471);
            this.textBox_StudentId.Name = "textBox_StudentId";
            this.textBox_StudentId.Size = new System.Drawing.Size(31, 27);
            this.textBox_StudentId.TabIndex = 54;
            // 
            // label_StudentId
            // 
            this.label_StudentId.AutoSize = true;
            this.label_StudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_StudentId.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label_StudentId.Location = new System.Drawing.Point(12, 475);
            this.label_StudentId.Name = "label_StudentId";
            this.label_StudentId.Size = new System.Drawing.Size(92, 23);
            this.label_StudentId.TabIndex = 53;
            this.label_StudentId.Text = "Student ID";
            // 
            // DataGridView_ZarzadzajOceny
            // 
            this.DataGridView_ZarzadzajOceny.AllowUserToAddRows = false;
            this.DataGridView_ZarzadzajOceny.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_ZarzadzajOceny.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_ZarzadzajOceny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_ZarzadzajOceny.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_ZarzadzajOceny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_ZarzadzajOceny.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_ZarzadzajOceny.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_ZarzadzajOceny.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_ZarzadzajOceny.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_ZarzadzajOceny.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_ZarzadzajOceny.EnableHeadersVisualStyles = false;
            this.DataGridView_ZarzadzajOceny.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_ZarzadzajOceny.Location = new System.Drawing.Point(12, 57);
            this.DataGridView_ZarzadzajOceny.Name = "DataGridView_ZarzadzajOceny";
            this.DataGridView_ZarzadzajOceny.RowHeadersVisible = false;
            this.DataGridView_ZarzadzajOceny.RowTemplate.Height = 50;
            this.DataGridView_ZarzadzajOceny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_ZarzadzajOceny.Size = new System.Drawing.Size(943, 398);
            this.DataGridView_ZarzadzajOceny.TabIndex = 52;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_ZarzadzajOceny.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_ZarzadzajOceny.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_ZarzadzajOceny.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.ReadOnly = false;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_ZarzadzajOceny.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_ZarzadzajOceny.ThemeStyle.RowsStyle.Height = 50;
            this.DataGridView_ZarzadzajOceny.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_ZarzadzajOceny.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_ZarzadzajOceny.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_ZarzadzajOceny_CellContentClick);
            this.DataGridView_ZarzadzajOceny.Click += new System.EventHandler(this.DataGridView_ZarzadzajOceny_Click);
            // 
            // comboBox_Wybierzkurs
            // 
            this.comboBox_Wybierzkurs.FormattingEnabled = true;
            this.comboBox_Wybierzkurs.Location = new System.Drawing.Point(139, 545);
            this.comboBox_Wybierzkurs.Name = "comboBox_Wybierzkurs";
            this.comboBox_Wybierzkurs.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Wybierzkurs.TabIndex = 67;
            // 
            // label_wybierzKurs
            // 
            this.label_wybierzKurs.AutoSize = true;
            this.label_wybierzKurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_wybierzKurs.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label_wybierzKurs.Location = new System.Drawing.Point(12, 541);
            this.label_wybierzKurs.Name = "label_wybierzKurs";
            this.label_wybierzKurs.Size = new System.Drawing.Size(109, 23);
            this.label_wybierzKurs.TabIndex = 66;
            this.label_wybierzKurs.Text = "Wybierz kurs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(71, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 29);
            this.label7.TabIndex = 68;
            this.label7.Text = "Zarządzaj ocenami";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(-7, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 130);
            this.panel1.TabIndex = 70;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dzienniczekv2.Properties.Resources.scorecard_80px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // button_szukaj
            // 
            this.button_szukaj.Image = global::Dzienniczekv2.Properties.Resources.search_26px;
            this.button_szukaj.Location = new System.Drawing.Point(915, 14);
            this.button_szukaj.Name = "button_szukaj";
            this.button_szukaj.Size = new System.Drawing.Size(40, 41);
            this.button_szukaj.TabIndex = 64;
            this.button_szukaj.UseVisualStyleBackColor = true;
            this.button_szukaj.Click += new System.EventHandler(this.button_szukaj_Click);
            // 
            // ZarzadzajOceny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_Wybierzkurs);
            this.Controls.Add(this.label_wybierzKurs);
            this.Controls.Add(this.textBox_szukaj);
            this.Controls.Add(this.button_szukaj);
            this.Controls.Add(this.button_usun);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.button_wyczysc);
            this.Controls.Add(this.label_opis);
            this.Controls.Add(this.textBox_opis);
            this.Controls.Add(this.textBox_Ocena);
            this.Controls.Add(this.label_Ocena);
            this.Controls.Add(this.textBox_StudentId);
            this.Controls.Add(this.label_StudentId);
            this.Controls.Add(this.DataGridView_ZarzadzajOceny);
            this.Controls.Add(this.panel1);
            this.Name = "ZarzadzajOceny";
            this.Text = "ZarzadzajOceny";
            this.Load += new System.EventHandler(this.ZarzadzajOceny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ZarzadzajOceny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_szukaj;
        private System.Windows.Forms.Button button_szukaj;
        private System.Windows.Forms.Button button_usun;
        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_wyczysc;
        private System.Windows.Forms.Label label_opis;
        private System.Windows.Forms.TextBox textBox_opis;
        private System.Windows.Forms.TextBox textBox_Ocena;
        private System.Windows.Forms.Label label_Ocena;
        private System.Windows.Forms.TextBox textBox_StudentId;
        private System.Windows.Forms.Label label_StudentId;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_ZarzadzajOceny;
        private System.Windows.Forms.ComboBox comboBox_Wybierzkurs;
        private System.Windows.Forms.Label label_wybierzKurs;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}