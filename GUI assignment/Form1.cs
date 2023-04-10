// George Couch
// 4/9/2023
// This program is based off of settings menus in video games. This assignment is for using arrays, lists and string functions

// Estimated time: 1 hour
// Actual time: 1 hour  15 minutes

// Time Estimate Description:
// I didn't give myself quite enough time for this assignment. I ended up having a lot of trouble formatting my strings just right so that they all
// looked the same after they were added. With that being said, I think I learned the most from this assignment out of all of the assignments so far.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace GUI_assignment
{
    public partial class Form1 : Form
    {
        int[] rndNums;
        List<String> strList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get default settings on startup
            defaultGraphics_Click(sender, e);
            populateIntArray();
            ArrayElemSelector.Maximum = rndNums.Length - 1;
        }

        #region Empty methods for GUI items
        private void graphicsAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resolutions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aspectRatio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void antialiasing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anisotropicFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void windowed_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void verticalSync_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void noneScreenEffect_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void bloomScreenEffects_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hdrScreenEffects_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Graphics preset buttons
        private void lowGraphics_Click(object sender, EventArgs e)
        {
            graphicsAdapter.SelectedIndex = 0;
            AspectRatio.SelectedIndex = 0;
            Antialiasing.SelectedIndex = 0;
            AnisotropicFiltering.SelectedIndex = 0;
            Resolutions.SelectedIndex = 0;
            Windowed.Checked = true;
            VerticalSync.Checked = false;
            None.Checked = true;
        }

        private void mediumGraphics_Click(object sender, EventArgs e)
        {
            graphicsAdapter.SelectedIndex = 0;
            AspectRatio.SelectedIndex = 1;
            Antialiasing.SelectedIndex = 1;
            AnisotropicFiltering.SelectedIndex = 2;
            Resolutions.SelectedIndex = 1;
            Windowed.Checked = false;
            VerticalSync.Checked = true;
            None.Checked = true;
        }

        private void highGraphics_Click(object sender, EventArgs e)
        {
            graphicsAdapter.SelectedIndex = 1;
            AspectRatio.SelectedIndex = 1;
            Antialiasing.SelectedIndex = 2;
            AnisotropicFiltering.SelectedIndex = 4;
            Resolutions.SelectedIndex = 2;
            Windowed.Checked = false;
            VerticalSync.Checked = true;
            Bloom.Checked = true;
        }

        private void ultraGraphics_Click(object sender, EventArgs e)
        {
            graphicsAdapter.SelectedIndex = 1;
            AspectRatio.SelectedIndex = 1;
            Antialiasing.SelectedIndex = 2;
            AnisotropicFiltering.SelectedIndex = 5;
            Resolutions.SelectedIndex = 2;
            Windowed.Checked = false;
            VerticalSync.Checked = true;
            HDR.Checked = true;
        }

        private void defaultGraphics_Click(object sender, EventArgs e)
        {
            graphicsAdapter.SelectedIndex = 0;
            AspectRatio.SelectedIndex = 1;
            Antialiasing.SelectedIndex = 1;
            AnisotropicFiltering.SelectedIndex = 3;
            Resolutions.SelectedIndex = 1;
            Windowed.Checked = true;
            VerticalSync.Checked = true;
            None.Checked = true;
        }
        #endregion

        #region Close Buttons and Github
        // OK and Cancel buttons just close the program
        private void finish_Click(object sender, EventArgs e)
        {
            StreamWriter fileOut;
            try
            {
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GameSettings.txt");
                fileOut = new StreamWriter(filePath);
            }
            catch (Exception exception)
            {
                fileOut = new StreamWriter("../GameSettings.txt");
                MessageBox.Show(exception.Message);
            }
            writeRandomNumber(fileOut);
            fileOut.WriteLine();
            writeGraphicsOptions(fileOut);
            fileOut.WriteLine();
            writeModeOptions(fileOut);
            fileOut.WriteLine();
            writeScreenEffectOptions(fileOut);
            fileOut.Flush();
            fileOut.Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // LinkLabel links to my Github page
        private void github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GeorgeCouch");
        }
        #endregion

        #region Helper Functions

        private void writeRandomNumber(StreamWriter fileOut)
        {
            fileOut.WriteLine("Random number generator");
            fileOut.WriteLine("__________________");
            int num = generateNumBetweenRange(1, 100);
            fileOut.WriteLine(num.ToString());
        }

        private int generateNumBetweenRange(int min, int max)
        {
            Random random = new Random();
            int num = random.Next(min, max);
            return num;
        }

        private void writeGraphicsOptions(StreamWriter fileOut)
        {
            fileOut.WriteLine("Graphics Options");
            fileOut.WriteLine("__________________");
            fileOut.WriteLine(graphicsAdapter.Text);
            fileOut.WriteLine(Resolutions.Text);
            fileOut.WriteLine(AspectRatio.Text);
            fileOut.WriteLine(Antialiasing.Text);
            fileOut.WriteLine(AnisotropicFiltering.Text);
        }

        private void writeModeOptions(StreamWriter fileOut)
        {
            fileOut.WriteLine("Mode");
            fileOut.WriteLine("__________________");
            fileOut.WriteLine(Windowed.Text + "Checked = " + Windowed.Checked);
            fileOut.WriteLine(VerticalSync.Text + "Checked = " + VerticalSync.Checked);
        }

        private void writeScreenEffectOptions(StreamWriter fileOut)
        {
            fileOut.WriteLine("Screen Effects");
            fileOut.WriteLine("__________________");
            fileOut.WriteLine(None.Text + "Checked = " + None.Checked);
            fileOut.WriteLine(Bloom.Text + "Checked = " + Bloom.Checked);
            fileOut.WriteLine(HDR.Text + "Checked = " + HDR.Checked);
        }
        #endregion

        private void ArrayElemDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArrayElemSelector_ValueChanged(object sender, EventArgs e)
        {
            ArrayElemDisplay.Text = rndNums[(int)ArrayElemSelector.Value].ToString();
        }

        private void ListElemAdd_Click(object sender, EventArgs e)
        {
            string elemText = ListElemToAdd.Text;
            elemText = elemText.Trim();
            elemText = elemText.ToUpper();
            if (elemText.Contains('.'))
            {
                string[] splitString = elemText.Split('.');
                elemText = splitString[1];
                elemText = elemText.Trim();
            }
            strList.Add(elemText);
            comboBox1.Items.Clear();
            for (int i = 0; i < strList.Count; i++)
            {
                comboBox1.Items.Add(strList[i]);
            }
        }

        private void populateIntArray()
        {
            Random rnd = new Random();
            int numOfElements = rnd.Next(100);
            rndNums = new int[numOfElements];
            for (int i = 0; i < rndNums.Length; i++)
            {
                rndNums[i] = rnd.Next(1000);
            }
        }

        private void ListElemToAdd_TextChanged(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
