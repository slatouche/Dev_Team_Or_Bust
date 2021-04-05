using System.ComponentModel.DataAnnotations;

namespace WebApi_EF_Test.DTOs
{
    public class TestModelCreateDTO
    {
        //ID not needed to be added, is done automatically

        [Required]
        [MaxLength(250)]
        public string TestString { get; set; }

        [Required]
        [MaxLength(500)]
        public string TestOtherString { get; set; }

        [Required]
        public int TestInt { get; set; }
    }
}