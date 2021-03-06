﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace DecimalConversionsDLL
{
    public class DecimalConvert
    {
        //This is a private method the user wont be able to see
        public static string ReverseString(string s)
        {
            //send the input string to a CharArray
            char[] chararray = s.ToCharArray();
            //reverse the aray and return it
            Array.Reverse(chararray);
            return new string(chararray);
        }

        public long BinaryCalculator(long DecimalInput)
        {
            try
            {
                long input = DecimalInput;
                string binaryString = string.Empty;

                while (input >= 1)
                {
                    if (input % 2 == 1) //If ODD NUMBER
                        binaryString = binaryString + "1"; //Add a 1 to the end of the string
                    else if (input % 2 == 0) //if EVEN NUMBER
                        binaryString = binaryString + "0"; //Add a 0 to the end of the string
                    //divide the value by 2
                    input = input / 2;
                }
                //Use our private method to reverse the string
                return long.Parse(ReverseString(binaryString));
            }
            catch (Exception ex)
            {
                //We can use message boxes so we use this
                throw new System.ArgumentException(ex.Message);
            }
        }

        public string OctalCalculator(long DecimalInput)
        {
            long input = DecimalInput;
            long remainder = 0;
            string result = string.Empty;
            try
            {
                while (input > 0)
                {
                    remainder = input % 8;
                    input = input / 8;
                    result = remainder.ToString() + result;
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message);
            }
        }

        public string HexCalculator(long DecimalInput)
        {
            return DecimalInput.ToString("X");
        }
    }
}
