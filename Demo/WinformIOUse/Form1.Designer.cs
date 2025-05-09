
namespace WinformIOUse
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textContent = new System.Windows.Forms.RichTextBox();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnSystemLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMoveFile = new System.Windows.Forms.Button();
            this.btnCopyFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.textToFile = new System.Windows.Forms.TextBox();
            this.textFromFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCatlogAndFile = new System.Windows.Forms.Button();
            this.btnShowCatlog = new System.Windows.Forms.Button();
            this.btnCreateCatlog = new System.Windows.Forms.Button();
            this.btnShowFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textContent
            // 
            this.textContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textContent.Location = new System.Drawing.Point(33, 28);
            this.textContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(288, 381);
            this.textContent.TabIndex = 1;
            this.textContent.Text = "";
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(15, 24);
            this.btnWriteFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(116, 39);
            this.btnWriteFile.TabIndex = 3;
            this.btnWriteFile.Text = "写入文本文件";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(144, 24);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(116, 39);
            this.btnReadFile.TabIndex = 3;
            this.btnReadFile.Text = "读取文本文件";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnSystemLog
            // 
            this.btnSystemLog.Location = new System.Drawing.Point(273, 24);
            this.btnSystemLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSystemLog.Name = "btnSystemLog";
            this.btnSystemLog.Size = new System.Drawing.Size(151, 39);
            this.btnSystemLog.TabIndex = 3;
            this.btnSystemLog.Text = "模拟写入系统日志";
            this.btnSystemLog.UseVisualStyleBackColor = true;
            this.btnSystemLog.Click += new System.EventHandler(this.btnSystemLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWriteFile);
            this.groupBox1.Controls.Add(this.btnSystemLog);
            this.groupBox1.Controls.Add(this.btnReadFile);
            this.groupBox1.Location = new System.Drawing.Point(349, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(447, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "文本读取写入";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnMoveFile);
            this.groupBox3.Controls.Add(this.btnCopyFile);
            this.groupBox3.Controls.Add(this.btnDeleteFile);
            this.groupBox3.Controls.Add(this.textToFile);
            this.groupBox3.Controls.Add(this.textFromFile);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(349, 140);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(447, 149);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "文件操作";
            // 
            // btnMoveFile
            // 
            this.btnMoveFile.Location = new System.Drawing.Point(273, 115);
            this.btnMoveFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMoveFile.Name = "btnMoveFile";
            this.btnMoveFile.Size = new System.Drawing.Size(93, 28);
            this.btnMoveFile.TabIndex = 3;
            this.btnMoveFile.Text = "移动文件";
            this.btnMoveFile.UseVisualStyleBackColor = true;
            this.btnMoveFile.Click += new System.EventHandler(this.btnMoveFile_Click);
            // 
            // btnCopyFile
            // 
            this.btnCopyFile.Location = new System.Drawing.Point(144, 115);
            this.btnCopyFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCopyFile.Name = "btnCopyFile";
            this.btnCopyFile.Size = new System.Drawing.Size(93, 28);
            this.btnCopyFile.TabIndex = 3;
            this.btnCopyFile.Text = "复制文件";
            this.btnCopyFile.UseVisualStyleBackColor = true;
            this.btnCopyFile.Click += new System.EventHandler(this.btnCopyFile_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(11, 115);
            this.btnDeleteFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(93, 28);
            this.btnDeleteFile.TabIndex = 3;
            this.btnDeleteFile.Text = "删除文件";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // textToFile
            // 
            this.textToFile.Location = new System.Drawing.Point(144, 68);
            this.textToFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textToFile.Name = "textToFile";
            this.textToFile.Size = new System.Drawing.Size(195, 25);
            this.textToFile.TabIndex = 1;
            // 
            // textFromFile
            // 
            this.textFromFile.Location = new System.Drawing.Point(144, 34);
            this.textFromFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textFromFile.Name = "textFromFile";
            this.textFromFile.Size = new System.Drawing.Size(195, 25);
            this.textFromFile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "目的文件路径：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "源文件路径：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteCatlogAndFile);
            this.groupBox2.Controls.Add(this.btnShowCatlog);
            this.groupBox2.Controls.Add(this.btnCreateCatlog);
            this.groupBox2.Controls.Add(this.btnShowFile);
            this.groupBox2.Location = new System.Drawing.Point(349, 312);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(447, 95);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文件目录操作";
            // 
            // btnDeleteCatlogAndFile
            // 
            this.btnDeleteCatlogAndFile.Location = new System.Drawing.Point(213, 58);
            this.btnDeleteCatlogAndFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCatlogAndFile.Name = "btnDeleteCatlogAndFile";
            this.btnDeleteCatlogAndFile.Size = new System.Drawing.Size(228, 28);
            this.btnDeleteCatlogAndFile.TabIndex = 3;
            this.btnDeleteCatlogAndFile.Text = "删除指定目录所有目录和文件";
            this.btnDeleteCatlogAndFile.UseVisualStyleBackColor = true;
            this.btnDeleteCatlogAndFile.Click += new System.EventHandler(this.btnDeleteCatlogAndFile_Click);
            // 
            // btnShowCatlog
            // 
            this.btnShowCatlog.Location = new System.Drawing.Point(213, 24);
            this.btnShowCatlog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowCatlog.Name = "btnShowCatlog";
            this.btnShowCatlog.Size = new System.Drawing.Size(228, 28);
            this.btnShowCatlog.TabIndex = 3;
            this.btnShowCatlog.Text = "显式指定目录下的所有子目录";
            this.btnShowCatlog.UseVisualStyleBackColor = true;
            this.btnShowCatlog.Click += new System.EventHandler(this.btnShowCatlog_Click);
            // 
            // btnCreateCatlog
            // 
            this.btnCreateCatlog.Location = new System.Drawing.Point(9, 58);
            this.btnCreateCatlog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateCatlog.Name = "btnCreateCatlog";
            this.btnCreateCatlog.Size = new System.Drawing.Size(199, 28);
            this.btnCreateCatlog.TabIndex = 3;
            this.btnCreateCatlog.Text = "在指定目录创建子目录";
            this.btnCreateCatlog.UseVisualStyleBackColor = true;
            this.btnCreateCatlog.Click += new System.EventHandler(this.btnCreateCatlog_Click);
            // 
            // btnShowFile
            // 
            this.btnShowFile.Location = new System.Drawing.Point(11, 24);
            this.btnShowFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowFile.Name = "btnShowFile";
            this.btnShowFile.Size = new System.Drawing.Size(197, 28);
            this.btnShowFile.TabIndex = 3;
            this.btnShowFile.Text = "显式指定目录下的文件";
            this.btnShowFile.UseVisualStyleBackColor = true;
            this.btnShowFile.Click += new System.EventHandler(this.btnShowFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textContent;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnSystemLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnMoveFile;
        private System.Windows.Forms.Button btnCopyFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.TextBox textToFile;
        private System.Windows.Forms.TextBox textFromFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteCatlogAndFile;
        private System.Windows.Forms.Button btnShowCatlog;
        private System.Windows.Forms.Button btnCreateCatlog;
        private System.Windows.Forms.Button btnShowFile;
    }
}

