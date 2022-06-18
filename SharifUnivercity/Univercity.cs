using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;//?


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
            Caller caller = new Caller();

            bool LoginFlag = false;
            bool WhileFlag = true ;
            while (WhileFlag == true)
            {
                int commandVal;

                while ( true )
                {
                    try
                    {
                        io.Print("\n-----");
                        io.Print("1-About\n2-News\n3-Login\n4-Register Course\n5-Email\n6-College\n0-Exit");
                        io.Print("Enter Command Code :");
                        commandVal = io.GetInt();
                        break;
                    }
                    catch( Exception e)
                    {
                        io.Print("Enter <integer> Number!");
                    }
                }

                if( commandVal == 0)
                   {
                      break;
                   }


                caller.Call(Valid , commandVal ,ref LoginFlag);

                // Flag = caller --> Command Number
            }
        }
    }
}
