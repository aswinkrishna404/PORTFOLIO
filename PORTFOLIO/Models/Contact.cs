using System.ComponentModel.DataAnnotations;

namespace PORTFOLIO.Models
{
   
        public class Contact
        {
            [Key]
           
            public string Name { get; set; }
            [EmailAddress]
            public string Email { get; set; }
            public string Phone { get; set; }
             public string Message { get; set; }

    }
    
}
