using ClassRoomApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomApp.Model.Repositories
{
    public class PersonRepositoy : BaseRepository
    {
        public PersonRepositoy() { }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            await Init();

            return await Database.Table<Person>().ToListAsync();
        }
    }
}
