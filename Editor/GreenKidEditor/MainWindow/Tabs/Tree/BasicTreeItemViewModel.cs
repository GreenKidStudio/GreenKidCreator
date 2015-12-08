using GalaSoft.MvvmLight;
using GreenKidEditor.MainWindow.Panels.Transform;

namespace GreenKidEditor.MainWindow.Tabs.Tree
{
    public class BasicTreeItemViewModel : ViewModelBase
    {
        private string mName;

        public string Name
        {
            get { return mName; }
            set
            {
                mName = value;

                RaisePropertyChanged(() => Name);
            }
        }

        public TransformPanelViewModel Transform { get; private set; }

        public BasicTreeItemViewModel(string name)
        {
            mName = name;
        }

        public virtual void InitViewModels()
        { 
            Transform = new TransformPanelViewModel();
        }
    }
}