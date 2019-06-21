using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MutexTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
            bool a;

        public App()
        {
            Mutex mutex = new Mutex(false, "MutexTask", out a);
            if (a)
            {
                mutex.WaitOne();
            }
            else
            {
                MessageBox.Show("Exit Window");
                mutex.ReleaseMutex();

            }
        }


        }
}
