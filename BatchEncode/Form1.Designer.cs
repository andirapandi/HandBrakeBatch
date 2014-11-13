namespace BatchEncode
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
            this.Label5 = new System.Windows.Forms.Label();
            this.ButtonBrowseHandbrake = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.ComboBoxPreset = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ButtonBrowseTarget = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.ButtonSourceBrowse = new System.Windows.Forms.Button();
            this.TextBoxHandBrake = new System.Windows.Forms.TextBox();
            this.TextBoxCommandLine = new System.Windows.Forms.TextBox();
            this.TextBoxTarget = new System.Windows.Forms.TextBox();
            this.TextBoxSource = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFileExtensions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(48, 110);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 13);
            this.Label5.TabIndex = 27;
            this.Label5.Text = "handbrakecli";
            // 
            // ButtonBrowseHandbrake
            // 
            this.ButtonBrowseHandbrake.Location = new System.Drawing.Point(310, 126);
            this.ButtonBrowseHandbrake.Name = "ButtonBrowseHandbrake";
            this.ButtonBrowseHandbrake.Size = new System.Drawing.Size(25, 20);
            this.ButtonBrowseHandbrake.TabIndex = 26;
            this.ButtonBrowseHandbrake.Text = "..";
            this.ButtonBrowseHandbrake.UseVisualStyleBackColor = true;
            this.ButtonBrowseHandbrake.Click += new System.EventHandler(this.ButtonBrowseHandbrake_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(321, 271);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 24;
            this.ButtonStart.Text = "start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(48, 242);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(72, 13);
            this.Label4.TabIndex = 22;
            this.Label4.Text = "command line";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(48, 185);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(36, 13);
            this.Label3.TabIndex = 21;
            this.Label3.Text = "preset";
            this.Label3.Visible = false;
            // 
            // ComboBoxPreset
            // 
            this.ComboBoxPreset.FormattingEnabled = true;
            this.ComboBoxPreset.Location = new System.Drawing.Point(51, 201);
            this.ComboBoxPreset.Name = "ComboBoxPreset";
            this.ComboBoxPreset.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPreset.TabIndex = 20;
            this.ComboBoxPreset.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(48, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(34, 13);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "target";
            // 
            // ButtonBrowseTarget
            // 
            this.ButtonBrowseTarget.Location = new System.Drawing.Point(310, 81);
            this.ButtonBrowseTarget.Name = "ButtonBrowseTarget";
            this.ButtonBrowseTarget.Size = new System.Drawing.Size(25, 20);
            this.ButtonBrowseTarget.TabIndex = 18;
            this.ButtonBrowseTarget.Text = "..";
            this.ButtonBrowseTarget.UseVisualStyleBackColor = true;
            this.ButtonBrowseTarget.Click += new System.EventHandler(this.ButtonBrowseTarget_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(48, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(39, 13);
            this.Label1.TabIndex = 16;
            this.Label1.Text = "source";
            // 
            // ButtonSourceBrowse
            // 
            this.ButtonSourceBrowse.Location = new System.Drawing.Point(310, 46);
            this.ButtonSourceBrowse.Name = "ButtonSourceBrowse";
            this.ButtonSourceBrowse.Size = new System.Drawing.Size(25, 20);
            this.ButtonSourceBrowse.TabIndex = 15;
            this.ButtonSourceBrowse.Text = "..";
            this.ButtonSourceBrowse.UseVisualStyleBackColor = true;
            this.ButtonSourceBrowse.Click += new System.EventHandler(this.ButtonSourceBrowse_Click);
            // 
            // TextBoxHandBrake
            // 
            this.TextBoxHandBrake.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BatchEncode.Properties.Settings.Default, "handbrakepath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextBoxHandBrake.Location = new System.Drawing.Point(51, 126);
            this.TextBoxHandBrake.Name = "TextBoxHandBrake";
            this.TextBoxHandBrake.Size = new System.Drawing.Size(253, 20);
            this.TextBoxHandBrake.TabIndex = 25;
            this.TextBoxHandBrake.Text = global::BatchEncode.Properties.Settings.Default.handbrakepath;
            // 
            // TextBoxCommandLine
            // 
            this.TextBoxCommandLine.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BatchEncode.Properties.Settings.Default, "commandline", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextBoxCommandLine.Location = new System.Drawing.Point(51, 258);
            this.TextBoxCommandLine.Multiline = true;
            this.TextBoxCommandLine.Name = "TextBoxCommandLine";
            this.TextBoxCommandLine.Size = new System.Drawing.Size(253, 82);
            this.TextBoxCommandLine.TabIndex = 23;
            this.TextBoxCommandLine.Text = global::BatchEncode.Properties.Settings.Default.commandline;
            // 
            // TextBoxTarget
            // 
            this.TextBoxTarget.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BatchEncode.Properties.Settings.Default, "targetpath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextBoxTarget.Location = new System.Drawing.Point(51, 81);
            this.TextBoxTarget.Name = "TextBoxTarget";
            this.TextBoxTarget.Size = new System.Drawing.Size(253, 20);
            this.TextBoxTarget.TabIndex = 17;
            this.TextBoxTarget.Text = global::BatchEncode.Properties.Settings.Default.targetpath;
            // 
            // TextBoxSource
            // 
            this.TextBoxSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BatchEncode.Properties.Settings.Default, "sourcepath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextBoxSource.Location = new System.Drawing.Point(51, 46);
            this.TextBoxSource.Name = "TextBoxSource";
            this.TextBoxSource.Size = new System.Drawing.Size(253, 20);
            this.TextBoxSource.TabIndex = 14;
            this.TextBoxSource.Text = global::BatchEncode.Properties.Settings.Default.sourcepath;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(48, 358);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "file extensions";
            // 
            // textBoxFileExtensions
            // 
            this.textBoxFileExtensions.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::BatchEncode.Properties.Settings.Default, "fileextensions", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxFileExtensions.Location = new System.Drawing.Point(51, 162);
            this.textBoxFileExtensions.Name = "textBoxFileExtensions";
            this.textBoxFileExtensions.Size = new System.Drawing.Size(253, 20);
            this.textBoxFileExtensions.TabIndex = 29;
            this.textBoxFileExtensions.Text = global::BatchEncode.Properties.Settings.Default.fileextensions;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 406);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFileExtensions);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ButtonBrowseHandbrake);
            this.Controls.Add(this.TextBoxHandBrake);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.TextBoxCommandLine);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ComboBoxPreset);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ButtonBrowseTarget);
            this.Controls.Add(this.TextBoxTarget);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonSourceBrowse);
            this.Controls.Add(this.TextBoxSource);
            this.Name = "Form1";
            this.Text = "BatchEncode with HandBrake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button ButtonBrowseHandbrake;
        internal System.Windows.Forms.TextBox TextBoxHandBrake;
        internal System.Windows.Forms.Button ButtonStart;
        internal System.Windows.Forms.TextBox TextBoxCommandLine;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox ComboBoxPreset;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button ButtonBrowseTarget;
        internal System.Windows.Forms.TextBox TextBoxTarget;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button ButtonSourceBrowse;
        internal System.Windows.Forms.TextBox TextBoxSource;
        private System.Windows.Forms.Label labelStatus;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox textBoxFileExtensions;
    }
}

