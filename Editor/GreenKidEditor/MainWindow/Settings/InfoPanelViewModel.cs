using GreenKidEditor.Application.Managers;

namespace GreenKidEditor.MainWindow.Settings
{
    public class InfoPanelViewModel : BasicViewModel
    {
        public string EditorVersion { get; private set; }

        public string OpenGLVersion => GraphicsManager.OpenGL;
        public string GLSLVersion => GraphicsManager.GLSL;

        public InfoPanelViewModel()
        {
            EditorVersion = "Alpha 1 v.0.0.4";
        }

        public override void InitViewModels()
        {
        }
    }
}