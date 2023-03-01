using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProtoReg;

namespace ProtoReg_TEST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
           
            if(richTextBox2.Text.Contains(" "))
            {
                var res = MessageBox.Show("Cannot have spaces in protocol names. Would you like me to replace it with dashes?", "Oops!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    richTextBox2.Text = richTextBox2.Text.Replace(" ", "-");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.AddExtension = true;
            diag.RestoreDirectory = true;
            diag.InitialDirectory = Application.StartupPath;
            diag.Filter = "Executables (*.exe)|*.exe|All files (*.*)|*.*";
            if(diag.ShowDialog() == DialogResult.OK)
            {
               richTextBox1.Text = diag.FileName;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar.Register(richTextBox2.Text, richTextBox1.Text, checkBox1.Checked);
        }
    }
}
