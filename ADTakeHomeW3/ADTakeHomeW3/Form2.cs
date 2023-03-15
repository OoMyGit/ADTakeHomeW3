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
            if (checkagreesecond.Checked==true && checktruesecond.Checked==true)
            {
                MainWindowForm form = Application.OpenForms["MainWindowForm"] as MainWindowForm;
                if (radiopinkbg.Checked==true)
                {
                    form.BackColor = Color.Pink;
                }
                if (radioyellowbg.Checked == true)
                {
                    form.BackColor = Color.Yellow;
                }
                if (radiogreenbg.Checked == true)
                {
                    form.BackColor = Color.Green;
                }
                if (radiobluebg.Checked == true)
                {
                    form.BackColor = Color.Blue;
                }
                if (radiolightgraybg.Checked == true)
                {
                    form.BackColor = Color.LightGray;
                }
                if (radioredtext.Checked == true)
                {
                    form.ForeColor = Color.Red;
                    form.TextBoxName = Color.Red;
                    form.TextBoxArtist= Color.Red;
                }
                if (radiopurpletext.Checked == true)
                {
                    form.ForeColor = Color.Purple;
                    form.TextBoxName = Color.Purple;
                    form.TextBoxArtist = Color.Purple;
                }
                if (radioorangetext.Checked == true)
                {
                    form.ForeColor = Color.Orange;
                    form.TextBoxName = Color.Orange;
                    form.TextBoxArtist = Color.Orange;
                }
                //if (MainWindowForm.ActiveForm==null)
                if (form != null) 
                {
                    form.Refresh();
                }
            }
        }
    }
}
