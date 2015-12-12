namespace GreenKidEditor.MainWindow.Panels.Texture
{
    public class TextureData
    {
        public string File { get; set; }

        public bool UseMipMaps { get; set; }
        public bool IsCompressed { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}