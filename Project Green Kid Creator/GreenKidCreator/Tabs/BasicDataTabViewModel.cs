using GalaSoft.MvvmLight.Command;

namespace GreenKidCreator.Tabs
{
    public class BasicDataTabViewModel : BasicTabViewModel
    {
        private RelayCommand mAddItemCommand;
        private RelayCommand mRemoveItemCommand;
        private RelayCommand mSaveItemsCommand;

        public RelayCommand AddItemCommand => mAddItemCommand ?? (mAddItemCommand = new RelayCommand(ExecuteAddItemCommand)); 
        public RelayCommand RemoveItemCommand => mRemoveItemCommand ?? (mRemoveItemCommand = new RelayCommand(ExecuteRemoveItemCommand));
        public RelayCommand SaveItemsCommand => mSaveItemsCommand ?? (mSaveItemsCommand = new RelayCommand(ExecuteSaveItemsCommand));

        protected virtual void ExecuteAddItemCommand()
        {
        }

        protected virtual void ExecuteRemoveItemCommand()
        {  
        }

        protected virtual void ExecuteSaveItemsCommand()
        {
        }
    }
}