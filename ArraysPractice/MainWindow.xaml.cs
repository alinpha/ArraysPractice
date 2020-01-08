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

namespace ArraysPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double total = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lstResults.Items.Add(txtScore.Text);
            total += double.Parse(txtScore.Text);
            tbAvg.Text = $"{total / lstResults.Items.Count}";
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            total = 0;
            lstResults.Items.Clear();
            tbAvg.Text = "";
        }
    }
}
