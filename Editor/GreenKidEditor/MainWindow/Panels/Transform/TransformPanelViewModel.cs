using GreenKidEditor.MainWindow.Menus;

namespace GreenKidEditor.MainWindow.Panels.Transform
{
    public class TransformPanelViewModel : BasicViewModel
    {
        public Vector3ControlViewModel PositionControl { get; private set; }
        public Vector3ControlViewModel RotationControl { get; private set; }
        public Vector3ControlViewModel ScaleControl { get; private set; }

        public override void InitViewModels()
        {
            PositionControl = new Vector3ControlViewModel("Position");
            RotationControl = new Vector3ControlViewModel("Rotation");
            ScaleControl = new Vector3ControlViewModel("Scale");
        }
    }
}