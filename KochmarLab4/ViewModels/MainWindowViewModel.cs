using KochmarLab4.Tools;

namespace KochmarLab4
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private bool _isControlEnabled = true;
     
        public bool IsControlEnabled
        {
            get { return _isControlEnabled; }
            set
            {
                _isControlEnabled = value;
                OnPropertyChanged();
            }
        }
    }
}
