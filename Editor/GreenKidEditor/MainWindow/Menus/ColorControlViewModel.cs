using GalaSoft.MvvmLight;
using GreenKidEditor.Utils;

namespace GreenKidEditor.MainWindow.Menus
{
    public class ColorControlViewModel : ViewModelBase
    {
        public Color Color { get; set; }
        public string Header { get; set; }

        public int R
        {
            get { return Color.R; }
            set
            {
                Color.SetR(value);

                RaisePropertyChanged(() => R);
            }
        }

        public int G
        {
            get { return Color.G; }
            set
            {
                Color.SetG(value);

                RaisePropertyChanged(() => G);
            }
        }

        public int B
        {
            get { return Color.B; }
            set
            {
                Color.SetB(value);

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
            Color = color;
        }
    }
}