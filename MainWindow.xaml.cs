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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user1 = new User();
            user1.MyProperty = "bonjour";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Test tt = new Test(textbox_value.Text);
            string var1 = textbox_value.Text;
        }

        class Test
        {
            string TextRecup;
            public Test(string TextRecup)
            {
                this.TextRecup = TextRecup;
            }
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                Console.WriteLine("salut");
            }

        }
    }
}
