﻿using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;
using GreenKidEditor.Utils;

namespace GreenKidEditor.MainWindow.Panels.Material
{
    public class MaterialPanelViewModel : BasicTreeItemViewModel
    {
        private bool mIsChecked;

        public ColorControlViewModel ColorControl { get; private set; }

        public bool IsChecked
        {
            get { return mIsChecked; }
            set
            {
                mIsChecked = value;

                RaisePropertyChanged(() => IsChecked);
            }
        }

        public MaterialPanelViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            ColorControl = new ColorControlViewModel("Diffuse", Color.Red);
        }
    }
}