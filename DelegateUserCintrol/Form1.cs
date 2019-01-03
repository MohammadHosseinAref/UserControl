using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateUserCintrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void SendDataToForm2(string value);
        public SendDataToForm2 SendData;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            this.SendData += new SendDataToForm2(f.getData);
            SendData(textBox1.Text);
            f.Show();
        }
        public void getDataFromUserControl(string val)
        {
            label2.Text = val;
        }
    }
}
