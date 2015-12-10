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
        public override void LoadData()
        {
            base.LoadData();

            ItemsTree.AddItem(new ModelViewModel("Model"));
            ItemsTree.AddItem(new MeshViewModel("Mesh"));
            ItemsTree.AddItem(new TextureViewModel("Texture"));
            ItemsTree.AddItem(new MaterialViewModel("Material"));
            ItemsTree.AddItem(new TechniqueViewModel("Technique"));
            ItemsTree.AddItem(new AnimationViewModel("Animation"));

            foreach (var item in ItemsTree.Items)
            {
                item.InitViewModels();
                item.InitModelData();
            }
        }
    }
}