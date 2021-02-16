namespace Comparator
{
    partial class ComparatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComparatorForm));
            this.priceBoxA = new System.Windows.Forms.TextBox();
            this.weightBoxA = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.weightBoxB = new System.Windows.Forms.TextBox();
            this.priceBoxB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceBoxA
            // 
            this.priceBoxA.Font = new System.Drawing.Font("Consolas", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBoxA.Location = new System.Drawing.Point(66, 40);
            this.priceBoxA.MaxLength = 13;
            this.priceBoxA.Name = "priceBoxA";
            this.priceBoxA.Size = new System.Drawing.Size(129, 26);
            this.priceBoxA.TabIndex = 0;
            this.priceBoxA.TextChanged += new System.EventHandler(this.priceBoxB_TextChanged);
            this.priceBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // weightBoxA
            // 
            this.weightBoxA.Font = new System.Drawing.Font("Consolas", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightBoxA.Location = new System.Drawing.Point(66, 83);
            this.weightBoxA.MaxLength = 13;
            this.weightBoxA.Name = "weightBoxA";
            this.weightBoxA.Size = new System.Drawing.Size(129, 26);
            this.weightBoxA.TabIndex = 1;
            this.weightBoxA.TextChanged += new System.EventHandler(this.weightBoxB_TextChanged);
            this.weightBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("微软雅黑", 16F);
            this.title.Location = new System.Drawing.Point(171, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(196, 30);
            this.title.TabIndex = 6;
            this.title.Text = "Price Comparator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.priceBoxA);
            this.groupBox1.Controls.Add(this.weightBoxA);
            this.groupBox1.Location = new System.Drawing.Point(38, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price";
            // 
            // weightBoxB
            // 
            this.weightBoxB.Font = new System.Drawing.Font("Consolas", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightBoxB.Location = new System.Drawing.Point(66, 83);
            this.weightBoxB.MaxLength = 13;
            this.weightBoxB.Name = "weightBoxB";
            this.weightBoxB.ReadOnly = true;
            this.weightBoxB.Size = new System.Drawing.Size(129, 26);
            this.weightBoxB.TabIndex = 3;
            this.weightBoxB.TextChanged += new System.EventHandler(this.weightBoxB_TextChanged);
            this.weightBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // priceBoxB
            // 
            this.priceBoxB.Font = new System.Drawing.Font("Consolas", 12.10084F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBoxB.Location = new System.Drawing.Point(66, 40);
            this.priceBoxB.MaxLength = 13;
            this.priceBoxB.Name = "priceBoxB";
            this.priceBoxB.Size = new System.Drawing.Size(129, 26);
            this.priceBoxB.TabIndex = 2;
            this.priceBoxB.TextChanged += new System.EventHandler(this.priceBoxB_TextChanged);
            this.priceBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Weight";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.priceBoxB);
            this.groupBox2.Controls.Add(this.weightBoxB);
            this.groupBox2.Location = new System.Drawing.Point(281, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 136);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "B";
            // 
            // ComparatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("微软雅黑", 10.28571F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ComparatorForm";
            this.Text = "Comparator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox priceBoxA;
        private System.Windows.Forms.TextBox weightBoxA;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox weightBoxB;
        private System.Windows.Forms.TextBox priceBoxB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

