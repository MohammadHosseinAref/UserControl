using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateUserCintrol
{
    public partial class UserControlSendData2 : UserControl
    {
        public UserControlSendData2()
        {
            InitializeComponent();
        }
        public delegate void SendUCDatatoForm(string val);
        public SendUCDatatoForm sendUCDatatoForm;
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.sendUCDatatoForm += new SendUCDatatoForm(f.getDataFromUserControl);
            sendUCDatatoForm(textBox1.Text);
            sendUCDatatoForm = null;
        }
    }
}
