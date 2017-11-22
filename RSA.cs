using System;
using System.Text;

namespace lab4
{
    public static class ConversionExtensions
    {
        public static int ConvertToWindows1251(this Char src)
        {
            Encoding windows1251 = Encoding.GetEncoding("windows-1251");
            Encoding unicode = Encoding.Unicode;

            byte[] windows1251Bytes = Encoding.Convert(unicode, windows1251, unicode.GetBytes(src.ToString()));
            char[] windows1251Chars = new char[windows1251.GetCharCount(windows1251Bytes, 0, windows1251Bytes.Length)];
            windows1251.GetChars(windows1251Bytes, 0, windows1251Bytes.Length, windows1251Chars, 0);

            if (windows1251Chars[0] != src)
            {
                throw new Exception("Текст должен быть в кодировке ASCII.");
            }

            return BitConverter.ToInt32(new byte[] { windows1251Bytes[0], 0, 0, 0 }, 0);
        }

        public static Char ConvertFromWindows1251(this int src)
        {
            Encoding windows1251 = Encoding.GetEncoding("windows-1251");
            Encoding unicode = Encoding.Unicode;

            byte[] unicode1251Bytes = Encoding.Convert(windows1251, unicode, BitConverter.GetBytes(src));
            char[] unicode1251Chars = new char[windows1251.GetCharCount(unicode1251Bytes, 0, unicode1251Bytes.Length)];
            unicode.GetChars(unicode1251Bytes, 0, unicode1251Chars.Length, unicode1251Chars, 0);

            return unicode1251Chars[0];
        }
    }

    public static class RSA
    {
        public static long ModPow(this long number, long module, long exp)
        {
            long temp = number;
            do
            {
                temp -= module;
            }
            while (temp > module);
            return temp / exp + number;
        }

        public static bool Prime(this long num)
        {
            if ((num % 2) == 0) 
            {
                return (num == 2);
            }
            if (num == 1)
            {
                return false;
            }
            long max = (long)Math.Sqrt(num);
            for (int i = 3; i <= max; i += 2)
            {
                if ((num % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static long GCD(long a, long b)
        {
            return (b == 0 ? a : GCD(b, a % b));
        }

        public static long create_open_exp(long p, long q)
        {
            long open_exp = 1;
            long euler = (p - 1) * (q - 1);
            Random rand = new Random();
            for (int i = 10; i < euler; i++)
            {
                if ((Convert.ToInt64(i).Prime()) && (GCD(i, euler) == 1))
                {
                    if (rand.Next(5) == 3)
                    {
                        open_exp = i;
                        break;
                    }
                }
            }
            return open_exp;
        }
        public static string Encode(long open_exp, long module, string text)
        {
            int blockLength = (int)(Math.Ceiling(Math.Log(open_exp, 2D) / 8)) - 2;
            if (blockLength < 1)
            {
                blockLength = 1;
            }

            StringBuilder sourceText = new StringBuilder(text);
            while (sourceText.Length % blockLength != 0)
            {
                sourceText.Append(" ");
            }

            int blocks = sourceText.Length / blockLength;

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < blocks; i++)
            {
                StringBuilder sb = new StringBuilder();

                for (int j = i * (sourceText.Length / blocks); j < ((i + 1) * (sourceText.Length / blocks)); j++)
                {
                    int code = sourceText[j].ConvertToWindows1251();

                    sb.AppendFormat("{0:D3}", code);
                }

                result.Append(Int64.Parse(sb.ToString()).ModPow(open_exp, module).ToString() + " ");
            }
            return result.ToString();
        }

        public static string Decode(long secret_exp, long module, string text)
        {
            StringBuilder result = new StringBuilder();

            string[] nums = text.Split(' ');
            for (int i = 0; i < nums.Length - 1; i++)
            {
                StringBuilder sb = new StringBuilder(Int64.Parse(nums[i]).ModPow(secret_exp, module).ToString());
                while (sb.Length % 3 != 0)
                {
                    sb.Insert(0, '0');
                }

                string str = sb.ToString();
                for (int j = 0; j < str.Length; j += 3)
                {
                    result.Append(int.Parse(str.Substring(j, 3)).ConvertFromWindows1251());
                }
            }

            return result.ToString();
        }
    } 
}
