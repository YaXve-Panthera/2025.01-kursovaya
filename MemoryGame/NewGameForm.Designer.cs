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
            this.LvlNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.VSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.LvlNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VSizeNumericUpDown)).BeginInit();
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
            // LvlNumericUpDown
            // 
            this.LvlNumericUpDown.Location = new System.Drawing.Point(63, 57);
            this.LvlNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LvlNumericUpDown.Name = "LvlNumericUpDown";
            this.LvlNumericUpDown.Size = new System.Drawing.Size(98, 22);
            this.LvlNumericUpDown.TabIndex = 15;
            this.LvlNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TimeNumericUpDown
            // 
            this.TimeNumericUpDown.Location = new System.Drawing.Point(63, 101);
            this.TimeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeNumericUpDown.Name = "TimeNumericUpDown";
            this.TimeNumericUpDown.Size = new System.Drawing.Size(98, 22);
            this.TimeNumericUpDown.TabIndex = 16;
            this.TimeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HSizeNumericUpDown
            // 
            this.HSizeNumericUpDown.Location = new System.Drawing.Point(63, 145);
            this.HSizeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.HSizeNumericUpDown.Name = "HSizeNumericUpDown";
            this.HSizeNumericUpDown.Size = new System.Drawing.Size(98, 22);
            this.HSizeNumericUpDown.TabIndex = 17;
            this.HSizeNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // VSizeNumericUpDown
            // 
            this.VSizeNumericUpDown.Location = new System.Drawing.Point(63, 189);
            this.VSizeNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.VSizeNumericUpDown.Name = "VSizeNumericUpDown";
            this.VSizeNumericUpDown.Size = new System.Drawing.Size(98, 22);
            this.VSizeNumericUpDown.TabIndex = 18;
            this.VSizeNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 303);
            this.Controls.Add(this.VSizeNumericUpDown);
            this.Controls.Add(this.HSizeNumericUpDown);
            this.Controls.Add(this.TimeNumericUpDown);
            this.Controls.Add(this.LvlNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartButton);
            this.Name = "NewGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Test";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewTestForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.LvlNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VSizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown LvlNumericUpDown;
        private System.Windows.Forms.NumericUpDown TimeNumericUpDown;
        private System.Windows.Forms.NumericUpDown HSizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown VSizeNumericUpDown;
    }
}