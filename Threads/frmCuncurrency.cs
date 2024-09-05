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
    public partial class frmCuncurrency : Form
    {
        int _balance = 500;
         
        
        public frmCuncurrency()
        {
            InitializeComponent();
        }

        private void btnThreadA_Click(object sender, EventArgs e)
        {
          var thread = new Thread(() => { UpdateBalanceWithSemaphor(100, 6000); });
            thread.Start();
        }

        private void btnThreadB_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => { UpdateBalanceWithSemaphor(-50, 9000); });
            thread.Start();
        }

        private void btnThreadC_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => { UpdateBalanceWithSemaphor(-200, 4000); });
            thread.Start();
        }

        object objLock = new object();
        private void UpdateBalance(int value, int sleep)
        {
            lock (objLock)
            {
                var temp = _balance;
                Thread.Sleep(sleep);
                temp += value;
                _balance = temp;

                Invoke(new MethodInvoker(delegate ()
                {
                    lblBalance.Text = _balance.ToString();
                }));
            }

        }

        Semaphore _balanceSemaphore = new Semaphore(1, 1);

        private void UpdateBalanceWithSemaphor(int value, int sleep)
        {
            //گرقتن کلید توسط نفر اول صف 

            try
            {

                _balanceSemaphore.WaitOne();

                var temp = _balance;
                Thread.Sleep(sleep);
                temp += value;
                _balance = temp;

                Invoke(new MethodInvoker(delegate ()
                {
                    lblBalance.Text = _balance.ToString();
                }));

            }

            catch (Exception ex)
            {
                // add log info to log file
                // show message or behavior to use
            }

            finally
            {

                // آراد کردن کلید

                _balanceSemaphore.Release();

            }
            //

        }


    }
}
