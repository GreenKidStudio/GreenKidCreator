using GalaSoft.MvvmLight.Command;
using GreenKidEditor.MainWindow.Tabs.AssetsTab;
using GreenKidEditor.MainWindow.Tabs.EntitiesTab;
using GreenKidEditor.MainWindow.Tabs.FilesTab;
using GreenKidEditor.MainWindow.Tabs.NodesTab;
using GreenKidEditor.MainWindow.Tabs.SceneTab;
using GreenKidEditor.MainWindow.Tabs.SettingsTab;

namespace GreenKidEditor.MainWindow
{
    public class MainWindowViewModel : BasicViewModel
    {
        public RelayCommand LoadedCmd { get; private set; }

        public SceneTabViewModel SceneTab { get; private set; }
        public EntitiesTabViewModel EntitiesTab { get; private set; }
        public FilesTabViewModel FilesTab { get; private set; }

        public NodesTabViewModel NodesTab { get; private set; }
        public AssetsTabViewModel AssetsTab { get; private set; }
        public SettingsTabViewModel SettingsTab { get; private set; }

        public StatusBarViewModel StatusBar { get; private set; }

        public override void InitViewModels()
        {
            SceneTab = new SceneTabViewModel();
            EntitiesTab = new EntitiesTabViewModel();
            FilesTab = new FilesTabViewModel();

            NodesTab = new NodesTabViewModel();
            NodesTab.InitViewModels();

            AssetsTab = new AssetsTabViewModel();
            AssetsTab.InitViewModels();

            SettingsTab = new SettingsTabViewModel();
            SettingsTab.InitViewModels();
            
            StatusBar = new StatusBarViewModel();
        }

        public override void InitCommands()
        {
            LoadedCmd = new RelayCommand(ExecuteLoad);
        }

        private void ExecuteLoad()
        {
            AssetsTab.LoadData();
            NodesTab.LoadData();
        }
    }
}