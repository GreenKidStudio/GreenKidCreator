using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Material
{
    public class MaterialPanelViewModel : BasicTreeItemViewModel
    {
        private bool mIsChecked;

        public bool IsChecked
        {
            get { return mIsChecked; }
            set
            {
                mIsChecked = value;

                RaisePropertyChanged(() => IsChecked);
            }
        }

        public MaterialPanelViewModel(string name)
            : base(name)
        {
        }
    }
}