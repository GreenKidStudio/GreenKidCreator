using GalaSoft.MvvmLight.Threading;

namespace GreenKidEditor.Application
{
    public partial class App
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}