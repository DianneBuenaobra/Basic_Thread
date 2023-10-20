using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Thread
{
    public partial class frmBasicThread : Form
    {
        Thread ThreadA,ThreadB;

        public frmBasicThread()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "- Start of Thread -";
            ThreadStart Thstart = new ThreadStart(MyThreadClass.Thread1);
            ThreadA = new Thread(Thstart); ThreadB = new Thread(Thstart);

            ThreadA.Name = "Thread A Process ";
            ThreadB.Name = "Thread B Process ";

            Console.WriteLine(label1.Text);
            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();
            label1.Text = "- End of Thread -";
            Console.WriteLine(label1.Text);
        }
    }
}
