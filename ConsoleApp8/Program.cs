using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] hex = new string[3, 3] { {"7B" , "-2D", "FC" },
                                               {"-3C" , "AF", "BE" },
                                               {"-E3" , "10", "A8" }
            };
            int[,] dec = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = hex[i, j].Length - 1; k >= 0; k--)
                    {
                        if (Convert.ToString(hex[i, j][k]) == Convert.ToString("-"))
                        {
                            dec[i, j] *= -1;
                        }
                        if (Convert.ToString(hex[i, j][k]) == Convert.ToString("A"))
                        {
                            dec[i, j] += Convert.ToInt32(10 * Math.Pow(16, hex[i, j].Length - 1 - k));
                        }
                        if (Convert.ToString(hex[i, j][k]) == Convert.ToString("B"))
                        {
                            dec[i, j] += Convert.ToInt32(11 * Math.Pow(16, hex[i, j].Length - 1 - k));
                        }
                        if (Convert.ToString(hex[i, j][k]) == Convert.ToString("C"))
                        {
                            dec[i, j] += Convert.ToInt32(12 * Math.Pow(16, hex[i, j].Length - 1 - k));
                        }
                        if (Convert.ToString(hex[i, j][k]) == Convert.ToString("D"))
                        {
                            dec[i, j] += Convert.ToInt32(13 * Math.Pow(16, hex[i, j].Length - 1 - k));
                        }
                        if (Convert.ToString(hex[i, j][k]) == Convert.ToString("E"))
                        {
                            dec[i, j] += Convert.ToInt32(14 * Math.Pow(16, hex[i, j].Length - 1 - k));
                        }
                        if (Convert.ToString(hex[i, j][k]) == Convert.ToString("F"))
                        {
                            dec[i, j] += Convert.ToInt32(15 * Math.Pow(16, hex[i, j].Length - 1 - k));
                        }
                        if ((hex[i, j][k]) >= Convert.ToChar("0")&& (hex[i, j][k]) <= Convert.ToChar("9"))
                        {
                            dec[i, j] += Convert.ToInt32(Convert.ToInt32(Convert.ToString(hex[i, j][k])) * Math.Pow(16, hex[i, j].Length - 1 - k));
                        }
                    }
                }
            }
            int ADec = (dec[0, 0] * dec[1, 1] * dec[2, 2]) + (dec[0, 1] * dec[1, 2] * dec[2, 0]) + (dec[0, 2] * dec[1, 0] * dec[2, 1]) - (dec[0, 2] * dec[1, 1] * dec[2, 0]) - (dec[0, 1] * dec[1, 0] * dec[2, 2]) - (dec[0, 0] * dec[1, 2] * dec[2, 1]);
            string AHex = "";
            int rez = ADec;
            int k1=0;
            while(rez>15)
            {
                k1 = rez%16;
                if(k1==15)
                {
                    AHex += "F";
                }
                if (k1 == 14)
                {
                    AHex += "E";
                }
                if (k1 == 13)
                {
                    AHex += "D";
                }
                if (k1 == 12)
                {
                    AHex += "C";
                }
                if (k1 == 11)
                {
                    AHex += "B";
                }
                if (k1 == 10)
                {
                    AHex += "A";
                }
                if(k1>=0&&k1<10)
                {
                    AHex += Convert.ToString(k1);
                }
                rez = rez / 16;
            }
            if (k1 == 15)
            {
                AHex += "F";
            }
            if (k1 == 14)
            {
                AHex += "E";
            }
            if (k1 == 13)
            {
                AHex += "D";
            }
            if (k1 == 12)
            {
                AHex += "C";
            }
            if (k1 == 11)
            {
                AHex += "B";
            }
            if (k1 == 10)
            {
                AHex += "A";
            }
            if (k1 >= 0 && k1 < 10)
            {
                AHex += Convert.ToString(k1);
            }
            string DAHex = "";
            for (int i = AHex.Length-1; i >= 0; i--)
            {
                DAHex+= AHex[i];
            }
            Console.WriteLine(DAHex);
            Console.ReadKey();
        }
    }
}
