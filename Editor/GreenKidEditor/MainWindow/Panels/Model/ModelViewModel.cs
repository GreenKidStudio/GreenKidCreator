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

        public string File => mModelData.File;

        public bool UseAnimations
        {
            get { return mModelData.UseAnimations; }
            set
            {
                mModelData.UseAnimations = value;
                
                RaisePropertyChanged(() => UseAnimations);
            }
        }

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