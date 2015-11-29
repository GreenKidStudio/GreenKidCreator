using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace GreenKidCreator.Tabs.Tree
{
    public class BasicTreeViewModel : ViewModelBase
    {
        private BasicTreeItemViewModel mSelectedItem;

        public ObservableCollection<BasicTreeItemViewModel> Items { get; set; }

        public bool SelectedItemIsNull => SelectedItem == null;
   
        public BasicTreeItemViewModel SelectedItem
        {
            get { return mSelectedItem; }
            set
            {
                mSelectedItem = value;
                
                RaisePropertyChanged(() => SelectedItem);
                RaisePropertyChanged(() => SelectedItemIsNull);
            }
        }
    }
}