namespace Calculator
{
    partial class MainForm
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
            this.PlusButton = new System.Windows.Forms.Button();
            this.FirstNumberTextbox = new System.Windows.Forms.TextBox();
            this.SecondNumberTextbox = new System.Windows.Forms.TextBox();
            this.FirstNumberLabel = new System.Windows.Forms.Label();
            this.SecondNumberLabel = new System.Windows.Forms.Label();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlusButton
            // 
            this.PlusButton.Location = new System.Drawing.Point(61, 255);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(61, 35);
            this.PlusButton.TabIndex = 0;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // FirstNumberTextbox
            // 
            this.FirstNumberTextbox.Location = new System.Drawing.Point(107, 53);
            this.FirstNumberTextbox.Name = "FirstNumberTextbox";
            this.FirstNumberTextbox.Size = new System.Drawing.Size(98, 20);
            this.FirstNumberTextbox.TabIndex = 1;
            // 
            // SecondNumberTextbox
            // 
            this.SecondNumberTextbox.Location = new System.Drawing.Point(107, 94);
            this.SecondNumberTextbox.Name = "SecondNumberTextbox";
            this.SecondNumberTextbox.Size = new System.Drawing.Size(98, 20);
            this.SecondNumberTextbox.TabIndex = 2;
            // 
            // FirstNumberLabel
            // 
            this.FirstNumberLabel.AutoSize = true;
            this.FirstNumberLabel.Location = new System.Drawing.Point(11, 56);
            this.FirstNumberLabel.Name = "FirstNumberLabel";
            this.FirstNumberLabel.Size = new System.Drawing.Size(66, 13);
            this.FirstNumberLabel.TabIndex = 3;
            this.FirstNumberLabel.Text = "First Number";
            // 
            // SecondNumberLabel
            // 
            this.SecondNumberLabel.AutoSize = true;
            this.SecondNumberLabel.Location = new System.Drawing.Point(12, 97);
            this.SecondNumberLabel.Name = "SecondNumberLabel";
            this.SecondNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.SecondNumberLabel.TabIndex = 4;
            this.SecondNumberLabel.Text = "Second Number";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(128, 327);
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(77, 20);
            this.OutputTextbox.TabIndex = 5;
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(78, 330);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(39, 13);
            this.OutputLabel.TabIndex = 6;
            this.OutputLabel.Text = "Output";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "*";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(262, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.SecondNumberLabel);
            this.Controls.Add(this.FirstNumberLabel);
            this.Controls.Add(this.SecondNumberTextbox);
            this.Controls.Add(this.FirstNumberTextbox);
            this.Controls.Add(this.PlusButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.TextBox FirstNumberTextbox;
        private System.Windows.Forms.TextBox SecondNumberTextbox;
        private System.Windows.Forms.Label FirstNumberLabel;
        private System.Windows.Forms.Label SecondNumberLabel;
        private System.Windows.Forms.TextBox OutputTextbox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

