namespace Merge_PDF
{
    partial class Merge_Form
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
            this.Merge_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileload_A = new System.Windows.Forms.TextBox();
            this.fileload_B = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileload_save = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Merge_btn
            // 
            this.Merge_btn.Location = new System.Drawing.Point(275, 315);
            this.Merge_btn.Name = "Merge_btn";
            this.Merge_btn.Size = new System.Drawing.Size(108, 38);
            this.Merge_btn.TabIndex = 0;
            this.Merge_btn.Text = "开始合并";
            this.Merge_btn.UseVisualStyleBackColor = true;
            this.Merge_btn.Click += new System.EventHandler(this.Merge_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "路径-前";
            // 
            // fileload_A
            // 
            this.fileload_A.Location = new System.Drawing.Point(275, 103);
            this.fileload_A.Name = "fileload_A";
            this.fileload_A.Size = new System.Drawing.Size(537, 31);
            this.fileload_A.TabIndex = 3;
            // 
            // fileload_B
            // 
            this.fileload_B.Location = new System.Drawing.Point(275, 167);
            this.fileload_B.Name = "fileload_B";
            this.fileload_B.Size = new System.Drawing.Size(537, 31);
            this.fileload_B.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "路径-后";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "路径-存";
            // 
            // fileload_save
            // 
            this.fileload_save.Location = new System.Drawing.Point(275, 239);
            this.fileload_save.Name = "fileload_save";
            this.fileload_save.Size = new System.Drawing.Size(537, 31);
            this.fileload_save.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(768, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "声明：软件仅供技术交流，请勿用于商业及非法用途，如产生法律纠纷与本人无关";
            // 
            // Merge_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 549);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fileload_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fileload_B);
            this.Controls.Add(this.fileload_A);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Merge_btn);
            this.Name = "Merge_Form";
            this.Text = "合并";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Merge_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileload_A;
        private System.Windows.Forms.TextBox fileload_B;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileload_save;
        private System.Windows.Forms.Label label4;
    }
}

