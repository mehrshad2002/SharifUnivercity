namespace SharifUnivercity
{
    public class Lesson
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int Copacity { get; set; }
        public string Major { get; set; }

        public Lesson(string name, int code, int copacity, string major)
        {
            Name = name;
            Code = code;
            Copacity = copacity;
            Major = major;
        }
    }
}