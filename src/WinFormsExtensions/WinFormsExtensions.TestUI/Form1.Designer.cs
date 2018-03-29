namespace WinFormsExtensions.TestUI
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
            this.testInputBoxButton = new System.Windows.Forms.Button();
            this.testLogTextBoxButton = new System.Windows.Forms.Button();
            this.logger = new System.Windows.Forms.LogTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testInputBoxButton
            // 
            this.testInputBoxButton.Location = new System.Drawing.Point(13, 13);
            this.testInputBoxButton.Name = "testInputBoxButton";
            this.testInputBoxButton.Size = new System.Drawing.Size(154, 39);
            this.testInputBoxButton.TabIndex = 0;
            this.testInputBoxButton.Text = "Test InputBox...";
            this.testInputBoxButton.UseVisualStyleBackColor = true;
            this.testInputBoxButton.Click += new System.EventHandler(this.testInputBoxButton_Click);
            // 
            // testLogTextBoxButton
            // 
            this.testLogTextBoxButton.Location = new System.Drawing.Point(12, 58);
            this.testLogTextBoxButton.Name = "testLogTextBoxButton";
            this.testLogTextBoxButton.Size = new System.Drawing.Size(154, 39);
            this.testLogTextBoxButton.TabIndex = 2;
            this.testLogTextBoxButton.Text = "Test LogTextBox";
            this.testLogTextBoxButton.UseVisualStyleBackColor = true;
            this.testLogTextBoxButton.Click += new System.EventHandler(this.testLogTextBoxButton_Click);
            // 
            // logger
            // 
            this.logger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logger.IndentText = "--";
            this.logger.Location = new System.Drawing.Point(174, 13);
            this.logger.Name = "logger";
            this.logger.Size = new System.Drawing.Size(620, 472);
            this.logger.TabIndex = 1;
            this.logger.TextColor = System.Drawing.Color.Black;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Test Invoke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 497);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.testLogTextBoxButton);
            this.Controls.Add(this.logger);
            this.Controls.Add(this.testInputBoxButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testInputBoxButton;
        private System.Windows.Forms.LogTextBox logger;
        private System.Windows.Forms.Button testLogTextBoxButton;
        private System.Windows.Forms.Button button1;
    }
}

