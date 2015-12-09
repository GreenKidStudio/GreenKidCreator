using GalaSoft.MvvmLight;

namespace GreenKidEditor.MainWindow.Menus
{
    public class Vector3ControlViewModel : ViewModelBase
    {
        private float mX;
        private float mY;
        private float mZ;

        public string Header { get; set; }

        public float X
        {
            get { return mX; }
            set
            {
                mX = value;

                RaisePropertyChanged(() => X);
            }
        }

        public float Y
        {
            get { return mY; }
            set
            {
                mY = value;

                RaisePropertyChanged(() => Y);
            }
        }

        public float Z
        {
            get { return mZ; }
            set
            {
                mZ = value;

                RaisePropertyChanged(() => Z);
            }
        }

        public Vector3ControlViewModel(string header)
        {
            Header = header;
        }

        public Vector3ControlViewModel(string header, float x, float y, float z)
            : this(header)
        {
            mX = x;
            mY = y;
            mZ = z;
        }
    }
}