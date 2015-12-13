using System.Windows.Media;

namespace GreenKidEditor.MainWindow.Menus
{
    public class ColorControlViewModel : BasicViewModel
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

                // Update the Hex Value
                RaisePropertyChanged(() => HexValue);
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
                RaisePropertyChanged(() => HexValue);
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
                RaisePropertyChanged(() => HexValue);
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
                RaisePropertyChanged(() => HexValue);
            }
        }

        public string HexValue => "Hex Value #" + mColor.R.ToString("X2") + mColor.G.ToString("X2") + mColor.B.ToString("X2");

        public ColorControlViewModel(string header)
        {
            Header = header;
        }

        public ColorControlViewModel(string header, Color color)
            : this(header)
        {
            mColor = color;
        }

        public override void InitViewModels()
        {
        }
    }
}