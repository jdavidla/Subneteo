﻿using System;
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
        private int initMascOct1;
        private int initMascOct2;
        private int initMascOct3;
        private int initMascOct4;
        private bool noCheck;
        int[] validMaskValues = {0, 128, 192, 224, 240, 248, 252, 254, 255};
        private IP IP;
        private IP InitialMask;
        private IP SubnetMask;

        public Form1()
        {
            InitializeComponent();
            MyInit();
        }


        void calcHost()
        {
            int hostBits = hostbits(requiredNumber);
            SubnetMask = new IP(1, hostBits);
        }

        void calcSubRedes()
        {

        }

        public int hostbits(int hostRequired)
        {
            int hostBits = 0;
            for (int i = 1; i < 100000000; i++)
            {
                int maxHost = (int)Math.Pow(2, i);
                if (maxHost > hostRequired)
                {
                    hostBits = i;
                    break;
                }
            }
            return hostBits;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                Console.WriteLine("ahora si viene lo chido");
                IP = new IP(oct1, oct2, oct3, oct4);
                InitialMask = new IP(initMascOct1, initMascOct2, initMascOct3, initMascOct4);
                if (requiredThing == 1)
                {
                    calcHost();
                }

                if (requiredThing == 0)
                {
                    calcSubRedes();
                }
            }

        }

        void MyInit()
        {
            initMascOct1Box.Visible = false;
            initMascOct2Box.Visible = false;
            initMascOct3Box.Visible = false;
            initMascOct4Box.Visible = false;
            MascIPLabel.Visible = false;
            slashLabel.Visible = false;
            slashBox.Visible = false;
        }

        void hideSlash()
        {
            slashLabel.Visible = false;
            slashBox.Visible = false;
        }

        void hideIP()
        {
            initMascOct1Box.Visible = false;
            initMascOct2Box.Visible = false;
            initMascOct3Box.Visible = false;
            initMascOct4Box.Visible = false;
            MascIPLabel.Visible = false;
        }

        void getData()
        {
            
            try
            {
                string selectedChoise = requiredBox.SelectedItem.ToString();
                requiredThing = Int32.Parse(requiredBox.SelectedIndex.ToString());
                noCheck = true;
            } catch (NullReferenceException e)
            {
                
                noCheck = false;
            }
                
         
                
                oct1 = Int32.Parse(oct1Input.Value.ToString());
                oct2 = Int32.Parse(oct2Input.Value.ToString());
                oct3 = Int32.Parse(this.oct3Input.Value.ToString());
                oct4 = Int32.Parse(this.oct4Input.Value.ToString());
                requiredNumber = Int32.Parse(this.requiredNumberInput.Value.ToString());
                


                if (radioSlash.Checked)
            {
                Console.WriteLine("entro if checkeado");
                try
                {

                    maskSlash = Int32.Parse(slashBox.SelectedItem.ToString());
                    noCheck = true;
                }
                catch (NullReferenceException e)
                {
                    
                    noCheck = false;
                }
            }



                if (radioIP.Checked)
            {
                try
                {
                    initMascOct1 = Int32.Parse(initMascOct1Box.SelectedItem.ToString());
                    initMascOct2 = Int32.Parse(initMascOct2Box.SelectedItem.ToString());
                    initMascOct3 = Int32.Parse(initMascOct3Box.SelectedItem.ToString());
                    initMascOct4 = Int32.Parse(initMascOct4Box.SelectedItem.ToString());
                    noCheck = true;
                } catch (NullReferenceException e)
                {
                    noCheck = false;
                }
            }

                

                Console.WriteLine("Octeto1 " + oct1);
                Console.WriteLine("Octeto2 " + oct2);
                Console.WriteLine("Octeto3 " + oct3);
                Console.WriteLine("Octeto4 " + oct4);
                Console.WriteLine("Required Number" + requiredNumber);
                Console.WriteLine("Mask Slash " + maskSlash);
                Console.WriteLine("required thing index " + requiredThing);
                Console.WriteLine("Mask oct1: " + initMascOct1);
                Console.WriteLine("Mask oct2: " + initMascOct2);
                Console.WriteLine("Mask oct3: " + initMascOct3);
                Console.WriteLine("Mask oct4: " + initMascOct4);
                Console.WriteLine("massk slash: " + maskSlash);
            
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

            if (!(oct3 >= 0) || !(oct3 <= 255))
            {
                errorMessage += "Tercer octeto de la IP no valido\n";
            }

            if (!(oct4 >= 0) || !(oct4 <= 255))
            {
                errorMessage += "Cuarto octeto de la IP no valido\n";
            }



            if (!(initMascOct1 >= 0) || !(oct1 <= 255))
            {
                errorMessage += "Primer octeto de la IP no valido\n";
            }

            if (!(oct2 >= 0) || !(oct2 <= 255))
            {
                errorMessage += "Segundo octeto de la IP no valido\n";
            }

            if (!(oct3 >= 0) || !(oct3 <= 255))
            {
                errorMessage += "Tercer octeto de la IP no valido\n";
            }

            if (!(oct4 >= 0) || !(oct4 <= 255))
            {
                errorMessage += "Cuarto octeto de la IP no valido\n";
            }


            if (!(requiredNumber >= 0))
            {
                errorMessage += "No inserte datos negativos\n";
            }

            if (!errorMessage.Equals("") || !noCheck)
            {
                MessageBox.Show(errorMessage + "\nSeleccione todos los campos en pantalla");
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

        private void oct1Input_ValueChanged(object sender, EventArgs e)
        {

        }

        private void oct3Input_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hideSlash();
            initMascOct1Box.Visible = true;
            initMascOct2Box.Visible = true;
            initMascOct3Box.Visible = true;
            initMascOct4Box.Visible = true;
            MascIPLabel.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            hideIP();
            slashBox.Visible = true;
            slashLabel.Visible = true;
        }

        private void initMascOct1Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Int32.Parse(initMascOct1Box.SelectedItem.ToString());
            initMascOct2Box.Items.Clear();

            if (selected < 255)
            {
                initMascOct2Box.Items.Add(0);
                initMascOct2Box.SelectedItem = 0;
                initMascOct2Box.Enabled = false;
                return;
            }

            foreach (int n in validMaskValues)
            {
                if (selected == 255)
                {
                    initMascOct2Box.Items.Add(n);
                }
            }
            
            initMascOct2Box.Enabled = true;
        }

        private void initMascOct2Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Int32.Parse(initMascOct2Box.SelectedItem.ToString());
            initMascOct3Box.Items.Clear();

            if (selected < 255)
            {
                initMascOct3Box.Items.Add(0);
                initMascOct3Box.SelectedItem = 0;
                initMascOct3Box.Enabled = false;
                return;
            }

            foreach (int n in validMaskValues)
            {
                if (selected == 255)
                {
                    initMascOct3Box.Items.Add(n);
                }
            }

            initMascOct3Box.Enabled = true;
        }

        private void initMascOct3Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = Int32.Parse(initMascOct3Box.SelectedItem.ToString());
            initMascOct4Box.Items.Clear();

            if (selected < 255)
            {
                initMascOct4Box.Items.Add(0);
                initMascOct4Box.SelectedItem = 0;
                initMascOct4Box.Enabled = false;
                return;
            }

            foreach (int n in validMaskValues)
            {
                if (selected == 255)
                {
                    initMascOct4Box.Items.Add(n);
                }
            }

            initMascOct4Box.Enabled = true;
        }


    }
}