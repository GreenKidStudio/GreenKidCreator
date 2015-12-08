using GreenKidEditor.MainWindow.Panels.Animation;
using GreenKidEditor.MainWindow.Panels.Material;
using GreenKidEditor.MainWindow.Panels.Mesh;
using GreenKidEditor.MainWindow.Panels.Model;
using GreenKidEditor.MainWindow.Panels.Technique;
using GreenKidEditor.MainWindow.Panels.Texture;

namespace GreenKidEditor.MainWindow.Tabs.AssetsTab
{
    public class AssetsTabViewModel : BasicDataTabViewModel
    {
        public override void LoadDataTab()
        {
            base.LoadDataTab();

            ItemsTree.AddItem(new ModelPanelViewModel("Model"));
            ItemsTree.AddItem(new MeshPanelViewModel("Mesh"));
            ItemsTree.AddItem(new TexturePanelViewModel("Texture"));
            ItemsTree.AddItem(new MaterialPanelViewModel("Material"));
            ItemsTree.AddItem(new TechniquePanelViewModel("Technique"));
            ItemsTree.AddItem(new AnimationPanelViewModel("Animation"));

            foreach (var item in ItemsTree.Items)
            {
                item.InitViewModels();
            }
        }
    }
}