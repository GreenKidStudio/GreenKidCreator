using GreenKidEditor.MainWindow.Panels.Light;
using GreenKidEditor.MainWindow.Panels.Object;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Tabs.NodesTab
{
    public class NodesTabViewModel : BasicDataTabViewModel
    {
        public override void LoadDataTab()
        {
            base.LoadDataTab();

            var node = new BasicTreeItemCollectionViewModel("Node");
            var obj = new ObjectPanelViewModel("Object");
            var light = new LightPanelViewModel("Light");

            node.InitTransformation();
            obj.InitTransformation();
            light.InitTransformation();

            ItemsTree.AddItem(node);
            ItemsTree.AddItem(obj);
            ItemsTree.AddItem(light);
        }
    }
}