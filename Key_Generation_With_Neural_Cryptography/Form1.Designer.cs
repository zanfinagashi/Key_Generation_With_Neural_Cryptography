namespace Key_Generation_With_Neural_Cryptography
{
    partial class NeuralCryptographyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuralCryptographyForm));
            this.dgv_A = new System.Windows.Forms.DataGridView();
            this.grb_TMP_A = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_B = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Key = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nud_L = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_N = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_K = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.btn_Generate_Key = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_A)).BeginInit();
            this.grb_TMP_A.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_B)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_K)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_A
            // 
            this.dgv_A.AllowUserToAddRows = false;
            this.dgv_A.AllowUserToDeleteRows = false;
            this.dgv_A.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgv_A.BackgroundColor = System.Drawing.Color.White;
            this.dgv_A.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_A.ColumnHeadersVisible = false;
            this.dgv_A.Location = new System.Drawing.Point(14, 3);
            this.dgv_A.Name = "dgv_A";
            this.dgv_A.ReadOnly = true;
            this.dgv_A.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_A.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_A.Size = new System.Drawing.Size(204, 179);
            this.dgv_A.TabIndex = 0;
            // 
            // grb_TMP_A
            // 
            this.grb_TMP_A.BackColor = System.Drawing.Color.Transparent;
            this.grb_TMP_A.Controls.Add(this.panel1);
            this.grb_TMP_A.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_TMP_A.ForeColor = System.Drawing.Color.Red;
            this.grb_TMP_A.Location = new System.Drawing.Point(46, 15);
            this.grb_TMP_A.Name = "grb_TMP_A";
            this.grb_TMP_A.Size = new System.Drawing.Size(247, 220);
            this.grb_TMP_A.TabIndex = 2;
            this.grb_TMP_A.TabStop = false;
            this.grb_TMP_A.Text = "Tree Parity Machine A";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_A);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(6, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 190);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(361, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 220);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree Parity Machine B";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_B);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(6, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 190);
            this.panel2.TabIndex = 0;
            // 
            // dgv_B
            // 
            this.dgv_B.AllowUserToAddRows = false;
            this.dgv_B.AllowUserToDeleteRows = false;
            this.dgv_B.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgv_B.BackgroundColor = System.Drawing.Color.White;
            this.dgv_B.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_B.ColumnHeadersVisible = false;
            this.dgv_B.Location = new System.Drawing.Point(14, 3);
            this.dgv_B.Name = "dgv_B";
            this.dgv_B.ReadOnly = true;
            this.dgv_B.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_B.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_B.Size = new System.Drawing.Size(204, 179);
            this.dgv_B.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txt_Key);
            this.groupBox2.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(46, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated Key";
            // 
            // txt_Key
            // 
            this.txt_Key.Location = new System.Drawing.Point(6, 18);
            this.txt_Key.Name = "txt_Key";
            this.txt_Key.Size = new System.Drawing.Size(550, 25);
            this.txt_Key.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.nud_L);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nud_N);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.nud_K);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(46, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 150);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set parameters";
            // 
            // nud_L
            // 
            this.nud_L.Location = new System.Drawing.Point(171, 107);
            this.nud_L.Name = "nud_L";
            this.nud_L.Size = new System.Drawing.Size(111, 25);
            this.nud_L.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Weight\'s Range (L)";
            // 
            // nud_N
            // 
            this.nud_N.Location = new System.Drawing.Point(171, 68);
            this.nud_N.Name = "nud_N";
            this.nud_N.Size = new System.Drawing.Size(111, 25);
            this.nud_N.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inupt neurons (N)";
            // 
            // nud_K
            // 
            this.nud_K.Location = new System.Drawing.Point(171, 29);
            this.nud_K.Name = "nud_K";
            this.nud_K.Size = new System.Drawing.Size(111, 25);
            this.nud_K.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hidden neurons (K)";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.txt_Status);
            this.groupBox4.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(367, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(241, 93);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(14, 23);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(204, 58);
            this.txt_Status.TabIndex = 1;
            // 
            // btn_Generate_Key
            // 
            this.btn_Generate_Key.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Generate_Key.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Generate_Key.Location = new System.Drawing.Point(367, 429);
            this.btn_Generate_Key.Name = "btn_Generate_Key";
            this.btn_Generate_Key.Size = new System.Drawing.Size(241, 51);
            this.btn_Generate_Key.TabIndex = 9;
            this.btn_Generate_Key.Text = "Generate Key";
            this.btn_Generate_Key.UseVisualStyleBackColor = false;
            this.btn_Generate_Key.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NeuralCryptographyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 526);
            this.Controls.Add(this.btn_Generate_Key);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_TMP_A);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NeuralCryptographyForm";
            this.Text = "Key Generation with Neural Cryptography - ©  Zanfina Gashi 2015";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_A)).EndInit();
            this.grb_TMP_A.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_B)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_K)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_A;
        private System.Windows.Forms.GroupBox grb_TMP_A;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_B;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Key;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.Button btn_Generate_Key;
        public System.Windows.Forms.NumericUpDown nud_K;
        public System.Windows.Forms.NumericUpDown nud_L;
        public System.Windows.Forms.NumericUpDown nud_N;
    }
}

