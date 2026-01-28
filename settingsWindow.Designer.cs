namespace hit36
{
    partial class settingsWindow
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
            paramminKeyCount = new Label();
            parammaxKeyCount = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            settingsApply = new Button();
            settingsCancel = new Button();
            inpMinKeyCount = new NumericUpDown();
            inpMaxKeyCount = new NumericUpDown();
            inpBiggestNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)inpMinKeyCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inpMaxKeyCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inpBiggestNumber).BeginInit();
            SuspendLayout();
            // 
            // paramminKeyCount
            // 
            paramminKeyCount.AutoSize = true;
            paramminKeyCount.Location = new Point(12, 12);
            paramminKeyCount.Name = "paramminKeyCount";
            paramminKeyCount.Size = new Size(115, 15);
            paramminKeyCount.TabIndex = 0;
            paramminKeyCount.Text = "Minimum key count";
            // 
            // parammaxKeyCount
            // 
            parammaxKeyCount.AutoSize = true;
            parammaxKeyCount.Location = new Point(12, 36);
            parammaxKeyCount.Name = "parammaxKeyCount";
            parammaxKeyCount.Size = new Size(117, 15);
            parammaxKeyCount.TabIndex = 1;
            parammaxKeyCount.Text = "Maximum key count";
            // 
            // label3
            // 
            label3.AccessibleDescription = "parammaxRand";
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(136, 15);
            label3.TabIndex = 2;
            label3.Text = "Biggest random number";
            // 
            // label1
            // 
            label1.AccessibleDescription = "parammaxRand";
            label1.AutoSize = true;
            label1.Location = new Point(202, 60);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 8;
            label1.Text = "[4 , 36]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 36);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 7;
            label2.Text = "[1,9]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 12);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 6;
            label4.Text = "[1,9]";
            // 
            // settingsApply
            // 
            settingsApply.BackColor = Color.FromArgb(192, 255, 192);
            settingsApply.Location = new Point(59, 104);
            settingsApply.Name = "settingsApply";
            settingsApply.Size = new Size(60, 30);
            settingsApply.TabIndex = 9;
            settingsApply.Text = "Apply";
            settingsApply.UseVisualStyleBackColor = false;
            // 
            // settingsCancel
            // 
            settingsCancel.BackColor = Color.FromArgb(255, 192, 192);
            settingsCancel.Location = new Point(167, 104);
            settingsCancel.Name = "settingsCancel";
            settingsCancel.Size = new Size(60, 30);
            settingsCancel.TabIndex = 9;
            settingsCancel.Text = "Cancel";
            settingsCancel.UseVisualStyleBackColor = false;
            settingsCancel.Click += settingsCancel_Click;
            // 
            // inpMinKeyCount
            // 
            inpMinKeyCount.Location = new Point(160, 8);
            inpMinKeyCount.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            inpMinKeyCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inpMinKeyCount.Name = "inpMinKeyCount";
            inpMinKeyCount.Size = new Size(36, 23);
            inpMinKeyCount.TabIndex = 10;
            inpMinKeyCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // inpMaxKeyCount
            // 
            inpMaxKeyCount.Location = new Point(160, 32);
            inpMaxKeyCount.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            inpMaxKeyCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            inpMaxKeyCount.Name = "inpMaxKeyCount";
            inpMaxKeyCount.Size = new Size(36, 23);
            inpMaxKeyCount.TabIndex = 11;
            inpMaxKeyCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // inpBiggestNumber
            // 
            inpBiggestNumber.Location = new Point(160, 56);
            inpBiggestNumber.Maximum = new decimal(new int[] { 36, 0, 0, 0 });
            inpBiggestNumber.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            inpBiggestNumber.Name = "inpBiggestNumber";
            inpBiggestNumber.Size = new Size(36, 23);
            inpBiggestNumber.TabIndex = 12;
            inpBiggestNumber.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // settingsWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 252, 252);
            ClientSize = new Size(286, 146);
            Controls.Add(inpBiggestNumber);
            Controls.Add(inpMaxKeyCount);
            Controls.Add(inpMinKeyCount);
            Controls.Add(settingsCancel);
            Controls.Add(settingsApply);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(parammaxKeyCount);
            Controls.Add(paramminKeyCount);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "settingsWindow";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)inpMinKeyCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)inpMaxKeyCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)inpBiggestNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label paramminKeyCount;
        private Label parammaxKeyCount;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button settingsApply;
        private Button settingsCancel;
        internal NumericUpDown inpMinKeyCount;
        internal NumericUpDown inpMaxKeyCount;
        internal NumericUpDown inpBiggestNumber;
    }
}