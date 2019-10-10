using System;
using System.Windows.Forms;

namespace WindowsForm
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var f = new Form();
            f.Text = "Hello world";
            f.Text=button1.Text;
            Application.Run(f);
        }
    }
}
