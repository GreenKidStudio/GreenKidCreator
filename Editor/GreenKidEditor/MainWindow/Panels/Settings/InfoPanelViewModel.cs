using GalaSoft.MvvmLight;

namespace GreenKidEditor.MainWindow.Panels.Settings
{
    public class InfoPanelViewModel : ViewModelBase
    {
        public string EditorVersion { get; private set; }

        public InfoPanelViewModel()
        {
            EditorVersion = "Alpha 1 v.0.0.3";
        }
    }
}