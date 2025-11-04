using ClassRoomApp.Model.Entities;
using ClassRoomApp.Model.Repositories;

namespace ClassRoomApp.Model.Data
{
    public class AddressRepository : BaseRepository
    {
        public AddressRepository() { }

        public async Task<int> SaveItemAsync(Address address)
        {
            await Init();

            if(address.Id != 0)
                await Database.UpdateAsync(address);
            else
                await Database.InsertAsync(address.Id);

            return address.Id;
        }

        public async Task<int> DeleteAsync(Address address)
        {
            await Init();

            return await Database.DeleteAsync(address.Id);
        }
    }
}
