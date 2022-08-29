namespace SystemSim
{
    partial class DispatchForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DispatchForm));
            this.title = new System.Windows.Forms.Label();
            this.AlgorithmSelect = new System.Windows.Forms.GroupBox();
            this.AlgorithmBox = new System.Windows.Forms.CheckedListBox();
            this.DefaultTimeslice = new System.Windows.Forms.Label();
            this.Timeslice_number = new System.Windows.Forms.TextBox();
            this.richTextBox_main = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.ResetAll = new System.Windows.Forms.Button();
            this.AddAll = new System.Windows.Forms.Button();
            this.Priority2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPPriority = new System.Windows.Forms.Label();
            this.NewPId = new System.Windows.Forms.Label();
            this.Timeslice2 = new System.Windows.Forms.TextBox();
            this.Id2 = new System.Windows.Forms.TextBox();
            this.ReadyP = new System.Windows.Forms.Label();
            this.NewPName = new System.Windows.Forms.Label();
            this.Name2 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Disappear = new System.Windows.Forms.RichTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Running = new System.Windows.Forms.RichTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Ready = new System.Windows.Forms.RichTextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Block = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AlgorithmSelect.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("仿宋", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.title.Location = new System.Drawing.Point(312, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(444, 33);
            this.title.TabIndex = 41;
            this.title.Text = "进程调度模块：进程调度算法";
            // 
            // AlgorithmSelect
            // 
            this.AlgorithmSelect.Controls.Add(this.AlgorithmBox);
            this.AlgorithmSelect.Controls.Add(this.DefaultTimeslice);
            this.AlgorithmSelect.Controls.Add(this.Timeslice_number);
            this.AlgorithmSelect.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AlgorithmSelect.Location = new System.Drawing.Point(710, 92);
            this.AlgorithmSelect.Name = "AlgorithmSelect";
            this.AlgorithmSelect.Size = new System.Drawing.Size(362, 170);
            this.AlgorithmSelect.TabIndex = 71;
            this.AlgorithmSelect.TabStop = false;
            this.AlgorithmSelect.Text = "调度算法选择";
            // 
            // AlgorithmBox
            // 
            this.AlgorithmBox.Font = new System.Drawing.Font("仿宋", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AlgorithmBox.FormattingEnabled = true;
            this.AlgorithmBox.Items.AddRange(new object[] {
            "时间片轮转RR调度算法",
            "短进程优先SPF调度算法",
            "先来先服务FCFS调度算法",
            "高优先级优先PSA调度算法",
            "高响应比高优先HRRN调度算法"});
            this.AlgorithmBox.Location = new System.Drawing.Point(33, 30);
            this.AlgorithmBox.Name = "AlgorithmBox";
            this.AlgorithmBox.Size = new System.Drawing.Size(297, 76);
            this.AlgorithmBox.TabIndex = 42;
            this.AlgorithmBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.AlgorithmBox_ItemCheck);
            this.AlgorithmBox.SelectedIndexChanged += new System.EventHandler(this.AlgorithmBox_SelectedIndexChanged);
            // 
            // DefaultTimeslice
            // 
            this.DefaultTimeslice.AutoSize = true;
            this.DefaultTimeslice.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DefaultTimeslice.Location = new System.Drawing.Point(44, 130);
            this.DefaultTimeslice.Name = "DefaultTimeslice";
            this.DefaultTimeslice.Size = new System.Drawing.Size(148, 22);
            this.DefaultTimeslice.TabIndex = 60;
            this.DefaultTimeslice.Text = "时间片长度：";
            // 
            // Timeslice_number
            // 
            this.Timeslice_number.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Timeslice_number.Location = new System.Drawing.Point(196, 131);
            this.Timeslice_number.Name = "Timeslice_number";
            this.Timeslice_number.Size = new System.Drawing.Size(112, 21);
            this.Timeslice_number.TabIndex = 61;
            // 
            // richTextBox_main
            // 
            this.richTextBox_main.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_main.Location = new System.Drawing.Point(6, 34);
            this.richTextBox_main.Name = "richTextBox_main";
            this.richTextBox_main.Size = new System.Drawing.Size(636, 128);
            this.richTextBox_main.TabIndex = 72;
            this.richTextBox_main.Text = "";
            this.richTextBox_main.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_main);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(33, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 170);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进程运行情况";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Exit);
            this.groupBox2.Controls.Add(this.Start);
            this.groupBox2.Controls.Add(this.ResetAll);
            this.groupBox2.Controls.Add(this.AddAll);
            this.groupBox2.Controls.Add(this.Priority2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.NewPPriority);
            this.groupBox2.Controls.Add(this.NewPId);
            this.groupBox2.Controls.Add(this.Timeslice2);
            this.groupBox2.Controls.Add(this.Id2);
            this.groupBox2.Controls.Add(this.ReadyP);
            this.groupBox2.Controls.Add(this.NewPName);
            this.groupBox2.Controls.Add(this.Name2);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(33, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1039, 151);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入及操作";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Crimson;
            this.Exit.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Exit.Location = new System.Drawing.Point(855, 88);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(91, 39);
            this.Exit.TabIndex = 62;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Lime;
            this.Start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Start.Location = new System.Drawing.Point(591, 90);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(91, 39);
            this.Start.TabIndex = 56;
            this.Start.Text = "开始运行";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ResetAll
            // 
            this.ResetAll.BackColor = System.Drawing.Color.Yellow;
            this.ResetAll.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResetAll.Location = new System.Drawing.Point(69, 88);
            this.ResetAll.Name = "ResetAll";
            this.ResetAll.Size = new System.Drawing.Size(91, 39);
            this.ResetAll.TabIndex = 65;
            this.ResetAll.Text = "重置";
            this.ResetAll.UseVisualStyleBackColor = false;
            this.ResetAll.Click += new System.EventHandler(this.ResetAll_Click);
            // 
            // AddAll
            // 
            this.AddAll.BackColor = System.Drawing.Color.LightSkyBlue;
            this.AddAll.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddAll.Location = new System.Drawing.Point(317, 88);
            this.AddAll.Name = "AddAll";
            this.AddAll.Size = new System.Drawing.Size(91, 39);
            this.AddAll.TabIndex = 57;
            this.AddAll.Text = "添加";
            this.AddAll.UseVisualStyleBackColor = false;
            this.AddAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // Priority2
            // 
            this.Priority2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Priority2.Location = new System.Drawing.Point(677, 39);
            this.Priority2.Name = "Priority2";
            this.Priority2.Size = new System.Drawing.Size(60, 21);
            this.Priority2.TabIndex = 61;
            this.Priority2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(571, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "优先级：";
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
            // NewPId
            // 
            this.NewPId.AutoSize = true;
            this.NewPId.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPId.Location = new System.Drawing.Point(299, 38);
            this.NewPId.Name = "NewPId";
            this.NewPId.Size = new System.Drawing.Size(125, 22);
            this.NewPId.TabIndex = 1;
            this.NewPId.Text = "进程编号：";
            // 
            // Timeslice2
            // 
            this.Timeslice2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Timeslice2.Location = new System.Drawing.Point(927, 40);
            this.Timeslice2.Name = "Timeslice2";
            this.Timeslice2.Size = new System.Drawing.Size(60, 21);
            this.Timeslice2.TabIndex = 59;
            this.Timeslice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Id2
            // 
            this.Id2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Id2.Location = new System.Drawing.Point(429, 39);
            this.Id2.Name = "Id2";
            this.Id2.Size = new System.Drawing.Size(60, 21);
            this.Id2.TabIndex = 10;
            this.Id2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReadyP
            // 
            this.ReadyP.AutoSize = true;
            this.ReadyP.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReadyP.Location = new System.Drawing.Point(796, 39);
            this.ReadyP.Name = "ReadyP";
            this.ReadyP.Size = new System.Drawing.Size(125, 22);
            this.ReadyP.TabIndex = 58;
            this.ReadyP.Text = "运行时间：";
            // 
            // NewPName
            // 
            this.NewPName.AutoSize = true;
            this.NewPName.Font = new System.Drawing.Font("仿宋", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewPName.Location = new System.Drawing.Point(35, 39);
            this.NewPName.Name = "NewPName";
            this.NewPName.Size = new System.Drawing.Size(125, 22);
            this.NewPName.TabIndex = 0;
            this.NewPName.Text = "进程名称：";
            // 
            // Name2
            // 
            this.Name2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name2.Location = new System.Drawing.Point(166, 40);
            this.Name2.Name = "Name2";
            this.Name2.Size = new System.Drawing.Size(60, 21);
            this.Name2.TabIndex = 5;
            this.Name2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.richTextBox_Disappear);
            this.groupBox8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox8.Location = new System.Drawing.Point(845, 433);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(227, 243);
            this.groupBox8.TabIndex = 77;
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.richTextBox_Running);
            this.groupBox6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox6.ForeColor = System.Drawing.Color.Lime;
            this.groupBox6.Location = new System.Drawing.Point(309, 433);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(227, 243);
            this.groupBox6.TabIndex = 76;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.richTextBox_Ready);
            this.groupBox5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox5.ForeColor = System.Drawing.Color.DarkKhaki;
            this.groupBox5.Location = new System.Drawing.Point(39, 433);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 243);
            this.groupBox5.TabIndex = 75;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "就绪队列";
            // 
            // richTextBox_Ready
            // 
            this.richTextBox_Ready.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Ready.Location = new System.Drawing.Point(7, 22);
            this.richTextBox_Ready.Name = "richTextBox_Ready";
            this.richTextBox_Ready.Size = new System.Drawing.Size(215, 211);
            this.richTextBox_Ready.TabIndex = 0;
            this.richTextBox_Ready.Text = "";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.richTextBox_Block);
            this.groupBox7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox7.ForeColor = System.Drawing.Color.Gold;
            this.groupBox7.Location = new System.Drawing.Point(579, 433);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(227, 243);
            this.groupBox7.TabIndex = 78;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "阻塞队列";
            // 
            // richTextBox_Block
            // 
            this.richTextBox_Block.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_Block.Location = new System.Drawing.Point(6, 25);
            this.richTextBox_Block.Name = "richTextBox_Block";
            this.richTextBox_Block.Size = new System.Drawing.Size(215, 211);
            this.richTextBox_Block.TabIndex = 3;
            this.richTextBox_Block.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DispatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 688);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AlgorithmSelect);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DispatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThreeGold";
            this.Load += new System.EventHandler(this.DispatchForm_Load);
            this.AlgorithmSelect.ResumeLayout(false);
            this.AlgorithmSelect.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox AlgorithmSelect;
        private System.Windows.Forms.CheckedListBox AlgorithmBox;
        private System.Windows.Forms.Label DefaultTimeslice;
        private System.Windows.Forms.TextBox Timeslice_number;
        private System.Windows.Forms.RichTextBox richTextBox_main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button ResetAll;
        private System.Windows.Forms.Button AddAll;
        private System.Windows.Forms.Label NewPPriority;
        private System.Windows.Forms.Label NewPId;
        private System.Windows.Forms.TextBox Timeslice2;
        private System.Windows.Forms.TextBox Id2;
        private System.Windows.Forms.Label ReadyP;
        private System.Windows.Forms.Label NewPName;
        private System.Windows.Forms.TextBox Name2;
        private System.Windows.Forms.TextBox Priority2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RichTextBox richTextBox_Disappear;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBox_Running;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox richTextBox_Ready;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox richTextBox_Block;
        private System.Windows.Forms.Timer timer1;
    }
}