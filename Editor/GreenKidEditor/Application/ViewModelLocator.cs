using GreenKidEditor.MainWindow;

namespace GreenKidEditor.Application
{
    public class ViewModelLocator
    {
        private static MainWindowViewModel mMainWindow;

        public static MainWindowViewModel MainWindow
        {
            get
            {
                if (mMainWindow != null)
                {
                    return mMainWindow;
                }

                mMainWindow = new MainWindowViewModel();
                mMainWindow.InitViewModels();
                mMainWindow.InitCommands();

                return mMainWindow;
            }
        }

        public static void Cleanup()
        {
            MainWindow.Cleanup();
        }
    }
}