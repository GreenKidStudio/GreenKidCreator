using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Model
{
    public class ModelPanelViewModel : BasicTreeItemCollectionViewModel
    {
        public PreviewControlViewModel PreviewControl { get; private set; }

        public ModelPanelViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {

            PreviewControl = new PreviewControlViewModel();
        }
    }
}