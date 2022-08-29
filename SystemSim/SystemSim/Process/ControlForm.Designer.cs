namespace SystemSim
{
    partial class ControlForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.NewPName = new System.Windows.Forms.Label();
            this.NewPId = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.Label();
            this.Ntime = new System.Windows.Forms.Label();
            this.Operation = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.Id1 = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.NewPPriority = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.AddAll = new System.Windows.Forms.Button();
            this.ReadyP = new System.Windows.Forms.Label();
            this.Timeslice1 = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.ResetAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_main = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Ready = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Running = new System.Windows.Forms.RichTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Disappear = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewPName
            // 
            this.NewPName.AutoSize = true;
            this.NewPName.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPName.Location = new System.Drawing.Point(33, 33);
            this.NewPName.Name = "NewPName";
            this.NewPName.Size = new System.Drawing.Size(125, 22);
            this.NewPName.TabIndex = 0;
            this.NewPName.Text = "进程名称：";
            // 
            // NewPId
            // 
            this.NewPId.AutoSize = true;
            this.NewPId.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPId.Location = new System.Drawing.Point(241, 33);
            this.NewPId.Name = "NewPId";
            this.NewPId.Size = new System.Drawing.Size(125, 22);
            this.NewPId.TabIndex = 1;
            this.NewPId.Text = "进程编号：";
            // 
            // State
            // 
            this.State.AutoSize = true;
            this.State.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.State.Location = new System.Drawing.Point(306, 373);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(0, 22);
            this.State.TabIndex = 2;
            // 
            // Ntime
            // 
            this.Ntime.AutoSize = true;
            this.Ntime.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ntime.Location = new System.Drawing.Point(426, 373);
            this.Ntime.Name = "Ntime";
            this.Ntime.Size = new System.Drawing.Size(0, 22);
            this.Ntime.TabIndex = 3;
            // 
            // Operation
            // 
            this.Operation.AutoSize = true;
            this.Operation.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Operation.Location = new System.Drawing.Point(692, 49);
            this.Operation.Name = "Operation";
            this.Operation.Size = new System.Drawing.Size(0, 22);
            this.Operation.TabIndex = 4;
            // 
            // Name1
            // 
            this.Name1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name1.Location = new System.Drawing.Point(162, 33);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(60, 21);
            this.Name1.TabIndex = 5;
            this.Name1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Id1
            // 
            this.Id1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Id1.Location = new System.Drawing.Point(371, 34);
            this.Id1.Name = "Id1";
            this.Id1.Size = new System.Drawing.Size(60, 21);
            this.Id1.TabIndex = 10;
            this.Id1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("仿宋", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(119, 18);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(510, 33);
            this.title.TabIndex = 40;
            this.title.Text = "进程控制模块：操作系统基本功能";
            // 
            // NewPPriority
            // 
            this.NewPPriority.AutoSize = true;
            this.NewPPriority.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPPriority.Location = new System.Drawing.Point(408, 32);
            this.NewPPriority.Name = "NewPPriority";
            this.NewPPriority.Size = new System.Drawing.Size(0, 22);
            this.NewPPriority.TabIndex = 49;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Lime;
            this.Start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.Location = new System.Drawing.Point(390, 75);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(91, 39);
            this.Start.TabIndex = 56;
            this.Start.Text = "开始运行";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // AddAll
            // 
            this.AddAll.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddAll.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddAll.Location = new System.Drawing.Point(212, 73);
            this.AddAll.Name = "AddAll";
            this.AddAll.Size = new System.Drawing.Size(91, 39);
            this.AddAll.TabIndex = 57;
            this.AddAll.Text = "添加";
            this.AddAll.UseVisualStyleBackColor = false;
            this.AddAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // ReadyP
            // 
            this.ReadyP.AutoSize = true;
            this.ReadyP.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadyP.Location = new System.Drawing.Point(455, 35);
            this.ReadyP.Name = "ReadyP";
            this.ReadyP.Size = new System.Drawing.Size(125, 22);
            this.ReadyP.TabIndex = 58;
            this.ReadyP.Text = "运行时间：";
            // 
            // Timeslice1
            // 
            this.Timeslice1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Timeslice1.Location = new System.Drawing.Point(606, 35);
            this.Timeslice1.Name = "Timeslice1";
            this.Timeslice1.Size = new System.Drawing.Size(60, 21);
            this.Timeslice1.TabIndex = 59;
            this.Timeslice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Timeslice1.TextChanged += new System.EventHandler(this.ReadyP_number_TextChanged);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.Location = new System.Drawing.Point(557, 73);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 39);
            this.Exit.TabIndex = 62;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ResetAll
            // 
            this.ResetAll.BackColor = System.Drawing.Color.Yellow;
            this.ResetAll.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetAll.Location = new System.Drawing.Point(54, 73);
            this.ResetAll.Name = "ResetAll";
            this.ResetAll.Size = new System.Drawing.Size(91, 39);
            this.ResetAll.TabIndex = 65;
            this.ResetAll.Text = "重置";
            this.ResetAll.UseVisualStyleBackColor = false;
            this.ResetAll.Click += new System.EventHandler(this.ResetAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.richTextBox_main);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(26, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 174);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进程运行情况";
            // 
            // richTextBox_main
            // 
            this.richTextBox_main.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_main.Location = new System.Drawing.Point(10, 34);
            this.richTextBox_main.Name = "richTextBox_main";
            this.richTextBox_main.Size = new System.Drawing.Size(677, 129);
            this.richTextBox_main.TabIndex = 0;
            this.richTextBox_main.Text = "";
            this.richTextBox_main.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Exit);
            this.groupBox2.Controls.Add(this.Start);
            this.groupBox2.Controls.Add(this.ResetAll);
            this.groupBox2.Controls.Add(this.AddAll);
            this.groupBox2.Controls.Add(this.NewPPriority);
            this.groupBox2.Controls.Add(this.NewPId);
            this.groupBox2.Controls.Add(this.Timeslice1);
            this.groupBox2.Controls.Add(this.Id1);
            this.groupBox2.Controls.Add(this.ReadyP);
            this.groupBox2.Controls.Add(this.NewPName);
            this.groupBox2.Controls.Add(this.Name1);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(26, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 130);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入及操作";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox_Ready);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox5.Location = new System.Drawing.Point(26, 386);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 248);
            this.groupBox5.TabIndex = 71;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "就绪队列";
            // 
            // richTextBox_Ready
            // 
            this.richTextBox_Ready.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Ready.Location = new System.Drawing.Point(6, 25);
            this.richTextBox_Ready.Name = "richTextBox_Ready";
            this.richTextBox_Ready.Size = new System.Drawing.Size(215, 211);
            this.richTextBox_Ready.TabIndex = 0;
            this.richTextBox_Ready.Text = "";
            this.richTextBox_Ready.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox_Running);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.ForeColor = System.Drawing.Color.Lime;
            this.groupBox6.Location = new System.Drawing.Point(259, 386);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(227, 248);
            this.groupBox6.TabIndex = 72;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "运行队列";
            // 
            // richTextBox_Running
            // 
            this.richTextBox_Running.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Running.Location = new System.Drawing.Point(9, 25);
            this.richTextBox_Running.Name = "richTextBox_Running";
            this.richTextBox_Running.Size = new System.Drawing.Size(211, 211);
            this.richTextBox_Running.TabIndex = 1;
            this.richTextBox_Running.Text = "";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.richTextBox_Disappear);
            this.groupBox8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox8.Location = new System.Drawing.Point(492, 386);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(227, 248);
            this.groupBox8.TabIndex = 73;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "消亡队列";
            // 
            // richTextBox_Disappear
            // 
            this.richTextBox_Disappear.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Disappear.Location = new System.Drawing.Point(6, 25);
            this.richTextBox_Disappear.Name = "richTextBox_Disappear";
            this.richTextBox_Disappear.Size = new System.Drawing.Size(215, 211);
            this.richTextBox_Disappear.TabIndex = 3;
            this.richTextBox_Disappear.Text = "";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 652);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Operation);
            this.Controls.Add(this.Ntime);
            this.Controls.Add(this.State);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreeGold";
            this.Load += new System.EventHandler(this.Show_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPName;
        private System.Windows.Forms.Label NewPId;
        private System.Windows.Forms.Label State;
        private System.Windows.Forms.Label Ntime;
        private System.Windows.Forms.Label Operation;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.TextBox Id1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label NewPPriority;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button AddAll;
        private System.Windows.Forms.Label ReadyP;
        private System.Windows.Forms.TextBox Timeslice1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ResetAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox richTextBox_main;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox richTextBox_Ready;
        private System.Windows.Forms.RichTextBox richTextBox_Running;
        private System.Windows.Forms.RichTextBox richTextBox_Disappear;
    }
}

