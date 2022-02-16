using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class FormExperiment : Form
    {
        public Scene st = null;
        public FormExperiment()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormExperiment_Load(object sender, EventArgs e)
        {
            st.Clear();
            st.Draw();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
