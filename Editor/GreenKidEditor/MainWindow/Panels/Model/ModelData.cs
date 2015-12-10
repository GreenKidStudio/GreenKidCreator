namespace GreenKidEditor.MainWindow.Panels.Model
{
    public class ModelData
    {
        public string File { get; private set; }
        public bool UseAnimations { get; set; }

        public int Meshes { get; set; }
        public int Materials { get; set; }
        public int Textures { get; set; }

        public ModelData(string file)
        {
            File = file;
        }
    }
}