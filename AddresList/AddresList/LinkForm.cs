using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddresList
{
    public partial class LinkForm : Form
    {
        public LinkForm()
        {
            InitializeComponent();
        }

        private void linkmanAdd_Click(object sender, EventArgs e)
        {
            LinkmanAddForm linkmanAddForm = new LinkmanAddForm();
            linkmanAddForm.Show();
        }
    }
}
