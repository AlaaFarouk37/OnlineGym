namespace online_gym_app
{
    partial class Guest_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_form));
            this.label1 = new System.Windows.Forms.Label();
            this.view_classes_btn = new System.Windows.Forms.Button();
            this.book_class_btn = new System.Windows.Forms.Button();
            this.review_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(318, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Try out our classes !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // view_classes_btn
            // 
            this.view_classes_btn.BackColor = System.Drawing.SystemColors.Control;
            this.view_classes_btn.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_classes_btn.ForeColor = System.Drawing.Color.Indigo;
            this.view_classes_btn.Location = new System.Drawing.Point(420, 188);
            this.view_classes_btn.Name = "view_classes_btn";
            this.view_classes_btn.Size = new System.Drawing.Size(209, 56);
            this.view_classes_btn.TabIndex = 2;
            this.view_classes_btn.Text = "View Classes";
            this.view_classes_btn.UseVisualStyleBackColor = false;
            this.view_classes_btn.Click += new System.EventHandler(this.view_classes_btn_Click);
            // 
            // book_class_btn
            // 
            this.book_class_btn.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_class_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.book_class_btn.Location = new System.Drawing.Point(420, 299);
            this.book_class_btn.Name = "book_class_btn";
            this.book_class_btn.Size = new System.Drawing.Size(209, 56);
            this.book_class_btn.TabIndex = 3;
            this.book_class_btn.Text = "Book a class";
            this.book_class_btn.UseVisualStyleBackColor = true;
            this.book_class_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // review_btn
            // 
            this.review_btn.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.review_btn.Location = new System.Drawing.Point(420, 417);
            this.review_btn.Name = "review_btn";
            this.review_btn.Size = new System.Drawing.Size(209, 56);
            this.review_btn.TabIndex = 4;
            this.review_btn.Text = "Review class";
            this.review_btn.UseVisualStyleBackColor = true;
            this.review_btn.Click += new System.EventHandler(this.review_btn_Click);
            // 
            // Guest_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1055, 514);
            this.Controls.Add(this.review_btn);
            this.Controls.Add(this.book_class_btn);
            this.Controls.Add(this.view_classes_btn);
            this.Controls.Add(this.label1);
            this.Name = "Guest_form";
            this.Text = "Guest_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_classes_btn;
        private System.Windows.Forms.Button book_class_btn;
        private System.Windows.Forms.Button review_btn;
    }
}