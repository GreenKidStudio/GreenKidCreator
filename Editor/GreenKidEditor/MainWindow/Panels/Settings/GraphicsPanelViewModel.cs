using System.Collections.Generic;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GreenKidEditor.Application.Managers;

namespace GreenKidEditor.MainWindow.Panels.Settings
{
    public class GraphicsPanelViewModel : ViewModelBase
    {
        private RelayCommand mSaveCmd;

        public IEnumerable<int> SamplesList => GraphicsManager.SamplesValues; 

        public RelayCommand SaveCmd => mSaveCmd ?? (mSaveCmd = new RelayCommand(ExecuteSave));

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

        public GraphicsPanelViewModel()
        {
            Samples = SamplesList.First();
        }

        private void ExecuteSave()
        {
        }
    }
}