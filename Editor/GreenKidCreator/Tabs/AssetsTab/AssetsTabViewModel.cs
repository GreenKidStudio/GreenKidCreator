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

            ItemsTree.AddItem(new ModelPanelViewModel());
            ItemsTree.AddItem(new MeshPanelViewModel());
            ItemsTree.AddItem(new TexturePanelViewModel());
            ItemsTree.AddItem(new MaterialPanelViewModel());
            ItemsTree.AddItem(new TechniquePanelViewModel());
        }
    }
}