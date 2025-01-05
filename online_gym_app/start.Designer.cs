namespace online_gym_app
{
    partial class start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(start));
            this.admin_btn = new System.Windows.Forms.Button();
            this.member_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guest_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.Color.Firebrick;
            this.admin_btn.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.ForeColor = System.Drawing.Color.LightCoral;
            this.admin_btn.Location = new System.Drawing.Point(80, 191);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(177, 62);
            this.admin_btn.TabIndex = 0;
            this.admin_btn.Text = "Admin";
            this.admin_btn.UseVisualStyleBackColor = false;
            // 
            // member_btn
            // 
            this.member_btn.BackColor = System.Drawing.Color.Firebrick;
            this.member_btn.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.member_btn.ForeColor = System.Drawing.Color.LightCoral;
            this.member_btn.Location = new System.Drawing.Point(80, 275);
            this.member_btn.Name = "member_btn";
            this.member_btn.Size = new System.Drawing.Size(177, 66);
            this.member_btn.TabIndex = 4;
            this.member_btn.Text = "Member";
            this.member_btn.UseVisualStyleBackColor = false;
            this.member_btn.Click += new System.EventHandler(this.member_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(78, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 70);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose one of the following:";
            // 
            // guest_btn
            // 
            this.guest_btn.BackColor = System.Drawing.Color.Firebrick;
            this.guest_btn.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guest_btn.ForeColor = System.Drawing.Color.LightCoral;
            this.guest_btn.Location = new System.Drawing.Point(80, 374);
            this.guest_btn.Name = "guest_btn";
            this.guest_btn.Size = new System.Drawing.Size(177, 66);
            this.guest_btn.TabIndex = 6;
            this.guest_btn.Text = "Guest";
            this.guest_btn.UseVisualStyleBackColor = false;
            this.guest_btn.Click += new System.EventHandler(this.guest_btn_Click);
            // 
            // start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 516);
            this.Controls.Add(this.guest_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.member_btn);
            this.Controls.Add(this.admin_btn);
            this.Name = "start";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_btn;
        private System.Windows.Forms.Button member_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button guest_btn;
    }
}

