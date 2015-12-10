using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Model
{
    public class ModelViewModel : BasicDataTreeItemViewModel
    {
        private ModelData mModelData;

        public PreviewControlViewModel PreviewControl { get; private set; }

        public int MeshesCount => mModelData.Meshes;
        public int MaterialsCount => mModelData.Materials;
        public int TexturesCount => mModelData.Textures;

        public bool UseAnimations => mModelData.UseAnimations;

        public string File => mModelData.File;

        public ModelViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            PreviewControl = new PreviewControlViewModel();
        }

        public override void InitModelData()
        {
            mModelData = new ModelData();
        }
    }
}