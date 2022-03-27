using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneCE
{
    public partial class NameCP : Form
    {
        public NameCP()
        {
            InitializeComponent();
        }
        public string Passvalue { get; set; }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (rb_Enel.Checked == true)
            {
                if (txb_SerialNamberCP.Text != String.Empty)
                {
                    Regex regex = new Regex(@"CASARS\d{12}");
                    Match match = regex.Match(txb_SerialNamberCP.Text);
                    if (match.Success)
                    {
                        Passvalue = match.Value;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Serial Number Errato", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Inserire Serial Number", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_Sielte.Checked == true)
            {
                Regex regex = new Regex(@"SIELTE");
                Match match = regex.Match(txb_SerialNamberCP.Text);
                if (match.Success)
                {
                    Passvalue = match.Value;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Serial Number Errato", "Gestione CP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rb_Sielte_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = !(rb_Sielte.Checked);

            if (rb_Sielte.Checked == true)
            {
                txb_SerialNamberCP.Text = "SIELTE";
            }
            else
            {
                txb_SerialNamberCP.Clear();

            }
        }
    }
}
