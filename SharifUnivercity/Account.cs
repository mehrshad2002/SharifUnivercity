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
        public List<Lesson> lessons { get; set; }


        public Account(string name, string password, int major,
            int studentNumberCard, DateTime? dateBirthDay,
            int college, List<Lesson> lessons)
        {
            Name = name;
            Password = password;
            Major = major;
            StudentNumberCard = studentNumberCard;
            DateBirthDay = dateBirthDay;
            College = college;
            this.lessons = lessons;
        }
    }
}
