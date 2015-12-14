using GreenKidEditor.MainWindow.Panels.Transform;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Object
{
    public class ObjectViewModel : BasicDataTreeItemViewModel
    {
        public ObjectViewModel(string name)
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