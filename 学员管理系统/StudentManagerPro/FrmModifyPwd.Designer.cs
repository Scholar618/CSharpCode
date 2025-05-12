
namespace StudentManagerPro
{
    partial class FrmModifyPwd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOldPwd = new System.Windows.Forms.TextBox();
            this.tbNewPwd = new System.Windows.Forms.TextBox();
            this.tbConfirmNewPwd = new System.Windows.Forms.TextBox();
            this.btnConfirmModify = new System.Windows.Forms.Button();
            this.btnCancelModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(36, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "确认密码：";
            // 
            // tbOldPwd
            // 
            this.tbOldPwd.Font = new System.Drawing.Font("宋体", 10F);
            this.tbOldPwd.Location = new System.Drawing.Point(103, 37);
            this.tbOldPwd.Name = "tbOldPwd";
            this.tbOldPwd.PasswordChar = '*';
            this.tbOldPwd.Size = new System.Drawing.Size(118, 23);
            this.tbOldPwd.TabIndex = 1;
            // 
            // tbNewPwd
            // 
            this.tbNewPwd.Font = new System.Drawing.Font("宋体", 10F);
            this.tbNewPwd.Location = new System.Drawing.Point(103, 69);
            this.tbNewPwd.Name = "tbNewPwd";
            this.tbNewPwd.PasswordChar = '*';
            this.tbNewPwd.Size = new System.Drawing.Size(118, 23);
            this.tbNewPwd.TabIndex = 1;
            // 
            // tbConfirmNewPwd
            // 
            this.tbConfirmNewPwd.Font = new System.Drawing.Font("宋体", 10F);
            this.tbConfirmNewPwd.Location = new System.Drawing.Point(103, 101);
            this.tbConfirmNewPwd.Name = "tbConfirmNewPwd";
            this.tbConfirmNewPwd.PasswordChar = '*';
            this.tbConfirmNewPwd.Size = new System.Drawing.Size(118, 23);
            this.tbConfirmNewPwd.TabIndex = 1;
            // 
            // btnConfirmModify
            // 
            this.btnConfirmModify.Font = new System.Drawing.Font("宋体", 10F);
            this.btnConfirmModify.Location = new System.Drawing.Point(39, 142);
            this.btnConfirmModify.Name = "btnConfirmModify";
            this.btnConfirmModify.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmModify.TabIndex = 2;
            this.btnConfirmModify.Text = "确认修改";
            this.btnConfirmModify.UseVisualStyleBackColor = true;
            this.btnConfirmModify.Click += new System.EventHandler(this.btnConfirmModify_Click);
            // 
            // btnCancelModify
            // 
            this.btnCancelModify.Font = new System.Drawing.Font("宋体", 10F);
            this.btnCancelModify.Location = new System.Drawing.Point(146, 142);
            this.btnCancelModify.Name = "btnCancelModify";
            this.btnCancelModify.Size = new System.Drawing.Size(75, 23);
            this.btnCancelModify.TabIndex = 2;
            this.btnCancelModify.Text = "取消修改";
            this.btnCancelModify.UseVisualStyleBackColor = true;
            this.btnCancelModify.Click += new System.EventHandler(this.btnCancelModify_Click);
            // 
            // FrmModifyPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 181);
            this.Controls.Add(this.btnCancelModify);
            this.Controls.Add(this.btnConfirmModify);
            this.Controls.Add(this.tbConfirmNewPwd);
            this.Controls.Add(this.tbNewPwd);
            this.Controls.Add(this.tbOldPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmModifyPwd";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOldPwd;
        private System.Windows.Forms.TextBox tbNewPwd;
        private System.Windows.Forms.TextBox tbConfirmNewPwd;
        private System.Windows.Forms.Button btnConfirmModify;
        private System.Windows.Forms.Button btnCancelModify;
    }
}