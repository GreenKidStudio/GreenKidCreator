using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Panels.Transform;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Mesh
{
    public class MeshViewModel : BasicTreeItemViewModel
    {
        private MeshData mMeshData;

        public PreviewControlViewModel PreviewControl { get; private set; }

        public int VerticesCount => mMeshData.Vertices;
        public int TrianglesCount => mMeshData.Triangles;

        public MeshViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            Transform = new TransformPanelViewModel();
            Transform.InitViewModels();

            PreviewControl = new PreviewControlViewModel();
        }

        public override void InitModelData()
        {
            mMeshData = new MeshData();
        }
    }
}