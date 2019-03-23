using System.Windows.Controls;
using KochmarLab4.Tools.Navigation;
using KochmarLab4.ViewModels;


namespace KochmarLabs2_3.Views
{
    /// <summary>
    /// Логика взаимодействия для FormView.xaml
    /// </summary>
    public partial class FormView : UserControl, INavigatable
    {
        public FormView()
        {
            InitializeComponent();
                 DataContext = new AddingViewModel();
        }
    }
}
