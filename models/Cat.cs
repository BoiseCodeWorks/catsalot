using System.ComponentModel.DataAnnotations;

namespace catsalot.Models
{
  public class Cat
  {
    [Required]
    public string Name { get; set; }
    public int Age { get; set; }

    public Cat(string name, int age)
    {
      Name = name;
      Age = age;
    }
  }
}