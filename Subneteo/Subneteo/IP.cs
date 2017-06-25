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
        }

        //agarra los octs en decimal y pasa a binario rellenando 0
        private void convertAlltoBinary()
        {
            string oct1BinaryTemp = Convert.ToString(oct1, 2);
            string oct2BinaryTemp = Convert.ToString(oct2, 2);
            string oct3BinaryTemp = Convert.ToString(oct3, 2);
            string oct4BinaryTemp = Convert.ToString(oct4, 2);
            oct1Binary = fillBinary(oct1BinaryTemp);
            oct2Binary = fillBinary(oct2BinaryTemp);
            oct3Binary = fillBinary(oct3BinaryTemp);
            oct4Binary = fillBinary(oct4BinaryTemp);
        }

        //rellenar con 0 un numero binario que esta en string
        private string fillBinary(string n)
        {
            string filled = "";
            int lon = n.Length;
            int diff = 8 - lon;
            for (int i = 0; i < diff; i++)
            {
                filled += "0";
            }
            filled += n;
            return filled;
        }
    }
}
