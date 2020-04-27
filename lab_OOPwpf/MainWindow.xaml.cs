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

namespace lab_OOPwpf
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
            Class1  hum = new Class1();
            hum.ID = 1;
            hum.Name = "konthai";
            hum.Lastname = "1";
            hum.Postion ="ยาม" ;

            Class1 hum2 = new Class1();
            hum2.ID = 2;
            hum2.Name = "konthai";
            hum2.Lastname = "1";
            hum2.Postion = "ยาม";


            Class1 hum3 = new Class1();
            hum3.ID = 1;
            hum3.Name = "konthai";
            hum3.Lastname = "1";
            hum3.Postion = "ยาม";
                
            List<Class1> list = new List<Class1>();
            list.Add(hum);
            list.Add(hum2);
            list.Add(hum);

           

        }
    }
}
