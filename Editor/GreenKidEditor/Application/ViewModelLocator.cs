using GreenKidEditor.MainWindow;

namespace GreenKidEditor.Application
{
    public class ViewModelLocator
    {
        private static MainWindowViewModel mMainWindow;

        public static MainWindowViewModel MainWindow => mMainWindow ?? (mMainWindow = new MainWindowViewModel());

        public static void Cleanup()
        {
            MainWindow.Cleanup();
        }
    }
}