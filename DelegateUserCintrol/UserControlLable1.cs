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
    public partial class UserControlLable1 : UserControl
    {
        public UserControlLable1()
        {
            InitializeComponent();
        }
        public void getData(string value)
        {
            userControl_label1.Text = value;
        }
    }
}
