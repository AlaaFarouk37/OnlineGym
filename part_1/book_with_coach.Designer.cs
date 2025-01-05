namespace online_gym_app
{
    partial class book_with_coach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_with_coach));
            this.timetable_textBox = new System.Windows.Forms.TextBox();
            this.cust_textBox = new System.Windows.Forms.TextBox();
            this.coach_textBox = new System.Windows.Forms.TextBox();
            this.book_coach_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timetable_textBox
            // 
            this.timetable_textBox.Location = new System.Drawing.Point(314, 294);
            this.timetable_textBox.Name = "timetable_textBox";
            this.timetable_textBox.Size = new System.Drawing.Size(100, 22);
            this.timetable_textBox.TabIndex = 0;
            // 
            // cust_textBox
            // 
            this.cust_textBox.Location = new System.Drawing.Point(314, 364);
            this.cust_textBox.Name = "cust_textBox";
            this.cust_textBox.Size = new System.Drawing.Size(100, 22);
            this.cust_textBox.TabIndex = 1;
            this.cust_textBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // coach_textBox
            // 
            this.coach_textBox.Location = new System.Drawing.Point(314, 219);
            this.coach_textBox.Name = "coach_textBox";
            this.coach_textBox.Size = new System.Drawing.Size(100, 22);
            this.coach_textBox.TabIndex = 2;
            // 
            // book_coach_btn
            // 
            this.book_coach_btn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.book_coach_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_coach_btn.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.book_coach_btn.Location = new System.Drawing.Point(188, 429);
            this.book_coach_btn.Name = "book_coach_btn";
            this.book_coach_btn.Size = new System.Drawing.Size(100, 51);
            this.book_coach_btn.TabIndex = 3;
            this.book_coach_btn.Text = "Book";
            this.book_coach_btn.UseVisualStyleBackColor = false;
            this.book_coach_btn.Click += new System.EventHandler(this.book_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(30, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Coach ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(30, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter your ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(30, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter TimeTable ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(566, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book with our best-trained Coaches !";
            // 
            // book_with_coach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 519);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book_coach_btn);
            this.Controls.Add(this.coach_textBox);
            this.Controls.Add(this.cust_textBox);
            this.Controls.Add(this.timetable_textBox);
            this.Name = "book_with_coach";
            this.Text = "book_with_coach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timetable_textBox;
        private System.Windows.Forms.TextBox cust_textBox;
        private System.Windows.Forms.TextBox coach_textBox;
        private System.Windows.Forms.Button book_coach_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}