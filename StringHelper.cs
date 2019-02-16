using System;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            if ( str.Length == 0)
            {
                throw new ArgumentNullException();
            }
            char[] strArray = str.ToCharArray();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                for( int j = 0; j < vowels.Length; j++)
                {
                    if( strArray[i] == vowels[j])
                    {
                        count++;
                    }
                }
            }
            return count;

        }
    }
}
