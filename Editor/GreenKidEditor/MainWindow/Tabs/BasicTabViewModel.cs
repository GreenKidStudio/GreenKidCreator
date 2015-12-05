using GalaSoft.MvvmLight;

namespace GreenKidEditor.MainWindow.Tabs
{
    public class BasicTabViewModel : ViewModelBase
    {
        private bool mIsSelected;

        public bool IsSelected
        {
            get { return mIsSelected; }
            set
            {
                mIsSelected = value;
                
                RaisePropertyChanged(() => IsSelected);
            }
        }
    }
}