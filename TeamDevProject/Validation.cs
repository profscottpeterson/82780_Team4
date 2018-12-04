using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamDevProject
{
    class Validation
    {
        public int numValidate(string input)
        {
            try
            {
                int numInput = Convert.ToInt32(input);
                if (numInput > 0)
                {
                    return numInput;
                }
                else
                {
                    return -1;
                }
            }
            //Returns value of -1 to indicate non-integer input.
            catch
            {
                return -1;
            }
        }

        public string emailValidate(string input)
        {
            Boolean atCheck = false;
            Boolean dotCheck = false;
            char[] inputArray = input.ToCharArray();

            //Checks input string to ensure input is in format of X@Y.Z
            for (int i = 0; i < input.Length; i++)
            {
                if (inputArray[i] == '.' && atCheck == true && i < input.Length - 1)
                {
                    dotCheck = true;
                }

                if (inputArray[i] == '@' && i > 0)
                {
                    atCheck = true;
                    i++;
                }
            }

            if (atCheck == true && dotCheck == true)
            {
                return input;
            }
            else
            {
                return "";
            }
        }

        public double moneyValidate(string input)
        {
            try
            {
                double numInput = Convert.ToDouble(input);
                numInput = Math.Round(numInput, 2);
                if (numInput >= 0)
                {
                    return numInput;
                }
                else
                {
                    return -1;
                }
            }
            // Returns the value of -1 to indicate the input of a non-number.
            catch
            {
                return -1;
            }
        }

      /*public string dateValidate(string input)
        {
            //Turns input into a char array and checks each char to ensure date is in MM/DD/YYYY format.
            Boolean errorCheck = false;
            char[] inputArray = input.ToCharArray();

            if (input == "<NULL>" || input == "")
            {
                return "NULL";
            }
            else if (input.Length != 10)
            {
                return "[Error]";
            }
            else
            {

                if (inputArray[0] != '0' && inputArray[0] != '1')
                {
                    errorCheck = true;
                }

                if (!char.IsDigit(inputArray[1]))
                {
                    errorCheck = true;
                }

                if (inputArray[2] != '/')
                {
                    errorCheck = true;
                }

                if (inputArray[3] != '0' && inputArray[3] != '1' && inputArray[3] != '2' && inputArray[3] != '3')
                {
                    errorCheck = true;
                }

                if (!char.IsDigit(inputArray[4]))
                {
                    errorCheck = true;
                }

                if (inputArray[5] != '/')
                {
                    errorCheck = true;
                }

                if (!char.IsDigit(inputArray[6]) || !char.IsDigit(inputArray[7]) || !char.IsDigit(inputArray[8]) || !char.IsDigit(inputArray[9]))
                {
                    errorCheck = true;
                }

                if (errorCheck == true)
                {
                    return "[Error]";
                }
                else
                {
                    return input;
                }

            }
        }*/

      /*public string stringValidate(string input)
        {
            if (input == "<NULL>" || input == "")
            {
                input = "NULL";
            }

            return input;
        }*/
    }
}
