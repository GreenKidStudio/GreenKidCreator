using GalaSoft.MvvmLight;

namespace GreenKidEditor.MainWindow.Tabs
{
    public class BasicTabViewModel : ViewModelBase
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

        public BasicTabViewModel()
        {
            mIsVisible = true;
        }
    }
}