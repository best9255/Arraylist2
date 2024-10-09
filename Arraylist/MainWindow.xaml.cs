using System;
using System.Collections;
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

namespace Arraylist
{
    public partial class MainWindow : Window
    {
        ArrayList ArrayList;
        public MainWindow()
        {
            InitializeComponent();
            ArrayList = new ArrayList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ArrayList.Add(text_box.Text);
            MessageBox.Show("complete");
            ArrayList.Sort();
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            ArrayList.Remove(text_box.Text);
            MessageBox.Show("complete");
        }

        private void Show_All_Click(object sender, RoutedEventArgs e)
        {
            string data = string.Empty;
            foreach (string item in ArrayList)
            {
                data = item;
                MessageBox.Show(data);
            }
        }
    }
}
