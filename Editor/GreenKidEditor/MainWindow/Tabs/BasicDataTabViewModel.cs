using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Tabs
{
    public abstract class BasicDataTabViewModel : BasicTabViewModel
    {
        private AddItemBarViewModel mAddItemBar;
        private SearchBarViewModel mSearchBar;

        public BasicTreeViewModel ItemsTree { get; private set; }

        public AddItemBarViewModel AddItemBar { get; private set; }
        public SearchBarViewModel SearchBar { get; private set; }

        public override void InitViewModels()
        {
            ItemsTree = new BasicTreeViewModel();
            ItemsTree.InitViewModels();
            ItemsTree.InitCommands();

            AddItemBar = new AddItemBarViewModel();
            SearchBar = new SearchBarViewModel();
            SearchBar.InitViewModels();
        }

        public virtual void LoadData() { }
    }
}