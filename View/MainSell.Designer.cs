namespace POS_build
{
    partial class MainSell
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.Btn_coffee = new System.Windows.Forms.Button();
            this.btn_nonCoffee = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_teaAndAde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // Btn_coffee
            // 
            this.Btn_coffee.Location = new System.Drawing.Point(12, 24);
            this.Btn_coffee.Name = "Btn_coffee";
            this.Btn_coffee.Size = new System.Drawing.Size(195, 66);
            this.Btn_coffee.TabIndex = 12;
            this.Btn_coffee.Text = "화면전환1";
            this.Btn_coffee.UseVisualStyleBackColor = true;
            this.Btn_coffee.Click += new System.EventHandler(this.Btn_coffee_Click);
            // 
            // btn_nonCoffee
            // 
            this.btn_nonCoffee.Location = new System.Drawing.Point(213, 24);
            this.btn_nonCoffee.Name = "btn_nonCoffee";
            this.btn_nonCoffee.Size = new System.Drawing.Size(195, 66);
            this.btn_nonCoffee.TabIndex = 13;
            this.btn_nonCoffee.Text = "화면전환2";
            this.btn_nonCoffee.UseVisualStyleBackColor = true;
            this.btn_nonCoffee.Click += new System.EventHandler(this.Btn_nonCoffee_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(12, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 538);
            this.panel1.TabIndex = 14;
            // 
            // Btn_teaAndAde
            // 
            this.Btn_teaAndAde.Location = new System.Drawing.Point(414, 24);
            this.Btn_teaAndAde.Name = "Btn_teaAndAde";
            this.Btn_teaAndAde.Size = new System.Drawing.Size(195, 66);
            this.Btn_teaAndAde.TabIndex = 15;
            this.Btn_teaAndAde.Text = "화면전환2";
            this.Btn_teaAndAde.UseVisualStyleBackColor = true;
            this.Btn_teaAndAde.Click += new System.EventHandler(this.Btn_teaAndAde_Click);
            // 
            // MainSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 861);
            this.Controls.Add(this.Btn_teaAndAde);
            this.Controls.Add(this.btn_nonCoffee);
            this.Controls.Add(this.Btn_coffee);
            this.Controls.Add(this.panel1);
            this.Name = "MainSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.Button Btn_coffee;
        private System.Windows.Forms.Button btn_nonCoffee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_teaAndAde;
    }
}

