using GalaSoft.MvvmLight;
using GreenKidEditor.Application.Managers;

namespace GreenKidEditor.MainWindow.Panels.Settings
{
    public class InfoPanelViewModel : ViewModelBase
    {
        public string EditorVersion { get; private set; }

        public string OpenGLVersion
        {
            get { return GraphicsManager.OpenGL; }
        }

        public string GLSLVersion
        {
            get { return GraphicsManager.GLSL; }
        }

        public InfoPanelViewModel()
        {
            EditorVersion = "Alpha 1 v.0.0.3";
        }
    }
}