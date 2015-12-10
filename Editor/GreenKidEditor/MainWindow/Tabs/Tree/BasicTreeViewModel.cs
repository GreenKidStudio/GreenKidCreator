using System.Collections.ObjectModel;
using System.Windows;
using GalaSoft.MvvmLight.Command;

namespace GreenKidEditor.MainWindow.Tabs.Tree
{
    public class BasicTreeViewModel : BasicViewModel
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

        public override void InitViewModels()
        {
            Items = new ObservableCollection<BasicTreeItemViewModel>();
        }

        public override void InitCommands()
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