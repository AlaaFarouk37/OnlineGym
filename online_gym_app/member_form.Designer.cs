namespace online_gym_app
{
    partial class member_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(member_form));
            this.label1 = new System.Windows.Forms.Label();
            this.view_coaches_btn = new System.Windows.Forms.Button();
            this.book_coach_btn = new System.Windows.Forms.Button();
            this.review_coach_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(456, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // view_coaches_btn
            // 
            this.view_coaches_btn.BackColor = System.Drawing.Color.Transparent;
            this.view_coaches_btn.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_coaches_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.view_coaches_btn.Location = new System.Drawing.Point(630, 334);
            this.view_coaches_btn.Name = "view_coaches_btn";
            this.view_coaches_btn.Size = new System.Drawing.Size(264, 53);
            this.view_coaches_btn.TabIndex = 3;
            this.view_coaches_btn.Text = "View Coaches";
            this.view_coaches_btn.UseVisualStyleBackColor = false;
            this.view_coaches_btn.Click += new System.EventHandler(this.view_coaches_btn_Click);
            // 
            // book_coach_btn
            // 
            this.book_coach_btn.BackColor = System.Drawing.Color.Transparent;
            this.book_coach_btn.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_coach_btn.ForeColor = System.Drawing.Color.Magenta;
            this.book_coach_btn.Location = new System.Drawing.Point(630, 422);
            this.book_coach_btn.Name = "book_coach_btn";
            this.book_coach_btn.Size = new System.Drawing.Size(264, 59);
            this.book_coach_btn.TabIndex = 4;
            this.book_coach_btn.Text = "Book with a coach";
            this.book_coach_btn.UseVisualStyleBackColor = false;
            this.book_coach_btn.Click += new System.EventHandler(this.book_coach_btn_Click);
            // 
            // review_coach_btn
            // 
            this.review_coach_btn.BackColor = System.Drawing.Color.Transparent;
            this.review_coach_btn.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_coach_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.review_coach_btn.Location = new System.Drawing.Point(630, 240);
            this.review_coach_btn.Name = "review_coach_btn";
            this.review_coach_btn.Size = new System.Drawing.Size(264, 53);
            this.review_coach_btn.TabIndex = 5;
            this.review_coach_btn.Text = "Review Coach";
            this.review_coach_btn.UseVisualStyleBackColor = false;
            this.review_coach_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // member_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1030, 512);
            this.Controls.Add(this.review_coach_btn);
            this.Controls.Add(this.book_coach_btn);
            this.Controls.Add(this.view_coaches_btn);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "member_form";
            this.Text = "member_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button view_coaches_btn;
        private System.Windows.Forms.Button book_coach_btn;
        private System.Windows.Forms.Button review_coach_btn;
    }
}