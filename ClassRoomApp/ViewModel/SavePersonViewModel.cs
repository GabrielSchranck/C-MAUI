using ClassRoomApp.Model.Data;
using ClassRoomApp.Model.Repositories;
using ClassRoomApp.ViewModel.Base;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomApp.ViewModel
{
    public partial class SavePersonViewModel : BaseViewModel, IQueryAttributable
    {
        private readonly PersonRepositoy _personRepositoy;
        private readonly AddressRepository _addressRepository;

        public SavePersonViewModel()
        {
        }

        public SavePersonViewModel(PersonRepositoy personRepositoy, AddressRepository addressRepository)
        {
            _personRepositoy = personRepositoy;
            _addressRepository = addressRepository;

            ExecuteCommand = new AsyncRelayCommand(SavePersonAsync);
            DeleteCommand = new AsyncRelayCommand(DeletePersonAsync);
            RedirectCommand = new AsyncRelayCommand(BackToListAsync);
        }

        public PersonWithAddress Item { get; set; }

    }
}
