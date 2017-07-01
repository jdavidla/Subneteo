using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subneteo
{
    public class IP
    {
        private int oct1;
        private int oct2;
        private int oct3;
        private int oct4;
        private string oct1Binary;
        private string oct2Binary;
        private string oct3Binary;
        private string oct4Binary;
        private int type;
        private int bits;
        private int affectedOct;
        private int reds;
        private int iterationBits;
        private int iterationNumber;

        private string initMaskOct1Binary;
        private string initMaskOct2Binary;
        private string initMaskOct3Binary;
        private string initMaskOct4Binary;

        public IP(int oct1, int oct2, int oct3, int oct4)
        {
            this.oct1 = oct1;
            this.oct2 = oct2;
            this.oct3 = oct3;
            this.oct4 = oct4;
            convertAlltoBinary();
        }

        public IP(int type, int bits)
        {
            this.bits = bits;
            this.type = type;
            buildSubnetIP();
        }

        public IP(string initMaskOct1Binary, string initMaskOct2Binary, string initMaskOct3Binary,
            string initMaskOct4Binary, int reds)
        {
            
            this.bits = reds;
            this.initMaskOct1Binary = initMaskOct1Binary;
            this.initMaskOct2Binary = initMaskOct2Binary;
            this.initMaskOct3Binary = initMaskOct3Binary;
            this.initMaskOct4Binary = initMaskOct4Binary;
            buildRedIP();
        }

        public int unoCountAff()
        {
            int count = 0;
            char[] temp;
            if (affectedOct == 1)
            {
                temp = oct1Binary.ToArray();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == '1')
                    {
                        count = count + 1;
                    }
                }
            }
            if (affectedOct == 2)
            {
                temp = oct2Binary.ToArray();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == '1')
                    {
                        count = count + 1;
                    }
                }
            }
            if (affectedOct == 3)
            {
                temp = oct3Binary.ToArray();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == '1')
                    {
                        count = count + 1;
                    }
                }
            }
            if (affectedOct == 4)
            {
                temp = oct4Binary.ToArray();
                for (int i = 0; i < temp.Length; i++)
                {
                    if (temp[i] == '1')
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
        public void setIterationBits()
        {
            if (affectedOct == 1)
            {
                setIterationBits(oct1Binary);
            }
            if (affectedOct == 2)
            {
                setIterationBits(oct2Binary);
            }
            if (affectedOct == 3)
            {
                setIterationBits(oct3Binary);
            }
            if (affectedOct == 4)
            {
                setIterationBits(oct4Binary);
            }
        }

        public void setIterationBits(string octBinary)
        {
            int count = 0;
            char[] array = octBinary.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '0')
                {
                    count += 1;
                }
            }
            iterationBits = count;
            iterationNumber = (int)Math.Pow(2, iterationBits);
        }

        private void buildRedIP()
        {
            oct1Binary = "";
            oct2Binary = "";
            oct3Binary = "";
            oct4Binary = "";

            int affectedBit = 0;
            int temp = bits;
            string initMaskJoinedIPTemp = initMaskOct1Binary + initMaskOct2Binary + 
                initMaskOct3Binary + initMaskOct4Binary;
            char[] initMaskJoinedIP = initMaskJoinedIPTemp.ToCharArray();
            for (int i = 0; i < initMaskJoinedIP.Length; i++)
            {
                if (initMaskJoinedIP[i] == '0')
                {
                    temp = temp - 1;
                    initMaskJoinedIP[i] = '1';
                    
                }
                if (temp == 0)
                {
                    affectedBit = i;
                    break;
                }
            }
            for (int e = 0; e < initMaskJoinedIP.Length; e++)
            {
                if (e >= 0 && e <= 7)
                {
                    oct1Binary += initMaskJoinedIP[e] + "";
                }
                if (e >= 8 && e <= 15)
                {
                    oct2Binary += initMaskJoinedIP[e] + "";
                }
                if (e >= 16 && e <= 23)
                {
                    oct3Binary += initMaskJoinedIP[e] + "";
                }
                if (e >= 24 && e <= 31)
                {
                    oct4Binary += initMaskJoinedIP[e] + "";
                }
            }

            if (affectedBit >= 0 && affectedBit <= 7)
            {
                affectedOct = 1;
            }
            if (affectedBit >= 8 && affectedBit <= 15)
            {
                affectedOct = 2;
            }
            if (affectedBit >= 16 && affectedBit <= 23)
            {
                affectedOct = 3;
            }
            if (affectedBit >= 24 && affectedBit <= 31)
            {
                affectedOct = 4;
            }
            oct1 = Convert.ToInt32(oct1Binary, 2);
            oct2 = Convert.ToInt32(oct2Binary, 2);
            oct3 = Convert.ToInt32(oct3Binary, 2);
            oct4 = Convert.ToInt32(oct4Binary, 2);
        }

        public string charArrayToString(char[] array)
        {
            string joined = "";
            for (int i = 0; i < array.Length; i++)
            {
                joined = array[i] + "";
            }
            return joined;
        }

        private void buildSubnetIP()
        {
            if (type == 1)
            {
                buildHostIP();
            }

            if (type == 0)
            {
                buildRedIP();
            }
        }



        //construye la mascara de subnet si me pidieron host
        private void buildHostIP()
        {
            if (bits > 0 && bits <= 8)
            {
                oct1Binary = "11111111";
                oct1 = 255;
                oct2Binary = "11111111";
                oct2 = 255;
                oct3Binary = "11111111";
                oct3 = 255;
                string oct4BinaryTemp = "";
                oct4 = 0;
                for (int i = 0; i < bits; i++)
                {
                    oct4BinaryTemp += "0";
                }
                oct4Binary = fillBinaryLeft(oct4BinaryTemp, "1");
                affectedOct = 4;
                //transformar el oct 4 con el que tengo binario a decimal
                oct4 = Convert.ToInt32(oct4Binary, 2);
            }

            if (bits >= 9 && bits <= 16)
            {
                oct1Binary = "11111111";
                oct1 = 255;
                oct2Binary = "11111111";
                oct2 = 255;
                oct4Binary = "00000000";
                oct4 = 0;
                string oct3BinaryTemp = "";
                oct3 = 0;
                for (int i = 0; i < bits - 8; i++)
                {
                    oct3BinaryTemp += "0";
                }
                oct3Binary = fillBinaryLeft(oct3BinaryTemp, "1");
                affectedOct = 3;
                //transformar el tercer oct que tengo binario a decimal
                oct3 = Convert.ToInt32(oct3Binary, 2);
            }

            if (bits >= 17 && bits <= 24)
            {
                oct1Binary = "11111111";
                oct1 = 255;
                oct3Binary = "00000000";
                oct3 = 0;
                oct4Binary = "00000000";
                oct4 = 0;
                string oct2BinaryTemp = "";
                oct3 = 0;
                for (int i = 0; i < bits - 16; i++)
                {
                    oct2BinaryTemp += "0";
                }
                oct2Binary = fillBinaryLeft(oct2BinaryTemp, "1");
                affectedOct = 2;
                //transformar el 2 oct que tengo binario a decimal
                oct2 = Convert.ToInt32(oct2Binary, 2);
            }

            if (bits >= 25 && bits > 32)
            {
                oct2Binary = "00000000";
                oct2 = 0;
                oct3Binary = "00000000";
                oct3 = 0;
                oct4Binary = "00000000";
                oct4 = 0;
                string oct1BinaryTemp = "";
                oct3 = 0;
                for (int i = 0; i < bits - 24; i++)
                {
                    oct1BinaryTemp += "0";
                }
                oct1Binary = fillBinaryLeft(oct1BinaryTemp, "1");
                affectedOct = 1;
                //transformar el 1 oct que tengo binario a decimal
                oct1 = Convert.ToInt32(oct1Binary, 2);
            }
        }



        //agarra los octs en decimal y pasa a binario rellenando 0
        private void convertAlltoBinary()
        {
            string oct1BinaryTemp = Convert.ToString(oct1, 2);
            string oct2BinaryTemp = Convert.ToString(oct2, 2);
            string oct3BinaryTemp = Convert.ToString(oct3, 2);
            string oct4BinaryTemp = Convert.ToString(oct4, 2);
            oct1Binary = fillBinaryLeft(oct1BinaryTemp, "0");
            oct2Binary = fillBinaryLeft(oct2BinaryTemp, "0");
            oct3Binary = fillBinaryLeft(oct3BinaryTemp, "0");
            oct4Binary = fillBinaryLeft(oct4BinaryTemp, "0");
        }

        //rellenar con parametro fillWith a la izquierda un numero binario que esta en string
        private string fillBinaryLeft(string n, string fillWith)
        {
            string filled = "";
            int lon = n.Length;
            int diff = 8 - lon;
            for (int i = 0; i < diff; i++)
            {
                filled += fillWith;
            }
            filled += n;
            return filled;
        }

        public string toString()
        {
            return "oct1: " + oct1 + "oct2: " + oct2 + "oct3: " + oct3 + "oct4: " + oct4 + "\n" +
                "IBinario: " + oct1Binary + "." + oct2Binary + "." + oct3Binary + "." + oct4Binary + "\n" +
                "tipo: " + type + "bits: " + bits + "afectado " + affectedOct + "\n" +
                "Iteration Bits: " + iterationBits + " Iteration number: " + iterationNumber;
        }

        public int Oct1
        {
            get
            {
                return oct1;
            }

            set
            {
                oct1 = value;
            }
        }

        public int Oct2
        {
            get
            {
                return oct2;
            }

            set
            {
                oct2 = value;
            }
        }

        public int Oct3
        {
            get
            {
                return oct3;
            }

            set
            {
                oct3 = value;
            }
        }

        public int Oct4
        {
            get
            {
                return oct4;
            }

            set
            {
                oct4 = value;
            }
        }

        public string Oct1Binary
        {
            get
            {
                return oct1Binary;
            }

            set
            {
                oct1Binary = value;
            }
        }

        public string Oct2Binary
        {
            get
            {
                return oct2Binary;
            }

            set
            {
                oct2Binary = value;
            }
        }

        public string Oct3Binary
        {
            get
            {
                return oct3Binary;
            }

            set
            {
                oct3Binary = value;
            }
        }

        public string Oct4Binary
        {
            get
            {
                return oct4Binary;
            }

            set
            {
                oct4Binary = value;
            }
        }

        public int Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public int Bits
        {
            get
            {
                return bits;
            }

            set
            {
                bits = value;
            }
        }

        public int AffectedOct
        {
            get
            {
                return affectedOct;
            }

            set
            {
                affectedOct = value;
            }
        }
        

        public int Reds
        {
            get
            {
                return reds;
            }

            set
            {
                reds = value;
            }
        }

        public int IterationBits
        {
            get
            {
                return iterationBits;
            }

            set
            {
                this.iterationBits = value;
            }
        }

        public int IterationNumber
        {
            get
            {
                return iterationNumber;
            }

            set
            {
                iterationNumber = value;
            }
        }
    }
}
