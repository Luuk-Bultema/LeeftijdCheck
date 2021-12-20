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

namespace leeftijd
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnCheck_Click(object sender, RoutedEventArgs e)

        {
            int sleeftijd = Int32.Parse(btnCheck1.Text);
            if (sleeftijd >= 18)
            {
                if (sleeftijd >= 18 && sleeftijd <= 25)
                {
                    MessageBox.Show("ff ID laten zien!");
                }
                MessageBox.Show("U mag bier drinken met carnaval");





            }
            else MessageBox.Show("U mag geen bier drinken!");
            MessageBox.Show("De ingevoerde leeftijd is:" + sleeftijd); 
        }
    }
    
}
