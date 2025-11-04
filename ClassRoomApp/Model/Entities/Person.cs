using SQLite;


namespace ClassRoomApp.Model.Entities
{
    [Table("Person")]
    public class Person : BaseModel
    {
        [Column("Name")]
        public string? Name { get; set; }

        [Indexed]
        [Column("AddressId")]
        public int AddressId { get; set; }
    }
}
