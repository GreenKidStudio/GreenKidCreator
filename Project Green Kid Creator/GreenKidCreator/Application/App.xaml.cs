using GalaSoft.MvvmLight.Threading;

namespace GreenKidCreator.Application
{
    public partial class App
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }
    }
}