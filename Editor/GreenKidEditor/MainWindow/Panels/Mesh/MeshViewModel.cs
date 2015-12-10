using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Panels.Transform;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Mesh
{
    public class MeshViewModel : BasicTreeItemViewModel
    {
        public TransformPanelViewModel Transform { get; private set; }
        public PreviewControlViewModel PreviewControl { get; private set; }

        public MeshViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            Transform = new TransformPanelViewModel();
            Transform.InitViewModels();

            PreviewControl = new PreviewControlViewModel();
        }
    }
}