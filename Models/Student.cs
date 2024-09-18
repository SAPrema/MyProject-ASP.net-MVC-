namespace MyProject.Models
{
    public class Student
    {
       
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Email { get; set; }
            public required string PhoneNumber { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string? State { get; set; }
            public string? City { get; set; }
        }
    }


