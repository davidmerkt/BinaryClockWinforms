using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClockWinforms
{
    public class BinaryConverter
    {
        private int decimalNumber;
        private string stringBinaryNumber;
        private List<bool> listBinaryNumber;

        public int DecimalNumber
        {
            get { return decimalNumber; }
        }

        public string StringBinaryNumber { get { return stringBinaryNumber; } }

        public List<bool> ListBinaryNumber { get { return listBinaryNumber; } }

        public void SetDecimalNumber(int DecimalNumber)
        {
            this.decimalNumber = DecimalNumber;
            convertDecimalToBinary();
        }

        public BinaryConverter(int decimalNumber)
        {
            this.decimalNumber = decimalNumber;
            convertDecimalToBinary();
        }

        private void convertDecimalToBinary()
        {
            int decimalNumber = this.decimalNumber;
            stringBinaryNumber = "";
            listBinaryNumber = new List<bool>();

            if (decimalNumber > 0)
            {
                while (decimalNumber > 0)
                {
                    stringBinaryNumber = decimalNumber % 2 + stringBinaryNumber;

                    if (decimalNumber % 2 == 1) { listBinaryNumber.Add(true); }
                    else { listBinaryNumber.Add(false); }

                    decimalNumber /= 2;
                }
            }
            else if (decimalNumber == 0)
            {
                stringBinaryNumber = "0";
                decimalNumber = 0;
                listBinaryNumber.Add(false);
            }
            else if (decimalNumber < 0)
                throw new NotImplementedException();
        }
    }
}
