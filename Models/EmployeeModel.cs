using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models
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
            this.Name = name;
            this.Age = age;
            this.Photo = photo;
        }
    }
}
