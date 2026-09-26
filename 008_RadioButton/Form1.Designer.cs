namespace _008_RadioButton
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
            this.button1 = new System.Windows.Forms.Button();
            this.rbKR = new System.Windows.Forms.RadioButton();
            this.rbCN = new System.Windows.Forms.RadioButton();
            this.rbJP = new System.Windows.Forms.RadioButton();
            this.rbOT = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbFM = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "제출";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbKR
            // 
            this.rbKR.AutoSize = true;
            this.rbKR.Location = new System.Drawing.Point(22, 24);
            this.rbKR.Name = "rbKR";
            this.rbKR.Size = new System.Drawing.Size(88, 19);
            this.rbKR.TabIndex = 1;
            this.rbKR.TabStop = true;
            this.rbKR.Text = "대한민국";
            this.rbKR.UseVisualStyleBackColor = true;
            // 
            // rbCN
            // 
            this.rbCN.AutoSize = true;
            this.rbCN.Location = new System.Drawing.Point(22, 60);
            this.rbCN.Name = "rbCN";
            this.rbCN.Size = new System.Drawing.Size(58, 19);
            this.rbCN.TabIndex = 2;
            this.rbCN.TabStop = true;
            this.rbCN.Text = "중국";
            this.rbCN.UseVisualStyleBackColor = true;
            // 
            // rbJP
            // 
            this.rbJP.AutoSize = true;
            this.rbJP.Location = new System.Drawing.Point(22, 98);
            this.rbJP.Name = "rbJP";
            this.rbJP.Size = new System.Drawing.Size(58, 19);
            this.rbJP.TabIndex = 3;
            this.rbJP.TabStop = true;
            this.rbJP.Text = "일본";
            this.rbJP.UseVisualStyleBackColor = true;
            // 
            // rbOT
            // 
            this.rbOT.AutoSize = true;
            this.rbOT.Location = new System.Drawing.Point(22, 137);
            this.rbOT.Name = "rbOT";
            this.rbOT.Size = new System.Drawing.Size(98, 19);
            this.rbOT.TabIndex = 4;
            this.rbOT.TabStop = true;
            this.rbOT.Text = "그 외 국가";
            this.rbOT.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(37, 24);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(43, 19);
            this.rbM.TabIndex = 5;
            this.rbM.TabStop = true;
            this.rbM.Text = "남";
            this.rbM.UseVisualStyleBackColor = true;
            this.rbM.CheckedChanged += new System.EventHandler(this.rbM_CheckedChanged_1);
            // 
            // rbFM
            // 
            this.rbFM.AutoSize = true;
            this.rbFM.Location = new System.Drawing.Point(110, 24);
            this.rbFM.Name = "rbFM";
            this.rbFM.Size = new System.Drawing.Size(43, 19);
            this.rbFM.TabIndex = 6;
            this.rbFM.TabStop = true;
            this.rbFM.Text = "여";
            this.rbFM.UseVisualStyleBackColor = true;
            this.rbFM.CheckedChanged += new System.EventHandler(this.rbFM_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKR);
            this.groupBox1.Controls.Add(this.rbCN);
            this.groupBox1.Controls.Add(this.rbJP);
            this.groupBox1.Controls.Add(this.rbOT);
            this.groupBox1.Location = new System.Drawing.Point(33, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 171);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbM);
            this.groupBox2.Controls.Add(this.rbFM);
            this.groupBox2.Location = new System.Drawing.Point(377, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 50);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbKR;
        private System.Windows.Forms.RadioButton rbCN;
        private System.Windows.Forms.RadioButton rbJP;
        private System.Windows.Forms.RadioButton rbOT;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbFM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

