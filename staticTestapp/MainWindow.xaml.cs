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

namespace staticTestapp
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
            double price = double.Parse(Textboxprice.Text);
            double vat = double.Parse(TextboxVat.Text);
            double totalprice = vatcalculator.TotalPrice(price, vat);
            double valcalculate = vatcalculator.varCalculate(price,vat);
            MessageBox.Show($"ราคาสินค้า :" +price+"บาท ภาษี :"+vat  +"\n"
                +"ภาษีมูลค่าเพิ่ม :"+valcalculate+"\nรวมมูลค่าทั้งหมด : "+totalprice);     
               
        }
    }
}
