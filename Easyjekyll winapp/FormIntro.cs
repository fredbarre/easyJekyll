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
    public partial class FormIntro : Form
    {

        Form1 parent;
        public FormIntro()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public FormIntro(Form1 parent1)
        {
            InitializeComponent();
            parent = parent1;
        }

        private void button1NewPost_Click(object sender, EventArgs e)
        {
            parent.openChildForm(new FormTitle(parent));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
