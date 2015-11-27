using GalaSoft.MvvmLight;

namespace GreenKidCreator.Tabs
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