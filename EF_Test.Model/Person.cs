using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Test.Model
{
    [Table("tab_persons")]
    public class Person
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("first_name")]
        [Required]
        public string FirstName { get; set; }
        
        [Column("last_name")]
        [Required]
        public string LastName { get; set; }
        
        [Column("age")]
        [Required]
        public int Age { get; set; }
        
        [Column("is_delete")]
        [Required]
        [DefaultValue(false)]
        public bool IsDelete { get; set; }
    }
}