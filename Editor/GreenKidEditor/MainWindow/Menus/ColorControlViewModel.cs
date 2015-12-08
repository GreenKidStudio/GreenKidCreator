using System.Windows.Media;
using GalaSoft.MvvmLight;

namespace GreenKidEditor.MainWindow.Menus
{
    public class ColorControlViewModel : ViewModelBase
    {
        private Color mColor;

        public string Header { get; set; }

        public Color Color
        {
            get { return mColor; }
            set
            {
                mColor = value;

                RaisePropertyChanged(() => Color);
            }
        }

        public byte R
        {
            get { return mColor.R; }
            set
            {
                mColor.R = value;

                RaisePropertyChanged(() => R);
            }
        }

        public byte G
        {
            get { return mColor.G; }
            set
            {
                mColor.G = value;

                RaisePropertyChanged(() => G);
            }
        }

        public byte B
        {
            get { return mColor.B; }
            set
            {
                mColor.B = value;

                RaisePropertyChanged(() => B);
            }
        }

        public ColorControlViewModel(string header)
        {
            Header = header;
        }

        public ColorControlViewModel(string header, Color color)
            : this(header)
        {
            mColor = color;
        }
    }
}