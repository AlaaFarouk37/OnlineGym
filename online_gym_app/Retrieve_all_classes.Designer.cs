namespace online_gym_app
{
    partial class Retrieve_all_classes
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
            this.classes_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.classes_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classes_dataGridView
            // 
            this.classes_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classes_dataGridView.Location = new System.Drawing.Point(12, -4);
            this.classes_dataGridView.Name = "classes_dataGridView";
            this.classes_dataGridView.RowTemplate.Height = 24;
            this.classes_dataGridView.Size = new System.Drawing.Size(763, 557);
            this.classes_dataGridView.TabIndex = 0;
            // 
            // Retrieve_all_classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 609);
            this.Controls.Add(this.classes_dataGridView);
            this.Name = "Retrieve_all_classes";
            this.Text = "Retrieve_all_classes";
            ((System.ComponentModel.ISupportInitialize)(this.classes_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView classes_dataGridView;
    }
}