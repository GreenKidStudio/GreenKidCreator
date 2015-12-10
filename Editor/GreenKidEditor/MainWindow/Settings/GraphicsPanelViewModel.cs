using System.Collections.Generic;
using System.Threading;
using GalaSoft.MvvmLight.Command;
using GreenKidEditor.Application.Managers;

namespace GreenKidEditor.MainWindow.Settings
{
    public class GraphicsPanelViewModel : BasicViewModel
    {
        public RelayCommand SaveCmd { get; private set; }

        public IEnumerable<int> SamplesList => GraphicsManager.SamplesValues;

        public int Samples
        {
            get { return GraphicsManager.Samples; }
            set
            {
                GraphicsManager.Samples = value;
                
                RaisePropertyChanged(() => Samples);
            }
        }

        public bool InBuildOnly
        {
            get { return GraphicsManager.UseSamplesInBuild; }
            set
            {
                GraphicsManager.UseSamplesInBuild = value;
                
                RaisePropertyChanged(() => InBuildOnly);
            }
        }

        public override void InitViewModels()
        {
        }

        public override void InitCommands()
        {
            SaveCmd = new RelayCommand(ExecuteSave);
        }

        private void ExecuteSave()
        {
            new Thread(GraphicsManager.SaveSettings).Start();
        }
    }
}