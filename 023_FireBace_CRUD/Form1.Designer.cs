namespace _023_FireBace_CRUD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_SId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ViewAll = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_deleteAll = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(542, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "순번";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(107, 294);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 25);
            this.txt_ID.TabIndex = 2;
            // 
            // txt_SId
            // 
            this.txt_SId.Location = new System.Drawing.Point(107, 325);
            this.txt_SId.Name = "txt_SId";
            this.txt_SId.Size = new System.Drawing.Size(100, 25);
            this.txt_SId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "학번";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(107, 356);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 25);
            this.txt_Name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "이름";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(107, 387);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(100, 25);
            this.txt_Phone.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "전화번호";
            // 
            // btn_ViewAll
            // 
            this.btn_ViewAll.Location = new System.Drawing.Point(270, 288);
            this.btn_ViewAll.Name = "btn_ViewAll";
            this.btn_ViewAll.Size = new System.Drawing.Size(110, 31);
            this.btn_ViewAll.TabIndex = 9;
            this.btn_ViewAll.Text = "View All";
            this.btn_ViewAll.UseVisualStyleBackColor = true;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(270, 325);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(110, 31);
            this.btn_insert.TabIndex = 10;
            this.btn_insert.Text = "추가";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(270, 362);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(110, 31);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(270, 399);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(110, 31);
            this.btn_Clear.TabIndex = 12;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_deleteAll
            // 
            this.btn_deleteAll.Location = new System.Drawing.Point(422, 288);
            this.btn_deleteAll.Name = "btn_deleteAll";
            this.btn_deleteAll.Size = new System.Drawing.Size(110, 31);
            this.btn_deleteAll.TabIndex = 13;
            this.btn_deleteAll.Text = "모두삭제";
            this.btn_deleteAll.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(422, 325);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(110, 31);
            this.btn_delete.TabIndex = 14;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(422, 362);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(110, 31);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "수정";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(422, 399);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(110, 31);
            this.btn_Exit.TabIndex = 16;
            this.btn_Exit.Text = "종료";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 451);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_deleteAll);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_ViewAll);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "전화번호부";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_SId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ViewAll;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_deleteAll;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Exit;
    }
}

