using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Animation
{
    public class AnimationViewModel : BasicTreeItemViewModel
    {
        public PreviewControlViewModel PreviewControl { get; private set; }

        public AnimationViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            PreviewControl = new PreviewControlViewModel();
        }
    }
}