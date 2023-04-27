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
            System.Windows.Forms.Label label6;
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
            this.graphicsAdapter = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Antialiasing = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AspectRatio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Github = new System.Windows.Forms.LinkLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Arial", 10F);
            label6.Location = new System.Drawing.Point(6, 25);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(100, 16);
            label6.TabIndex = 24;
            label6.Text = "Master Volume";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.SystemColors.Window;
            this.Finish.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Finish.Location = new System.Drawing.Point(20, 22);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(173, 38);
            this.Finish.TabIndex = 3;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // None
            // 
            this.None.AutoSize = true;
            this.None.Font = new System.Drawing.Font("Arial", 10F);
            this.None.Location = new System.Drawing.Point(6, 18);
            this.None.Name = "None";
            this.None.Size = new System.Drawing.Size(58, 20);
            this.None.TabIndex = 4;
            this.None.TabStop = true;
            this.None.Text = "None";
            this.None.UseVisualStyleBackColor = true;
            this.None.CheckedChanged += new System.EventHandler(this.noneScreenEffect_CheckedChanged);
            // 
            // Bloom
            // 
            this.Bloom.AutoSize = true;
            this.Bloom.Font = new System.Drawing.Font("Arial", 10F);
            this.Bloom.Location = new System.Drawing.Point(6, 41);
            this.Bloom.Name = "Bloom";
            this.Bloom.Size = new System.Drawing.Size(64, 20);
            this.Bloom.TabIndex = 5;
            this.Bloom.TabStop = true;
            this.Bloom.Text = "Bloom";
            this.Bloom.UseVisualStyleBackColor = true;
            this.Bloom.CheckedChanged += new System.EventHandler(this.bloomScreenEffects_CheckedChanged);
            // 
            // HDR
            // 
            this.HDR.AutoSize = true;
            this.HDR.Font = new System.Drawing.Font("Arial", 10F);
            this.HDR.Location = new System.Drawing.Point(6, 64);
            this.HDR.Name = "HDR";
            this.HDR.Size = new System.Drawing.Size(54, 20);
            this.HDR.TabIndex = 6;
            this.HDR.TabStop = true;
            this.HDR.Text = "HDR";
            this.HDR.UseVisualStyleBackColor = true;
            this.HDR.CheckedChanged += new System.EventHandler(this.hdrScreenEffects_CheckedChanged);
            // 
            // Windowed
            // 
            this.Windowed.AutoSize = true;
            this.Windowed.Font = new System.Drawing.Font("Arial", 10F);
            this.Windowed.Location = new System.Drawing.Point(6, 22);
            this.Windowed.Name = "Windowed";
            this.Windowed.Size = new System.Drawing.Size(91, 20);
            this.Windowed.TabIndex = 9;
            this.Windowed.Text = "Windowed";
            this.Windowed.UseVisualStyleBackColor = true;
            this.Windowed.CheckedChanged += new System.EventHandler(this.windowed_CheckedChanged);
            // 
            // VerticalSync
            // 
            this.VerticalSync.AutoSize = true;
            this.VerticalSync.Font = new System.Drawing.Font("Arial", 10F);
            this.VerticalSync.Location = new System.Drawing.Point(6, 58);
            this.VerticalSync.Name = "VerticalSync";
            this.VerticalSync.Size = new System.Drawing.Size(107, 20);
            this.VerticalSync.TabIndex = 10;
            this.VerticalSync.Text = "Vertical Sync";
            this.VerticalSync.UseVisualStyleBackColor = true;
            this.VerticalSync.CheckedChanged += new System.EventHandler(this.verticalSync_CheckedChanged);
            // 
            // Low
            // 
            this.Low.BackColor = System.Drawing.SystemColors.Window;
            this.Low.FlatAppearance.BorderSize = 2;
            this.Low.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Low.Location = new System.Drawing.Point(3, 19);
            this.Low.Name = "Low";
            this.Low.Size = new System.Drawing.Size(90, 38);
            this.Low.TabIndex = 11;
            this.Low.Text = "Low";
            this.Low.UseVisualStyleBackColor = false;
            this.Low.Click += new System.EventHandler(this.lowGraphics_Click);
            // 
            // Medium
            // 
            this.Medium.BackColor = System.Drawing.SystemColors.Window;
            this.Medium.FlatAppearance.BorderSize = 2;
            this.Medium.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Medium.Location = new System.Drawing.Point(99, 19);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(90, 38);
            this.Medium.TabIndex = 12;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = false;
            this.Medium.Click += new System.EventHandler(this.mediumGraphics_Click);
            // 
            // High
            // 
            this.High.BackColor = System.Drawing.SystemColors.Window;
            this.High.FlatAppearance.BorderSize = 2;
            this.High.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.High.Location = new System.Drawing.Point(195, 19);
            this.High.Name = "High";
            this.High.Size = new System.Drawing.Size(90, 38);
            this.High.TabIndex = 13;
            this.High.Text = "High";
            this.High.UseVisualStyleBackColor = false;
            this.High.Click += new System.EventHandler(this.highGraphics_Click);
            // 
            // Ultra
            // 
            this.Ultra.BackColor = System.Drawing.SystemColors.Window;
            this.Ultra.FlatAppearance.BorderSize = 2;
            this.Ultra.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Ultra.Location = new System.Drawing.Point(291, 19);
            this.Ultra.Name = "Ultra";
            this.Ultra.Size = new System.Drawing.Size(90, 38);
            this.Ultra.TabIndex = 14;
            this.Ultra.Text = "Ultra";
            this.Ultra.UseVisualStyleBackColor = false;
            this.Ultra.Click += new System.EventHandler(this.ultraGraphics_Click);
            // 
            // Default
            // 
            this.Default.BackColor = System.Drawing.SystemColors.Window;
            this.Default.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Default.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Default.Location = new System.Drawing.Point(387, 19);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(173, 38);
            this.Default.TabIndex = 15;
            this.Default.Text = "Default";
            this.Default.UseVisualStyleBackColor = false;
            this.Default.Click += new System.EventHandler(this.defaultGraphics_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.Low);
            this.groupBox1.Controls.Add(this.Default);
            this.groupBox1.Controls.Add(this.Medium);
            this.groupBox1.Controls.Add(this.High);
            this.groupBox1.Controls.Add(this.Ultra);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox1.Location = new System.Drawing.Point(13, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 63);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.Windowed);
            this.groupBox2.Controls.Add(this.VerticalSync);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox2.Location = new System.Drawing.Point(13, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 84);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Controls.Add(this.None);
            this.groupBox3.Controls.Add(this.Bloom);
            this.groupBox3.Controls.Add(this.HDR);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox3.Location = new System.Drawing.Point(297, 267);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 84);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Screen Effects";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Controls.Add(this.Resolutions);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.AnisotropicFiltering);
            this.groupBox4.Controls.Add(this.graphicsAdapter);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.Antialiasing);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.AspectRatio);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox4.Location = new System.Drawing.Point(13, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(562, 180);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Graphics Adapter and Resolution";
            // 
            // Resolutions
            // 
            this.Resolutions.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resolutions.FormattingEnabled = true;
            this.Resolutions.Items.AddRange(new object[] {
            "1280x720",
            "1360x768",
            "1920x1080"});
            this.Resolutions.Location = new System.Drawing.Point(144, 49);
            this.Resolutions.Name = "Resolutions";
            this.Resolutions.Size = new System.Drawing.Size(413, 24);
            this.Resolutions.TabIndex = 10;
            this.Resolutions.SelectedIndexChanged += new System.EventHandler(this.resolutions_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resolutions";
            // 
            // AnisotropicFiltering
            // 
            this.AnisotropicFiltering.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnisotropicFiltering.FormattingEnabled = true;
            this.AnisotropicFiltering.Items.AddRange(new object[] {
            "10 Samples",
            "11 Samples",
            "12 Samples",
            "13 Samples",
            "14 Samples",
            "15 Samples"});
            this.AnisotropicFiltering.Location = new System.Drawing.Point(144, 131);
            this.AnisotropicFiltering.Name = "AnisotropicFiltering";
            this.AnisotropicFiltering.Size = new System.Drawing.Size(413, 24);
            this.AnisotropicFiltering.TabIndex = 8;
            this.AnisotropicFiltering.SelectedIndexChanged += new System.EventHandler(this.anisotropicFiltering_SelectedIndexChanged);
            // 
            // graphicsAdapter
            // 
            this.graphicsAdapter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphicsAdapter.FormattingEnabled = true;
            this.graphicsAdapter.Items.AddRange(new object[] {
            "NVIDIA GEFORCE GTX 1070",
            "NVIDIA GEFORCE GTX 1080"});
            this.graphicsAdapter.Location = new System.Drawing.Point(144, 22);
            this.graphicsAdapter.Name = "graphicsAdapter";
            this.graphicsAdapter.Size = new System.Drawing.Size(413, 24);
            this.graphicsAdapter.TabIndex = 5;
            this.graphicsAdapter.SelectedIndexChanged += new System.EventHandler(this.graphicsAdapter_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Anisotropic Filtering";
            // 
            // Antialiasing
            // 
            this.Antialiasing.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Antialiasing.FormattingEnabled = true;
            this.Antialiasing.Items.AddRange(new object[] {
            "Off (best performance)",
            "2 Samples",
            "4 Samples",
            "15 Samples"});
            this.Antialiasing.Location = new System.Drawing.Point(144, 104);
            this.Antialiasing.Name = "Antialiasing";
            this.Antialiasing.Size = new System.Drawing.Size(413, 24);
            this.Antialiasing.TabIndex = 7;
            this.Antialiasing.SelectedIndexChanged += new System.EventHandler(this.antialiasing_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Antialiasing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aspect Ratio";
            // 
            // AspectRatio
            // 
            this.AspectRatio.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AspectRatio.FormattingEnabled = true;
            this.AspectRatio.Items.AddRange(new object[] {
            "Standard (4:3 or 5:4)",
            "16:9 Widescreen",
            "16:10 Widescreen"});
            this.AspectRatio.Location = new System.Drawing.Point(144, 76);
            this.AspectRatio.Name = "AspectRatio";
            this.AspectRatio.Size = new System.Drawing.Size(413, 24);
            this.AspectRatio.TabIndex = 6;
            this.AspectRatio.SelectedIndexChanged += new System.EventHandler(this.aspectRatio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graphics Adapter";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.Window;
            this.Cancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(199, 22);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(173, 38);
            this.Cancel.TabIndex = 21;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Github
            // 
            this.Github.AutoSize = true;
            this.Github.Location = new System.Drawing.Point(345, 65);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(54, 16);
            this.Github.TabIndex = 22;
            this.Github.TabStop = true;
            this.Github.Text = "Github";
            this.Github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.github_LinkClicked);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(112, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 221);
            this.flowLayoutPanel1.TabIndex = 23;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F);
            this.label7.Location = new System.Drawing.Point(6, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Music Volume";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F);
            this.label8.Location = new System.Drawing.Point(6, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 26;
            this.label8.Text = "SFX Volume";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F);
            this.label9.Location = new System.Drawing.Point(6, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "Voip Volume";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(label6);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox5.Location = new System.Drawing.Point(581, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(399, 249);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Audio";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F);
            this.label10.Location = new System.Drawing.Point(6, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Mute All";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox6.Controls.Add(this.Finish);
            this.groupBox6.Controls.Add(this.Cancel);
            this.groupBox6.Controls.Add(this.Github);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.groupBox6.Location = new System.Drawing.Point(581, 267);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(399, 84);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Finalize";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(992, 363);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Game Options Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

