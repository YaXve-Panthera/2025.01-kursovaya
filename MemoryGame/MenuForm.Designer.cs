namespace MemoryGame
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewTestButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewTestButton
            // 
            this.NewTestButton.CausesValidation = false;
            this.NewTestButton.Location = new System.Drawing.Point(50, 69);
            this.NewTestButton.Name = "NewTestButton";
            this.NewTestButton.Size = new System.Drawing.Size(118, 44);
            this.NewTestButton.TabIndex = 0;
            this.NewTestButton.Text = "New test";
            this.NewTestButton.UseVisualStyleBackColor = true;
            this.NewTestButton.Click += new System.EventHandler(this.NewTestButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(50, 211);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(118, 44);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.Location = new System.Drawing.Point(50, 144);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Size = new System.Drawing.Size(118, 44);
            this.StatisticsButton.TabIndex = 4;
            this.StatisticsButton.Text = "Statistics";
            this.StatisticsButton.UseVisualStyleBackColor = true;
            this.StatisticsButton.Click += new System.EventHandler(this.StatisticsButton_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 303);
            this.Controls.Add(this.StatisticsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.NewTestButton);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewTestButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StatisticsButton;
    }
}

