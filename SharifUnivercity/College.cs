using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharifUnivercity
{
    public class College
    {
        public void MainCollege()
        {
            IO io = new IO();
            while( true)
            {
                io.Print("Welcome To College Page");
                io.Print("\n1-CMP\n2-Arts\n3-Scince\n0-Exit");
                io.Print("Enter Your Command Code");
            }
        }
    }
}
