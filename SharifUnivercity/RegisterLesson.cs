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
                if( valid.Studentobj.Major == 100)
                {
                    io.Print("Welcome To Course And Lesson Register(Computer Major)");
                    io.Print("-------");
                    io.Print("701-Computer-1\n702-Math-1\n703-Advanced-Programming\n704-Data-Structures" +
                        "\n705-Physics-1\n1-See My Lesson\n0-Exit\n----");
                    io.Print("Enter Lesson Code : ");

                    int commandInt = io.GetInt();

                    if( commandInt == 0)
                    {
                        break;
                    }else if( commandInt == 1)
                    {
                        LV.ShowMyLesson(valid);
                    }
                    else
                    {
                        bool FlagSaveLesson = LV.Check(commandInt , valid );//if our flag == true --> we can save data 
                    }
                }else if( valid.Studentobj.Major == 110)
                {
                    io.Print("Welcome To Course And Lesson Register(Art Major)");
                    io.Print("-------");
                    io.Print("706-Painting\n----\n1-See My Lesson\n0-Exit");
                    io.Print("Enter Lesson Code : ");

                    int commandInt = io.GetInt();

                    if (commandInt == 0)
                    {
                        break;
                    }
                    else if (commandInt == 1)
                    {
                        LV.ShowMyLesson(valid);
                    }
                    else
                    {
                        bool FlagSaveLesson = LV.Check(commandInt, valid);//if our flag == true --> we can save data 
                    }
                }
            }
        }
    }
}