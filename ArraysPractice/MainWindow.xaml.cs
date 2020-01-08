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
        private int[] scores = new int[5];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int score = int.Parse(txtScore.Text);
            scores[lstResults.Items.Count] = score;
            lstResults.Items.Add(score);

            int total = 0;

            for (int i = 0; i < lstResults.Items.Count; i++)
            {
                total += scores[i];
            }

            tbAvg.Text = $"{total / lstResults.Items.Count}";
            txtScore.Text = "";
            txtScore.SelectAll();
            txtScore.Focus();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            scores = new int[5];
            lstResults.Items.Clear();
            tbAvg.Text = "";
        }
    }
}
