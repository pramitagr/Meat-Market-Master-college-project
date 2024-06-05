namespace SmartFreshHouse
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.FullNameText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegisterUserBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FullNameText
            // 
            this.FullNameText.Location = new System.Drawing.Point(137, 117);
            this.FullNameText.Margin = new System.Windows.Forms.Padding(4);
            this.FullNameText.Name = "FullNameText";
            this.FullNameText.Size = new System.Drawing.Size(240, 22);
            this.FullNameText.TabIndex = 0;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(137, 165);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(240, 22);
            this.EmailText.TabIndex = 1;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(137, 210);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(240, 22);
            this.PasswordText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // RegisterUserBtn
            // 
            this.RegisterUserBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.RegisterUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterUserBtn.FlatAppearance.BorderSize = 0;
            this.RegisterUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterUserBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.RegisterUserBtn.Location = new System.Drawing.Point(137, 262);
            this.RegisterUserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RegisterUserBtn.Name = "RegisterUserBtn";
            this.RegisterUserBtn.Size = new System.Drawing.Size(100, 28);
            this.RegisterUserBtn.TabIndex = 3;
            this.RegisterUserBtn.Text = "Register";
            this.RegisterUserBtn.UseVisualStyleBackColor = false;
            this.RegisterUserBtn.Click += new System.EventHandler(this.RegisterUserBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(13)))), ((int)(((byte)(10)))));
            this.pictureBox1.Image = global::SmartFreshHouse.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RegisterUserBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.FullNameText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FullNameText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RegisterUserBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}