namespace Subneteo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.slashBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.requiredBox = new System.Windows.Forms.ComboBox();
            this.requiredNumberInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.oct1Input = new System.Windows.Forms.NumericUpDown();
            this.oct4Input = new System.Windows.Forms.NumericUpDown();
            this.oct3Input = new System.Windows.Forms.NumericUpDown();
            this.oct2Input = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSlash = new System.Windows.Forms.RadioButton();
            this.radioIP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MascIPLabel = new System.Windows.Forms.Label();
            this.slashLabel = new System.Windows.Forms.Label();
            this.initMascOct1Box = new System.Windows.Forms.ComboBox();
            this.initMascOct4Box = new System.Windows.Forms.ComboBox();
            this.initMascOct3Box = new System.Windows.Forms.ComboBox();
            this.initMascOct2Box = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.requiredNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct4Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct3Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct2Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slashBox
            // 
            this.slashBox.FormattingEnabled = true;
            this.slashBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.slashBox.Location = new System.Drawing.Point(233, 75);
            this.slashBox.Name = "slashBox";
            this.slashBox.Size = new System.Drawing.Size(53, 21);
            this.slashBox.TabIndex = 1;
            this.slashBox.SelectedIndexChanged += new System.EventHandler(this.claseBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Requiero";
            // 
            // requiredBox
            // 
            this.requiredBox.FormattingEnabled = true;
            this.requiredBox.Items.AddRange(new object[] {
            "Subredes",
            "Host por subred"});
            this.requiredBox.Location = new System.Drawing.Point(165, 202);
            this.requiredBox.Name = "requiredBox";
            this.requiredBox.Size = new System.Drawing.Size(101, 21);
            this.requiredBox.TabIndex = 4;
            this.requiredBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // requiredNumberInput
            // 
            this.requiredNumberInput.Location = new System.Drawing.Point(74, 203);
            this.requiredNumberInput.Maximum = new decimal(new int[] {
            2147483646,
            0,
            0,
            0});
            this.requiredNumberInput.Name = "requiredNumberInput";
            this.requiredNumberInput.Size = new System.Drawing.Size(85, 20);
            this.requiredNumberInput.TabIndex = 6;
            this.requiredNumberInput.ValueChanged += new System.EventHandler(this.requiredNumberInput_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = ".";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = ".";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(279, 200);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 19;
            this.calcButton.Text = "Calcular";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // oct1Input
            // 
            this.oct1Input.Location = new System.Drawing.Point(50, 31);
            this.oct1Input.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.oct1Input.Name = "oct1Input";
            this.oct1Input.Size = new System.Drawing.Size(53, 20);
            this.oct1Input.TabIndex = 26;
            this.oct1Input.ValueChanged += new System.EventHandler(this.oct1Input_ValueChanged);
            // 
            // oct4Input
            // 
            this.oct4Input.Location = new System.Drawing.Point(272, 31);
            this.oct4Input.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.oct4Input.Name = "oct4Input";
            this.oct4Input.Size = new System.Drawing.Size(53, 20);
            this.oct4Input.TabIndex = 27;
            // 
            // oct3Input
            // 
            this.oct3Input.Location = new System.Drawing.Point(197, 31);
            this.oct3Input.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.oct3Input.Name = "oct3Input";
            this.oct3Input.Size = new System.Drawing.Size(53, 20);
            this.oct3Input.TabIndex = 28;
            this.oct3Input.ValueChanged += new System.EventHandler(this.oct3Input_ValueChanged);
            // 
            // oct2Input
            // 
            this.oct2Input.Location = new System.Drawing.Point(125, 31);
            this.oct2Input.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.oct2Input.Name = "oct2Input";
            this.oct2Input.Size = new System.Drawing.Size(53, 20);
            this.oct2Input.TabIndex = 29;
            this.oct2Input.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(412, 296);
            this.dataGridView1.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSlash);
            this.groupBox1.Controls.Add(this.radioIP);
            this.groupBox1.Location = new System.Drawing.Point(27, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 69);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mascara Inicial de Subred";
            // 
            // radioSlash
            // 
            this.radioSlash.AutoSize = true;
            this.radioSlash.Location = new System.Drawing.Point(18, 42);
            this.radioSlash.Name = "radioSlash";
            this.radioSlash.Size = new System.Drawing.Size(44, 17);
            this.radioSlash.TabIndex = 33;
            this.radioSlash.TabStop = true;
            this.radioSlash.Text = "/XX";
            this.radioSlash.UseVisualStyleBackColor = true;
            this.radioSlash.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioIP
            // 
            this.radioIP.AutoSize = true;
            this.radioIP.Checked = true;
            this.radioIP.Location = new System.Drawing.Point(18, 19);
            this.radioIP.Name = "radioIP";
            this.radioIP.Size = new System.Drawing.Size(35, 17);
            this.radioIP.TabIndex = 32;
            this.radioIP.TabStop = true;
            this.radioIP.Text = "IP";
            this.radioIP.UseVisualStyleBackColor = true;
            this.radioIP.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = ".";
            // 
            // MascIPLabel
            // 
            this.MascIPLabel.AutoSize = true;
            this.MascIPLabel.Location = new System.Drawing.Point(21, 159);
            this.MascIPLabel.Name = "MascIPLabel";
            this.MascIPLabel.Size = new System.Drawing.Size(49, 13);
            this.MascIPLabel.TabIndex = 32;
            this.MascIPLabel.Text = "Masc IP:";
            // 
            // slashLabel
            // 
            this.slashLabel.AutoSize = true;
            this.slashLabel.Location = new System.Drawing.Point(204, 78);
            this.slashLabel.Name = "slashLabel";
            this.slashLabel.Size = new System.Drawing.Size(12, 13);
            this.slashLabel.TabIndex = 40;
            this.slashLabel.Text = "/";
            // 
            // initMascOct1Box
            // 
            this.initMascOct1Box.FormattingEnabled = true;
            this.initMascOct1Box.Items.AddRange(new object[] {
            "128",
            "192",
            "224",
            "240",
            "248",
            "252",
            "254",
            "255"});
            this.initMascOct1Box.Location = new System.Drawing.Point(75, 158);
            this.initMascOct1Box.Name = "initMascOct1Box";
            this.initMascOct1Box.Size = new System.Drawing.Size(55, 21);
            this.initMascOct1Box.TabIndex = 41;
            this.initMascOct1Box.SelectedIndexChanged += new System.EventHandler(this.initMascOct1Box_SelectedIndexChanged);
            // 
            // initMascOct4Box
            // 
            this.initMascOct4Box.Enabled = false;
            this.initMascOct4Box.FormattingEnabled = true;
            this.initMascOct4Box.Location = new System.Drawing.Point(299, 156);
            this.initMascOct4Box.Name = "initMascOct4Box";
            this.initMascOct4Box.Size = new System.Drawing.Size(55, 21);
            this.initMascOct4Box.TabIndex = 42;
            // 
            // initMascOct3Box
            // 
            this.initMascOct3Box.Enabled = false;
            this.initMascOct3Box.FormattingEnabled = true;
            this.initMascOct3Box.Location = new System.Drawing.Point(227, 156);
            this.initMascOct3Box.Name = "initMascOct3Box";
            this.initMascOct3Box.Size = new System.Drawing.Size(55, 21);
            this.initMascOct3Box.TabIndex = 43;
            this.initMascOct3Box.SelectedIndexChanged += new System.EventHandler(this.initMascOct3Box_SelectedIndexChanged);
            // 
            // initMascOct2Box
            // 
            this.initMascOct2Box.Enabled = false;
            this.initMascOct2Box.FormattingEnabled = true;
            this.initMascOct2Box.Location = new System.Drawing.Point(150, 156);
            this.initMascOct2Box.Name = "initMascOct2Box";
            this.initMascOct2Box.Size = new System.Drawing.Size(55, 21);
            this.initMascOct2Box.TabIndex = 44;
            this.initMascOct2Box.SelectedIndexChanged += new System.EventHandler(this.initMascOct2Box_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.initMascOct2Box);
            this.Controls.Add(this.initMascOct3Box);
            this.Controls.Add(this.initMascOct4Box);
            this.Controls.Add(this.initMascOct1Box);
            this.Controls.Add(this.slashLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MascIPLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.oct2Input);
            this.Controls.Add(this.oct3Input);
            this.Controls.Add(this.oct4Input);
            this.Controls.Add(this.oct1Input);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.requiredNumberInput);
            this.Controls.Add(this.requiredBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.slashBox);
            this.Name = "Form1";
            this.Text = "Calculadora Subneteo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requiredNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct4Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct3Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct2Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox slashBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox requiredBox;
        private System.Windows.Forms.NumericUpDown requiredNumberInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.NumericUpDown oct1Input;
        private System.Windows.Forms.NumericUpDown oct4Input;
        private System.Windows.Forms.NumericUpDown oct3Input;
        private System.Windows.Forms.NumericUpDown oct2Input;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioSlash;
        private System.Windows.Forms.RadioButton radioIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MascIPLabel;
        private System.Windows.Forms.Label slashLabel;
        private System.Windows.Forms.ComboBox initMascOct1Box;
        private System.Windows.Forms.ComboBox initMascOct4Box;
        private System.Windows.Forms.ComboBox initMascOct3Box;
        private System.Windows.Forms.ComboBox initMascOct2Box;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

