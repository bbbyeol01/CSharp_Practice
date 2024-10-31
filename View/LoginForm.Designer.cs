namespace POS_build.View
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
            this.Txt_inputId = new System.Windows.Forms.TextBox();
            this.Txt_inputPwd = new System.Windows.Forms.TextBox();
            this.Btn_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_inputId
            // 
            this.Txt_inputId.Location = new System.Drawing.Point(122, 138);
            this.Txt_inputId.Name = "Txt_inputId";
            this.Txt_inputId.Size = new System.Drawing.Size(197, 21);
            this.Txt_inputId.TabIndex = 0;
            // 
            // Txt_inputPwd
            // 
            this.Txt_inputPwd.Location = new System.Drawing.Point(122, 165);
            this.Txt_inputPwd.Name = "Txt_inputPwd";
            this.Txt_inputPwd.Size = new System.Drawing.Size(197, 21);
            this.Txt_inputPwd.TabIndex = 1;
            // 
            // Btn_login
            // 
            this.Btn_login.Location = new System.Drawing.Point(122, 192);
            this.Btn_login.Name = "Btn_login";
            this.Btn_login.Size = new System.Drawing.Size(197, 46);
            this.Btn_login.TabIndex = 2;
            this.Btn_login.Text = "로그인";
            this.Btn_login.UseVisualStyleBackColor = true;
            this.Btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard Variable", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(180, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_login);
            this.Controls.Add(this.Txt_inputPwd);
            this.Controls.Add(this.Txt_inputId);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_inputId;
        private System.Windows.Forms.TextBox Txt_inputPwd;
        private System.Windows.Forms.Button Btn_login;
        private System.Windows.Forms.Label label1;
    }
}