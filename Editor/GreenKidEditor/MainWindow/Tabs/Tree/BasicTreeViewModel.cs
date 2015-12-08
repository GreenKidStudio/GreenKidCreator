using System.Collections.ObjectModel;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace GreenKidEditor.MainWindow.Tabs.Tree
{
    public class BasicTreeViewModel : ViewModelBase
    {
        private BasicTreeItemViewModel mSelectedItem;

        public ObservableCollection<BasicTreeItemViewModel> Items { get; private set; }
        public RelayCommand<RoutedEventArgs> SelectedItemCmd { get; private set; }

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

        public void InitViewModels()
        {
            Items = new ObservableCollection<BasicTreeItemViewModel>();
        }

        public void InitCommands()
        {
            SelectedItemCmd = new RelayCommand<RoutedEventArgs>(ExecuteSelectedItem);
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