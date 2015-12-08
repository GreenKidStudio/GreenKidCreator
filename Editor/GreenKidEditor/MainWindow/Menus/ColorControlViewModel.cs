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

                // Update the color
                RaisePropertyChanged(() => Color);

                // Update the RGB Fields
                RaisePropertyChanged(() => R);
                RaisePropertyChanged(() => G);
                RaisePropertyChanged(() => B);
            }
        }

        public byte R
        {
            get { return mColor.R; }
            set
            {
                mColor.R = value;

                RaisePropertyChanged(() => R);
                RaisePropertyChanged(() => Color);
            }
        }

        public byte G
        {
            get { return mColor.G; }
            set
            {
                mColor.G = value;

                RaisePropertyChanged(() => G);
                RaisePropertyChanged(() => Color);
            }
        }

        public byte B
        {
            get { return mColor.B; }
            set
            {
                mColor.B = value;

                RaisePropertyChanged(() => B);
                RaisePropertyChanged(() => Color);
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