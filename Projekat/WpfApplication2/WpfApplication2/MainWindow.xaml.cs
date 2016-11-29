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
using System.IO;

namespace WpfApplication2
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: ");
            sb.AppendLine(Name.Text);
            sb.Append("Sex: ");
            sb.Append((bool)Male.IsChecked ? "Male" : "Female");
            MessageBox.Show(sb.ToString());
            StreamWriter writer = new StreamWriter("C:\\Users\\DOIT_DOTNET_USER8\\Desktop\\Name.txt", true);
            writer.Write(sb);
            writer.WriteLine();
            writer.Dispose();
        }
    }
}
