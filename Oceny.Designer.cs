namespace Dzienniczekv2
{
    partial class Oceny
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_wyczysc = new System.Windows.Forms.Button();
            this.label_label = new System.Windows.Forms.Label();
            this.textBox_opis = new System.Windows.Forms.TextBox();
            this.textBox_studentId = new System.Windows.Forms.TextBox();
            this.DataGridView_ListaStudentow = new Guna.UI2.WinForms.Guna2DataGridView();
            this.comboBox_Wybierzkurs = new System.Windows.Forms.ComboBox();
            this.textBox_Ocena = new System.Windows.Forms.TextBox();
            this.label_Ocena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_pokazOceny = new System.Windows.Forms.Button();
            this.button_PokazStudenta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaStudentow)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_dodaj
            // 
            this.button_dodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_dodaj.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.button_dodaj.Location = new System.Drawing.Point(812, 518);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(143, 40);
            this.button_dodaj.TabIndex = 47;
            this.button_dodaj.Text = "Dodaj";
            this.button_dodaj.UseVisualStyleBackColor = false;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // button_wyczysc
            // 
            this.button_wyczysc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_wyczysc.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.button_wyczysc.Location = new System.Drawing.Point(812, 472);
            this.button_wyczysc.Name = "button_wyczysc";
            this.button_wyczysc.Size = new System.Drawing.Size(143, 40);
            this.button_wyczysc.TabIndex = 46;
            this.button_wyczysc.Text = "Wyczyść";
            this.button_wyczysc.UseVisualStyleBackColor = false;
            this.button_wyczysc.Click += new System.EventHandler(this.button_wyczysc_Click);
            // 
            // label_label
            // 
            this.label_label.AutoSize = true;
            this.label_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_label.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label_label.Location = new System.Drawing.Point(341, 77);
            this.label_label.Name = "label_label";
            this.label_label.Size = new System.Drawing.Size(48, 23);
            this.label_label.TabIndex = 45;
            this.label_label.Text = "Opis:";
            // 
            // textBox_opis
            // 
            this.textBox_opis.Location = new System.Drawing.Point(392, 476);
            this.textBox_opis.Multiline = true;
            this.textBox_opis.Name = "textBox_opis";
            this.textBox_opis.Size = new System.Drawing.Size(382, 89);
            this.textBox_opis.TabIndex = 44;
            // 
            // textBox_studentId
            // 
            this.textBox_studentId.Location = new System.Drawing.Point(155, 476);
            this.textBox_studentId.Name = "textBox_studentId";
            this.textBox_studentId.Size = new System.Drawing.Size(121, 20);
            this.textBox_studentId.TabIndex = 41;
            // 
            // DataGridView_ListaStudentow
            // 
            this.DataGridView_ListaStudentow.AllowUserToAddRows = false;
            this.DataGridView_ListaStudentow.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridView_ListaStudentow.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView_ListaStudentow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView_ListaStudentow.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView_ListaStudentow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView_ListaStudentow.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_ListaStudentow.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_ListaStudentow.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridView_ListaStudentow.ColumnHeadersHeight = 24;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_ListaStudentow.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView_ListaStudentow.EnableHeadersVisualStyles = false;
            this.DataGridView_ListaStudentow.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_ListaStudentow.Location = new System.Drawing.Point(12, 61);
            this.DataGridView_ListaStudentow.Name = "DataGridView_ListaStudentow";
            this.DataGridView_ListaStudentow.RowHeadersVisible = false;
            this.DataGridView_ListaStudentow.RowTemplate.Height = 50;
            this.DataGridView_ListaStudentow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView_ListaStudentow.Size = new System.Drawing.Size(943, 394);
            this.DataGridView_ListaStudentow.TabIndex = 39;
            this.DataGridView_ListaStudentow.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_ListaStudentow.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_ListaStudentow.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_ListaStudentow.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_ListaStudentow.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_ListaStudentow.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_ListaStudentow.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_ListaStudentow.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_ListaStudentow.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_ListaStudentow.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_ListaStudentow.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_ListaStudentow.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_ListaStudentow.ThemeStyle.HeaderStyle.Height = 24;
            this.DataGridView_ListaStudentow.ThemeStyle.ReadOnly = false;
            this.DataGridView_ListaStudentow.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_ListaStudentow.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_ListaStudentow.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridView_ListaStudentow.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_ListaStudentow.ThemeStyle.RowsStyle.Height = 50;
            this.DataGridView_ListaStudentow.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_ListaStudentow.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_ListaStudentow.Click += new System.EventHandler(this.DataGridView_ListaStudentow_Click);
            // 
            // comboBox_Wybierzkurs
            // 
            this.comboBox_Wybierzkurs.FormattingEnabled = true;
            this.comboBox_Wybierzkurs.Location = new System.Drawing.Point(155, 513);
            this.comboBox_Wybierzkurs.Name = "comboBox_Wybierzkurs";
            this.comboBox_Wybierzkurs.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Wybierzkurs.TabIndex = 48;
            // 
            // textBox_Ocena
            // 
            this.textBox_Ocena.Location = new System.Drawing.Point(155, 546);
            this.textBox_Ocena.Name = "textBox_Ocena";
            this.textBox_Ocena.Size = new System.Drawing.Size(121, 20);
            this.textBox_Ocena.TabIndex = 50;
            // 
            // label_Ocena
            // 
            this.label_Ocena.AutoSize = true;
            this.label_Ocena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_Ocena.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label_Ocena.Location = new System.Drawing.Point(12, 542);
            this.label_Ocena.Name = "label_Ocena";
            this.label_Ocena.Size = new System.Drawing.Size(63, 23);
            this.label_Ocena.TabIndex = 49;
            this.label_Ocena.Text = "Ocena:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID Studenta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Wybierz kurs:";
            // 
            // button_pokazOceny
            // 
            this.button_pokazOceny.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_pokazOceny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_pokazOceny.FlatAppearance.BorderSize = 0;
            this.button_pokazOceny.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.button_pokazOceny.Image = global::Dzienniczekv2.Properties.Resources.scorecard_32px;
            this.button_pokazOceny.Location = new System.Drawing.Point(779, 3);
            this.button_pokazOceny.Name = "button_pokazOceny";
            this.button_pokazOceny.Size = new System.Drawing.Size(176, 52);
            this.button_pokazOceny.TabIndex = 52;
            this.button_pokazOceny.Text = "Pokaż Oceny";
            this.button_pokazOceny.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_pokazOceny.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_pokazOceny.UseVisualStyleBackColor = false;
            this.button_pokazOceny.Click += new System.EventHandler(this.button_pokazOceny_Click);
            // 
            // button_PokazStudenta
            // 
            this.button_PokazStudenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_PokazStudenta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_PokazStudenta.FlatAppearance.BorderSize = 0;
            this.button_PokazStudenta.Font = new System.Drawing.Font("Yu Gothic UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.button_PokazStudenta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_PokazStudenta.Image = global::Dzienniczekv2.Properties.Resources.student_male_26px;
            this.button_PokazStudenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_PokazStudenta.Location = new System.Drawing.Point(12, 3);
            this.button_PokazStudenta.Name = "button_PokazStudenta";
            this.button_PokazStudenta.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.button_PokazStudenta.Size = new System.Drawing.Size(176, 52);
            this.button_PokazStudenta.TabIndex = 51;
            this.button_PokazStudenta.Text = "Pokaż Studenta";
            this.button_PokazStudenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_PokazStudenta.UseVisualStyleBackColor = false;
            this.button_PokazStudenta.Click += new System.EventHandler(this.button_PokazStudenta_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label_label);
            this.panel1.Location = new System.Drawing.Point(-10, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 123);
            this.panel1.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(387, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 29);
            this.label7.TabIndex = 54;
            this.label7.Text = "Dodaj Ocenę";
            // 
            // Oceny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(967, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_pokazOceny);
            this.Controls.Add(this.button_PokazStudenta);
            this.Controls.Add(this.textBox_Ocena);
            this.Controls.Add(this.label_Ocena);
            this.Controls.Add(this.comboBox_Wybierzkurs);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.button_wyczysc);
            this.Controls.Add(this.textBox_opis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_studentId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView_ListaStudentow);
            this.Controls.Add(this.panel1);
            this.Name = "Oceny";
            this.Text = "Oceny";
            this.Load += new System.EventHandler(this.Oceny_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_ListaStudentow)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_wyczysc;
        private System.Windows.Forms.Label label_label;
        private System.Windows.Forms.TextBox textBox_opis;
        private System.Windows.Forms.TextBox textBox_studentId;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_ListaStudentow;
        private System.Windows.Forms.ComboBox comboBox_Wybierzkurs;
        private System.Windows.Forms.TextBox textBox_Ocena;
        private System.Windows.Forms.Label label_Ocena;
        private System.Windows.Forms.Button button_PokazStudenta;
        private System.Windows.Forms.Button button_pokazOceny;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}