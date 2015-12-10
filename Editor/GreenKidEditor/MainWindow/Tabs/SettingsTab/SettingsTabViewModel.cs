using GreenKidEditor.MainWindow.Settings;

namespace GreenKidEditor.MainWindow.Tabs.SettingsTab
{
    public class SettingsTabViewModel : BasicTabViewModel
    {
        public GraphicsPanelViewModel GraphicsPanel { get; private set; }
        public BuildPanelViewModel BuildPanel { get; private set; }
        public ScenePanelViewModel ScenePanel { get; private set; }
        public InfoPanelViewModel InfoPanel { get; private set; }

        public override void InitViewModels()
        {
            GraphicsPanel = new GraphicsPanelViewModel();
            GraphicsPanel.InitCommands();

            ScenePanel = new ScenePanelViewModel();
            ScenePanel.InitViewModels();

            BuildPanel = new BuildPanelViewModel();
            BuildPanel.InitCommands();

            InfoPanel = new InfoPanelViewModel();
        }
    }
}