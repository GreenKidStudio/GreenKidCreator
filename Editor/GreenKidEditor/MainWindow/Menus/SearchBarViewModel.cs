using System.Collections.Generic;
using System.Linq;

namespace GreenKidEditor.MainWindow.Menus
{
    public class SearchBarViewModel : BasicViewModel
    {
        private string mItemsFilter;

        public List<string> ItemsFilterTypes { get; set; }

        public string ItemsFilter
        {
            get { return mItemsFilter; }
            set
            {
                mItemsFilter = value;

                RaisePropertyChanged(() => ItemsFilter);
            }
        }

        public override void InitViewModels()
        {
            ItemsFilterTypes = new List<string> { "All" };

            ItemsFilter = ItemsFilterTypes.First();
        }
    }
}