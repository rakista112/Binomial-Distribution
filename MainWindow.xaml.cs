using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace binomDistWpf
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

        public int fac(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * fac(n - 1);
            }
        }

        public float comb(int n, int r)
        {
            float result = fac(n) / (fac(n - r) * fac(r));
            return result;
        }

        public float getBinoDist(float P, int n, int x)
        {
            float result = comb(n, x) * (float)Math.Pow(P, x) * (float)Math.Pow(1 - P, n - x);
            return result;
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            float P = float.Parse(txtP.Text);
            int n = int.Parse(txtN.Text);
            int x = int.Parse(txtX.Text);
 
            lblResult.Content = Math.Round(getBinoDist(P, n, x), 2);
        }

    }
}
