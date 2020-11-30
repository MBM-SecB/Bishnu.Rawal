using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "We need first name")]
    [Display(Name = "First Name")]    
    public string FirstName { get; set; }

    [Required(ErrorMessage = "We need your parent name")]
    [Display(Name = "Last Name")]
    public string Surname { get; set; }
    
    public string Address { get; set; }

    public char Gender { get; set; } = 'M';    
    public double Salary { get; set; }
}