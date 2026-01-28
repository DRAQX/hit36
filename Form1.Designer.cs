namespace hit36
{
    partial class mainGameWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainGameWindow));
            keyHolder = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            toolTip1 = new ToolTip(components);
            scoreTracker = new Label();
            testButton = new Button();
            showCase = new PictureBox();
            resetButton = new Button();
            streakSign = new Label();
            streakCount = new Label();
            keepRollin = new CheckBox();
            settingsicon = new PictureBox();
            keyHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showCase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)settingsicon).BeginInit();
            SuspendLayout();
            // 
            // keyHolder
            // 
            keyHolder.Controls.Add(button1);
            keyHolder.Controls.Add(button2);
            keyHolder.Controls.Add(button3);
            keyHolder.Controls.Add(button4);
            keyHolder.Controls.Add(button5);
            keyHolder.Controls.Add(button6);
            keyHolder.Controls.Add(button7);
            keyHolder.Controls.Add(button8);
            keyHolder.Controls.Add(button9);
            keyHolder.Location = new Point(12, 108);
            keyHolder.Name = "keyHolder";
            keyHolder.Padding = new Padding(0, 6, 6, 0);
            keyHolder.Size = new Size(204, 204);
            keyHolder.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(6, 6);
            button1.Margin = new Padding(6, 0, 0, 6);
            button1.MinimumSize = new Size(60, 60);
            button1.Name = "button1";
            button1.Size = new Size(60, 60);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.Tag = "numkeys";
            button1.UseVisualStyleBackColor = true;
            button1.Click += keypadOnClick;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(72, 6);
            button2.Margin = new Padding(6, 0, 0, 6);
            button2.MinimumSize = new Size(60, 60);
            button2.Name = "button2";
            button2.Size = new Size(60, 60);
            button2.TabIndex = 0;
            button2.TabStop = false;
            button2.Tag = "numkeys";
            button2.UseVisualStyleBackColor = true;
            button2.Click += keypadOnClick;
            // 
            // button3
            // 
            button3.Location = new Point(138, 6);
            button3.Margin = new Padding(6, 0, 0, 6);
            button3.MinimumSize = new Size(60, 60);
            button3.Name = "button3";
            button3.Size = new Size(60, 60);
            button3.TabIndex = 0;
            button3.TabStop = false;
            button3.Tag = "numkeys";
            button3.UseVisualStyleBackColor = true;
            button3.Click += keypadOnClick;
            // 
            // button4
            // 
            button4.Location = new Point(6, 72);
            button4.Margin = new Padding(6, 0, 0, 6);
            button4.MinimumSize = new Size(60, 60);
            button4.Name = "button4";
            button4.Size = new Size(60, 60);
            button4.TabIndex = 0;
            button4.TabStop = false;
            button4.Tag = "numkeys";
            button4.UseVisualStyleBackColor = true;
            button4.Click += keypadOnClick;
            // 
            // button5
            // 
            button5.Location = new Point(72, 72);
            button5.Margin = new Padding(6, 0, 0, 6);
            button5.MinimumSize = new Size(60, 60);
            button5.Name = "button5";
            button5.Size = new Size(60, 60);
            button5.TabIndex = 0;
            button5.TabStop = false;
            button5.Tag = "numkeys";
            button5.UseVisualStyleBackColor = true;
            button5.Click += keypadOnClick;
            // 
            // button6
            // 
            button6.Location = new Point(138, 72);
            button6.Margin = new Padding(6, 0, 0, 6);
            button6.MinimumSize = new Size(60, 60);
            button6.Name = "button6";
            button6.Size = new Size(60, 60);
            button6.TabIndex = 0;
            button6.TabStop = false;
            button6.Tag = "numkeys";
            button6.UseVisualStyleBackColor = true;
            button6.Click += keypadOnClick;
            // 
            // button7
            // 
            button7.Location = new Point(6, 138);
            button7.Margin = new Padding(6, 0, 0, 6);
            button7.MinimumSize = new Size(60, 60);
            button7.Name = "button7";
            button7.Size = new Size(60, 60);
            button7.TabIndex = 1;
            button7.TabStop = false;
            button7.Tag = "numkeys";
            button7.UseVisualStyleBackColor = true;
            button7.Click += keypadOnClick;
            // 
            // button8
            // 
            button8.Location = new Point(72, 138);
            button8.Margin = new Padding(6, 0, 0, 6);
            button8.MinimumSize = new Size(60, 60);
            button8.Name = "button8";
            button8.Size = new Size(60, 60);
            button8.TabIndex = 2;
            button8.TabStop = false;
            button8.Tag = "numkeys";
            button8.UseVisualStyleBackColor = true;
            button8.Click += keypadOnClick;
            // 
            // button9
            // 
            button9.Location = new Point(138, 138);
            button9.Margin = new Padding(6, 0, 0, 6);
            button9.MinimumSize = new Size(60, 60);
            button9.Name = "button9";
            button9.Size = new Size(60, 60);
            button9.TabIndex = 3;
            button9.TabStop = false;
            button9.Tag = "numkeys";
            button9.UseVisualStyleBackColor = true;
            button9.Click += keypadOnClick;
            // 
            // toolTip1
            // 
            toolTip1.Tag = "numkeys";
            // 
            // scoreTracker
            // 
            scoreTracker.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            scoreTracker.Location = new Point(12, 12);
            scoreTracker.Margin = new Padding(0);
            scoreTracker.Name = "scoreTracker";
            scoreTracker.Padding = new Padding(6, 0, 0, 0);
            scoreTracker.Size = new Size(204, 60);
            scoreTracker.TabIndex = 1;
            scoreTracker.Text = "0";
            scoreTracker.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // testButton
            // 
            testButton.Location = new Point(12, 12);
            testButton.Name = "testButton";
            testButton.Size = new Size(60, 60);
            testButton.TabIndex = 2;
            testButton.TabStop = false;
            testButton.Text = "TEST";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // showCase
            // 
            showCase.ImageLocation = "";
            showCase.Location = new Point(222, 12);
            showCase.Name = "showCase";
            showCase.Size = new Size(200, 300);
            showCase.TabIndex = 3;
            showCase.TabStop = false;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(156, 12);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(60, 60);
            resetButton.TabIndex = 4;
            resetButton.TabStop = false;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // streakSign
            // 
            streakSign.Font = new Font("Segoe UI", 12F);
            streakSign.Location = new Point(289, 14);
            streakSign.Name = "streakSign";
            streakSign.Size = new Size(66, 25);
            streakSign.TabIndex = 5;
            streakSign.Text = "Streak: ";
            // 
            // streakCount
            // 
            streakCount.Font = new Font("Segoe UI", 12F);
            streakCount.Location = new Point(335, 14);
            streakCount.Name = "streakCount";
            streakCount.Size = new Size(66, 25);
            streakCount.TabIndex = 6;
            streakCount.Text = "0";
            // 
            // keepRollin
            // 
            keepRollin.Appearance = Appearance.Button;
            keepRollin.Cursor = Cursors.Hand;
            keepRollin.Location = new Point(66, 78);
            keepRollin.Name = "keepRollin";
            keepRollin.Size = new Size(96, 25);
            keepRollin.TabIndex = 7;
            keepRollin.Text = "Keep me rollin";
            keepRollin.TextAlign = ContentAlignment.MiddleCenter;
            keepRollin.UseVisualStyleBackColor = true;
            keepRollin.CheckedChanged += keepRollin_CheckedChanged;
            // 
            // settingsicon
            // 
            settingsicon.Cursor = Cursors.Hand;
            settingsicon.Image = Properties.Resources.settings;
            settingsicon.Location = new Point(186, 73);
            settingsicon.Name = "settingsicon";
            settingsicon.Size = new Size(30, 30);
            settingsicon.SizeMode = PictureBoxSizeMode.StretchImage;
            settingsicon.TabIndex = 8;
            settingsicon.TabStop = false;
            settingsicon.Click += settingsicon_Click;
            // 
            // mainGameWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 252);
            ClientSize = new Size(434, 321);
            Controls.Add(settingsicon);
            Controls.Add(keepRollin);
            Controls.Add(streakCount);
            Controls.Add(streakSign);
            Controls.Add(resetButton);
            Controls.Add(showCase);
            Controls.Add(testButton);
            Controls.Add(scoreTracker);
            Controls.Add(keyHolder);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "mainGameWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hit 36!";
            keyHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)showCase).EndInit();
            ((System.ComponentModel.ISupportInitialize)settingsicon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel keyHolder;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private ToolTip toolTip1;
        private Label scoreTracker;
        private Button testButton;
        private PictureBox showCase;
        private Button resetButton;
        private Label streakSign;
        private Label streakCount;
        private CheckBox keepRollin;
        private PictureBox settingsicon;
    }
}
