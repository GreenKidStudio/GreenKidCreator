using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Texture
{
    public class TexturePanelViewModel : BasicTreeItemViewModel
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

        public TexturePanelViewModel(string name)
            : base(name)
        {
        }
    }
}