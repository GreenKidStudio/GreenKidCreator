using GalaSoft.MvvmLight;

namespace GreenKidCreator.Tabs.Tree
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

        public BasicTreeItemViewModel(string name)
        {
            mName = name;
        }
    }
}