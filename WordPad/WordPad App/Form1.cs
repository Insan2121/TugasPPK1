using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        FontStyle fs = FontStyle.Regular;

        public Form1()
        {
            InitializeComponent();
            comboBox_1033_1.Items.AddRange(FontFamily.Families.Select(s => s.Name).ToArray());
            comboBox_1033_1.SelectedIndex = 1;
            comboBox_1033_2.SelectedIndex = 13;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void label_1033_1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_1033_2_Click(object sender, EventArgs e)
        {

        }



        const int INDENT_SIZE = 70;
        private void button_1033_9_Click(object sender, EventArgs e)
        {
            richTextBox_1033_1.SelectionIndent -= INDENT_SIZE;
        }
        private void comboBox_1033_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                int index = comboBox_1033_2.SelectedIndex == -1 ? 0 : comboBox_1033_2.SelectedIndex;
                fontDialog_1033_1.Font = richTextBox_1033_1.SelectionFont = new Font((String)comboBox_1033_1.SelectedItem, (float)Convert.ToDouble(comboBox_1033_2.Items[index]), fs);
            }
        }

        private void button_1033_1_Click(object sender, EventArgs e)
        {
            richTextBox_1033_1.Paste();
        }

        private void button_1033_2_Click(object sender, EventArgs e)
        {
            richTextBox_1033_1.Cut();
        }

        private void button_1033_3_Click(object sender, EventArgs e)
        {
            richTextBox_1033_1.Copy();
        }

        private void button_1033_4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                richTextBox_1033_1.SelectionFont = new Font(fontDialog_1033_1.Font, fs = fs ^ FontStyle.Bold);
            }
        }

        private void button_1033_5_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                fontDialog_1033_1.Font = richTextBox_1033_1.SelectionFont = new Font(fontDialog_1033_1.Font, fs = fs ^ FontStyle.Italic);
            }
        }

        private void richTextBox_1033_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_1033_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                fontDialog_1033_1.Font = richTextBox_1033_1.SelectionFont = new Font((String)comboBox_1033_1.SelectedItem, (float)Convert.ToDouble(comboBox_1033_2.SelectedItem), fs);
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button_1033_7_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                fontDialog_1033_1.Font = richTextBox_1033_1.SelectionFont = new Font(fontDialog_1033_1.Font, fs = fs ^ FontStyle.Strikeout);
            }
        }

        private void button_1033_8_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                colorDialog_1033_1.ShowDialog();
                richTextBox_1033_1.SelectionColor = colorDialog_1033_1.Color;
            }
        }

        private void button_1033_10_Click(object sender, EventArgs e)
        {
            richTextBox_1033_1.SelectionIndent += INDENT_SIZE;
        }


        const int LIST_INDENT_SIZE = 40;
        private void button_1033_11_Click(object sender, EventArgs e)
        {
            Boolean isListed = richTextBox_1033_1.SelectionBullet;

            if (!isListed)
            {
                richTextBox_1033_1.SelectionIndent = LIST_INDENT_SIZE;
                richTextBox_1033_1.SelectionBullet = true;
                richTextBox_1033_1.BulletIndent = 25;
            }
            else
            {
                richTextBox_1033_1.SelectionIndent = 0;
                richTextBox_1033_1.SelectionBullet = false;
                richTextBox_1033_1.BulletIndent = 0;
            }
        }

        private void button_1033_12_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                richTextBox_1033_1.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

        private void button_1033_13_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                richTextBox_1033_1.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void button_1033_14_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                richTextBox_1033_1.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void button_1033_15_Click(object sender, EventArgs e)
        {

        }

        private void button_1033_16_Click(object sender, EventArgs e)
        {
            openFileDialog_1033_1.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            openFileDialog_1033_1.Multiselect = false;
            openFileDialog_1033_1.FileName = "";
            DialogResult result = openFileDialog_1033_1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog_1033_1.FileName);
                Clipboard.SetImage(img);
                richTextBox_1033_1.Paste();
                richTextBox_1033_1.Focus();
            }
            else
            {
                richTextBox_1033_1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_1033_6_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox_1033_1.Text))
            {
                fontDialog_1033_1.Font = richTextBox_1033_1.SelectionFont = new Font(fontDialog_1033_1.Font, fs = fs ^ FontStyle.Underline);
            }
        }
    }
}

       