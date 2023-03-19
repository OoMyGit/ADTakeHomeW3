using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADTakeHomeW3
{
    public partial class SecondWindowForm : Form
    {
        public SecondWindowForm()
        {
            InitializeComponent();
        }
        public string LabelHi
        {
            get { return labelhi.Text; }
            set { labelhi.Text = value; }
        }
        private void buttonmagic_Click(object sender, EventArgs e)
        {
            int salah = 0;
            if (checkagreesecond.Checked==true && checktruesecond.Checked==true)
            {
                MainWindowForm form = Application.OpenForms["MainWindowForm"] as MainWindowForm;
                if ((radiopinkbg.Checked == false && radioyellowbg.Checked == false && radiogreenbg.Checked == false && radiobluebg.Checked == false && radiolightgraybg.Checked == false) || (radioredtext.Checked == false && radiopurpletext.Checked == false && radioorangetext.Checked == false))
                {
                    salah++;
                }
                else if (radiopinkbg.Checked==true)
                {
                    form.BackColor = Color.Pink;
                }
                else if (radioyellowbg.Checked == true)
                {
                    form.BackColor = Color.Yellow;
                }
                else if (radiogreenbg.Checked == true)
                {
                    form.BackColor = Color.Green;
                }
                else if (radiobluebg.Checked == true)
                {
                    form.BackColor = Color.Blue;
                }
                else if (radiolightgraybg.Checked == true)
                {
                    form.BackColor = Color.LightGray;
                }

                if ((radiopinkbg.Checked == false && radioyellowbg.Checked == false && radiogreenbg.Checked == false && radiobluebg.Checked == false && radiolightgraybg.Checked == false) || (radioredtext.Checked == false && radiopurpletext.Checked == false && radioorangetext.Checked == false))
                {
                    salah++;
                }
                else if (radioredtext.Checked == true)
                {
                    form.ForeColor = Color.Red;
                    form.TextBoxName = Color.Red;
                    form.TextBoxArtist= Color.Red;
                }
                else if (radiopurpletext.Checked == true)
                {
                    form.ForeColor = Color.Purple;
                    form.TextBoxName = Color.Purple;
                    form.TextBoxArtist = Color.Purple;
                }
                else if (radioorangetext.Checked == true)
                {
                    form.ForeColor = Color.Orange;
                    form.TextBoxName = Color.Orange;
                    form.TextBoxArtist = Color.Orange;
                }
                if (salah == 0 && form != null) 
                {
                    form.Refresh();
                }
                else
                {
                    MessageBox.Show("Choose Color", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void SecondWindowForm_Load(object sender, EventArgs e)
        {
            buttonmagic.Enabled = false;
        }
        private void checkagreesecond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkagreesecond.Checked == true && checktruesecond.Checked == true)
            {
                buttonmagic.Enabled = true;
            }
            else
            {
                buttonmagic.Enabled = false;
            }
        }
        private void checktruesecond_CheckedChanged(object sender, EventArgs e)
        {
            if (checkagreesecond.Checked == true && checktruesecond.Checked == true)
            {
                buttonmagic.Enabled = true;
            }
            else
            {
                buttonmagic.Enabled = false;
            }
        }
    }
}
