using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoList.Data.Models
{
    public class Listeler
    {
            [Key]
            public int Id { get; set; }
            public string? Name { get; set; }
    }

    public class Yapacaklarim
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Yapiyorum
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }

    public class Yaptim
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
