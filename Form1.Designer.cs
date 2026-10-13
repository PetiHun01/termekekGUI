namespace termekekGUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgAdatok = new DataGridView();
            panel1 = new Panel();
            lbTermekAra = new Label();
            lbTermekNeve = new Label();
            rtTermekek = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbAfatartalom = new Label();
            lbBruttoar = new Label();
            btnMentes = new Button();
            btnElvet = new Button();
            panel2 = new Panel();
            dgAfakulcsonkenti = new DataGridView();
            label5 = new Label();
            lbLegdragabbNetto = new Label();
            lbAtlagBruttoAr = new Label();
            tbTermekNeve = new TextBox();
            tbNettoEgysegar = new TextBox();
            cbAfaKulcs = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgAdatok).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgAfakulcsonkenti).BeginInit();
            SuspendLayout();
            // 
            // dgAdatok
            // 
            dgAdatok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAdatok.Location = new Point(12, 12);
            dgAdatok.Name = "dgAdatok";
            dgAdatok.Size = new Size(534, 287);
            dgAdatok.TabIndex = 0;
            dgAdatok.CellClick += dgAdatok_CellClick;
            dgAdatok.CellContentClick += dgAdatok_CellContentClick;
            dgAdatok.SelectionChanged += dgAdatok_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(lbTermekAra);
            panel1.Controls.Add(lbTermekNeve);
            panel1.Location = new Point(12, 305);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // lbTermekAra
            // 
            lbTermekAra.AutoSize = true;
            lbTermekAra.Location = new Point(3, 35);
            lbTermekAra.Name = "lbTermekAra";
            lbTermekAra.Size = new Size(38, 15);
            lbTermekAra.TabIndex = 1;
            lbTermekAra.Text = "label1";
            // 
            // lbTermekNeve
            // 
            lbTermekNeve.AutoSize = true;
            lbTermekNeve.Location = new Point(3, 3);
            lbTermekNeve.Name = "lbTermekNeve";
            lbTermekNeve.Size = new Size(38, 15);
            lbTermekNeve.TabIndex = 0;
            lbTermekNeve.Text = "label1";
            // 
            // rtTermekek
            // 
            rtTermekek.Location = new Point(284, 305);
            rtTermekek.Name = "rtTermekek";
            rtTermekek.Size = new Size(262, 133);
            rtTermekek.TabIndex = 2;
            rtTermekek.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(552, 12);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 3;
            label1.Text = "Megnevezés:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(552, 40);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 4;
            label2.Text = "Nettó Egységár:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(552, 71);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Áfa kulcs:";
            // 
            // lbAfatartalom
            // 
            lbAfatartalom.AutoSize = true;
            lbAfatartalom.Location = new Point(572, 98);
            lbAfatartalom.Name = "lbAfatartalom";
            lbAfatartalom.Size = new Size(76, 15);
            lbAfatartalom.TabIndex = 6;
            lbAfatartalom.Text = "Áfa tartalom:";
            // 
            // lbBruttoar
            // 
            lbBruttoar.AutoSize = true;
            lbBruttoar.Location = new Point(572, 123);
            lbBruttoar.Name = "lbBruttoar";
            lbBruttoar.Size = new Size(58, 15);
            lbBruttoar.TabIndex = 7;
            lbBruttoar.Text = "Bruttó Ár:";
            // 
            // btnMentes
            // 
            btnMentes.Location = new Point(754, 35);
            btnMentes.Name = "btnMentes";
            btnMentes.Size = new Size(77, 23);
            btnMentes.TabIndex = 8;
            btnMentes.Text = "Mentés";
            btnMentes.UseVisualStyleBackColor = true;
            btnMentes.Click += btnMentes_Click;
            // 
            // btnElvet
            // 
            btnElvet.Location = new Point(754, 90);
            btnElvet.Name = "btnElvet";
            btnElvet.Size = new Size(77, 23);
            btnElvet.TabIndex = 9;
            btnElvet.Text = "Elvet";
            btnElvet.UseVisualStyleBackColor = true;
            btnElvet.Click += btnElvet_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 255);
            panel2.Controls.Add(dgAfakulcsonkenti);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lbLegdragabbNetto);
            panel2.Controls.Add(lbAtlagBruttoAr);
            panel2.Location = new Point(552, 170);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 235);
            panel2.TabIndex = 10;
            // 
            // dgAfakulcsonkenti
            // 
            dgAfakulcsonkenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAfakulcsonkenti.Location = new Point(20, 95);
            dgAfakulcsonkenti.Name = "dgAfakulcsonkenti";
            dgAfakulcsonkenti.Size = new Size(295, 137);
            dgAfakulcsonkenti.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 77);
            label5.Name = "label5";
            label5.Size = new Size(155, 15);
            label5.TabIndex = 2;
            label5.Text = "Áfakulcsonkénti darabszám:";
            // 
            // lbLegdragabbNetto
            // 
            lbLegdragabbNetto.AutoSize = true;
            lbLegdragabbNetto.Location = new Point(20, 48);
            lbLegdragabbNetto.Name = "lbLegdragabbNetto";
            lbLegdragabbNetto.Size = new Size(164, 15);
            lbLegdragabbNetto.TabIndex = 1;
            lbLegdragabbNetto.Text = "Legdrágább nettó árú termék:";
            // 
            // lbAtlagBruttoAr
            // 
            lbAtlagBruttoAr.AutoSize = true;
            lbAtlagBruttoAr.Location = new Point(20, 16);
            lbAtlagBruttoAr.Name = "lbAtlagBruttoAr";
            lbAtlagBruttoAr.Size = new Size(100, 15);
            lbAtlagBruttoAr.TabIndex = 0;
            lbAtlagBruttoAr.Text = "Átlagor Bruttó Ár:";
            // 
            // tbTermekNeve
            // 
            tbTermekNeve.Location = new Point(636, 9);
            tbTermekNeve.Name = "tbTermekNeve";
            tbTermekNeve.Size = new Size(130, 23);
            tbTermekNeve.TabIndex = 11;
            // 
            // tbNettoEgysegar
            // 
            tbNettoEgysegar.Location = new Point(648, 36);
            tbNettoEgysegar.Name = "tbNettoEgysegar";
            tbNettoEgysegar.Size = new Size(100, 23);
            tbNettoEgysegar.TabIndex = 12;
            tbNettoEgysegar.TextChanged += tbNettoEgysegar_TextChanged;
            // 
            // cbAfaKulcs
            // 
            cbAfaKulcs.FormattingEnabled = true;
            cbAfaKulcs.Location = new Point(616, 65);
            cbAfaKulcs.Name = "cbAfaKulcs";
            cbAfaKulcs.Size = new Size(48, 23);
            cbAfaKulcs.TabIndex = 13;
            cbAfaKulcs.SelectedIndexChanged += cbAfaKulcs_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Purple;
            ClientSize = new Size(1142, 450);
            Controls.Add(cbAfaKulcs);
            Controls.Add(tbNettoEgysegar);
            Controls.Add(tbTermekNeve);
            Controls.Add(panel2);
            Controls.Add(btnElvet);
            Controls.Add(btnMentes);
            Controls.Add(lbBruttoar);
            Controls.Add(lbAfatartalom);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtTermekek);
            Controls.Add(panel1);
            Controls.Add(dgAdatok);
            Name = "Form1";
            Text = "Termékek";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgAdatok).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgAfakulcsonkenti).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgAdatok;
        private Panel panel1;
        private Label lbTermekNeve;
        private RichTextBox rtTermekek;
        private Label lbTermekAra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbAfatartalom;
        private Label lbBruttoar;
        private Button btnMentes;
        private Button btnElvet;
        private Panel panel2;
        private Label lbLegdragabbNetto;
        private Label lbAtlagBruttoAr;
        private Label label5;
        private DataGridView dgAfakulcsonkenti;
        private TextBox tbTermekNeve;
        private TextBox tbNettoEgysegar;
        private ComboBox cbAfaKulcs;
    }
}
