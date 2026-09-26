namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtNM = new System.Windows.Forms.Label();
            this.inNM = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.outNM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNM
            // 
            this.txtNM.AutoSize = true;
            this.txtNM.Location = new System.Drawing.Point(46, 68);
            this.txtNM.Name = "txtNM";
            this.txtNM.Size = new System.Drawing.Size(52, 15);
            this.txtNM.TabIndex = 0;
            this.txtNM.Text = "이름 : ";
            // 
            // inNM
            // 
            this.inNM.Location = new System.Drawing.Point(123, 65);
            this.inNM.Name = "inNM";
            this.inNM.Size = new System.Drawing.Size(100, 25);
            this.inNM.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "클릭";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // outNM
            // 
            this.outNM.AutoSize = true;
            this.outNM.Location = new System.Drawing.Point(123, 121);
            this.outNM.Name = "outNM";
            this.outNM.Size = new System.Drawing.Size(0, 15);
            this.outNM.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 169);
            this.Controls.Add(this.outNM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inNM);
            this.Controls.Add(this.txtNM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNM;
        private System.Windows.Forms.TextBox inNM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outNM;
    }
}

