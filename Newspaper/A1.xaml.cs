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

namespace Newspaper
{
    /// <summary>
    /// Логика взаимодействия для A1.xaml
    /// </summary>
    public partial class A1 : Page
    {
        public A1()
        {
            InitializeComponent();
        }
        public partial class print : Page
        {
            public Frame framel;
            public List<A1> user = new List<A1>();
            public print(Frame framel, List<A1> user)
            {
                this.framel = framel;
                this.user = user;
            }
        }
        private void Red1_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
