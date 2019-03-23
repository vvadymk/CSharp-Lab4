

using System;
using System.Threading.Tasks;
using System.Windows;
using KochmarLab4.Models;
using KochmarLab4.Tools;
using KochmarLab4.Tools.Managers;
using KochmarLab4.Tools.Navigation;
using KochmarLabs2_3.Exceptions;

namespace KochmarLab4.ViewModels
{
    class AddingViewModel: BaseViewModel
    {
        private string _firstName;
        private string _lastName;
        private string _eMail;
        private DateTime _birthDate = DateTime.Today;

        private RelayCommand<object> _proceedCommand;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }

        }

        public string Email
        {
            get => _eMail;
            set
            {
                _eMail = value;
                OnPropertyChanged();
            }
        }

        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                OnPropertyChanged();
            }
        }

        private async void ProceedImplementation(object obj)
        {
            var result = await Task.Run(() =>
            {
                try
                {
                    StationManager.CurrentUser = new Person(_firstName, _lastName, _eMail, _birthDate);
                }
                catch (PersonException.MaybeDiedPersonException e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }
                catch (PersonException.NotEvenBorn e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }
                catch (PersonException.EmailException e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }
                catch (PersonException.FirstNameException e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }
                catch (PersonException.LastNameException e)
                {
                    MessageBox.Show(e.ToString());
                    return false;
                }
                if (StationManager.CurrentUser.IsBirthday)
                {
                    MessageBox.Show("Happy Birthday!!!");
                }
                MessageBox.Show("Successful input");
                return true;

            });

            if (result)
            {
                StationManager.DataStorage.AddUser(new Person(_firstName, _lastName, _eMail, _birthDate));
            }
        }

        public RelayCommand<object> ProceedCommand
        {
            get
            {
                return _proceedCommand ?? (_proceedCommand = new RelayCommand<object>(
                           ProceedImplementation, o => CanExecuteCommand()));
            }
        }

        private bool CanExecuteCommand()
        {
            return !String.IsNullOrWhiteSpace(FirstName) && !String.IsNullOrWhiteSpace(LastName) && !String
                       .IsNullOrWhiteSpace(Email);
        }
    }
}
