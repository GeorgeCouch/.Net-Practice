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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get default settings on startup
            defaultGraphics_Click(sender, e);
            MasterVolumeSlider master = new MasterVolumeSlider(5, "5");
            master.createMasterSlider(flowLayoutPanel1);
            SubVolumeSlider music = new SubVolumeSlider(master.masterVolumeInt, master.masterVolumeStr, 5, "5", master.trackBar, master.textBox);
            music.createSubSlider(flowLayoutPanel1);
            SubVolumeSlider sfx = new SubVolumeSlider(master.masterVolumeInt, master.masterVolumeStr, 5, "5", master.trackBar, master.textBox);
            sfx.createSubSlider(flowLayoutPanel1);
            VoipSlider voip = new VoipSlider(master.masterVolumeInt, master.masterVolumeStr, 5, "5", false, master.trackBar, master.textBox);
            voip.createVoipSlider(flowLayoutPanel1);
        }

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
        private void ListElemToAdd_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ArrayElemDisplay_TextChanged(object sender, EventArgs e)
        {

        }
        private void ArrayElemSelector_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ListElemAdd_Click(object sender, EventArgs e)
        {

        }

        private void populateIntArray()
        {

        }
        #endregion
    }

    public class MasterVolumeSlider
    {
        public int masterVolumeInt;
        public string masterVolumeStr;

        public TrackBar trackBar;
        public TextBox textBox;

        public MasterVolumeSlider(int masterVolumeInt, string masterVolumeStr)
        {
            this.masterVolumeInt = masterVolumeInt;
            this.masterVolumeStr = masterVolumeStr;
        }

        public virtual void createMasterSlider(FlowLayoutPanel flowLayoutPanel)
        {
            trackBar = new TrackBar();
            trackBar.Size = new Size(104, 45);
            trackBar.Value = masterVolumeInt;
            trackBar.ValueChanged += changeNumOnSliderChange;
            flowLayoutPanel.Controls.Add(trackBar);

            textBox = new TextBox();
            textBox.Size = new Size(104, 45);
            textBox.Text = masterVolumeStr;
            textBox.TextChanged += changeSliderOnNumEntered;
            flowLayoutPanel.Controls.Add(textBox);
        }

        public virtual void changeNumOnSliderChange(object sender, EventArgs e)
        {
            textBox.Text = trackBar.Value.ToString();
        }

        public virtual void changeSliderOnNumEntered(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(textBox.Text, out num))
            {
                if (num >= 0 && num <= 10)
                {
                    trackBar.Value = num;
                }
                else if (num < 0)
                {
                    num = 0;
                    trackBar.Value = num;
                    textBox.Text = "0";
                }
                else
                {
                    num = 10;
                    trackBar.Value = num;
                    textBox.Text = "10";
                }
            }
            else
            {
                textBox.Text = "";
            }
        }
    }

    public class SubVolumeSlider : MasterVolumeSlider
    {
        public int subVolumeInt;
        public string subVolumeStr;

        public TrackBar subTrackBar;
        public TextBox subTextBox;

        public TrackBar masterTrackbar;
        public TextBox masterTextBox;

        public bool changeDueToExceed;

        public SubVolumeSlider(int masterVolumeInt, string masterVolumeStr, int subVolumeInt, string subVolumeStr, 
            TrackBar masterTrackbar, TextBox masterTextBox) : 
            base(masterVolumeInt, masterVolumeStr)
        {
            this.subVolumeInt = subVolumeInt;
            this.subVolumeStr = subVolumeStr;
            this.masterTrackbar = masterTrackbar;
            this.masterTextBox = masterTextBox;
        }

        public void createSubSlider(FlowLayoutPanel flowLayoutPanel)
        {
            subTrackBar = new TrackBar();
            subTrackBar.Size = new Size(104, 45);
            subTrackBar.Value = subVolumeInt;
            subTrackBar.ValueChanged += changeNumOnSliderChange;
            flowLayoutPanel.Controls.Add(subTrackBar);

            subTextBox = new TextBox();
            subTextBox.Size = new Size(104, 45);
            subTextBox.Text = subVolumeStr;
            subTextBox.TextChanged += changeSliderOnNumEntered;
            flowLayoutPanel.Controls.Add(subTextBox);

            masterTrackbar.ValueChanged += changeSliderOnMasterVolumeChange;
        }

        public override void changeNumOnSliderChange(object sender, EventArgs e)
        {
            subTextBox.Text = subTrackBar.Value.ToString();
            changeMasterSliderOnExceedMasterVolume();
        }

        public override void changeSliderOnNumEntered(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(subTextBox.Text, out num))
            {
                if (num >= 0 && num <= 10)
                {
                    subTrackBar.Value = num;
                }
                else if (num < 0)
                {
                    num = 0;
                    subTrackBar.Value = num;
                    subTextBox.Text = "0";
                }
                else
                {
                    num = 10;
                    subTrackBar.Value = num;
                    subTextBox.Text = "10";
                }
            }
            else
            {
                subTextBox.Text = "";
            }
            changeMasterSliderOnExceedMasterVolume();
        }

        public void changeMasterSliderOnExceedMasterVolume()
        {
            if (subTrackBar.Value > masterTrackbar.Value)
            {
                changeDueToExceed = true;
                masterTrackbar.Value = subTrackBar.Value;
                masterTextBox.Text = subTextBox.Text;
                masterVolumeInt = masterTrackbar.Value;
            }
        }

        public void changeSliderOnMasterVolumeChange(object sender, EventArgs e)
        {
            if (!changeDueToExceed)
            {
                // Get diff between current master value and master int stored
                int masterDiff = masterTrackbar.Value - masterVolumeInt;

                // Ensure that subBars adjust if equal to master
                if (subTrackBar.Value == masterVolumeInt)
                {
                    subTrackBar.Value = masterTrackbar.Value;
                }
                else
                {
                    // Ensure that subtrackbar doesn't fall out of bounds when following master volume
                    if (subTrackBar.Value + masterDiff < 0)
                    {
                        subTrackBar.Value = 0;
                    }
                    else if (subTrackBar.Value + masterDiff > 10)
                    {
                        subTrackBar.Value = 10;
                    }
                    else
                    {
                        subTrackBar.Value += masterDiff;
                    }
                }

                // Adjust master int to equal master trackbar for future calculations 
                masterVolumeInt = masterTrackbar.Value;
            }
            changeDueToExceed = false;
        }
    }

    public class VoipSlider : MasterVolumeSlider
    {
        public int voipVolumeInt;
        public string voipVolumeStr;
        public bool voipEnabled;

        public TrackBar voipTrackBar;
        public TextBox voipTextBox;
        public CheckBox voipCheckBox;

        public TrackBar masterTrackBar;
        public TextBox masterTextBox;

        public bool changeDueToExceed;

        public VoipSlider(int masterVolumeInt, string masterVolumeStr, int voipVolumeInt, string voipVolumeStr, bool voipEnabled, 
            TrackBar masterTrackBar, TextBox masterTextBox) : 
            base(masterVolumeInt, masterVolumeStr)
        {
            this.voipVolumeInt = voipVolumeInt;
            this.voipVolumeStr = voipVolumeStr;
            this.voipEnabled = voipEnabled;
            this.masterTrackBar = masterTrackBar;
            this.masterTextBox = masterTextBox;
        }

        public void createVoipSlider(FlowLayoutPanel flowLayoutPanel)
        {
            voipTrackBar = new TrackBar();
            voipTrackBar.Size = new Size(104, 45);
            voipTrackBar.Value = voipVolumeInt;
            voipTrackBar.ValueChanged += changeNumOnSliderChange;
            flowLayoutPanel.Controls.Add(voipTrackBar);

            voipTextBox = new TextBox();
            voipTextBox.Size = new Size(104, 45);
            voipTextBox.Text = voipVolumeStr;
            voipTextBox.TextChanged += changeSliderOnNumEntered;
            flowLayoutPanel.Controls.Add(voipTextBox);

            voipCheckBox = new CheckBox();
            voipCheckBox.Size = new Size(104, 45);
            voipCheckBox.Checked = voipEnabled;
            voipCheckBox.CheckedChanged += onVoipCheckChanged;
            flowLayoutPanel.Controls.Add(voipCheckBox);

            masterTrackBar.ValueChanged += changeSliderOnMasterVolumeChange;
        }

        public override void changeNumOnSliderChange(object sender, EventArgs e)
        {
            voipTextBox.Text = voipTrackBar.Value.ToString();
            changeMasterSliderOnExceedMasterVolume();
        }

        public override void changeSliderOnNumEntered(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(voipTextBox.Text, out num))
            {
                if (num >= 0 && num <= 10)
                {
                    voipTrackBar.Value = num;
                }
                else if (num < 0)
                {
                    num = 0;
                    voipTrackBar.Value = num;
                    voipTextBox.Text = "0";
                }
                else
                {
                    num = 10;
                    voipTrackBar.Value = num;
                    voipTextBox.Text = "10";
                }
            }
            else
            {
                voipTextBox.Text = "";
            }
            changeMasterSliderOnExceedMasterVolume();
        }

        public void changeSliderOnMasterVolumeChange(object sender, EventArgs e)
        {
            if (!changeDueToExceed)
            {
                // Get diff between current master value and master int stored
                int masterDiff = masterTrackBar.Value - masterVolumeInt;

                // Ensure that subBars adjust if equal to master
                if (voipTrackBar.Value == masterVolumeInt)
                {
                    voipTrackBar.Value = masterTrackBar.Value;
                }
                else
                {
                    // Ensure that subtrackbar doesn't fall out of bounds when following master volume
                    if (voipTrackBar.Value + masterDiff < 0)
                    {
                        voipTrackBar.Value = 0;
                    }
                    else if (voipTrackBar.Value + masterDiff > 10)
                    {
                        voipTrackBar.Value = 10;
                    }
                    else
                    {
                        voipTrackBar.Value += masterDiff;
                    }
                }

                // Adjust master int to equal master trackbar for future calculations 
                masterVolumeInt = masterTrackBar.Value;
            }
            changeDueToExceed = false;
        }

        public void changeMasterSliderOnExceedMasterVolume()
        {
            if (voipTrackBar.Value > masterTrackBar.Value)
            {
                changeDueToExceed = true;
                masterTrackBar.Value = voipTrackBar.Value;
                masterTextBox.Text = voipTextBox.Text;
                masterVolumeInt = masterTrackBar.Value;
            }
        }

        private void onVoipCheckChanged(object sender, EventArgs e)
        {

        }

        public void muteMasterWhileEnabled()
        {

        }

        public void resetVolumeWhileDisabled()
        {

        }
    }

    // TODOS IN ORDER OF IMPORTANCE
    // TODO: Write remaining methods for voip class
    // TODO: Merge functions between classes to avoid repeating code
    // TODO: Store all options in a string array/list to meet array/list requirement
    // TODO: Loop through array/list and write to file to meet loop and file writing requirements
    // TODO: Use 3 string functions to format strings in array/list to meet string function requirement
    // TODO: Add random volume levels to meet random number generation requirement
}
