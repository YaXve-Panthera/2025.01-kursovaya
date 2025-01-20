namespace MemoryGame
{
    partial class NewGameForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LvlTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HSizeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.VSizeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(76, 231);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horizontal Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vertical size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Time to memorize (sec)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start level";
            // 
            // LvlTextBox
            // 
            this.LvlTextBox.Location = new System.Drawing.Point(63, 57);
            this.LvlTextBox.Mask = "0000";
            this.LvlTextBox.Name = "LvlTextBox";
            this.LvlTextBox.Size = new System.Drawing.Size(100, 22);
            this.LvlTextBox.TabIndex = 11;
            this.LvlTextBox.TextChanged += new System.EventHandler(this.LvlTextBox_TextChanged);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(63, 101);
            this.TimeTextBox.Mask = "0000";
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.TimeTextBox.TabIndex = 12;
            this.TimeTextBox.TextChanged += new System.EventHandler(this.TimeTextBox_TextChanged);
            // 
            // HSizeTextBox
            // 
            this.HSizeTextBox.Location = new System.Drawing.Point(63, 145);
            this.HSizeTextBox.Mask = "0000";
            this.HSizeTextBox.Name = "HSizeTextBox";
            this.HSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.HSizeTextBox.TabIndex = 13;
            this.HSizeTextBox.TextChanged += new System.EventHandler(this.HSizeTextBox_TextChanged);
            // 
            // VSizeTextBox
            // 
            this.VSizeTextBox.Location = new System.Drawing.Point(63, 189);
            this.VSizeTextBox.Mask = "0000";
            this.VSizeTextBox.Name = "VSizeTextBox";
            this.VSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.VSizeTextBox.TabIndex = 14;
            this.VSizeTextBox.ValidatingType = typeof(int);
            this.VSizeTextBox.TextChanged += new System.EventHandler(this.VSizeTextBox_TextChanged);
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 303);
            this.Controls.Add(this.VSizeTextBox);
            this.Controls.Add(this.HSizeTextBox);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.LvlTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartButton);
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewTestForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox LvlTextBox;
        private System.Windows.Forms.MaskedTextBox TimeTextBox;
        private System.Windows.Forms.MaskedTextBox HSizeTextBox;
        private System.Windows.Forms.MaskedTextBox VSizeTextBox;
    }
}