using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShowInstalledFonts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.FontListBox.ItemsSource = Fonts.SystemFontFamilies.OrderBy(x => x.Source);
        }

        private void FontListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.DemoFontTextBox.FontFamily = this.FontListBox.SelectedItem as FontFamily;
        }
    }
}
