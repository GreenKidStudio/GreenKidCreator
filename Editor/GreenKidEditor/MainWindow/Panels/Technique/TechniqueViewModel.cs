using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Technique
{
    public class TechniqueViewModel : BasicTreeItemViewModel
    {
        private TechniqueData mTechniqueData;

        public string VertexFile
        {
            get { return mTechniqueData.VertexShader; }
            set
            {
                mTechniqueData.VertexShader = value;
                
                RaisePropertyChanged(() => VertexFile);
            }
        }

        public string FragmentFile
        {
            get { return mTechniqueData.FragmentShader; }
            set
            {
                mTechniqueData.FragmentShader = value;
                
                RaisePropertyChanged(() => FragmentFile);
            }
        }

        public string GeometryShader
        {
            get { return mTechniqueData.GeometryShader; }
            set
            {
                mTechniqueData.GeometryShader = value;
                
                RaisePropertyChanged(() => GeometryShader);
            }
        }

        public TechniqueViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
        }

        public override void InitModelData()
        {
            mTechniqueData = new TechniqueData();
        }
    }
}