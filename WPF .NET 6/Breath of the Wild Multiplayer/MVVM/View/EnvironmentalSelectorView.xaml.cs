﻿using Breath_of_the_Wild_Multiplayer.MVVM.ViewModel;
using System.Windows.Controls;

namespace Breath_of_the_Wild_Multiplayer.MVVM.View
{
    /// <summary>
    /// Lógica de interacción para EnvironmentalSelectorView.xaml
    /// </summary>
    public partial class EnvironmentalSelectorView : UserControl
    {
        public EnvironmentalSelectorView()
        {
            InitializeComponent();
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer send = (ScrollViewer)sender;

            if (send.VerticalOffset == 0 && send.VerticalOffset == send.ScrollableHeight)
                send.Tag = 0; // Full
            else if (send.VerticalOffset == 0 && send.VerticalOffset != send.ScrollableHeight)
                send.Tag = 1; // Top
            else if (send.VerticalOffset != 0 && send.VerticalOffset != send.ScrollableHeight)
                send.Tag = 2; // Middle
            else if (send.VerticalOffset != 0 && send.VerticalOffset == send.ScrollableHeight)
                send.Tag = 3; // Bottom
        }
    }
}
