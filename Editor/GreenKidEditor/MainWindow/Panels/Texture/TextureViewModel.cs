using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Texture
{
    public class TextureViewModel : BasicTreeItemViewModel
    {
        private TextureData mTextureData;

        public PreviewControlViewModel PreviewControl { get; private set; }

        public string File => mTextureData.File;

        public int Width => mTextureData.Width;
        public int Height => mTextureData.Height;

        public bool UseMipMaps
        {
            get { return mTextureData.UseMipMaps; }
            set
            {
                mTextureData.UseMipMaps = value;
                
                RaisePropertyChanged(() => UseMipMaps);
            }
        }

        public bool IsCompressed
        {
            get { return mTextureData.IsCompressed; }
            set
            {
                mTextureData.IsCompressed = value;
                
                RaisePropertyChanged(() => IsCompressed);
            }
        }

        public TextureViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            PreviewControl = new PreviewControlViewModel();
        }

        public override void InitModelData()
        {
            mTextureData = new TextureData();
        }
    }
}