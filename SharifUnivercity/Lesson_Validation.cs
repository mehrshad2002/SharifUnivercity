namespace SharifUnivercity
{
    internal class Lesson_Validation
    {
        public void Check(int commandInt , Login_Validation valid)
        {
            SaveLoad sl = new SaveLoad();
            List<Lesson> lessons = sl.LoadLessonData();

            //lessons = sl.Load();

            bool Cl = CheckLesson( commandInt, lessons);//1
            bool CCL = CheckCapacityLesson();
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

        public bool CheckCapacityLesson()
        {

            return true;
        }

        public void CheckCapacityStudent()
        {

        }

        public void CheckReRegister()
        {

        }
    }
}