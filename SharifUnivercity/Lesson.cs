namespace SharifUnivercity
{
    public class Lesson
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int Major { get; set; }
        public int Copacity { get; set; }
        public int Copacity_Now { get; set; }
        public List<int> Students_In_Class { get; set; }



        public Lesson(string name, int code, int major, int copacity,  int copacity_Now , List<int> students)
        {
            Name = name;
            Code = code;
            Major = major;
            Copacity = copacity;
            Copacity_Now = copacity_Now;
            Students_In_Class = students;
        }
    }
}