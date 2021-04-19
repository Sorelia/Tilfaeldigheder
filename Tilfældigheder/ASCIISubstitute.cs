using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilfældigheder
{
    public class ASCIISubstitute
    {
        
        private byte letter;
        private int key;
        private byte[] buffer;
        private char[] processedMSG;

        public string ASCIIEncrypt(string text)
        {
            key = 2;

            buffer = Encoding.ASCII.GetBytes(text);

            for (int i = 0; i < buffer.Length; i++)
            {
                // seperate the letters
                letter = buffer[i];

                //shift the letters according to key
                letter = (byte)(letter + key);


                //subtract 90 if there's an overflow
                //add 90 if there's an underflow
                if (letter > 122)
                {
                    letter = (byte)(letter - 90);
                }
                else if (letter < 32)
                {
                    letter = (byte)(letter + 90);
                }

                //re-store the variable data
                buffer[i] = letter;


                processedMSG = Encoding.ASCII.GetChars(buffer);
                
            }

            return new string(processedMSG);
        }

        public string ASCIIDecrypt(string text)
        {
            key = 2;

            buffer = Encoding.ASCII.GetBytes(text);

            for (int i = 0; i < buffer.Length; i++)
            {
                // seperate the letters
                letter = buffer[i];

                //shift the letters according to key
                letter = (byte)(letter - key);


                //subtract 90 if there's an overflow
                //add 90 if there's an underflow
                if (letter > 122)
                {
                    letter = (byte)(letter - 90);
                }
                else if (letter < 32)
                {
                    letter = (byte)(letter + 90);
                }

                //re-store the variable data
                buffer[i] = letter;

                //re-inccode buffer bytes to char
                processedMSG = Encoding.ASCII.GetChars(buffer);

            }
            // returns processedMSG as a new string
            return new string(processedMSG);
        }
    }
}
