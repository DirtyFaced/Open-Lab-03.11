using System;
using System.Linq;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)
        {
            bool jeto2 = true;
            int chunga = str.Length - 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[chunga])
                {
                    chunga = chunga - 1;
                }
                else
                {
                    jeto2 = false; 
                }
            }
            return jeto2;
        } 
    }
}
