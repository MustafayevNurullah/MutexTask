using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace MutexTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool a;
        public MainWindow()
        {
            InitializeComponent();
            Mutex mutex = new Mutex(false, "MutexTask",out a );
                mutex.WaitOne();
           if(!a)
            {
                MessageBox.Show("Test");
                mutex.ReleaseMutex();
            }



        }
    }
}
