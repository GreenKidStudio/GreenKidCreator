using System.Collections.ObjectModel;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace GreenKidCreator.Tabs.Tree
{
    public class BasicTreeViewModel : ViewModelBase
    {
        private BasicTreeItemViewModel mSelectedItem;
        private RelayCommand<RoutedEventArgs> mSelectedItemCmd;

        public ObservableCollection<BasicTreeItemViewModel> Items { get; private set; }

        public RelayCommand<RoutedEventArgs> SelectedItemCmd => mSelectedItemCmd ?? (mSelectedItemCmd = new RelayCommand<RoutedEventArgs>(ExecuteSelectedItem));

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

        public void Init()
        {
            Items = new ObservableCollection<BasicTreeItemViewModel>();
        }

        public void AddItem(BasicTreeItemViewModel item)
        {
            Items.Add(item);
        }

        private void ExecuteSelectedItem(RoutedEventArgs eventArgs)
        {
            SelectedItem = ((RoutedPropertyChangedEventArgs<object>)eventArgs).NewValue as BasicTreeItemViewModel;
        }
    }
}