using System;

namespace CSharpCipher
{
    class Cipher
    {
        /// <summary>
        /// <param name="message">The string message to cipher</param>
        /// <param name="shift">How many letters to shift</param>
        /// <returns>Returns the ciphered message</returns>
        /// </summary>
        public string String(string message, int shift)
        {
            // Check to make sure the shift isn't off-balance, and if it's zero: return the message to save processing power.
            switch (shift)
            {
                case > 26: shift = 26; break;
                case < -26: shift = -26; break;
                case 0: return message;
            }

            string cipher = null; char[] array = message.ToCharArray();
            
            for(int x = 0; x < array.Length; x++)
            {
                switch (array[x]){case ' ': continue;}
                array[x] = (char)(array[x] + shift);
                switch (array[x])
                {
                    case > 'z': array[x] = (char)(array[x] - 26); break;
                    case < 'a': array[x] = (char)(array[x] + 26); break;
                }
            }
            foreach(char i in array){cipher += i;} return cipher;
        }
    }
}