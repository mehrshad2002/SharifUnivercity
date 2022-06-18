namespace SharifUnivercity
{
    public class Lesson_Validation
    {
        public bool Check(int lessonCode , Login_Validation valid)
        {
            IO io = new IO();
            SaveLoad sl = new SaveLoad();

            List<Lesson> lessons = sl.LoadLessonData();
            List<Account> accounts = sl.LoadStudentData();

            bool CL = CheckLesson( lessonCode, lessons);
            bool CCL = CheckCapacityLesson(lessons , valid , lessonCode);
            bool CCS = CheckCapacityStudent(valid);
            bool CRR = CheckReRegister(valid, lessonCode , lessons , accounts );

            if( CL && CCL && CCS && CRR)
            {
                foreach( Lesson lesson in lessons)
                {
                    if( lesson.Code == lessonCode)
                    {
                        ++lesson.Copacity_Now;
                        lesson.Students_In_Class.Add(valid.Studentobj.StudentNumberCard);
                        string path = "../../../DataFile/LessonData/Lessons.json";
                        sl.Save(lessons, path);
                    }
                }
                foreach( Account account in accounts)
                {
                    if( account.StudentNumberCard == valid.Studentobj.StudentNumberCard)
                    {
                        foreach( Lesson lesson in lessons)
                        {
                            if(lesson.Code == lessonCode)
                            {
                                ++account.Capacity_Lesson;
                                account.lessons.Add(lesson.Name);
                                string path = "../../../DataFile/StudentData/Students.json";
                                sl.Save(accounts , path);
                            }
                        }
                    }
                }
                io.Print("Done!");
                return true;
            }
            return false;
        }

        public void ShowMyLesson(Login_Validation valid)
        {
            IO io = new IO();
            SaveLoad sl = new SaveLoad();
            List<Lesson> lessons = sl.LoadLessonData();
            List<Account> accounts = sl.LoadStudentData();

            io.Print("\n-- Your Lessone --");
            foreach( Account account in accounts)
            {
                if( account.Name == valid.Studentobj.Name)
                {
                    foreach( string lesson in account.lessons)
                    {
                        io.Print(lesson);
                    }
                }
            }
            io.Print("\n----");
        }

        public bool CheckLesson( int lessonCode , List<Lesson> lessons)
        {
            foreach(Lesson lesson in lessons)
            {
                if( lessonCode == lesson.Code)
                {
                    return true;
                }
            }
            IO io = new IO();
            io.Print("Error --> This Lesson And Code Is Not Exist");
            return false;
        }

        public bool CheckCapacityLesson( List<Lesson> lessons, Login_Validation valid , int lessonCode  )
        {
            IO io = new IO();
            SaveLoad sl = new SaveLoad();
            foreach( Lesson lesson in lessons)
            {
                if( lesson.Code == lessonCode)
                {
                    ++lesson.Copacity_Now;//some day we should save this data 
                    if ( lesson.Copacity_Now < lesson.Copacity)
                    {
                        return true;
                    }
                    else
                    {
                        io.Print("Error --> Capacity Of This Lesson Fs Full");
                        return false;
                    }
                }
            }
            return false;
        }

        public bool CheckCapacityStudent(Login_Validation valid)
        {
            if(++valid.Studentobj.Capacity_Lesson >5)
            {
                IO io = new IO();
                io.Print("Error --> Capacity Is Full!<Max Is 5>");
                return false ;
            }
            
            return true ;
        }

        public bool CheckReRegister(Login_Validation valid , int lessonCode , List<Lesson> lessons  , List<Account> accounts)
        {
            IO io = new IO();
            foreach( Lesson lesson in lessons)
            {
                if( lessonCode == lesson.Code)
                {
                    foreach( Account account in accounts)
                    {
                        foreach( string NameLesson in account.lessons)
                        {
                            if( NameLesson == lesson.Name)
                            {
                                io.Print("Error --> You Picked This Lesson Before");
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}