using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easyjekyll_winapp
{
    public partial class FormTitle : Form
    {
        Form1 parent;
        public FormTitle()
        {
            InitializeComponent();
        }

        public FormTitle(Form1 parent1)
        {
            InitializeComponent();
            parent = parent1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void button1Next_Click_1(object sender, EventArgs e)
        {
            parent.openChildForm(new FormAddImage());
        }

        private void placeHolderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
