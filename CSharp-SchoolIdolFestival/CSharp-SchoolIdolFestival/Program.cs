using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolIdolFestival
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] love = { 'ラ', 'ブ', 'ラ', 'イ', 'ブ', '！', 'カ' };
            int live = 0, school;
            string idol = "";

            Random festival = new Random();

            while (true)
            {
                school = festival.Next(love.Length);
                Console.Write("{0}", love[school]);
                idol += love[school];
                live++;

                if (idol.LastIndexOf("ラブライブ！") != -1)
                {
                    Console.WriteLine("{0} ", idol);
                    Console.WriteLine("スクールアイドルフェスティバル！ {0}回目でライブ成功！", live);
                    break;
                }
                else if (idol.LastIndexOf("ラブライカ") != -1)
                {
                    Console.WriteLine("{0} ", idol);
                    Console.WriteLine("LOVE LAIKA！ ﾐﾅﾐ･ｱｰﾆｬ尊い！{0}回目でライブ成功！", live);
                    break;
                }

            }

        }

    }
}
