namespace online_gym_app
{
    partial class book_a_class
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_a_class));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.class_id_textbox = new System.Windows.Forms.TextBox();
            this.weekday_textbox = new System.Windows.Forms.TextBox();
            this.book_btn = new System.Windows.Forms.Button();
            this.cash_rb = new System.Windows.Forms.RadioButton();
            this.card_rb = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cust_id_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(72, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Class ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(72, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Weekday:";
            // 
            // class_id_textbox
            // 
            this.class_id_textbox.Location = new System.Drawing.Point(275, 31);
            this.class_id_textbox.Multiline = true;
            this.class_id_textbox.Name = "class_id_textbox";
            this.class_id_textbox.Size = new System.Drawing.Size(166, 35);
            this.class_id_textbox.TabIndex = 2;
            // 
            // weekday_textbox
            // 
            this.weekday_textbox.Location = new System.Drawing.Point(281, 92);
            this.weekday_textbox.Multiline = true;
            this.weekday_textbox.Name = "weekday_textbox";
            this.weekday_textbox.Size = new System.Drawing.Size(166, 38);
            this.weekday_textbox.TabIndex = 3;
            // 
            // book_btn
            // 
            this.book_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.book_btn.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.book_btn.Location = new System.Drawing.Point(226, 357);
            this.book_btn.Name = "book_btn";
            this.book_btn.Size = new System.Drawing.Size(135, 53);
            this.book_btn.TabIndex = 4;
            this.book_btn.Text = "Book";
            this.book_btn.UseVisualStyleBackColor = false;
            this.book_btn.Click += new System.EventHandler(this.book_btn_Click);
            // 
            // cash_rb
            // 
            this.cash_rb.AutoSize = true;
            this.cash_rb.Checked = true;
            this.cash_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_rb.ForeColor = System.Drawing.Color.Maroon;
            this.cash_rb.Location = new System.Drawing.Point(281, 276);
            this.cash_rb.Name = "cash_rb";
            this.cash_rb.Size = new System.Drawing.Size(80, 29);
            this.cash_rb.TabIndex = 10;
            this.cash_rb.TabStop = true;
            this.cash_rb.Text = "Cash";
            this.cash_rb.UseVisualStyleBackColor = true;
            // 
            // card_rb
            // 
            this.card_rb.AutoSize = true;
            this.card_rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.card_rb.ForeColor = System.Drawing.Color.Maroon;
            this.card_rb.Location = new System.Drawing.Point(116, 276);
            this.card_rb.Name = "card_rb";
            this.card_rb.Size = new System.Drawing.Size(99, 29);
            this.card_rb.TabIndex = 9;
            this.card_rb.Text = "By card";
            this.card_rb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(72, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose your preferred payment method";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(72, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Enter Your ID:";
            // 
            // cust_id_textBox
            // 
            this.cust_id_textBox.Location = new System.Drawing.Point(275, 162);
            this.cust_id_textBox.Multiline = true;
            this.cust_id_textBox.Name = "cust_id_textBox";
            this.cust_id_textBox.Size = new System.Drawing.Size(166, 38);
            this.cust_id_textBox.TabIndex = 11;
            // 
            // book_a_class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 514);
            this.Controls.Add(this.cust_id_textBox);
            this.Controls.Add(this.cash_rb);
            this.Controls.Add(this.card_rb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.book_btn);
            this.Controls.Add(this.weekday_textbox);
            this.Controls.Add(this.class_id_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "book_a_class";
            this.Text = "book_a_class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox class_id_textbox;
        private System.Windows.Forms.TextBox weekday_textbox;
        private System.Windows.Forms.Button book_btn;
        private System.Windows.Forms.RadioButton cash_rb;
        private System.Windows.Forms.RadioButton card_rb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cust_id_textBox;
    }
}