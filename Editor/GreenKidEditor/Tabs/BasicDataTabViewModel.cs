using GreenKidCreator.Menus;
using GreenKidCreator.Tabs.Tree;

namespace GreenKidCreator.Tabs
{
    public class BasicDataTabViewModel : BasicTabViewModel
    {
        private BasicTreeViewModel mItemsTree;

        private AddItemBarViewModel mAddItemBar;
        private SearchBarViewModel mSearchBar;

        public BasicTreeViewModel ItemsTree
        {
            get { return mItemsTree; }
            private set
            {
                mItemsTree = value;
                
                RaisePropertyChanged(() => ItemsTree);
            }
        }

        public AddItemBarViewModel AddItemBar
        {
            get { return mAddItemBar; }
            set
            {
                mAddItemBar = value;
                
                RaisePropertyChanged(() => AddItemBar);
            }
        }

        public SearchBarViewModel SearchBar
        {
            get { return mSearchBar; }
            set
            {
                mSearchBar = value;
                
                RaisePropertyChanged(() => SearchBar);
            }
        }

        public virtual void LoadDataTab()
        {
            ItemsTree = new BasicTreeViewModel();
            ItemsTree.Init();
        }
    }
}