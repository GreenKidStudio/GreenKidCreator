using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Animation
{
    public class AnimationPanelViewModel : BasicTreeItemViewModel
    {
        public PreviewControlViewModel PreviewControl { get; private set; }

        public AnimationPanelViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            PreviewControl = new PreviewControlViewModel();
        }
    }
}