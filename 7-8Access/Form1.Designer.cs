namespace _7_8Access
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.butPut = new System.Windows.Forms.Button();
            this.butCel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textClass = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textNumber2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.butSel = new System.Windows.Forms.Button();
            this.butInset = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butUp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 365);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(903, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 73);
            this.button3.TabIndex = 1;
            this.button3.Text = "创建表格";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // butPut
            // 
            this.butPut.Enabled = false;
            this.butPut.Location = new System.Drawing.Point(583, 29);
            this.butPut.Name = "butPut";
            this.butPut.Size = new System.Drawing.Size(75, 23);
            this.butPut.TabIndex = 1;
            this.butPut.Text = "提交";
            this.butPut.UseVisualStyleBackColor = true;
            this.butPut.Click += new System.EventHandler(this.button1_Click);
            // 
            // butCel
            // 
            this.butCel.Enabled = false;
            this.butCel.Location = new System.Drawing.Point(583, 73);
            this.butCel.Name = "butCel";
            this.butCel.Size = new System.Drawing.Size(75, 23);
            this.butCel.TabIndex = 1;
            this.butCel.Text = "取消";
            this.butCel.UseVisualStyleBackColor = true;
            this.butCel.Click += new System.EventHandler(this.butCel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "班级";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "电话号码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "姓名";
            // 
            // textClass
            // 
            this.textClass.Location = new System.Drawing.Point(138, 81);
            this.textClass.Name = "textClass";
            this.textClass.Size = new System.Drawing.Size(100, 25);
            this.textClass.TabIndex = 3;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(386, 82);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(100, 25);
            this.textTel.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(386, 33);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 25);
            this.textName.TabIndex = 3;
            // 
            // textNumber2
            // 
            this.textNumber2.Location = new System.Drawing.Point(138, 23);
            this.textNumber2.Name = "textNumber2";
            this.textNumber2.Size = new System.Drawing.Size(100, 25);
            this.textNumber2.TabIndex = 3;
            this.textNumber2.TextChanged += new System.EventHandler(this.textNumber2_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textTel);
            this.groupBox1.Controls.Add(this.textNumber2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textClass);
            this.groupBox1.Controls.Add(this.textName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.butPut);
            this.groupBox1.Controls.Add(this.butCel);
            this.groupBox1.Location = new System.Drawing.Point(13, 450);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 121);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据编辑";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "学号";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(151, 30);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(100, 25);
            this.textNumber.TabIndex = 3;
            // 
            // butSel
            // 
            this.butSel.Location = new System.Drawing.Point(280, 31);
            this.butSel.Name = "butSel";
            this.butSel.Size = new System.Drawing.Size(75, 23);
            this.butSel.TabIndex = 5;
            this.butSel.Text = "查询";
            this.butSel.UseVisualStyleBackColor = true;
            this.butSel.Click += new System.EventHandler(this.button4_Click);
            // 
            // butInset
            // 
            this.butInset.Location = new System.Drawing.Point(399, 32);
            this.butInset.Name = "butInset";
            this.butInset.Size = new System.Drawing.Size(75, 23);
            this.butInset.TabIndex = 5;
            this.butInset.Text = "插入";
            this.butInset.UseVisualStyleBackColor = true;
            this.butInset.Click += new System.EventHandler(this.butInset_Click);
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(517, 32);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(75, 23);
            this.butDel.TabIndex = 5;
            this.butDel.Text = "删除";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butUp
            // 
            this.butUp.Location = new System.Drawing.Point(641, 32);
            this.butUp.Name = "butUp";
            this.butUp.Size = new System.Drawing.Size(75, 23);
            this.butUp.TabIndex = 5;
            this.butUp.Text = "修改";
            this.butUp.UseVisualStyleBackColor = true;
            this.butUp.Click += new System.EventHandler(this.butUp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(513, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 588);
            this.Controls.Add(this.butUp);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butInset);
            this.Controls.Add(this.butSel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button butPut;
        private System.Windows.Forms.Button butCel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textClass;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textNumber2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Button butSel;
        private System.Windows.Forms.Button butInset;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.Button butUp;
        private System.Windows.Forms.Label label6;
    }
}

