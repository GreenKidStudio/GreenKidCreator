namespace GreenKidEditor.MainWindow.Menus
{
    public class PreviewControlViewModel : BasicViewModel
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

        public override void InitViewModels()
        {
        }
    }
}