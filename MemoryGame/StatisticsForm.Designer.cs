namespace MemoryGame
{
    partial class StatisticsForm
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
            this.StatisticsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StatisticsDataGridView
            // 
            this.StatisticsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatisticsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.StatisticsDataGridView.Name = "StatisticsDataGridView";
            this.StatisticsDataGridView.RowHeadersWidth = 51;
            this.StatisticsDataGridView.RowTemplate.Height = 24;
            this.StatisticsDataGridView.Size = new System.Drawing.Size(776, 426);
            this.StatisticsDataGridView.TabIndex = 0;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatisticsDataGridView);
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StatisticsForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.StatisticsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StatisticsDataGridView;
    }
}