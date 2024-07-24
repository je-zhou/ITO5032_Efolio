using System.ComponentModel.DataAnnotations;

namespace _3._2A__View_Model.Models
{
    public class SampleFormViewModels
    {
    }
    public class FormOneViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}