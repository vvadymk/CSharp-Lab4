using System.Windows;
using System.Windows.Controls;
using KochmarLab4.Tools.DataStorage;
using KochmarLab4.Tools.Managers;
using KochmarLab4.Tools.Navigation;

namespace KochmarLab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IContentOwner
    {
        public ContentControl ContentControl
        {
            get { return _contentControl; }
        }


        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();

            StationManager.Initialize(new SerializedDataStorage());
            NavigationManager.Instance.Initialize(new InitializationNavigationModel(this));
            NavigationManager.Instance.Navigate(ViewType.UserListView);

        }
    }
}
