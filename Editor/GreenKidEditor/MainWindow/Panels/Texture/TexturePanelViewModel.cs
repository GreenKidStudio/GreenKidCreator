using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Texture
{
    public class TexturePanelViewModel : BasicTreeItemViewModel
    {
        public PreviewControlViewModel PreviewControl { get; private set; }

        public TexturePanelViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            PreviewControl = new PreviewControlViewModel();
        }
    }
}