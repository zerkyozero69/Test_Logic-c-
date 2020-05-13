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
            Class1  hum = new Class1(1,"anawat","promsorn","programer");
            
            Class1 hum2 = new Class1(2, "ning", "promsorn", "programer2");
            Class1 hum3 = new Class1(3, "aom", "promsorn", "programer3");

            Class1 hum4 = new Class1(4,"hello","hello");
                
            List<Class1> list = new List<Class1>();
                list.Add(hum);
            list.Add(hum2);
            list.Add(hum3);
            list.Add(hum4);
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
         
        }
    }
}
