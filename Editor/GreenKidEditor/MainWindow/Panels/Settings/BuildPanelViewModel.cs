using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GreenKidEditor.Application.Managers;

namespace GreenKidEditor.MainWindow.Panels.Settings
{
    public class BuildPanelViewModel : ViewModelBase
    {
        private RelayCommand mBuildCmd;

        public IEnumerable<string> PlatformList => BuildManager.Platforms;

        public RelayCommand BuildCmd => mBuildCmd ?? (mBuildCmd = new RelayCommand(ExecuteBuild));
    
        public string Platform
        {
            get { return BuildManager.CurrentPlatform; }
            set
            {
                BuildManager.CurrentPlatform = value;
                
                RaisePropertyChanged(() => Platform);
            }
        }

        public BuildPanelViewModel()
        {
            Platform = PlatformList.First();
        }

        private void ExecuteBuild()
        {
        }
    }
}