using System.Windows.Media;
using GalaSoft.MvvmLight;
using GreenKidEditor.MainWindow.Menus;

namespace GreenKidEditor.MainWindow.Settings
{
    public class ScenePanelViewModel : ViewModelBase
    {
        public ColorControlViewModel ColorControl { get; private set; }
        public Vector3ControlViewModel GravityControl { get; private set; }

        public void InitViewModels()
        {
            ColorControl = new ColorControlViewModel("Clear", Colors.LightGray);
            GravityControl = new Vector3ControlViewModel("Gravity", 0.0f, -9.81f, 0.0f);
        }
    }
}