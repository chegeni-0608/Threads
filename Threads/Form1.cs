using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Transactions;
using System.Windows.Forms;
using Threads.Models;

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

        private async void btnAsyncAwait_Click(object sender, EventArgs e)
        {
            var category = new Category

            {
                CategoryName = "ert",
                Description = "test123"
            };

            AddCategoryAsync(category);
            MessageBox.Show("Add Category suc....");

            var categories = GetCategoriesAsync();
            MessageBox.Show(categories.Result.Count.ToString());

            var categories2 = await GetCategoriesAsync();
            MessageBox.Show(categories2.Count.ToString());
        }

        public async void AddCategoryAsync(Category model)
        {
            using (var db = new CsharpSampleDBEntities())
            {
             db.Categories.Add(model);
                //db.SaveChanges();
                await db.SaveChangesAsync();
            }
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            using (var db = new CsharpSampleDBEntities())
            {
                var result = db.Categories.OrderBy(c => c.CategoryName);
                return await result.ToListAsync();

            }
        }

        private void btnWithoutTransaction_Click(object sender, EventArgs e)
        {
            var category1 = new Category { CategoryName = "transaction", Description = "abc1" };
            var category2 = new Category { CategoryName = "fdfgdgfdgfdgfdgfdgfdgfdgfdgfdddfgfdgfdgfdgfdrdytydgfdtdctrdt, Descripti", Description = "abc2" };

            var db1 = new CsharpSampleDBEntities();
            db1.Categories.Add(category1);
            db1.SaveChanges();

            var db2 = new CsharpSampleDBEntities();
            db2.Categories.Add(category2);
            db2.SaveChanges();
        }


        private void btnWithTransaction_Click(object sender, EventArgs e)
        {
            using (TransactionScope transaction = new TransactionScope())
            {
                var category1 = new Category { CategoryName = "transactionScopeSample", Description = "abc1" };
                // تعداد کاراکترها زیاد است گس transaction نمیگذارد هیچ دستوری اجرا شود
                // var category2 = new Category { CategoryName = "fdfgdgfdgfdgfdgfdgfdgfdgfdgfdddfgfdgfdgfdgfdrdytydgfdtdctrdt, Descripti", Description = "abc2" };

                //تعداد کاراکترها ورودی با جدول درست است گس transaction  دستور اجرا شود
                var category2 = new Category { CategoryName = " Description nnnn", Description = "abc2" };

                var db1 = new CsharpSampleDBEntities();
                db1.Categories.Add(category1);
                db1.SaveChanges();

                var db2 = new CsharpSampleDBEntities();
                db2.Categories.Add(category2);
                db2.SaveChanges();

                Transaction.ReferenceEquals(db1, db2);
            }
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
