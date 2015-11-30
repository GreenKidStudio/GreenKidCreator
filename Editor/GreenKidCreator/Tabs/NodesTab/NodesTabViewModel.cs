using GreenKidCreator.Panels.Light;
using GreenKidCreator.Panels.Object;
using GreenKidCreator.Tabs.Tree;

namespace GreenKidCreator.Tabs.NodesTab
{
    public class NodesTabViewModel : BasicDataTabViewModel
    {
        public override void LoadDataTab()
        {
            base.LoadDataTab();

            ItemsTree.AddItem(new BasicTreeItemCollectionViewModel());
            ItemsTree.AddItem(new ObjectPanelViewModel());
            ItemsTree.AddItem(new LightPanelViewModel());
        }
    }
}