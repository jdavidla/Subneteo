using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subneteo
{
    public partial class Form1 : Form
    {
        
        private int oct1;
        private int oct2;
        private int oct3;
        private int oct4;
        private int requiredThing;
        private int maskSlash;
        private int requiredNumber;

        public Form1()
        {
            InitializeComponent();
        }

        void getData()
        {
            try
            {

                oct1 = Int32.Parse(oct1Input.Value.ToString());
                oct2 = Int32.Parse(oct2Input.Value.ToString());
                oct3 = Int32.Parse(this.oct3Input.Value.ToString());
                oct4 = Int32.Parse(this.oct4Input.Value.ToString());
                requiredNumber = Int32.Parse(this.requiredNumberInput.Value.ToString());
                maskSlash = Int32.Parse(slashBox.SelectedItem.ToString());
                requiredThing = Int32.Parse(requiredBox.SelectedIndex.ToString());
                Console.WriteLine("Octeto1 " + oct1);
                Console.WriteLine("Octeto2 " + oct2);
                Console.WriteLine("Octeto3 " + oct3);
                Console.WriteLine("Octeto4 " + oct4);
                Console.WriteLine("Required Number" + requiredNumber);
                Console.WriteLine("Mask Slash " + maskSlash);
                Console.WriteLine("required thing index " + requiredThing);

            }
            catch (NullReferenceException e)
            {
                MessageBox.Show("Seleccione todos los campos solicitados");
            }
        }

        bool validateData()
        {
            getData();
            string errorMessage = "";
            if (!(oct1 >= 0) || !(oct1 <= 255))
            {
                errorMessage += "Primer octeto de la IP no valido\n";
            }

            if (!(oct2 >= 0) || !(oct2 <= 255))
            {
                errorMessage += "Segundo octeto de la IP no valido\n";
            }

            if (!(oct1 >= 0) || !(oct1 <= 255))
            {
                errorMessage += "Tercer octeto de la IP no valido\n";
            }

            if (!(oct1 >= 0) || !(oct1 <= 255))
            {
                errorMessage += "Cuarto octeto de la IP no valido\n";
            }

            if (!(requiredNumber >= 0))
            {
                errorMessage += "No inserte datos negativos\n";
            }

            if (!errorMessage.Equals(""))
            {
                Console.WriteLine(errorMessage);
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (validateData())
            {

            }
            
        }

        private void claseBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oct3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void oct1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
