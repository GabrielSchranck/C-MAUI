using SQLite;


namespace ClassRoomApp.Model.Entities
{
    public class BaseModel
    {
        [PrimaryKey, AutoIncrement]
        [Column("Id")]
        public int Id { get; set; }
    }
}
