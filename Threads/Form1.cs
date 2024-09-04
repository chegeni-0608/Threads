using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartCounterA_Click(object sender, EventArgs e)
        {
            //for(int i = 0; i < 2000; i++)
            //{
            //    Thread.Sleep(2);
            //    lblCounterA.Text = i.ToString();
            //}
            var thread = new Thread(() => { StartCounter(lblCounterA, 5000); });
            thread.Start();
        }

        //private void StartCounterA()
        //{
        //    for (int i = 0; i < 4000; i++)
        //    {
        //        Thread.Sleep(20);
        //        Invoke(new MethodInvoker(delegate ()
        //        {
        //            lblCounterA.Text = i.ToString();
        //        }));
        //    }
        //}
        private void StartCounter(Label control, int totalCount, int sleepTime=20)
            {
                for (int i = 0; i < totalCount; i++)
                {
                    Thread.Sleep(sleepTime);
                    Invoke(new MethodInvoker(delegate ()
                    {
                        control.Text = i.ToString();
                    }));
                }
            }

            private void btnStartCounterB_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < 2000; i++)
            //{
            //    Thread.Sleep(2);
            //    lblCounterB.Text = i.ToString();
            //}
            //var thread = new Thread(() => { StartCounterB(); });
            //thread.Start();
            var thread = new Thread(() => { StartCounter(lblCounterB, 7000, 5); });
            thread.Start();
        }
        //private void StartCounterB()
        //{
        //    for (int i = 0; i < 4000; i++)
        //    {
        //        Thread.Sleep(20);
        //        Invoke(new MethodInvoker(delegate ()
        //        {
        //            lblCounterA.Text = i.ToString();
        //        }));
        //    }
        //}
    }
}
