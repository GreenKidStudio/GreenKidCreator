namespace GreenKidEditor.MainWindow.Tabs.Tree
{
    public abstract class BasicTreeItemViewModel : BasicViewModel
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

        protected BasicTreeItemViewModel(string name)
        {
            mName = name;
        }
    }
}