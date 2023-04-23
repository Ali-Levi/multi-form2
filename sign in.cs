using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Multi_forms
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (un.Text.Contains("admin") && pw.Text.Contains("1234"))
                f1.Show();
                this.Hide();
        }
    }
}
