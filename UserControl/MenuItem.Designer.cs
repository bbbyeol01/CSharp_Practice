namespace POS_build
{
    partial class MenuItem
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMenuName = new System.Windows.Forms.Label();
            this.lblMenuPrice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pic_drink = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_drink)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuName
            // 
            this.lblMenuName.AutoSize = true;
            this.lblMenuName.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuName.Font = new System.Drawing.Font("Pretendard Variable", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuName.Location = new System.Drawing.Point(39, 29);
            this.lblMenuName.Name = "lblMenuName";
            this.lblMenuName.Size = new System.Drawing.Size(58, 23);
            this.lblMenuName.TabIndex = 0;
            this.lblMenuName.Text = "label1";
            // 
            // lblMenuPrice
            // 
            this.lblMenuPrice.AutoSize = true;
            this.lblMenuPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuPrice.Font = new System.Drawing.Font("Pretendard Variable", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMenuPrice.Location = new System.Drawing.Point(39, 61);
            this.lblMenuPrice.Name = "lblMenuPrice";
            this.lblMenuPrice.Size = new System.Drawing.Size(58, 23);
            this.lblMenuPrice.TabIndex = 1;
            this.lblMenuPrice.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Pic_drink);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(182, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 120);
            this.panel1.TabIndex = 2;
            // 
            // Pic_drink
            // 
            this.Pic_drink.Location = new System.Drawing.Point(0, 0);
            this.Pic_drink.Name = "Pic_drink";
            this.Pic_drink.Size = new System.Drawing.Size(118, 120);
            this.Pic_drink.TabIndex = 0;
            this.Pic_drink.TabStop = false;
            // 
            // MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMenuPrice);
            this.Controls.Add(this.lblMenuName);
            this.Name = "MenuItem";
            this.Size = new System.Drawing.Size(300, 120);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_drink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuName;
        private System.Windows.Forms.Label lblMenuPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Pic_drink;
    }
}
