namespace GreenKidEditor.MainWindow.Panels.Model
{
    public class ModelData
    {
        public int Meshes { get; private set; }
        public int Materials { get; private set; }
        public int Textures { get; private set; }

        public bool UseAnimations { get; private set; }

        public string File { get; private set; }

        public ModelData()
        {
        }

        public ModelData(string file)
        {
            File = file;
        }
    }
}