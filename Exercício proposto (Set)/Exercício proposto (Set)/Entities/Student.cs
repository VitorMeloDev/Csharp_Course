namespace Exercício_proposto__Set_.Entities
{
    class Student
    {
        public int Id { get; set; }

        public Student(int id)
        { this.Id = id; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is Student))
            {  return false; }
            
            Student student = obj as Student;
            
            return Id.Equals(student.Id);
        }
    }
}
