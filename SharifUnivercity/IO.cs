using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharifUnivercity
{
    public class IO
    {
        public void Print<E>( E val)
        {
            Console.WriteLine(val);
        }

        public void PrintAt<E>( E val)
        {
            Console.Write(val);
        }

        public string GetStr()
        {
            return Console.ReadLine();
        }

        public int GetInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
