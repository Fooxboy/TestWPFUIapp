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
using System.Windows.Shapes;

namespace TestWPFUIapp
{
    /// <summary>
    /// Логика взаимодействия для StyledWindow.xaml
    /// </summary>
    public partial class StyledWindow : Window
    {
        public StyledWindow()
        {
            InitializeComponent();
            this.Loaded += StyledWindow_Loaded;
        }

        private void StyledWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
