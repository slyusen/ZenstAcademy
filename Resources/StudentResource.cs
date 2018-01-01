namespace ZenstAcademy.Resources
{
   public class StudentResource
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string FullName { get; set; }

        public string StudentNumber { get; set; }

        public StudentResource()
        {
            this.FullName = this.FirstName + " " + this.LastName;
        }
    }
}