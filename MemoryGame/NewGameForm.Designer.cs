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
            this.HSizeTextBox = new System.Windows.Forms.TextBox();
            this.VSizeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(359, 366);
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
            this.label2.Location = new System.Drawing.Point(350, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Horizontal Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vertical size";
            // 
            // HSizeTextBox
            // 
            this.HSizeTextBox.Location = new System.Drawing.Point(346, 207);
            this.HSizeTextBox.Name = "HSizeTextBox";
            this.HSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.HSizeTextBox.TabIndex = 5;
            this.HSizeTextBox.TextChanged += new System.EventHandler(this.HSizeTextBox_TextChanged);
            this.HSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HSizeTextBox_KeyPress);
            // 
            // VSizeTextBox
            // 
            this.VSizeTextBox.Location = new System.Drawing.Point(346, 311);
            this.VSizeTextBox.Name = "VSizeTextBox";
            this.VSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.VSizeTextBox.TabIndex = 6;
            this.VSizeTextBox.TextChanged += new System.EventHandler(this.VSizeTextBox_TextChanged);
            this.VSizeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VSizeTextBox_KeyPress);
            // 
            // NewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VSizeTextBox);
            this.Controls.Add(this.HSizeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartButton);
            this.Name = "NewTestForm";
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
        private System.Windows.Forms.TextBox HSizeTextBox;
        private System.Windows.Forms.TextBox VSizeTextBox;
    }
}