using GreenKidCreator.Panels.Animation;
using GreenKidCreator.Panels.Material;
using GreenKidCreator.Panels.Mesh;
using GreenKidCreator.Panels.Model;
using GreenKidCreator.Panels.Technique;
using GreenKidCreator.Panels.Texture;

namespace GreenKidCreator.Tabs.AssetsTab
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
        }
    }
}