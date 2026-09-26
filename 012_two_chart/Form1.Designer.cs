namespace _012_two_chart
{
    partial class using_chartcontrol
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_onechart = new System.Windows.Forms.Button();
            this.btn_twochart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(600, 333);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn_onechart
            // 
            this.btn_onechart.Location = new System.Drawing.Point(78, 387);
            this.btn_onechart.Name = "btn_onechart";
            this.btn_onechart.Size = new System.Drawing.Size(163, 40);
            this.btn_onechart.TabIndex = 1;
            this.btn_onechart.Text = "합쳐서 그리기";
            this.btn_onechart.UseVisualStyleBackColor = true;
            this.btn_onechart.Click += new System.EventHandler(this.btn_onechart_Click);
            // 
            // btn_twochart
            // 
            this.btn_twochart.Location = new System.Drawing.Point(366, 387);
            this.btn_twochart.Name = "btn_twochart";
            this.btn_twochart.Size = new System.Drawing.Size(163, 40);
            this.btn_twochart.TabIndex = 2;
            this.btn_twochart.Text = "나누어 그리기";
            this.btn_twochart.UseVisualStyleBackColor = true;
            this.btn_twochart.Click += new System.EventHandler(this.btn_twochart_Click);
            // 
            // using_chartcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 459);
            this.Controls.Add(this.btn_twochart);
            this.Controls.Add(this.btn_onechart);
            this.Controls.Add(this.chart1);
            this.Name = "using_chartcontrol";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.using_chartcontrol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_onechart;
        private System.Windows.Forms.Button btn_twochart;
    }
}

