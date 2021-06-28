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

namespace Radius
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Cal(object sender, RoutedEventArgs e)
        {
            double Radius = 0;
            Radius = Convert.ToDouble(r.Text) + Convert.ToDouble(c.Text);
            radius.Text = Radius.ToString();
        }

        private void Button_Form(object sender, RoutedEventArgs e)
        {
            form.Text = "R = r + c\n R - Радиус  подшипника с учетом радиального зазора\n r - радиус ценности журнала\n c - значение радиального зазора";
        }
    }
}
