namespace Lab4
{
    public class Student : Person
    {
        public int Program { get; set; }

        public override string ToString()
        {
            return $"Name :{Name}, Phone :{Phone}, Email :{Email}, Program : {Program}";
        }
            
    }
}