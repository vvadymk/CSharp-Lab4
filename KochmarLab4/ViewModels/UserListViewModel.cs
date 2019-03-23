
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using KochmarLab4.Models;
using KochmarLab4.Tools;
using KochmarLab4.Tools.Managers;
using KochmarLab4.Tools.Navigation;

namespace KochmarLab4
{
    internal class UserListViewModel : BaseViewModel, INotifyPropertyChanged
    {
        private ObservableCollection<Person> _users;

        private RelayCommand<object> _addUserCommand;

        public ObservableCollection<Person> Users
        {
            get => _users;
            private set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        internal UserListViewModel()
        {
            _users = new ObservableCollection<Person>(StationManager.DataStorage.UsersList);
        }

        public IEnumerable<Person> UserList
        {
            get { return _users; }
        }

        public RelayCommand<object> AddCommand
        {
            get
            {
                return _addUserCommand ?? (_addUserCommand = new RelayCommand<object>(AddingImpl
                          ));
            }
        }

        private void AddingImpl(object obj)
        {
            StationManager.CurrentUser = new Person("test", "test", "test@mail");
            NavigationManager.Instance.Navigate(ViewType.FormView);
        }
    }

}
