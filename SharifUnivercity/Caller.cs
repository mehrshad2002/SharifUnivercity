namespace SharifUnivercity
{
    internal class Caller
    {
        public bool Call(Login_Validation valid , int commandVal , ref bool Flag)
        {
            
            IO io = new IO();
            switch (commandVal){
                case 1:
                    //cal About ;
                    break;
                case 2:
                    //cal news
                    break;

                case 3:
                    //Login Section
                    io.Print(Flag);
                    if( Flag != true )
                    {
                        Flag = valid.Login();
                    }
                    else
                    {
                        io.Print("You Are SyncUp !");
                    }
                    break;

                case 4:
                    if( Flag != true)
                    {
                        io.Print("You Should Login First.");
                    }
                    else
                    {
                        RegisterLesson RL = new RegisterLesson();
                        RL.Start(valid);
                    }
                    break;

                case 5:
                    //cal email
                    break;
                case 6:
                //cal College
                default:
                    io.Print("Invalid Command");
                    break;


            }
            return true;
        }
    }
}