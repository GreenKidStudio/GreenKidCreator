using GreenKidEditor.MainWindow.Panels.Settings;

namespace GreenKidEditor.MainWindow.Tabs.SettingsTab
{
    public class SettingsTabViewModel : BasicTabViewModel
    {
        private GraphicsPanelViewModel mGraphicsPanel;
        private BuildPanelViewModel mBuildPanel;
        private ScenePanelViewModel mScenePanel;
        private InfoPanelViewModel mInfoPanel;

        public GraphicsPanelViewModel GraphicsPanel => mGraphicsPanel ?? (mGraphicsPanel = new GraphicsPanelViewModel());
        public BuildPanelViewModel BuildPanel => mBuildPanel ?? (mBuildPanel = new BuildPanelViewModel());
        public ScenePanelViewModel ScenePane => mScenePanel ?? (mScenePanel = new ScenePanelViewModel());
        public InfoPanelViewModel InfoPanel => mInfoPanel ?? (mInfoPanel = new InfoPanelViewModel());
    }
}