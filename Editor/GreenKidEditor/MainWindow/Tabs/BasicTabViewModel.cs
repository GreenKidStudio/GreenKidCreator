namespace GreenKidEditor.MainWindow.Tabs
{
    public abstract class BasicTabViewModel : BasicViewModel
    {
        private bool mIsSelected;
        private bool mIsVisible;

        public bool IsSelected
        {
            get { return mIsSelected; }
            set
            {
                mIsSelected = value;
                
                RaisePropertyChanged(() => IsSelected);
            }
        }

        public bool IsVisible
        {
            get { return mIsVisible; }
            set
            {
                mIsVisible = value;
                
                RaisePropertyChanged(() => IsVisible);
            }
        }

        protected BasicTabViewModel()
        {
            mIsVisible = true;
        }
    }
}