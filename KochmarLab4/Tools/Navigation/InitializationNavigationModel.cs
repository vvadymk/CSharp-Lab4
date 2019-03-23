using System;
using KochmarLab4.Views;
using KochmarLabs2_3.Views;

namespace KochmarLab4.Tools.Navigation
{
    internal class InitializationNavigationModel : BaseNavigationModel
    {
        public InitializationNavigationModel(IContentOwner contentOwner) : base(contentOwner)
        {

        }

        protected override void InitializeView(ViewType viewType)
        {
            switch (viewType)
            {
                case ViewType.UserListView:
                    ViewsDictionary.Add(viewType, new UserListView());
                    break;
                case ViewType.FormView:
                    ViewsDictionary.Add(viewType, new FormView());
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(viewType), viewType, null);
            }
        }
    }
}
