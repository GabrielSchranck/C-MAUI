using SQLite;

namespace ClassRoomApp.Model.Entities
{
    [Table("Class")]
    public class Class : BaseModel
    {
        [Column("Text")]
        public string? Text { get; set; }

        [Column("Done")]
        public bool Done { get; set; } = false;

        [Indexed]
        [Column("PersonId")]
        public int PersonId { get; set; }
    }
}
