namespace SmartFreshHouse
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginEmailTextBox = new System.Windows.Forms.TextBox();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RgisterBtn = new System.Windows.Forms.Button();
            this.ResetPasswordBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // LoginEmailTextBox
            // 
            this.LoginEmailTextBox.Location = new System.Drawing.Point(151, 146);
            this.LoginEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginEmailTextBox.Name = "LoginEmailTextBox";
            this.LoginEmailTextBox.Size = new System.Drawing.Size(220, 22);
            this.LoginEmailTextBox.TabIndex = 1;
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(151, 194);
            this.LoginPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(220, 22);
            this.LoginPasswordTextBox.TabIndex = 2;
            this.LoginPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(13)))), ((int)(((byte)(10)))));
            this.LoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBtn.FlatAppearance.BorderSize = 0;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginBtn.Location = new System.Drawing.Point(151, 245);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(221, 32);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RgisterBtn
            // 
            this.RgisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RgisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RgisterBtn.Location = new System.Drawing.Point(65, 341);
            this.RgisterBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RgisterBtn.Name = "RgisterBtn";
            this.RgisterBtn.Size = new System.Drawing.Size(157, 32);
            this.RgisterBtn.TabIndex = 4;
            this.RgisterBtn.Text = "Create Account";
            this.RgisterBtn.UseVisualStyleBackColor = true;
            this.RgisterBtn.Click += new System.EventHandler(this.RgisterBtn_Click);
            // 
            // ResetPasswordBtn
            // 
            this.ResetPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetPasswordBtn.FlatAppearance.BorderSize = 0;
            this.ResetPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetPasswordBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ResetPasswordBtn.Location = new System.Drawing.Point(252, 341);
            this.ResetPasswordBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ResetPasswordBtn.Name = "ResetPasswordBtn";
            this.ResetPasswordBtn.Size = new System.Drawing.Size(165, 32);
            this.ResetPasswordBtn.TabIndex = 5;
            this.ResetPasswordBtn.Text = "Forgot Password?";
            this.ResetPasswordBtn.UseVisualStyleBackColor = true;
            this.ResetPasswordBtn.Click += new System.EventHandler(this.ResetPasswordBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(13)))), ((int)(((byte)(10)))));
            this.pictureBox2.Image = global::SmartFreshHouse.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(471, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 388);
            this.Controls.Add(this.ResetPasswordBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RgisterBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.LoginPasswordTextBox);
            this.Controls.Add(this.LoginEmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginEmailTextBox;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RgisterBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ResetPasswordBtn;
    }
}

