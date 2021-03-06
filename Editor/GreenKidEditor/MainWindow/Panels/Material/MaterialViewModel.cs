﻿using System.Windows.Media;
using GreenKidEditor.MainWindow.Menus;
using GreenKidEditor.MainWindow.Tabs.Tree;

namespace GreenKidEditor.MainWindow.Panels.Material
{
    public class MaterialViewModel : BasicTreeItemViewModel
    {
        public ColorControlViewModel ColorControl { get; private set; }
        public PreviewControlViewModel PreviewControl { get; private set; }

        public MaterialViewModel(string name)
            : base(name)
        {
        }

        public override void InitViewModels()
        {
            ColorControl = new ColorControlViewModel("Diffuse", Colors.Red);
            PreviewControl = new PreviewControlViewModel();
        }
    }
}