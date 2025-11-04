namespace StudentManagement.Model
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Department { get; set; }

    }
}

// dotnet ef migrations add InitialCreate --project StudentManagement.DAL --startup-project StudentManagement.WEB
// dotnet ef database update --project StudentManagement.DAL --startup-project StudentManagement.WEB
