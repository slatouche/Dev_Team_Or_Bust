using System.ComponentModel.DataAnnotations;

namespace WebApi_EF_Test.Models
{
    public class TestModel
    {
        [Key]
        public int Id { get; set; }

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