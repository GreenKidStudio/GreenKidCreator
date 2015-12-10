using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Texture
{
    public class TextureViewModel : BasicTreeItemViewModel
    {
        public PreviewControlViewModel PreviewControl { get; private set; }

        public TextureViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            PreviewControl = new PreviewControlViewModel();
        }
    }
}