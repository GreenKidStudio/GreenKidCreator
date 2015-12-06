using GalaSoft.MvvmLight.Threading;
using GreenKidEditor.Application.Managers;

namespace GreenKidEditor.Application
{
    public partial class App
    {
        static App()
        {
            GraphicsManager.LoadSettings();

            DispatcherHelper.Initialize();
        }
    }
}