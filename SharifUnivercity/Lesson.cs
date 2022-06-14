namespace SharifUnivercity
{
    public class Lesson
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int Major { get; set; }
        public int Copacity { get; set; }
        public int Copacity_Now { get; set; }

        public List<int> Students_In_Class = new List<int>();



        public Lesson(string name =  "Nodata", int code =  0 , int major = 0 , int copacity = 100 ,  int copacity_Now = 0  , int students = 0)
        {
            Name = name;
            Code = code;
            Major = major;
            Copacity = copacity;
            Copacity_Now = copacity_Now;
            Students_In_Class.Add(students);
        }
    }
}