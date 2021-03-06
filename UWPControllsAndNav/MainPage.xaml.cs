using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPControllsAndNav
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MyCheckBox_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CheckBoxResultTextBlock.Text = ((CheckBox)sender).IsChecked.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = ((RadioButton)sender);
            if (radioButton == NoRadioButton) {
                RadioButtonTextBlock.Text = "NO";

            }
            else {
                RadioButtonTextBlock.Text = "YES";
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxResultTextBlock == null) return;
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxResultTextBlock.Text = ((ComboBoxItem)comboBox.SelectedItem).Content.ToString();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxResultTextBlock == null) { return; }
                var selectedItems = MyListBox.Items.Cast<ListBoxItem>()
                      .Where(p => p.IsSelected)
                        .Select(t => t.Content.ToString())
                          .ToArray();
            ListBoxResultTextBlock.Text = string.Join(", ", selectedItems);
        }

        private void MyToggleButton_Click(object sender, RoutedEventArgs e)
        {
            ToggleButtonResultTextBlock.Text = MyToggleButton.IsChecked.ToString();
        }
    }
}
