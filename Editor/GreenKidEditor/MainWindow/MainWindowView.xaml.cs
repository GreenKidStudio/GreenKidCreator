using GreenKidCreator.Application;

namespace GreenKidCreator.MainWindow
{
    public partial class MainWindowView
    {
        public MainWindowView()
        {
            InitializeComponent();

            Closing += (sender, e) => ViewModelLocator.Cleanup();
        }
    }
}