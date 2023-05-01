// George Couch
// 4/30/2023
// This program is based off of settings menus in video games. This is my final submission

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace GUI_assignment
{
    // Driver Class
    public partial class Form1 : Form
    {
        string[] fileArr = new string[10];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get default settings on startup
            defaultGraphics_Click(sender, e);
            
            // Create volume sliders from classes and place them in the flowLayoutPanel 
            MasterVolumeSlider master = new MasterVolumeSlider();
            master.createSlider(flowLayoutPanel1);
            SubVolumeSlider music = new SubVolumeSlider(master.trackBar, master.textBox);
            music.createSlider(flowLayoutPanel1);
            SubVolumeSlider sfx = new SubVolumeSlider(master.trackBar, master.textBox);
            sfx.createSlider(flowLayoutPanel1);

            // Add SubVolumeSliders to list (music and sfx)
            List<SubVolumeSlider> subVolumeSliders = new List<SubVolumeSlider>();
            subVolumeSliders.Add(music);
            subVolumeSliders.Add(sfx);

            // Create voip volume slider using subVolumeSliders as a constructor parameter and add to flowLayoutPanel
            VoipSlider voip = new VoipSlider(master.trackBar, master.textBox, subVolumeSliders);
            voip.createSlider(flowLayoutPanel1);

            // Set default master value to a random number between 0 and 10
            master.trackBar.Value = generateNumBetweenRange(0, 10);
        }

        // Helper method for generating random number
        private int generateNumBetweenRange(int min, int max)
        {
            Random random = new Random();
            int num = random.Next(min, max);
            return num;
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

            // Fill Arr
            fileArr[0] = graphicsAdapter.Text;
            fileArr[1] = Resolutions.Text;
            fileArr[2] = AspectRatio.Text;
            fileArr[3] = Antialiasing.Text;
            fileArr[4] = AnisotropicFiltering.Text;
            fileArr[5] = Windowed.Text + "Checked = " + Windowed.Checked;
            fileArr[6] = VerticalSync.Text + "Checked = " + VerticalSync.Checked;
            fileArr[7] = None.Text + "Checked = " + None.Checked;
            fileArr[8] = Bloom.Text + "Checked = " + Bloom.Checked;
            fileArr[9] = HDR.Text + "Checked = " + HDR.Checked;

            // Write to file
            fileOut.WriteLine("Graphics Options");
            fileOut.WriteLine("__________________");
            for (int i = 0; i < 5; i++)
            {
                fileOut.WriteLine(fileArr[i]);
            }

            fileOut.WriteLine();

            fileOut.WriteLine("Mode");
            fileOut.WriteLine("__________________");
            for (int i = 5; i < 7; i++)
            {
                fileOut.WriteLine(fileArr[i]);
            }

            fileOut.WriteLine();

            fileOut.WriteLine("Screen Effects");
            fileOut.WriteLine("__________________");
            for (int i = 7; i < fileArr.Length; i++)
            {
                fileOut.WriteLine(fileArr[i]);
            }

            fileOut.Flush();
            fileOut.Close();

            Close();
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion
    }

    #region Classes for sliders
    // Base Volume Slider Class
    public class MasterVolumeSlider
    {
        // properties to access trackbar and textBox
        public TrackBar trackBar;
        public TextBox textBox;

        // Constructor
        public MasterVolumeSlider(){}

        // Method for creating slider and textbox on form and giving them onChange functions
        public virtual void createSlider(FlowLayoutPanel flowLayoutPanel)
        {
            trackBar = new TrackBar();
            trackBar.Size = new Size(104, 45);
            trackBar.ValueChanged += trackBarChange;
            flowLayoutPanel.Controls.Add(trackBar);

            textBox = new TextBox();
            textBox.Size = new Size(104, 45);
            textBox.TextChanged += textBoxChange;
            flowLayoutPanel.Controls.Add(textBox);
        }

        // Methods for text box and track bar change
        public virtual void textBoxChange(object sender, EventArgs e)
        {
            changeSliderOnNumEntered(textBox, trackBar);
        }

        public virtual void trackBarChange(object sender, EventArgs e)
        {
            changeNumOnSliderChange(textBox, trackBar);
        }

        // Make text box match trackbar value
        public void changeNumOnSliderChange(TextBox textBox, TrackBar trackBar)
        {
            textBox.Text = trackBar.Value.ToString();
        }

        // Make trackbar value match textbox (Also handle non-ints and out of bounds values entered)
        public void changeSliderOnNumEntered(TextBox textBox, TrackBar trackBar)
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

    // Inheritted class from MasterVolumeSlider
    public class SubVolumeSlider : MasterVolumeSlider
    {
        // Properties
        public int masterVolumeInt;

        public TrackBar subTrackBar;
        public TextBox subTextBox;

        public TrackBar masterTrackbar;
        public TextBox masterTextBox;

        // Bool flag
        public bool changeDueToExceed;

        // Constructor that uses references to the master volume slider and text box
        public SubVolumeSlider(TrackBar masterTrackbar, TextBox masterTextBox)
        {
            this.masterTrackbar = masterTrackbar;
            this.masterTextBox = masterTextBox;
        }

        // Override from master for creating slider and textbox and add them to form
        public override void createSlider(FlowLayoutPanel flowLayoutPanel)
        {
            subTrackBar = new TrackBar();
            subTrackBar.Size = new Size(104, 45);
            subTrackBar.ValueChanged += trackBarChange;
            flowLayoutPanel.Controls.Add(subTrackBar);

            subTextBox = new TextBox();
            subTextBox.Size = new Size(104, 45);
            subTextBox.TextChanged += textBoxChange;
            flowLayoutPanel.Controls.Add(subTextBox);

            // call method when master volume changes
            masterTrackbar.ValueChanged += masterBarChange;
        }

        // Methods for text box, track bar and master bar change
        public override void textBoxChange(object sender, EventArgs e)
        {
            changeSliderOnNumEntered(subTextBox, subTrackBar);
            changeMasterSliderOnExceedMasterVolume(subTextBox, subTrackBar);
        }

        public override void trackBarChange(object sender, EventArgs e)
        {
            changeNumOnSliderChange(subTextBox, subTrackBar);
            changeMasterSliderOnExceedMasterVolume(subTextBox, subTrackBar);
        }

        public virtual void masterBarChange(object sender, EventArgs e)
        {
            changeSliderOnMasterVolumeChange(subTrackBar);
        }

        // Method to increase master slider if a sub slider exceeds it
        protected void changeMasterSliderOnExceedMasterVolume(TextBox textBox, TrackBar trackBar)
        {
            if (trackBar.Value > masterTrackbar.Value)
            {
                changeDueToExceed = true;
                masterTrackbar.Value = trackBar.Value;
                masterTextBox.Text = textBox.Text;
                masterVolumeInt = masterTrackbar.Value;
            }
        }

        // Method to ensure that all sliders follow master slider without falling out of bounds
        protected void changeSliderOnMasterVolumeChange(TrackBar trackBar)
        {
            if (!changeDueToExceed)
            {
                // Get diff between current master value and master int stored
                int masterDiff = masterTrackbar.Value - masterVolumeInt;

                // Ensure that subBars adjust if equal to master
                if (trackBar.Value == masterVolumeInt)
                {
                    trackBar.Value = masterTrackbar.Value;
                }
                else
                {
                    // Ensure that subtrackbar doesn't fall out of bounds when following master volume
                    if (trackBar.Value + masterDiff < 0)
                    {
                        trackBar.Value = 0;
                    }
                    else if (trackBar.Value + masterDiff > 10)
                    {
                        trackBar.Value = 10;
                    }
                    else
                    {
                        trackBar.Value += masterDiff;
                    }
                }

                // Adjust master int to equal master trackbar for future calculations 
                masterVolumeInt = masterTrackbar.Value;
            }
            changeDueToExceed = false;
        }
    }

    // Inheritted class from SubVolumeSlider
    public class VoipSlider : SubVolumeSlider
    {
        // Properties
        private int voipVolumeInt;

        private TrackBar voipTrackBar;
        private TextBox voipTextBox;
        private CheckBox voipCheckBox;

        private TrackBar masterTrackBar;

        // Lists to store sliders and their values separately
        private List<SubVolumeSlider> subVolumeSliders;
        private List<int> sliderVols = new List<int>();

        // Constructor
        public VoipSlider(TrackBar masterTrackBar, TextBox masterTextBox, List<SubVolumeSlider> subVolumeSliders) : 
            base(masterTrackBar, masterTextBox)
        {
            this.masterTrackBar = masterTrackBar;
            this.masterTextBox = masterTextBox;
            this.subVolumeSliders = subVolumeSliders;
        }

        // Override from master for creating slider, textbox and checkbox and add them to form
        public override void createSlider(FlowLayoutPanel flowLayoutPanel)
        {
            voipTrackBar = new TrackBar();
            voipTrackBar.Size = new Size(104, 45);
            voipTrackBar.ValueChanged += trackBarChange;
            flowLayoutPanel.Controls.Add(voipTrackBar);

            voipTextBox = new TextBox();
            voipTextBox.Size = new Size(104, 45);
            voipTextBox.TextChanged += textBoxChange;
            flowLayoutPanel.Controls.Add(voipTextBox);

            voipCheckBox = new CheckBox();
            voipCheckBox.Size = new Size(104, 15);
            voipCheckBox.CheckedChanged += onVoipCheckChanged;
            flowLayoutPanel.Controls.Add(voipCheckBox);

            // call method when master volume changes
            masterTrackBar.ValueChanged += masterBarChange;
        }

        // Methods for text box, track bar and master track bar change 
        public override void textBoxChange(object sender, EventArgs e)
        {
            changeSliderOnNumEntered(voipTextBox, voipTrackBar);
            changeMasterSliderOnExceedMasterVolume(voipTextBox, voipTrackBar);
        }

        public override void trackBarChange(object sender, EventArgs e)
        {
            changeNumOnSliderChange(voipTextBox, voipTrackBar);
            changeMasterSliderOnExceedMasterVolume(voipTextBox, voipTrackBar);
        }

        public override void masterBarChange(object sender, EventArgs e)
        {
            changeSliderOnMasterVolumeChange(voipTrackBar);
        }

        private void onVoipCheckChanged(object sender, EventArgs e)
        {
            // Call method depending on state of checkbox
            if (voipCheckBox.Checked)
            {
                muteMasterWhileEnabled();
            }
            else
            {
                resetVolumeWhileDisabled();
            }
        }

        // Store all trackbar values and then set all trackbars to 0
        private void muteMasterWhileEnabled()
        {
            sliderVols.Add(masterTrackBar.Value);
            for (int i = 0; i < subVolumeSliders.Count; i++)
            {
                sliderVols.Add(subVolumeSliders[i].subTrackBar.Value);
            }
            voipVolumeInt = voipTrackBar.Value;
            masterTrackBar.Value = 0;
        }

        // Replace all trackbar values and then clear stored trackbar values
        private void resetVolumeWhileDisabled()
        {
            masterTrackBar.Value = sliderVols[0];
            for (int i = 0; i < subVolumeSliders.Count; i++)
            {
                subVolumeSliders[i].subTrackBar.Value = sliderVols[i + 1];
            }
            voipTrackBar.Value = voipVolumeInt;
            sliderVols.Clear();
        }
    }
    #endregion
}