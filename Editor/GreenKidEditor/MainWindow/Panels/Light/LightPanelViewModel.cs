using System.Windows.Media;
using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Light
{
    public class LightPanelViewModel : BasicTreeItemViewModel
    {
        public ColorControlViewModel ColorControl { get; private set; }

        public LightPanelViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            base.InitViewModels();

            ColorControl = new ColorControlViewModel("Color", Colors.Blue);
        }
    }
}