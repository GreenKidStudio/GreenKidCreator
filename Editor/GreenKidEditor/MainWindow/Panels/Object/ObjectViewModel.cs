using GreenKidEditor.MainWindow.Panels.Transform;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Object
{
    public class ObjectViewModel : BasicDataTreeItemViewModel
    {
        public TransformPanelViewModel Transform { get; private set; }

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