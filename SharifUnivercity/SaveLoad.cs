using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
namespace SharifUnivercity
{
    public class SaveLoad
    {
        public void Save<E>( List<E> data , string Path)
        {
            string jsonString = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(Path, jsonString);
        }

        public List<Account> LoadStudentData()
        {
            StudentAccount SA = new StudentAccount();
            SA.CreateStudentAccount();
            var json = File.ReadAllText("../../../DataFile/StudentData/Students.json");
            List<Account> Students = JsonConvert.DeserializeObject<List<Account>>(json);
            return Students;
        }

        public List<Lesson> LoadLessonData()
        {
            LessonCreate SA = new LessonCreate();
            SA.CreateLesson();
            var json = File.ReadAllText("../../../DataFile/LessonData/Lessons.json");
            List<Lesson> LessonData = JsonConvert.DeserializeObject<List<Lesson>>(json);
            return LessonData;
        }
    }
}