namespace SystemSim
{
    partial class AvoidDeadlockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvoidDeadlockForm));
            this.dataGridView_need = new System.Windows.Forms.DataGridView();
            this.dataGridView_get = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.systemmessageshow = new System.Windows.Forms.TextBox();
            this.datamaker = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_All = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_Now = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_max = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.exit = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_need)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_get)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_max)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_need
            // 
            this.dataGridView_need.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_need.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_need.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_need.Location = new System.Drawing.Point(5, 19);
            this.dataGridView_need.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_need.Name = "dataGridView_need";
            this.dataGridView_need.RowTemplate.Height = 27;
            this.dataGridView_need.Size = new System.Drawing.Size(363, 164);
            this.dataGridView_need.TabIndex = 13;
            // 
            // dataGridView_get
            // 
            this.dataGridView_get.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_get.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_get.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_get.Location = new System.Drawing.Point(5, 19);
            this.dataGridView_get.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_get.Name = "dataGridView_get";
            this.dataGridView_get.RowTemplate.Height = 27;
            this.dataGridView_get.Size = new System.Drawing.Size(357, 164);
            this.dataGridView_get.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(500, 40);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "系统提示:";
            // 
            // systemmessageshow
            // 
            this.systemmessageshow.BackColor = System.Drawing.Color.White;
            this.systemmessageshow.Enabled = false;
            this.systemmessageshow.Location = new System.Drawing.Point(588, 37);
            this.systemmessageshow.Margin = new System.Windows.Forms.Padding(2);
            this.systemmessageshow.Multiline = true;
            this.systemmessageshow.Name = "systemmessageshow";
            this.systemmessageshow.Size = new System.Drawing.Size(558, 77);
            this.systemmessageshow.TabIndex = 19;
            this.systemmessageshow.TextChanged += new System.EventHandler(this.systemmessageshow_TextChanged);
            // 
            // datamaker
            // 
            this.datamaker.BackColor = System.Drawing.Color.Ivory;
            this.datamaker.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.datamaker.Location = new System.Drawing.Point(234, 32);
            this.datamaker.Margin = new System.Windows.Forms.Padding(2);
            this.datamaker.Name = "datamaker";
            this.datamaker.Size = new System.Drawing.Size(125, 30);
            this.datamaker.TabIndex = 20;
            this.datamaker.Text = "随机生成数据";
            this.datamaker.UseVisualStyleBackColor = false;
            this.datamaker.Click += new System.EventHandler(this.datamaker_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "各个进程的资源的总数量(随机生成1-10)";
            // 
            // textBox_All
            // 
            this.textBox_All.Location = new System.Drawing.Point(234, 76);
            this.textBox_All.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_All.Name = "textBox_All";
            this.textBox_All.Size = new System.Drawing.Size(219, 21);
            this.textBox_All.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(61, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 12);
            this.label11.TabIndex = 22;
            this.label11.Text = "目前各种资源可利用的数量为";
            // 
            // textBox_Now
            // 
            this.textBox_Now.Location = new System.Drawing.Point(234, 111);
            this.textBox_Now.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Now.Name = "textBox_Now";
            this.textBox_Now.Size = new System.Drawing.Size(219, 21);
            this.textBox_Now.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(117, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "随机生成4-6个进程";
            // 
            // dataGridView_max
            // 
            this.dataGridView_max.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_max.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_max.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_max.Location = new System.Drawing.Point(11, 19);
            this.dataGridView_max.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_max.Name = "dataGridView_max";
            this.dataGridView_max.RowTemplate.Height = 27;
            this.dataGridView_max.Size = new System.Drawing.Size(388, 164);
            this.dataGridView_max.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(234, 147);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(219, 21);
            this.textBox2.TabIndex = 28;
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.Chartreuse;
            this.apply.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.apply.Location = new System.Drawing.Point(650, 129);
            this.apply.Margin = new System.Windows.Forms.Padding(2);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(115, 50);
            this.apply.TabIndex = 29;
            this.apply.Text = "申请进程资源";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(48, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "示例：进程号 资源0 资源1 ……";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_max);
            this.groupBox1.Location = new System.Drawing.Point(24, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 188);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "各进程所需要的各类资源的最大数量(10个以内)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_need);
            this.groupBox2.Location = new System.Drawing.Point(434, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 188);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "各进程还需要的资源数量:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_get);
            this.groupBox3.Location = new System.Drawing.Point(813, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 188);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "各进程已经得到的资源量:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.exit);
            this.groupBox4.Controls.Add(this.textBox_Now);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBox_All);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.systemmessageshow);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.apply);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.datamaker);
            this.groupBox4.Location = new System.Drawing.Point(24, 327);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1151, 205);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "输入与输出";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exit.Location = new System.Drawing.Point(982, 129);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(115, 50);
            this.exit.TabIndex = 32;
            this.exit.Text = "退出系统";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.title.Location = new System.Drawing.Point(416, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(411, 33);
            this.title.TabIndex = 41;
            this.title.Text = "避免死锁模块：银行家算法";
            // 
            // AvoidDeadlockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1195, 544);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AvoidDeadlockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreeGold";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_need)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_get)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_max)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_need;
        private System.Windows.Forms.DataGridView dataGridView_get;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox systemmessageshow;
        private System.Windows.Forms.Button datamaker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_All;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_Now;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_max;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button exit;
    }
}