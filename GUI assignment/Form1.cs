// George Couch
// 3/25/2023
// This program is based off of settings menus in video games. This assignment is for working with exception handling

// Estimated time: 45 minutes
// Actual time: 20 minutes

// Time Estimate Description
// After familiarizing myself on the last assignment with the .net elements, I have a better idea of how to make things connect to eachother.
// I've also used exception handling a lot in the past, so I knew that I wouldn't have to study up on it too much. For these reasons, I gave myself
// 45 minutes, but everything went smoothly so it only took around 20 minutes.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get default settings on startup
            button6_Click(sender, e);
        }

        #region Empty methods for GUI items
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Graphics preset buttons
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            checkBox1.Checked = true;
            checkBox2.Checked = false;
            radioButton1.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 1;
            comboBox4.SelectedIndex = 2;
            comboBox5.SelectedIndex = 1;
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            radioButton1.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 2;
            comboBox4.SelectedIndex = 4;
            comboBox5.SelectedIndex = 2;
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            radioButton2.Checked = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 2;
            comboBox4.SelectedIndex = 5;
            comboBox5.SelectedIndex = 2;
            checkBox1.Checked = false;
            checkBox2.Checked = true;
            radioButton3.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            comboBox3.SelectedIndex = 1;
            comboBox4.SelectedIndex = 3;
            comboBox5.SelectedIndex = 1;
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            radioButton1.Checked = true;
        }
        #endregion

        #region Close Buttons and Github
        // OK and Cancel buttons just close the program
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        // LinkLabel links to my Github page
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GeorgeCouch");
        }
        #endregion

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int result;
            if (int.TryParse(textBox1.Text, out result)){
                if (result <= 10 && result >= 0)
                {
                    trackBar1.Value = result;
                }
                else
                {
                    MessageBox.Show("Please enter a number between 0 and 10");
                }
            }
            else
            {
                MessageBox.Show("Please enter an integer");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int result;
            try
            {
                result = int.Parse(textBox2.Text);
                if (result <= 10 && result >= 0)
                {
                    trackBar2.Value = result;
                }
                else
                {
                    MessageBox.Show("Please enter a number between 0 and 10");
                }
            }
            catch
            {
                MessageBox.Show("Please enter an integer");
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }
    }
}
