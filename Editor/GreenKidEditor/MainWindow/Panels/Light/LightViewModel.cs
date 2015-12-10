using System.Windows.Media;
using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Panels.Transform;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Light
{
    public class LightViewModel : BasicTreeItemViewModel
    {
        public TransformPanelViewModel Transform { get; private set; }
        public ColorControlViewModel ColorControl { get; private set; }

        public LightViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            Transform = new TransformPanelViewModel();
            Transform.InitViewModels();

            ColorControl = new ColorControlViewModel("Color", Colors.Blue);
        }
    }
}