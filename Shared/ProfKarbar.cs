using System;
using System.ComponentModel.DataAnnotations;

public class ProfKarbar
{
    [Required]
    public string FirstName{get; set;}

    [Required]
    public string LastName{get; set;}
    [Required]
    public string Email{get; set;}

    [Required, Range(0, 1000, ErrorMessage= "Out of range!")]
    public int CardNum{get; set;}

    [Required]
    public DateTime Date;

    [Required]
    public bool IsGood;

}
