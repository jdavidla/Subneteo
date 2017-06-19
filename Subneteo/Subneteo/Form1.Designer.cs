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
            this.Mascara = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.requiredBox = new System.Windows.Forms.ComboBox();
            this.requiredNumberInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.rangosButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oct1Input = new System.Windows.Forms.NumericUpDown();
            this.oct4Input = new System.Windows.Forms.NumericUpDown();
            this.oct3Input = new System.Windows.Forms.NumericUpDown();
            this.oct2Input = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.requiredNumberInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct4Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct3Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct2Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.slashBox.Location = new System.Drawing.Point(206, 117);
            this.slashBox.Name = "slashBox";
            this.slashBox.Size = new System.Drawing.Size(64, 21);
            this.slashBox.TabIndex = 1;
            this.slashBox.SelectedIndexChanged += new System.EventHandler(this.claseBox_SelectedIndexChanged);
            // 
            // Mascara
            // 
            this.Mascara.AutoSize = true;
            this.Mascara.Location = new System.Drawing.Point(24, 120);
            this.Mascara.Name = "Mascara";
            this.Mascara.Size = new System.Drawing.Size(133, 13);
            this.Mascara.TabIndex = 1;
            this.Mascara.Text = "Mascara Inicial de Subred:";
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
            this.label3.Location = new System.Drawing.Point(24, 74);
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
            this.requiredBox.Location = new System.Drawing.Point(206, 71);
            this.requiredBox.Name = "requiredBox";
            this.requiredBox.Size = new System.Drawing.Size(121, 21);
            this.requiredBox.TabIndex = 4;
            this.requiredBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // requiredNumberInput
            // 
            this.requiredNumberInput.Location = new System.Drawing.Point(99, 72);
            this.requiredNumberInput.Name = "requiredNumberInput";
            this.requiredNumberInput.Size = new System.Drawing.Size(85, 20);
            this.requiredNumberInput.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = ".";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(313, 117);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 19;
            this.calcButton.Text = "Calcular";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // rangosButton
            // 
            this.rangosButton.Location = new System.Drawing.Point(427, 115);
            this.rangosButton.Name = "rangosButton";
            this.rangosButton.Size = new System.Drawing.Size(75, 23);
            this.rangosButton.TabIndex = 20;
            this.rangosButton.Text = "Ver Rangos:";
            this.rangosButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "/";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // oct1Input
            // 
            this.oct1Input.Location = new System.Drawing.Point(99, 31);
            this.oct1Input.Name = "oct1Input";
            this.oct1Input.Size = new System.Drawing.Size(85, 20);
            this.oct1Input.TabIndex = 26;
            // 
            // oct4Input
            // 
            this.oct4Input.Location = new System.Drawing.Point(417, 31);
            this.oct4Input.Name = "oct4Input";
            this.oct4Input.Size = new System.Drawing.Size(85, 20);
            this.oct4Input.TabIndex = 27;
            // 
            // oct3Input
            // 
            this.oct3Input.Location = new System.Drawing.Point(313, 31);
            this.oct3Input.Name = "oct3Input";
            this.oct3Input.Size = new System.Drawing.Size(85, 20);
            this.oct3Input.TabIndex = 28;
            // 
            // oct2Input
            // 
            this.oct2Input.Location = new System.Drawing.Point(206, 31);
            this.oct2Input.Name = "oct2Input";
            this.oct2Input.Size = new System.Drawing.Size(85, 20);
            this.oct2Input.TabIndex = 29;
            this.oct2Input.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 150);
            this.dataGridView1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 339);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.oct2Input);
            this.Controls.Add(this.oct3Input);
            this.Controls.Add(this.oct4Input);
            this.Controls.Add(this.oct1Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rangosButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.requiredNumberInput);
            this.Controls.Add(this.requiredBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mascara);
            this.Controls.Add(this.slashBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requiredNumberInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct4Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct3Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oct2Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox slashBox;
        private System.Windows.Forms.Label Mascara;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox requiredBox;
        private System.Windows.Forms.NumericUpDown requiredNumberInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button rangosButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown oct1Input;
        private System.Windows.Forms.NumericUpDown oct4Input;
        private System.Windows.Forms.NumericUpDown oct3Input;
        private System.Windows.Forms.NumericUpDown oct2Input;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

