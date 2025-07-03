
namespace LaksideEscapesBookingSystem
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbLogin = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblLoginSubmit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLogin.Location = new System.Drawing.Point(180, 93);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(100, 23);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPassword.Location = new System.Drawing.Point(183, 150);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 23);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbLogin
            // 
            this.txtbLogin.Location = new System.Drawing.Point(341, 95);
            this.txtbLogin.Name = "txtbLogin";
            this.txtbLogin.Size = new System.Drawing.Size(100, 20);
            this.txtbLogin.TabIndex = 2;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(341, 152);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbPassword.TabIndex = 3;
            // 
            // lblLoginSubmit
            // 
            this.lblLoginSubmit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLoginSubmit.Location = new System.Drawing.Point(306, 265);
            this.lblLoginSubmit.Name = "lblLoginSubmit";
            this.lblLoginSubmit.Size = new System.Drawing.Size(100, 23);
            this.lblLoginSubmit.TabIndex = 4;
            this.lblLoginSubmit.Text = "Submit";
            this.lblLoginSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLoginSubmit.Click += new System.EventHandler(this.lblLoginSubmit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLoginSubmit);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbLogin;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblLoginSubmit;
    }
}