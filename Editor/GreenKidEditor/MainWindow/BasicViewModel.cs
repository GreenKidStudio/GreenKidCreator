using GalaSoft.MvvmLight;

namespace GreenKidEditor.MainWindow
{
    public abstract class BasicViewModel : ViewModelBase
    {
        // Init the View Models
        public abstract void InitViewModels();

        // Init the Commands
        public virtual void InitCommands() { }

        // Init the Model Data
        public virtual void InitModelData() { }
    }
}