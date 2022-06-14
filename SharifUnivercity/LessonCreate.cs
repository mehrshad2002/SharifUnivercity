using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharifUnivercity
{
    public class LessonCreate
    {
        public void CreateLesson()
        {
            bool Flag = File.Exists("../../../DataFile/LessonData/Lessons.json");// Lesson file
            if (Flag != true)
            {
                List<Lesson> lessons = new List<Lesson>();
                SaveLoad sl = new SaveLoad();

                lessons.Add(new Lesson("Computer-1", 701, 100, 20, 0, null));
                lessons.Add(new Lesson("Math-1", 702, 100, 15, 0, null));
                lessons.Add(new Lesson("Advanced-Programming", 703, 100, 20, 0, null));
                lessons.Add(new Lesson("Data-Structures", 704, 100, 15, 0, null));
                lessons.Add(new Lesson("Physics-1", 705, 100, 30, 0, null));
                lessons.Add(new Lesson("Computer-Scince", 706, 100, 10, 0, null));

                string path = "../../../DataFile/LessonData/Lessons.json";
                sl.Save(lessons , path );
            }
        }
    }
}
