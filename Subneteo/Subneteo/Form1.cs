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
        private int initMascOct1;
        private int initMascOct2;
        private int initMascOct3;
        private int initMascOct4;
        private int subReds;
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

        void MyInit()
        {
            groupBox2.Visible = false;
            slashLabel.Visible = false;
            slashBox.Visible = false;
            maskLabel.Visible = false;
            octBinarioLabel.Visible = false;
            octDecimalLabel.Visible = false;
            afectadoLabel.Visible = false;
            prestadosLabel.Visible = false;
            iterationsLabel.Visible = false;
            requiredBox.SelectedIndex = 0;
            initMascOct1Box.SelectedItem = 255;
        }

        void calcHost()
        {
            int hostBits = hostbits(requiredNumber);
            SubnetMask = new IP(1, hostBits);
        }

        void calcSubRedes()
        {
            int reds = redBits(requiredNumber);
            SubnetMask = new IP(InitialMask.Oct1Binary, InitialMask.Oct2Binary, InitialMask.Oct3Binary,
                InitialMask.Oct4Binary, reds);
        }

        //saca los bits de host que se ocuparan segun el # de host necesarios
        public int hostbits(int hostRequired)
        {
            int hostBits = 0;
            for (int i = 1; i < 100000000; i++)
            {
                int maxHost = (int)Math.Pow(2, i);
                if (maxHost - 2 >= hostRequired)
                {
                    hostBits = i;
                    break;
                }
            }
            return hostBits;
        }

        //devuelve numero de bits prestados que se ocuparan para la mascara de subred para redes
        public int redBits(int redsRequired)
        {
            int redBits = 0;
            for (int i = 1; i < 100000000; i++)
            {
                int maxRed = (int)Math.Pow(2, i);
                if (maxRed > redsRequired)
                {
                    redBits = i;
                    break;
                }
            }
            return redBits;
        }

        void buildInitMask()
        {
            if (radioIP.Checked)
            {
                InitialMask = new IP(initMascOct1, initMascOct2, initMascOct3, initMascOct4);
            }

            if (radioSlash.Checked)
            {
                buildInitMaskSlash();
            }
        }

        public void calcSubReds()
        {
            int initMask1 = 0;
            int subnetMask1 = 0;
            string initMask = InitialMask.Oct1Binary + InitialMask.Oct2Binary + InitialMask.Oct3Binary +
                            InitialMask.Oct4Binary;
            string subNet = SubnetMask.Oct1Binary + SubnetMask.Oct2Binary + SubnetMask.Oct3Binary +
                            SubnetMask.Oct4Binary;
            char[] initMaskArray = initMask.ToArray();
            char[] subNetMaskArray = subNet.ToArray();
            for (int i = 0; i < initMaskArray.Length; i++)
            {
                if (initMaskArray[i] == '1')
                {
                    initMask1 = initMask1 + 1;
                }
            }
            for (int i = 0; i < subNetMaskArray.Length; i++)
            {
                if (subNetMaskArray[i] == '1')
                {
                    subnetMask1 = subnetMask1 + 1;
                }
            }
            int temp = subnetMask1 - initMask1;
            subReds = (int)Math.Pow(2, temp);
        }

        void calcRangos()
        {
            calcSubReds();
            int tempS = subReds;
            int number = 1;
            int temp2;
            int count = 0;
            int itNumber = SubnetMask.IterationNumber;
            int temp = itNumber;
            int singleIterations = 256 / itNumber;


            if (SubnetMask.AffectedOct == 1)
            {

            }

            if (SubnetMask.AffectedOct == 2)
            {
                table.Rows.Add(number, IP.Oct1 + "." + 0 + "." + 0 + "." + 0,
                                IP.Oct1 + "." + 0 + "." + 0 + "." + 1,
                                IP.Oct1 + "." + 0 + "." + 255 + "." + 254,
                                IP.Oct1 + "." + (itNumber - 1) + "." + 255 + "." + 255);
                tempS = tempS - 1;
                number++;
                for (int i = 0; i < singleIterations - 1; i++)
                {
                    table.Rows.Add(number, IP.Oct1 + "." + itNumber + "." + 0 + "." + 0,
                                IP.Oct1 + "." + (itNumber + 1) + "." + 0 + "." + 1,
                                IP.Oct1 + "." + ((itNumber + temp) - 2) + "." + 255 + "." + 254,
                                IP.Oct1 + "." + ((itNumber + temp) - 1) + "." + 255 + "." + 255);
                    itNumber = itNumber + temp;
                    tempS = tempS - 1;
                    number++;
                }


                temp2 = tempS;
                while (temp2 > 0) {
                    count = count + 1;
                    if (tempS > 0)
                    {
                        itNumber = SubnetMask.IterationNumber;
                        table.Rows.Add(number, IP.Oct1 + count + "." + 0 + "." + 0 + "." + 0,
                                    IP.Oct1 + count + "." + 0 + "." + 0 + "." + 1,
                                    IP.Oct1 + count + "." + 0 + "." + 255 + "." + 254,
                                    IP.Oct1 + count + "." + (itNumber - 1) + "." + 255 + "." + 255);
                        temp2 = temp2 - 1;
                        number++;
                        for (int i = 0; i < 255; i++)
                        {
                            table.Rows.Add(number, IP.Oct1 + count + "." + itNumber + "." + 0 + "." + 0,
                                        IP.Oct1 + count + "." + (itNumber + 1) + "." + 0 + "." + 1,
                                        IP.Oct1 + count + "." + ((itNumber + temp) - 2) + "." + 255 + "." + 254,
                                        IP.Oct1 + count + "." + ((itNumber + temp) - 1) + "." + 255 + "." + 255);
                            itNumber = itNumber + temp;
                            temp2 = temp2 - 1;
                            number++;
                            if (temp2 == 0)
                            {
                                break;
                            }
                        }
                    }
                }

                
            }

            if (SubnetMask.AffectedOct == 3)
            {
                table.Rows.Add(number, IP.Oct1 + "." + 0 + "." + 0 + "." + 0,
                                IP.Oct1 + "." + 0 + "." + 1 + "." + 1,
                                IP.Oct1 + "." + 0 + "." + (itNumber - 2) + "." + 254,
                                IP.Oct1 + "." + 0 + "." + (itNumber - 1) + "." + 255);
                tempS = tempS - 1;
                number++;
                for (int i = 0; i < singleIterations - 1; i++)
                {
                    table.Rows.Add(number, IP.Oct1 + "." + 0 + "." + itNumber + "." + 0,
                                IP.Oct1 + "." + 0 + "." + (itNumber + 1)  + "." + 1,
                                IP.Oct1 + "." + 0 + "." + ((itNumber + temp) - 2) + "." + 254,
                                IP.Oct1 + "." + 0 + "." + ((itNumber + temp) - 1) + "." + 255);
                    itNumber = itNumber + temp;
                    tempS = tempS - 1;
                    number++;
                }

                
                temp2 = tempS;
                while (temp2 > 0)
                {
                    count = count + 1;
                    if (temp2 > 0)
                    {
                        itNumber = SubnetMask.IterationNumber;
                        table.Rows.Add(number, IP.Oct1 + "." + count + "." + 0 + "." + 0,
                               IP.Oct1 + "." + count + "." + 1 + "." + 1,
                               IP.Oct1 + "." + count + "." + (itNumber - 2) + "." + 254,
                               IP.Oct1 + "." + count + "." + (itNumber - 1) + "." + 255);
                        temp2 = temp2 - 1;
                        number++;

                        for (int i = 0; i < singleIterations - 1; i++)
                        {
                            table.Rows.Add(number, IP.Oct1 + "." + count + "." + itNumber + "." + 0,
                                        IP.Oct1 + "." + count + "." + (itNumber + 1) + "." + 1,
                                        IP.Oct1 + "." + count + "." + ((itNumber + temp) - 2) + "." + 254,
                                        IP.Oct1 + "." + count + "." + ((itNumber + temp) - 1) + "." + 255);
                            itNumber = itNumber + temp;
                            temp2 = temp2 - 1;
                            number++;

                            if (temp2 == 0)
                            {
                                break;
                            }
                        }
                    }
                }

                
            }

            if (SubnetMask.AffectedOct == 4)
            {
                table.Rows.Add(number, IP.Oct1 + "." + IP.Oct2 + "." + 0 + "." + 0,
                                IP.Oct1 + "." + IP.Oct2 + "." + 0 + "." + 1,
                                IP.Oct1 + "." + IP.Oct2 + "." + 0 + "." + (itNumber - 2),
                                IP.Oct1 + "." + IP.Oct2 + "." + 0 + "." + (itNumber - 1));
                tempS = tempS - 1;
                number++;

                for (int i = 0; i < singleIterations - 1; i++)
                {
                    table.Rows.Add(number, IP.Oct1 + "." + IP.Oct2 + "." + 0 + "." + itNumber,
                                IP.Oct1 + "." + IP.Oct2 + "." + 0 + "." + (itNumber + 1),
                                IP.Oct1 + "." + IP.Oct2 + "." + 0 + "." + ((itNumber + temp) - 2),
                                IP.Oct1 + "." + IP.Oct2 + "." + 0 + "." + ((itNumber + temp) - 1));
                    itNumber = itNumber + temp;
                    tempS = tempS - 1;
                    number++;

                }

                itNumber = SubnetMask.IterationNumber;
                temp2 = tempS;
                while (temp2 > 0)
                {
                    count = count + 1;
                    if (temp2 > 0)
                    {
                        itNumber = SubnetMask.IterationNumber;
                        table.Rows.Add(number, IP.Oct1 + "." + IP.Oct2 + "." + count + "." + 0,
                                IP.Oct1 + "." + IP.Oct2 + "." + count + "." + 1,
                                IP.Oct1 + "." + IP.Oct2 + "." + count + "." + (itNumber - 2),
                                IP.Oct1 + "." + IP.Oct2 + "." + count + "." + (itNumber - 1));
                        temp2 = temp2 - 1;
                        number++;

                        for (int i = 0; i < singleIterations - 1; i++)
                        {
                            table.Rows.Add(number, IP.Oct1 + "." + IP.Oct2 + "." + count + "." + itNumber,
                                        IP.Oct1 + "." + IP.Oct2 + "." + count + "." + (itNumber + 1),
                                        IP.Oct1 + "." + IP.Oct2 + "." + count + "." + ((itNumber + temp) - 2),
                                        IP.Oct1 + "." + IP.Oct2 + "." + count + "." + ((itNumber + temp) - 1));
                            itNumber = itNumber + temp;
                            temp2 = temp2 - 1;
                            number++;

                            if (temp2 == 0)
                            {
                                break;
                            }
                        }
                    }
                }



            }
        }

        void buildInitMaskSlash()
        {
            string binaryOctTemp = "";
            if (maskSlash > 0 && maskSlash <= 8)
            {
                initMascOct4 = 0;
                initMascOct3 = 0;
                initMascOct2 = 0;
                for (int i = 0; i < maskSlash; i++)
                {
                    binaryOctTemp += "1";
                }
                string oct1 = fillBinaryRigth(binaryOctTemp, "0");
                initMascOct1 = Convert.ToInt32(oct1, 2);
            }

            if (maskSlash > 8 && maskSlash <= 16)
            {
                initMascOct1 = 255;
                initMascOct4 = 0;
                initMascOct3 = 0;

                if (maskSlash == 16)
                {
                    binaryOctTemp = "11111111";
                } else
                {
                    for (int i = 0; i < maskSlash % 8; i++)
                    {
                        binaryOctTemp += "1";
                    }
                }
                
                string oct2 = fillBinaryRigth(binaryOctTemp, "0");
                initMascOct2 = Convert.ToInt32(oct2, 2);
            }

            if (maskSlash > 16 && maskSlash <= 24)
            {
                initMascOct1 = 255;
                initMascOct4 = 0;
                initMascOct2 = 255;

                if (maskSlash == 24)
                {
                    binaryOctTemp = "11111111";
                }
                else
                {
                    for (int i = 0; i < maskSlash % 8; i++)
                    {
                        binaryOctTemp += "1";
                    }
                }


                string oct3 = fillBinaryRigth(binaryOctTemp, "0");
                initMascOct3 = Convert.ToInt32(oct3, 2);
            }

            if (maskSlash > 24 && maskSlash <= 30)
            {
                initMascOct1 = 255;
                initMascOct2 = 255;
                initMascOct3 = 255;

                for (int i = 0; i < maskSlash % 8; i++)
                {
                    binaryOctTemp += "1";
                }

                string oct4 = fillBinaryRigth(binaryOctTemp, "0");
                initMascOct4 = Convert.ToInt32(oct4, 2);
            }
            InitialMask = new IP(initMascOct1, initMascOct2, initMascOct3, initMascOct4);
        }

        private string fillBinaryRigth(string n, string fillWith)
        {
            string filled = "";
            int lon = n.Length;
            int diff = 8 - lon;
            for (int i = 0; i < diff; i++)
            {
                filled += fillWith;
            }
            filled = n + filled;
            return filled;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            table.Rows.Clear();
            IP = null;
            InitialMask = null;
            SubnetMask = null;
            if (validateData())
            {
                IP = new IP(oct1, oct2, oct3, oct4);
                //contruir mascara inicial
                buildInitMask();
                if (requiredThing == 1)
                {
                    calcHost();
                }

                if (requiredThing == 0)
                {
                    calcSubRedes();
                }
                
                //ya tengo todas las ip ahora los rangos xd

            }
            
            SubnetMask.setIterationBits();
            calcRangos();

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

            if (IP != null)
            {
                Console.WriteLine("IP");
                Console.WriteLine(IP.toString());
            }

            if (InitialMask != null)
            {
                Console.WriteLine("Mascara Inicial");
                Console.WriteLine(InitialMask.toString());
            }

            groupBox2.Visible = true;
            maskLabel.Visible = true;
            octBinarioLabel.Text = SubnetMask.Oct1Binary + "." + SubnetMask.Oct2Binary + "." +
                                SubnetMask.Oct3Binary + "." + SubnetMask.Oct4Binary;
            octBinarioLabel.Visible = true;

            octDecimalLabel.Text = SubnetMask.Oct1 + "." + SubnetMask.Oct2 + "." + SubnetMask.Oct3 + "." +
                                    SubnetMask.Oct4;
            octDecimalLabel.Visible = true;

            afectadoLabel.Text = "Octeto Afectado: " + SubnetMask.AffectedOct;
            afectadoLabel.Visible = true;

            prestadosLabel.Text = "Bits prestados: " + SubnetMask.Bits;
            prestadosLabel.Visible = true;

            iterationsLabel.Text = "Iteraciones de " + SubnetMask.IterationNumber + 
                                    " en " + SubnetMask.IterationNumber;
            iterationsLabel.Visible = true;

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
            } catch (NullReferenceException)
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
                try
                {

                    maskSlash = Int32.Parse(slashBox.SelectedItem.ToString());
                    noCheck = true;
                }
                catch (NullReferenceException)
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
                } catch (NullReferenceException)
                {
                    noCheck = false;
                }
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

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
