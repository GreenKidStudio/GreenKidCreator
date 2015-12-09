using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Mesh
{
    public class MeshPanelViewModel : BasicTreeItemViewModel
    {
        public PreviewControlViewModel PreviewControl { get; private set; }

        public MeshPanelViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            base.InitViewModels();

            PreviewControl = new PreviewControlViewModel();
        }
    }
}