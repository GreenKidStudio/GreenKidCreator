using GalaSoft.MvvmLight;
using GreenKidCreator.Tabs.AssetsTab;
using GreenKidCreator.Tabs.EntitiesTab;
using GreenKidCreator.Tabs.NodesTab;
using GreenKidCreator.Tabs.SceneTab;
using GreenKidCreator.Tabs.SettingsTab;

namespace GreenKidCreator.MainWindow
{
    public class MainWindowViewModel : ViewModelBase
    {
        private SceneTabViewModel mSceneTab;
        private EntitiesTabViewModel mEntitiesTab;

        private NodesTabViewModel mNodesTab;
        private AssetsTabViewModel mAssetsTab;
        private SettingsTabViewModel mSettingsTab;

        private StatusBarViewModel mStatusBar;

        public SceneTabViewModel SceneTab => mSceneTab ?? (mSceneTab = new SceneTabViewModel());
        public EntitiesTabViewModel EntitiesTab => mEntitiesTab ?? (mEntitiesTab = new EntitiesTabViewModel());

        public NodesTabViewModel NodesTab => mNodesTab ?? (mNodesTab = new NodesTabViewModel());
        public AssetsTabViewModel AssetsTab => mAssetsTab ?? (mAssetsTab = new AssetsTabViewModel());
        public SettingsTabViewModel SettingsTab => mSettingsTab ?? (mSettingsTab = new SettingsTabViewModel());

        public StatusBarViewModel StatusBar => mStatusBar ?? (mStatusBar = new StatusBarViewModel());

        public override void Cleanup()
        {
            base.Cleanup();
        }
    }
}