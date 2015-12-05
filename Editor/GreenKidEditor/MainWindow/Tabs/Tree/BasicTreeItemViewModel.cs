using GalaSoft.MvvmLight;
using GreenKidEditor.MainWindow.Panels.Transform;

namespace GreenKidEditor.MainWindow.Tabs.Tree
{
    public class BasicTreeItemViewModel : ViewModelBase
    {
        private string mName;
        private TransformPanelViewModel mTransform;

        public string Name
        {
            get { return mName; }
            set
            {
                mName = value;

                RaisePropertyChanged(() => Name);
            }
        }

        public TransformPanelViewModel Transform
        {
            get { return mTransform; }
            set
            {
                mTransform = value;
                
                RaisePropertyChanged(() => Transform);
            }
        }

        public BasicTreeItemViewModel(string name)
        {
            mName = name;
        }

        public void InitTransformation()
        { 
            mTransform = new TransformPanelViewModel();
        }
    }
}