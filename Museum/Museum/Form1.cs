using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museum
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AuthorBtn_Click(object sender, EventArgs e)
        {
            fAuthor authorForm = new fAuthor();
            authorForm.ShowDialog();
        }

        private void UslovBtn_Click(object sender, EventArgs e)
        {
            fUslov uslovForm = new fUslov();
            uslovForm.ShowDialog(); 
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            fStart startForm = new fStart();
            startForm.ShowDialog();
        }
    }
}
