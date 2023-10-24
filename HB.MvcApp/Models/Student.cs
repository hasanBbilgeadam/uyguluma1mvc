namespace HB.MvcApp.Models
{
    public class Student
    {
    

        public Student(string name, int vize1, int vize2)
        {
            Name = name;
            Vize1 = vize1;
            Vize2 = vize2;
        }
        public Student( string name, int vize1, int vize2,bool cinsyet):this(name, vize1, vize2)
        {
            Cinsyet = cinsyet;
        }
        public bool Cinsyet { get; set; }
        public string  Name { get; set; }
        public int Vize1  { get; set; }
        public int Vize2  { get; set; }
        
    }
}
