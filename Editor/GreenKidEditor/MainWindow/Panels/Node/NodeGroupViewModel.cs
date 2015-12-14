using GreenKidEditor.MainWindow.Panels.Transform;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Node
{
    public class NodeGroupViewModel : BasicDataTreeItemViewModel
    {
        public NodeGroupViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            Transform = new TransformPanelViewModel();
            Transform.InitViewModels();
        }
    }
}