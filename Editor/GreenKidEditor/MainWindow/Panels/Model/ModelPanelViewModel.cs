using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Model
{
    public class ModelPanelViewModel : BasicTreeItemCollectionViewModel
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

        public ModelPanelViewModel(string name)
            : base(name)
        {
        }
    }
}