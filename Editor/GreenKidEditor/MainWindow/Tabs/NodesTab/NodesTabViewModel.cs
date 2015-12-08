using GreenKidEditor.MainWindow.Panels.Light;
using GreenKidEditor.MainWindow.Panels.Object;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Tabs.NodesTab
{
    public class NodesTabViewModel : BasicDataTabViewModel
    {
        public override void LoadData()
        {
            base.LoadData();

            ItemsTree.AddItem(new BasicTreeItemCollectionViewModel("Node"));
            ItemsTree.AddItem(new ObjectPanelViewModel("Object"));
            ItemsTree.AddItem(new LightPanelViewModel("Light"));

            foreach (var item in ItemsTree.Items)
            {
                item.InitViewModels();
            }
        }
    }
}