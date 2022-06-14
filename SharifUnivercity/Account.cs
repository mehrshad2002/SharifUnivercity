using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharifUnivercity
{
    public class Account
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int Major { get; set; }
        public int StudentNumberCard { get; set; }
        public DateTime? DateBirthDay { get; set; }
        public int College { get; set; }

        public List<Lesson> lessons = new List<Lesson>();//List<str> Lesson 
        public int Capacity_Lesson { get; set; }


        public Account(string name, string password, int major,
            int studentNumberCard, DateTime? dateBirthDay,
            int college, Lesson lesson, int capacity_Lesson)
        {
            Name = name;
            Password = password;
            Major = major;
            StudentNumberCard = studentNumberCard;
            DateBirthDay = dateBirthDay;
            College = college;
            lessons.Add(lesson);
            Capacity_Lesson = capacity_Lesson;
        }
        //public Account(Lesson lesson)
        //{
        //    lessons.Add(new Lesson(lesson.Name, lesson.Code, lesson.Major, lesson.Copacity, lesson.Copacity_Now, null));
        //}
    }
}
