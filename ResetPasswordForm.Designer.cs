namespace SmartFreshHouse
{
    partial class ResetPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetPasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.UserEmailText = new System.Windows.Forms.TextBox();
            this.SendPasswordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your registered email below";
            // 
            // UserEmailText
            // 
            this.UserEmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmailText.Location = new System.Drawing.Point(36, 67);
            this.UserEmailText.Name = "UserEmailText";
            this.UserEmailText.Size = new System.Drawing.Size(281, 22);
            this.UserEmailText.TabIndex = 1;
            // 
            // SendPasswordBtn
            // 
            this.SendPasswordBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.SendPasswordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendPasswordBtn.FlatAppearance.BorderSize = 0;
            this.SendPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendPasswordBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SendPasswordBtn.Location = new System.Drawing.Point(36, 105);
            this.SendPasswordBtn.Name = "SendPasswordBtn";
            this.SendPasswordBtn.Size = new System.Drawing.Size(110, 27);
            this.SendPasswordBtn.TabIndex = 2;
            this.SendPasswordBtn.Text = "Submit";
            this.SendPasswordBtn.UseVisualStyleBackColor = false;
            this.SendPasswordBtn.Click += new System.EventHandler(this.SendPasswordBtn_Click);
            // 
            // ResetPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 172);
            this.Controls.Add(this.SendPasswordBtn);
            this.Controls.Add(this.UserEmailText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResetPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset your password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserEmailText;
        private System.Windows.Forms.Button SendPasswordBtn;
    }
}