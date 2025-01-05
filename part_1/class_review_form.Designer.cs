namespace online_gym_app
{
    partial class class_review_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(class_review_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.class_id_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.comments_textBox = new System.Windows.Forms.TextBox();
            this.rating_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cust_id_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm your Booking, Reserve Your Place !";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter class ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // class_id_textBox
            // 
            this.class_id_textBox.Location = new System.Drawing.Point(543, 200);
            this.class_id_textBox.Name = "class_id_textBox";
            this.class_id_textBox.Size = new System.Drawing.Size(100, 22);
            this.class_id_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Any comments?";
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.submit_btn.Location = new System.Drawing.Point(466, 466);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(109, 38);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // comments_textBox
            // 
            this.comments_textBox.Location = new System.Drawing.Point(339, 297);
            this.comments_textBox.Name = "comments_textBox";
            this.comments_textBox.Size = new System.Drawing.Size(340, 22);
            this.comments_textBox.TabIndex = 7;
            // 
            // rating_textBox
            // 
            this.rating_textBox.Location = new System.Drawing.Point(543, 380);
            this.rating_textBox.Name = "rating_textBox";
            this.rating_textBox.Size = new System.Drawing.Size(100, 22);
            this.rating_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rating (out of 5)";
            // 
            // cust_id_textbox
            // 
            this.cust_id_textbox.Location = new System.Drawing.Point(543, 150);
            this.cust_id_textbox.Name = "cust_id_textbox";
            this.cust_id_textbox.Size = new System.Drawing.Size(100, 22);
            this.cust_id_textbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Enter Your ID:";
            // 
            // class_review_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(829, 561);
            this.Controls.Add(this.cust_id_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rating_textBox);
            this.Controls.Add(this.comments_textBox);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.class_id_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "class_review_form";
            this.Text = "class_payment_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox class_id_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox comments_textBox;
        private System.Windows.Forms.TextBox rating_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cust_id_textbox;
        private System.Windows.Forms.Label label5;
    }
}