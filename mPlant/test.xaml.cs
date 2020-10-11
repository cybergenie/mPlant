using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace mPlant
{
    /// <summary>
    /// test.xaml 的交互逻辑
    /// </summary>
    public partial class test : Window
    {
        public test()
        {
            InitializeComponent();

            Thread test = new Thread(new ThreadStart(TestThread));
            test.Start();

        }

        public delegate void UpdateTextCallback(string message);

        private void TestThread()
        {
            int Temp = 0;
            for (int i = 0; i <= 1000; i++)
            {
                Thread.Sleep(10);
                lb.Dispatcher.Invoke(
                    new UpdateTextCallback(this.UpdateText),
                    new object[] { Temp.ToString() }
                );
                Random rd = new Random();
                Temp += rd.Next(1,5);
            }
        }
        private void UpdateText(string message)
        {
            lb.Content =message + "\n";
        }




    }

}
