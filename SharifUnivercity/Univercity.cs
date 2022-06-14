using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharifUnivercity
{
    public class Univercity
    {
        public static void Main()
        {
            IO io = new IO();
            io.Print("Wlcome To Sharif Univercity");
            Login_Validation Valid = new Login_Validation();
            Start(Valid);
        }

        public static void Start( Login_Validation Valid )
        {
            IO io = new IO();
            //Caller caller = new Caller();

            bool Flag = true ;
            while (Flag == true)
            {
                io.Print("\n-----");
                io.Print("1-About\n2-News\n3-Login\n4-Register Course\n5-Email\n6-College\n0-Exit");
                io.Print("Enter Command Code :");
                // need Try And Catch
                int CommandInt = io.GetInt();

                //caller.Call(Valid);
                // Flag = caller --> Command Number
            }
        }
    }
}
