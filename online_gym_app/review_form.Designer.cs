namespace online_gym_app
{
    partial class review_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(review_form));
            this.cust_id_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rating_textBox = new System.Windows.Forms.TextBox();
            this.comments_textBox = new System.Windows.Forms.TextBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.coach_id_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cust_id_textbox
            // 
            this.cust_id_textbox.Location = new System.Drawing.Point(400, 140);
            this.cust_id_textbox.Name = "cust_id_textbox";
            this.cust_id_textbox.Size = new System.Drawing.Size(100, 22);
            this.cust_id_textbox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(191, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 27);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enter Your ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rating (out of 5)";
            // 
            // rating_textBox
            // 
            this.rating_textBox.Location = new System.Drawing.Point(400, 370);
            this.rating_textBox.Name = "rating_textBox";
            this.rating_textBox.Size = new System.Drawing.Size(100, 22);
            this.rating_textBox.TabIndex = 18;
            // 
            // comments_textBox
            // 
            this.comments_textBox.Location = new System.Drawing.Point(196, 287);
            this.comments_textBox.Name = "comments_textBox";
            this.comments_textBox.Size = new System.Drawing.Size(340, 22);
            this.comments_textBox.TabIndex = 17;
            // 
            // submit_btn
            // 
            this.submit_btn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.submit_btn.Location = new System.Drawing.Point(321, 443);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(109, 38);
            this.submit_btn.TabIndex = 16;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Any comments?";
            // 
            // coach_id_textBox
            // 
            this.coach_id_textBox.Location = new System.Drawing.Point(400, 190);
            this.coach_id_textBox.Name = "coach_id_textBox";
            this.coach_id_textBox.Size = new System.Drawing.Size(100, 22);
            this.coach_id_textBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(191, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter coach ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(114, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 45);
            this.label1.TabIndex = 12;
            this.label1.Text = "Let us know how you think !";
            // 
            // review_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 529);
            this.Controls.Add(this.cust_id_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rating_textBox);
            this.Controls.Add(this.comments_textBox);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coach_id_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "review_form";
            this.Text = "review_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cust_id_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rating_textBox;
        private System.Windows.Forms.TextBox comments_textBox;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox coach_id_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}