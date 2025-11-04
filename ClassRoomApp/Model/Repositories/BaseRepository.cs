using ClassRoomApp.Model.Data;
using ClassRoomApp.Model.Entities;
using SQLite;

namespace ClassRoomApp.Model.Repositories
{
    public class BaseRepository
    {
        public SQLiteAsyncConnection Database;

        public BaseRepository()
        {
        }

        public async Task Init()
        {
            if (Database is not null)
                return;

            this.Database = new SQLiteAsyncConnection(DatabaseConstants.DatabasePath, DatabaseConstants.Flags);
            var resultClass = await this.Database.CreateTableAsync<Class>();
            var resultPerson = await this.Database.CreateTableAsync<Person>();
            var resultAddress = await this.Database.CreateTableAsync<Address>();
        }
    }
}
