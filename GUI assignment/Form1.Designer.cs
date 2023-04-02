namespace GUI_assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Finish = new System.Windows.Forms.Button();
            this.None = new System.Windows.Forms.RadioButton();
            this.Bloom = new System.Windows.Forms.RadioButton();
            this.HDR = new System.Windows.Forms.RadioButton();
            this.Windowed = new System.Windows.Forms.CheckBox();
            this.VerticalSync = new System.Windows.Forms.CheckBox();
            this.Low = new System.Windows.Forms.Button();
            this.Medium = new System.Windows.Forms.Button();
            this.High = new System.Windows.Forms.Button();
            this.Ultra = new System.Windows.Forms.Button();
            this.Default = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Resolutions = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AnisotropicFiltering = new System.Windows.Forms.ComboBox();
            this.Antialiasing = new System.Windows.Forms.ComboBox();
            this.AspectRatio = new System.Windows.Forms.ComboBox();
            this.graphicsAdapter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Github = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Finish
            // 
            this.Finish.Location = new System.Drawing.Point(528, 359);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 23);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = true;
            this.Finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Location = new System.Drawing.Point(6, 18);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(51, 17);
            this.None.TabIndex = 4;
            this.None.TabStop = true;
            this.None.Text = "None";
            this.None.UseVisualStyleBackColor = true;
            this.None.CheckedChanged += new System.EventHandler(this.noneScreenEffect_CheckedChanged);
            // 
            // Bloom
            // 
            this.Bloom.AutoSize = true;
            this.Bloom.Location = new System.Drawing.Point(6, 41);
            this.Bloom.Name = "Bloom";
            this.Bloom.Size = new System.Drawing.Size(54, 17);
            this.Bloom.TabIndex = 5;
            this.Bloom.TabStop = true;
            this.Bloom.Text = "Bloom";
            this.Bloom.UseVisualStyleBackColor = true;
            this.Bloom.CheckedChanged += new System.EventHandler(this.bloomScreenEffects_CheckedChanged);
            // 
            // HDR
            // 
            this.HDR.AutoSize = true;
            this.HDR.Location = new System.Drawing.Point(6, 64);
            this.HDR.Name = "HDR";
            this.HDR.Size = new System.Drawing.Size(49, 17);
            this.HDR.TabIndex = 6;
            this.HDR.TabStop = true;
            this.HDR.Text = "HDR";
            this.HDR.UseVisualStyleBackColor = true;
            this.HDR.CheckedChanged += new System.EventHandler(this.hdrScreenEffects_CheckedChanged);
            // 
            // Windowed
            // 
            this.Windowed.AutoSize = true;
            this.Windowed.Location = new System.Drawing.Point(6, 30);
            this.Windowed.Name = "Windowed";
            this.Windowed.Size = new System.Drawing.Size(77, 17);
            this.Windowed.TabIndex = 9;
            this.Windowed.Text = "Windowed";
            this.Windowed.UseVisualStyleBackColor = true;
            this.Windowed.CheckedChanged += new System.EventHandler(this.windowed_CheckedChanged);
            // 
            // VerticalSync
            // 
            this.VerticalSync.AutoSize = true;
            this.VerticalSync.Location = new System.Drawing.Point(6, 53);
            this.VerticalSync.Name = "VerticalSync";
            this.VerticalSync.Size = new System.Drawing.Size(88, 17);
            this.VerticalSync.TabIndex = 10;
            this.VerticalSync.Text = "Vertical Sync";
            this.VerticalSync.UseVisualStyleBackColor = true;
            this.VerticalSync.CheckedChanged += new System.EventHandler(this.verticalSync_CheckedChanged);
            // 
            // Low
            // 
            this.Low.Location = new System.Drawing.Point(3, 19);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(75, 23);
            this.Low.TabIndex = 11;
            this.Low.Text = "Low";
            this.Low.UseVisualStyleBackColor = true;
            this.Low.Click += new System.EventHandler(this.lowGraphics_Click);
            // 
            // Medium
            // 
            this.Medium.Location = new System.Drawing.Point(84, 19);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(75, 23);
            this.Medium.TabIndex = 12;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            this.Medium.Click += new System.EventHandler(this.mediumGraphics_Click);
            // 
            // High
            // 
            this.High.Location = new System.Drawing.Point(165, 19);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(75, 23);
            this.High.TabIndex = 13;
            this.High.Text = "High";
            this.High.UseVisualStyleBackColor = true;
            this.High.Click += new System.EventHandler(this.highGraphics_Click);
            // 
            // Ultra
            // 
            this.Ultra.Location = new System.Drawing.Point(246, 19);
            this.Ultra.Name = "Ultra";
            this.Ultra.Size = new System.Drawing.Size(75, 23);
            this.Ultra.TabIndex = 14;
            this.Ultra.Text = "Ultra";
            this.Ultra.UseVisualStyleBackColor = true;
            this.Ultra.Click += new System.EventHandler(this.ultraGraphics_Click);
            // 
            // Default
            // 
            this.Default.Location = new System.Drawing.Point(327, 19);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(173, 23);
            this.Default.TabIndex = 15;
            this.Default.Text = "Default";
            this.Default.UseVisualStyleBackColor = true;
            this.Default.Click += new System.EventHandler(this.defaultGraphics_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Low);
            this.groupBox1.Controls.Add(this.Medium);
            this.groupBox1.Controls.Add(this.Default);
            this.groupBox1.Controls.Add(this.High);
            this.groupBox1.Controls.Add(this.Ultra);
            this.groupBox1.Location = new System.Drawing.Point(15, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 63);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Windowed);
            this.groupBox2.Controls.Add(this.VerticalSync);
            this.groupBox2.Location = new System.Drawing.Point(15, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 102);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.None);
            this.groupBox3.Controls.Add(this.Bloom);
            this.groupBox3.Controls.Add(this.HDR);
            this.groupBox3.Location = new System.Drawing.Point(222, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Screen Effects";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Resolutions);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.AnisotropicFiltering);
            this.groupBox4.Controls.Add(this.Antialiasing);
            this.groupBox4.Controls.Add(this.AspectRatio);
            this.groupBox4.Controls.Add(this.graphicsAdapter);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(13, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 180);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Graphics Adapter and Resolution";
            // 
            // Resolutions
            // 
            this.Resolutions.FormattingEnabled = true;
            this.Resolutions.Items.AddRange(new object[] {
            "1280x720",
            "1360x768",
            "1920x1080"});
            this.Resolutions.Location = new System.Drawing.Point(118, 46);
            this.Resolutions.Name = "Resolutions";
            this.Resolutions.Size = new System.Drawing.Size(291, 21);
            this.Resolutions.TabIndex = 10;
            this.Resolutions.SelectedIndexChanged += new System.EventHandler(this.resolutions_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resolutions";
            // 
            // AnisotropicFiltering
            // 
            this.AnisotropicFiltering.FormattingEnabled = true;
            this.AnisotropicFiltering.Items.AddRange(new object[] {
            "10 Samples",
            "11 Samples",
            "12 Samples",
            "13 Samples",
            "14 Samples",
            "15 Samples"});
            this.AnisotropicFiltering.Location = new System.Drawing.Point(118, 131);
            this.AnisotropicFiltering.Name = "AnisotropicFiltering";
            this.AnisotropicFiltering.Size = new System.Drawing.Size(291, 21);
            this.AnisotropicFiltering.TabIndex = 8;
            this.AnisotropicFiltering.SelectedIndexChanged += new System.EventHandler(this.anisotropicFiltering_SelectedIndexChanged);
            // 
            // Antialiasing
            // 
            this.Antialiasing.FormattingEnabled = true;
            this.Antialiasing.Items.AddRange(new object[] {
            "Off (best performance)",
            "2 Samples",
            "4 Samples",
            "15 Samples"});
            this.Antialiasing.Location = new System.Drawing.Point(118, 104);
            this.Antialiasing.Name = "Antialiasing";
            this.Antialiasing.Size = new System.Drawing.Size(291, 21);
            this.Antialiasing.TabIndex = 7;
            this.Antialiasing.SelectedIndexChanged += new System.EventHandler(this.antialiasing_SelectedIndexChanged);
            // 
            // AspectRatio
            // 
            this.AspectRatio.FormattingEnabled = true;
            this.AspectRatio.Items.AddRange(new object[] {
            "Standard (4:3 or 5:4)",
            "16:9 Widescreen",
            "16:10 Widescreen"});
            this.AspectRatio.Location = new System.Drawing.Point(118, 73);
            this.AspectRatio.Name = "AspectRatio";
            this.AspectRatio.Size = new System.Drawing.Size(291, 21);
            this.AspectRatio.TabIndex = 6;
            this.AspectRatio.SelectedIndexChanged += new System.EventHandler(this.aspectRatio_SelectedIndexChanged);
            // 
            // graphicsAdapter
            // 
            this.graphicsAdapter.FormattingEnabled = true;
            this.graphicsAdapter.Items.AddRange(new object[] {
            "NVIDIA GEFORCE GTX 1070",
            "NVIDIA GEFORCE GTX 1080"});
            this.graphicsAdapter.Location = new System.Drawing.Point(118, 19);
            this.graphicsAdapter.Name = "graphicsAdapter";
            this.graphicsAdapter.Size = new System.Drawing.Size(291, 21);
            this.graphicsAdapter.TabIndex = 5;
            this.graphicsAdapter.SelectedIndexChanged += new System.EventHandler(this.graphicsAdapter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anisotropic Filtering";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Antialiasing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aspect Ratio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graphics Adapter";
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(636, 359);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Github
            // 
            this.Github.AutoSize = true;
            this.Github.Location = new System.Drawing.Point(728, 418);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(38, 13);
            this.Github.TabIndex = 22;
            this.Github.TabStop = true;
            this.Github.Text = "Github";
            this.Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Github);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Finish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Finish;
        private System.Windows.Forms.RadioButton None;
        private System.Windows.Forms.RadioButton Bloom;
        private System.Windows.Forms.RadioButton HDR;
        private System.Windows.Forms.CheckBox Windowed;
        private System.Windows.Forms.CheckBox VerticalSync;
        private System.Windows.Forms.Button Low;
        private System.Windows.Forms.Button Medium;
        private System.Windows.Forms.Button High;
        private System.Windows.Forms.Button Ultra;
        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox graphicsAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Resolutions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AnisotropicFiltering;
        private System.Windows.Forms.ComboBox Antialiasing;
        private System.Windows.Forms.ComboBox AspectRatio;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.LinkLabel Github;
    }
}

