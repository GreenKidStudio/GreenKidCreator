using GalaSoft.MvvmLight;
using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.Utils;

namespace GreenKidEditor.MainWindow.Settings
{
    public class ScenePanelViewModel : ViewModelBase
    {
        public ColorControlViewModel ColorControl { get; private set; }

        public void InitViewModels()
        {
            ColorControl = new ColorControlViewModel("Clear", Color.Black);
        }
    }
}