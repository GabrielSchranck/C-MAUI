using SQLite;


namespace ClassRoomApp.Model.Entities
{
    [Table("Address")]
    public class Address : BaseModel
    {
        [Column("CompleteAddress")]
        public string? CompleteAddress { get; set; }
    }
}
