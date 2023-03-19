using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADTakeHomeW3
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }
        public Color TextBoxName
        {
            get { return textboxname.ForeColor; }
            set { textboxname.ForeColor = value; }
        }
        public Color TextBoxArtist
        {
            get { return textboxartist.ForeColor; }
            set { textboxartist.ForeColor = value; }
        }
        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            SecondWindowForm form2 = Application.OpenForms["SecondWindowForm"] as SecondWindowForm;
            if (Application.OpenForms["SecondWindowForm"] != null && checktruefirst.Checked==true)
            {
                if (textboxname.Text == "" || textboxartist.Text == "")
                {
                    MessageBox.Show("Enter Correct Input", "WARNING", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    string kata = $"Hi, my name is " + textboxname.Text + " and my favorite artist is " + textboxartist.Text;
                    form2.LabelHi = kata;
                    form2.Refresh();
                }
            }
        }
        private void buttonopen_Click(object sender, EventArgs e)
        {
            SecondWindowForm form2 = new SecondWindowForm();
            form2.Show();
            if (Application.OpenForms["SecondWindowForm"] != null && checktruefirst.Checked == true)
            {
                buttonsubmit.Enabled = true;
            }
            else
            {
                buttonsubmit.Enabled = false;
            }
        }
        private void checktruefirst_CheckedChanged(object sender, EventArgs e)
        {
            if (Application.OpenForms["SecondWindowForm"] != null && checktruefirst.Checked == true)
            {
                buttonsubmit.Enabled= true;
            }
            else
            {
                buttonsubmit.Enabled= false;
            }
        }
        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            buttonsubmit.Enabled = false;
        }
    }
}
