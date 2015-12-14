using GreenKidEditor.MainWindow.Menus;

namespace GreenKidEditor.MainWindow.Panels.Transform
{
    public class TransformPanelViewModel : BasicViewModel
    {
        private bool mIsExpanded;

        public Vector3ControlViewModel PositionControl { get; private set; }
        public Vector3ControlViewModel RotationControl { get; private set; }
        public Vector3ControlViewModel ScaleControl { get; private set; }

        public bool IsExpanded
        {
            get { return mIsExpanded; }
            set
            {
                mIsExpanded = value;

                RaisePropertyChanged(() => IsExpanded);
            }
        }

        public TransformPanelViewModel()
        {
            mIsExpanded = true;
        }

        public override void InitViewModels()
        {
            PositionControl = new Vector3ControlViewModel("Position");
            RotationControl = new Vector3ControlViewModel("Rotation");
            ScaleControl = new Vector3ControlViewModel("Scale");
        }
    }
}