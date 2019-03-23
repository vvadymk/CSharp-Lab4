

namespace KochmarLab4.Tools.Navigation
{
    internal enum ViewType
    {
        UserListView,
        FormView
     
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
