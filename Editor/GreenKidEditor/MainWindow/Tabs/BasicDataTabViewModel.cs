using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Tabs
{
    public class BasicDataTabViewModel : BasicTabViewModel
    {
        private AddItemBarViewModel mAddItemBar;
        private SearchBarViewModel mSearchBar;

        public BasicTreeViewModel ItemsTree { get; private set; }

        public AddItemBarViewModel AddItemBar { get; private set; }
        public SearchBarViewModel SearchBar { get; private set; }

        public void InitViewModels()
        {
            ItemsTree = new BasicTreeViewModel();
            ItemsTree.InitViewModels();
            ItemsTree.InitCommands();
        }

        public virtual void LoadData()
        {
        }
    }
}