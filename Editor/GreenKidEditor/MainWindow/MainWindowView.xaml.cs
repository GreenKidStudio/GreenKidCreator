using GreenKidEditor.Application;

namespace GreenKidEditor.MainWindow
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