using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek5
{
    public partial class FormMateri : Form
    {
        string[] DataMateri = new string[999999];
         public FormMateri()
        {
            InitializeComponent();
        }
        private void FormMateri_Load(object sender, EventArgs e)
        {
            LabelOutput.Text = "";

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (ListBoxMateri.Items.Contains(TextBoxInput.Text))
            {
                MessageBox.Show("KEMBAR");
            }
            else
            {
                ListBoxMateri.Items.Add(TextBoxInput.Text);
            }
            ListBoxMateri.Text = "";

        }

        private void LabelOutput_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ListBoxMateri.Items.Clear();
            LabelOutput.Text = "";
        }

        private void CheckBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void RadioButtonMerah_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAktif.Checked == true)
            {
                LabelOutput.ForeColor = Color.Red;
            }
            else
            {
                LabelOutput.ForeColor = Color.Black;
            }
        }

        private void RadioButtonBiru_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAktif.Checked == true)
            {
                LabelOutput.ForeColor = Color.Blue;
            }
            else
            {
                LabelOutput.ForeColor = Color.Black;
            }
        }

        private void ListBoxMateri_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelOutput.Text = ListBoxMateri.Text;

        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
