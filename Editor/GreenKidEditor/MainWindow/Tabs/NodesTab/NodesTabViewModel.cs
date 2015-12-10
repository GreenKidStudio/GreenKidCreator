using GreenKidEditor.MainWindow.Panels.Light;
using GreenKidEditor.MainWindow.Panels.Node;
using GreenKidEditor.MainWindow.Panels.Object;

namespace GreenKidEditor.MainWindow.Tabs.NodesTab
{
    public class NodesTabViewModel : BasicDataTabViewModel
    {
        public override void LoadData()
        {
            base.LoadData();

            ItemsTree.AddItem(new NodeGroupViewModel("Node"));
            ItemsTree.AddItem(new ObjectViewModel("Object"));
            ItemsTree.AddItem(new LightViewModel("Light"));

            foreach (var item in ItemsTree.Items)
            {
                item.InitViewModels();
            }
        }
    }
}