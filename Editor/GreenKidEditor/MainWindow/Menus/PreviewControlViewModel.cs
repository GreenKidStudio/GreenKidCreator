using GalaSoft.MvvmLight;

namespace GreenKidEditor.MainWindow.Menus
{
    public class PreviewControlViewModel : ViewModelBase
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
    }
}