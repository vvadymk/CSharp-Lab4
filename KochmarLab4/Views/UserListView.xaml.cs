using System.Windows.Controls;
using KochmarLab4.Tools.Navigation;

namespace KochmarLab4.Views
{
    /// <summary>
    /// Логика взаимодействия для DataView.xaml
    /// </summary>
    public partial class UserListView : UserControl, INavigatable
    {

        public UserListView()
        {
            InitializeComponent();
            DataContext = new UserListViewModel();

        }
    }
}
