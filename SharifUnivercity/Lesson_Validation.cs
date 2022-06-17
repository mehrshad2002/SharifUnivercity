﻿namespace SharifUnivercity
{
    public class Lesson_Validation
    {
        public bool Check(int lessonCode , Login_Validation valid)
        {
            SaveLoad sl = new SaveLoad();

            List<Lesson> lessons = sl.LoadLessonData();
            List<Account> accounts = sl.LoadStudentData();

            bool CL = CheckLesson( lessonCode, lessons);//1
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
                                account.lessons.Add(lesson.Name);//error 
                                string path = "../../../DataFile/StudentData/Students.json";
                                sl.Save(accounts , path);
                            }
                        }
                    }
                }
                return true;
            }return false;
        }

        public bool CheckLesson( int lessonCode , List<Lesson> lessons)
        {
            foreach(Lesson lesson in lessons)
            {
                if( lessonCode == lesson.Code)
                {
                    return true;
                }
            }return false;
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
                }
            }
            io.Print("Capacity Of This Lesson Fs Full");
            return false ;
        }

        public bool CheckCapacityStudent(Login_Validation valid)
        {
            if(++valid.Studentobj.Capacity_Lesson > 5)
            {
                return false ;
            }
            
            return true ;
        }

        public bool CheckReRegister(Login_Validation valid , int lessonCode , List<Lesson> lessons  , List<Account> accounts)
        {
            //we bulding new one !!
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