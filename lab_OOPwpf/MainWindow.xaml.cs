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
            hum2.Name = "konthai2";
            hum2.Lastname = "รักตู่";
            hum2.Postion = "ceo";


            Class1 hum3 = new Class1();
            hum3.ID = 3;
            hum3.Name = "konthai3";
            hum3.Lastname = "11";
            hum3.Postion = "รักป้อม";
                
            List<Class1> list = new List<Class1>();
            list.Add(hum);
            list.Add(hum2);
            list.Add(hum3);

            foreach (Class1 obj in list)
            {
                try
                {
                    if (obj.ID == int.Parse(employeeTextBox.Text))
                    {
                        MessageBox.Show("id:  " + obj.ID + " Name: " + obj.Name + " Lastname " + obj.Lastname + "    Positon: " + obj.Postion + "  ");
                        break;  
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               
            }
            MessageBox.Show($"ไม่เจอหมายเลข");
        }
    }
}
