using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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
            var thread = new Thread(() => { StartCounter(lblCounterA, 5000, 2); });
            thread.Start();
        }

        //private void StartCounterA()
        //{
        //    for (int i = 0; i < 4000; i++),,
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
            var thread = new Thread(() => { StartCounter(lblCounterB, 7000, 1); });
            thread.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var thread = new Thread(() => { UpdateTime(); });
            thread.Start();
        }

        private void UpdateTime()
        {
            var timer = new System.Timers.Timer();
            timer.Interval = 1000; // 1s = 1000ms
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                lblTime.Text = DateTime.Now.ToLongTimeString();
            }));
        }

        private void ChangeBGColor_Click(object sender, EventArgs e)
        {
         this.BackColor = Color.FromName(textColorName.Text);
        }

        private void btnSampleCuncurrencyBottleneck_Click(object sender, EventArgs e)
        {
            var form = new frmCuncurrency();
            form.ShowDialog();

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
