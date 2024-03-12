using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Domain.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string? Photo { get; set; }

        public EmployeeModel() { }
        public EmployeeModel(string name, int age, string photo)
        {
            Name = name;
            Age = age;
            Photo = photo;
        }
    }
}
