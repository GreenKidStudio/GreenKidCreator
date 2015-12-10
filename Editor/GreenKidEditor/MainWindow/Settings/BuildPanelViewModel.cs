using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight.Command;
using GreenKidEditor.Application.Managers;

namespace GreenKidEditor.MainWindow.Settings
{
    public class BuildPanelViewModel : BasicViewModel
    {
        public RelayCommand BuildCmd { get; private set; }

        public IEnumerable<string> PlatformList => BuildManager.Platforms;

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

        public override void InitViewModels()
        {
        }

        public override void InitCommands()
        {
            BuildCmd = new RelayCommand(ExecuteBuild);
        }

        private void ExecuteBuild()
        {
        }
    }
}