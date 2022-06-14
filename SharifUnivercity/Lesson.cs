namespace SharifUnivercity
{
    public class Lesson
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public string Major { get; set; }
        public int Copacity { get; set; }


        public Lesson(string name, int code, string major, int copacity)
        {
            Name = name;
            Code = code;
            Major = major;
            Copacity = copacity;
        }
    }
}