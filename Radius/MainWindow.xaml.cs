using System;
using System.Windows;
using System.Windows.Input;
using Tulpep.NotificationWindow;
using Color = System.Drawing.Color;

namespace Radius
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void r_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!r.Text.Contains(",")
               && r.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }
        private void c_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!(Char.IsDigit(e.Text, 0) || (e.Text == ",")
               && (!c.Text.Contains(",")
               && c.Text.Length != 0)))
            {
                e.Handled = true;
            }
        }
        private void Button_Cal(object sender, RoutedEventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.LightPink;

            double Radius = 0;
            if (string.IsNullOrWhiteSpace(r.Text) || string.IsNullOrWhiteSpace(c.Text))
            {
                popup.ContentText = "Ключевые поля не заполнены";
                popup.Popup();
            }
            else
            {
                Radius = Convert.ToDouble(r.Text) + Convert.ToDouble(c.Text);
                radius.Text = Radius.ToString();
            }
        }

        private void Button_Form(object sender, RoutedEventArgs e)
        {
            form.Text = "R = r + c\nR - Радиус  подшипника с учетом радиального зазора\nr - радиус ценности журнала\nc - значение радиального зазора";
        }
    }
}
