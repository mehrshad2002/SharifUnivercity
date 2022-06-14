namespace SharifUnivercity
{
    internal class RegisterLesson
    {
        public void Start(Login_Validation valid)
        {
            IO io = new IO();
            Lesson_Validation LV = new Lesson_Validation();

            while( true)
            {
                io.Print("Welcome To Course And Lesson Register");
                io.Print("-------");
                io.Print("701-Computer-1\n702-Math-1\n703-Advanced-Programming\n704-Data-Structures" +
                    "\n705-Physics-1\n706-Computer-Scince\n0-Exit");
                io.Print("Enter Lesson Code : ");
                int commandInt = io.GetInt();

                if( commandInt == 0)
                {
                    break;
                }

                LV.Check(commandInt valid );


            }
        }
    }
}