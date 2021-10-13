namespace Lab1_silnik_krokowy
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonSOneLeftOne = new System.Windows.Forms.Button();
            this.buttonSTwoLeftOne = new System.Windows.Forms.Button();
            this.buttonSOneRightOne = new System.Windows.Forms.Button();
            this.buttonSTwoRightOne = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.numericUpDownSteps = new System.Windows.Forms.NumericUpDown();
            this.labelSteps = new System.Windows.Forms.Label();
            this.buttonMOneRightN = new System.Windows.Forms.Button();
            this.buttonMOneLeftN = new System.Windows.Forms.Button();
            this.buttonMTwoRightN = new System.Windows.Forms.Button();
            this.buttonMTwoLeftN = new System.Windows.Forms.Button();
            this.buttonDance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.AccessibleDescription = "";
            this.buttonConnect.Location = new System.Drawing.Point(61, 49);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(193, 51);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(61, 203);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(193, 230);
            this.richTextBoxOutput.TabIndex = 1;
            this.richTextBoxOutput.Text = "";
            // 
            // buttonSOneLeftOne
            // 
            this.buttonSOneLeftOne.Location = new System.Drawing.Point(274, 49);
            this.buttonSOneLeftOne.Name = "buttonSOneLeftOne";
            this.buttonSOneLeftOne.Size = new System.Drawing.Size(98, 23);
            this.buttonSOneLeftOne.TabIndex = 2;
            this.buttonSOneLeftOne.Text = "S1 1 step left";
            this.buttonSOneLeftOne.UseVisualStyleBackColor = true;
            this.buttonSOneLeftOne.Click += new System.EventHandler(this.buttonSOneLeftOne_Click);
            // 
            // buttonSTwoLeftOne
            // 
            this.buttonSTwoLeftOne.Location = new System.Drawing.Point(274, 104);
            this.buttonSTwoLeftOne.Name = "buttonSTwoLeftOne";
            this.buttonSTwoLeftOne.Size = new System.Drawing.Size(98, 23);
            this.buttonSTwoLeftOne.TabIndex = 3;
            this.buttonSTwoLeftOne.Text = "S2 1 steps left";
            this.buttonSTwoLeftOne.UseVisualStyleBackColor = true;
            this.buttonSTwoLeftOne.Click += new System.EventHandler(this.buttonSTwoLeftOne_Click);
            // 
            // buttonSOneRightOne
            // 
            this.buttonSOneRightOne.Location = new System.Drawing.Point(391, 49);
            this.buttonSOneRightOne.Name = "buttonSOneRightOne";
            this.buttonSOneRightOne.Size = new System.Drawing.Size(98, 23);
            this.buttonSOneRightOne.TabIndex = 4;
            this.buttonSOneRightOne.Text = "S1 1 step right";
            this.buttonSOneRightOne.UseVisualStyleBackColor = true;
            this.buttonSOneRightOne.Click += new System.EventHandler(this.buttonSOneRightOne_Click);
            // 
            // buttonSTwoRightOne
            // 
            this.buttonSTwoRightOne.Location = new System.Drawing.Point(391, 104);
            this.buttonSTwoRightOne.Name = "buttonSTwoRightOne";
            this.buttonSTwoRightOne.Size = new System.Drawing.Size(98, 23);
            this.buttonSTwoRightOne.TabIndex = 5;
            this.buttonSTwoRightOne.Text = "S2 1 step right";
            this.buttonSTwoRightOne.UseVisualStyleBackColor = true;
            this.buttonSTwoRightOne.Click += new System.EventHandler(this.buttonSTwoRightOne_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.AccessibleDescription = "";
            this.buttonDisconnect.Location = new System.Drawing.Point(61, 130);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(193, 51);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.DecimalPlaces = 2;
            this.numericUpDownSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSpeed.Location = new System.Drawing.Point(391, 413);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(98, 20);
            this.numericUpDownSpeed.TabIndex = 7;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(337, 415);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "Speed";
            // 
            // numericUpDownSteps
            // 
            this.numericUpDownSteps.Location = new System.Drawing.Point(391, 387);
            this.numericUpDownSteps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSteps.Name = "numericUpDownSteps";
            this.numericUpDownSteps.Size = new System.Drawing.Size(98, 20);
            this.numericUpDownSteps.TabIndex = 9;
            this.numericUpDownSteps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(337, 394);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(34, 13);
            this.labelSteps.TabIndex = 10;
            this.labelSteps.Text = "Steps";
            // 
            // buttonMOneRightN
            // 
            this.buttonMOneRightN.Location = new System.Drawing.Point(391, 158);
            this.buttonMOneRightN.Name = "buttonMOneRightN";
            this.buttonMOneRightN.Size = new System.Drawing.Size(98, 23);
            this.buttonMOneRightN.TabIndex = 12;
            this.buttonMOneRightN.Text = "M1 n steps right";
            this.buttonMOneRightN.UseVisualStyleBackColor = true;
            this.buttonMOneRightN.Click += new System.EventHandler(this.buttonMOneRightN_Click);
            // 
            // buttonMOneLeftN
            // 
            this.buttonMOneLeftN.Location = new System.Drawing.Point(274, 158);
            this.buttonMOneLeftN.Name = "buttonMOneLeftN";
            this.buttonMOneLeftN.Size = new System.Drawing.Size(98, 23);
            this.buttonMOneLeftN.TabIndex = 11;
            this.buttonMOneLeftN.Text = "M1 n steps left";
            this.buttonMOneLeftN.UseVisualStyleBackColor = true;
            this.buttonMOneLeftN.Click += new System.EventHandler(this.buttonMOneLeftN_Click);
            // 
            // buttonMTwoRightN
            // 
            this.buttonMTwoRightN.Location = new System.Drawing.Point(391, 215);
            this.buttonMTwoRightN.Name = "buttonMTwoRightN";
            this.buttonMTwoRightN.Size = new System.Drawing.Size(98, 23);
            this.buttonMTwoRightN.TabIndex = 14;
            this.buttonMTwoRightN.Text = "M2 n steps right";
            this.buttonMTwoRightN.UseVisualStyleBackColor = true;
            this.buttonMTwoRightN.Click += new System.EventHandler(this.buttonMTwoRightN_Click);
            // 
            // buttonMTwoLeftN
            // 
            this.buttonMTwoLeftN.Location = new System.Drawing.Point(274, 215);
            this.buttonMTwoLeftN.Name = "buttonMTwoLeftN";
            this.buttonMTwoLeftN.Size = new System.Drawing.Size(98, 23);
            this.buttonMTwoLeftN.TabIndex = 13;
            this.buttonMTwoLeftN.Text = "M2 n steps left";
            this.buttonMTwoLeftN.UseVisualStyleBackColor = true;
            this.buttonMTwoLeftN.Click += new System.EventHandler(this.buttonMTwoLeftN_Click);
            // 
            // buttonDance
            // 
            this.buttonDance.Location = new System.Drawing.Point(274, 294);
            this.buttonDance.Name = "buttonDance";
            this.buttonDance.Size = new System.Drawing.Size(206, 29);
            this.buttonDance.TabIndex = 15;
            this.buttonDance.Text = "Dance";
            this.buttonDance.UseVisualStyleBackColor = true;
            this.buttonDance.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 482);
            this.Controls.Add(this.buttonDance);
            this.Controls.Add(this.buttonMTwoRightN);
            this.Controls.Add(this.buttonMTwoLeftN);
            this.Controls.Add(this.buttonMOneRightN);
            this.Controls.Add(this.buttonMOneLeftN);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.numericUpDownSteps);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.numericUpDownSpeed);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonSTwoRightOne);
            this.Controls.Add(this.buttonSOneRightOne);
            this.Controls.Add(this.buttonSTwoLeftOne);
            this.Controls.Add(this.buttonSOneLeftOne);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.buttonConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSteps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonSOneLeftOne;
        private System.Windows.Forms.Button buttonSTwoLeftOne;
        private System.Windows.Forms.Button buttonSOneRightOne;
        private System.Windows.Forms.Button buttonSTwoRightOne;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownSteps;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Button buttonMOneRightN;
        private System.Windows.Forms.Button buttonMOneLeftN;
        private System.Windows.Forms.Button buttonMTwoRightN;
        private System.Windows.Forms.Button buttonMTwoLeftN;
        private System.Windows.Forms.Button buttonDance;
    }
}

