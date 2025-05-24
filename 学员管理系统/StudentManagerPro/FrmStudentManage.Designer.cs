
namespace StudentManagerPro
{
    partial class FrmStudentManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortById = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.sortByName = new System.Windows.Forms.Button();
            this.btSelectByClass = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cbClassName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btSelectById = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正粗黑宋简体", 18F);
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "学员信息管理";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 10F);
            this.btnClose.Location = new System.Drawing.Point(655, 36);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortById);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.sortByName);
            this.groupBox1.Controls.Add(this.btSelectByClass);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.cbClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[按照班级查询]";
            // 
            // sortById
            // 
            this.sortById.Font = new System.Drawing.Font("宋体", 10F);
            this.sortById.Location = new System.Drawing.Point(416, 29);
            this.sortById.Name = "sortById";
            this.sortById.Size = new System.Drawing.Size(86, 26);
            this.sortById.TabIndex = 2;
            this.sortById.Text = "学号降序";
            this.sortById.UseVisualStyleBackColor = true;
            this.sortById.Click += new System.EventHandler(this.sortById_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("宋体", 10F);
            this.button6.Location = new System.Drawing.Point(636, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 30);
            this.button6.TabIndex = 2;
            this.button6.Text = "删除";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // sortByName
            // 
            this.sortByName.Font = new System.Drawing.Font("宋体", 10F);
            this.sortByName.Location = new System.Drawing.Point(301, 29);
            this.sortByName.Name = "sortByName";
            this.sortByName.Size = new System.Drawing.Size(93, 26);
            this.sortByName.TabIndex = 2;
            this.sortByName.Text = "姓名降序";
            this.sortByName.UseVisualStyleBackColor = true;
            this.sortByName.Click += new System.EventHandler(this.sortByName_Click);
            // 
            // btSelectByClass
            // 
            this.btSelectByClass.Font = new System.Drawing.Font("宋体", 10F);
            this.btSelectByClass.Location = new System.Drawing.Point(202, 29);
            this.btSelectByClass.Name = "btSelectByClass";
            this.btSelectByClass.Size = new System.Drawing.Size(72, 27);
            this.btSelectByClass.TabIndex = 2;
            this.btSelectByClass.Text = "查询";
            this.btSelectByClass.UseVisualStyleBackColor = true;
            this.btSelectByClass.Click += new System.EventHandler(this.btSelectByClass_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 10F);
            this.button5.Location = new System.Drawing.Point(557, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 30);
            this.button5.TabIndex = 2;
            this.button5.Text = "修改";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cbClassName
            // 
            this.cbClassName.FormattingEnabled = true;
            this.cbClassName.Location = new System.Drawing.Point(90, 32);
            this.cbClassName.Name = "cbClassName";
            this.cbClassName.Size = new System.Drawing.Size(105, 20);
            this.cbClassName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "学员班级：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btSelectById);
            this.groupBox2.Location = new System.Drawing.Point(19, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 60);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[按学号精确查询]";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(113, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "请输入学号：";
            // 
            // btSelectById
            // 
            this.btSelectById.Font = new System.Drawing.Font("宋体", 10F);
            this.btSelectById.Location = new System.Drawing.Point(277, 23);
            this.btSelectById.Name = "btSelectById";
            this.btSelectById.Size = new System.Drawing.Size(82, 28);
            this.btSelectById.TabIndex = 2;
            this.btSelectById.Text = "提交查询";
            this.btSelectById.UseVisualStyleBackColor = true;
            this.btSelectById.Click += new System.EventHandler(this.btSelectById_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("宋体", 10F);
            this.button8.Location = new System.Drawing.Point(598, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(140, 24);
            this.button8.TabIndex = 2;
            this.button8.Text = "打印当前学员信息";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // dgvShowData
            // 
            this.dgvShowData.AllowUserToAddRows = false;
            this.dgvShowData.AllowUserToDeleteRows = false;
            this.dgvShowData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShowData.ColumnHeadersHeight = 25;
            this.dgvShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.Gender,
            this.Birthday,
            this.StudentIdNo,
            this.PhoneNumber,
            this.ClassName});
            this.dgvShowData.Location = new System.Drawing.Point(19, 260);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.ReadOnly = true;
            this.dgvShowData.RowTemplate.Height = 23;
            this.dgvShowData.Size = new System.Drawing.Size(719, 194);
            this.dgvShowData.TabIndex = 6;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "学号";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentName.Width = 80;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gender.Width = 60;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StudentIdNo
            // 
            this.StudentIdNo.DataPropertyName = "StudentIdNo";
            this.StudentIdNo.HeaderText = "身份证号";
            this.StudentIdNo.Name = "StudentIdNo";
            this.StudentIdNo.ReadOnly = true;
            this.StudentIdNo.Width = 120;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "手机号码";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "所在班级";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10F);
            this.button1.Location = new System.Drawing.Point(435, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 24);
            this.button1.TabIndex = 7;
            this.button1.Text = "导出到Excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmStudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvShowData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Name = "FrmStudentManage";
            this.Text = "学员管理";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button sortById;
        private System.Windows.Forms.Button sortByName;
        private System.Windows.Forms.Button btSelectByClass;
        private System.Windows.Forms.ComboBox cbClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSelectById;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
    }
}