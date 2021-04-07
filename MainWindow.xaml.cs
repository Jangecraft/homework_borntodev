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

namespace homework_borntodev
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
            double Income = double.Parse(txtIncome.Text);
            double Expenditure = double.Parse(txtExpenditure.Text);
            double Price = double.Parse(txtPrice.Text);

            double process = Income - Expenditure;

            int Day = 0;
            double i = 0;
            if (process > 0)
            {
                while (i < Price)
                {
                    i = i + process;
                    Day += 1;
                }
                txtDay.Text = Day.ToString();
            }
            else
            {
                txtDay.Text = "Error";
            }
        }
    }
}
