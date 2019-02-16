using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }
            else if(str == "")
            {
                throw new ArgumentException();
            }
            else
            {
                char[] strArray = str.ToCharArray();
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                int count = 0;
                for (int i = 0; i < strArray.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (strArray[i] == vowels[j])
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }
    }
}
