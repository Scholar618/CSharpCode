
namespace StudentManagerPro
{
    partial class FrmAddStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbStuPhoto = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btDeletePhoto = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbClassName = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbIdCard = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbWorkCard = new System.Windows.Forms.TextBox();
            this.tbStuName = new System.Windows.Forms.TextBox();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btSelectPhoto = new System.Windows.Forms.Button();
            this.dgvAddStudent = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentIdNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuPhoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正粗黑宋简体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "添加新学员";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(29, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 187);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbStuPhoto
            // 
            this.pbStuPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStuPhoto.Location = new System.Drawing.Point(619, 99);
            this.pbStuPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.pbStuPhoto.Name = "pbStuPhoto";
            this.pbStuPhoto.Size = new System.Drawing.Size(247, 187);
            this.pbStuPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStuPhoto.TabIndex = 1;
            this.pbStuPhoto.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(317, 99);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "启动摄像头";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 99);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "关闭摄像头";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btDeletePhoto
            // 
            this.btDeletePhoto.Location = new System.Drawing.Point(451, 170);
            this.btDeletePhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btDeletePhoto.Name = "btDeletePhoto";
            this.btDeletePhoto.Size = new System.Drawing.Size(125, 48);
            this.btDeletePhoto.TabIndex = 2;
            this.btDeletePhoto.Text = "清除照片";
            this.btDeletePhoto.UseVisualStyleBackColor = true;
            this.btDeletePhoto.Click += new System.EventHandler(this.btDeletePhoto_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 170);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 48);
            this.button4.TabIndex = 2;
            this.button4.Text = "开始拍照";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbClassName);
            this.groupBox1.Controls.Add(this.dtpBirthday);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbIdCard);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbWorkCard);
            this.groupBox1.Controls.Add(this.tbStuName);
            this.groupBox1.Location = new System.Drawing.Point(25, 294);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(963, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[学员基本信息]";
            // 
            // cbClassName
            // 
            this.cbClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassName.FormattingEnabled = true;
            this.cbClassName.Location = new System.Drawing.Point(811, 32);
            this.cbClassName.Margin = new System.Windows.Forms.Padding(4);
            this.cbClassName.Name = "cbClassName";
            this.cbClassName.Size = new System.Drawing.Size(131, 23);
            this.cbClassName.TabIndex = 4;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "yyyy-MM-dd";
            this.dtpBirthday.Font = new System.Drawing.Font("宋体", 10F);
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthday.Location = new System.Drawing.Point(527, 31);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(176, 27);
            this.dtpBirthday.TabIndex = 3;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(393, 35);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(43, 19);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(351, 35);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(43, 19);
            this.rdoMale.TabIndex = 2;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "出生日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "性别：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(667, 72);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "联系电话：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "身份证号：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "家庭地址：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "考勤卡号：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(716, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "所在班级：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "学员姓名：";
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("宋体", 10F);
            this.tbPhone.Location = new System.Drawing.Point(747, 66);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(195, 27);
            this.tbPhone.TabIndex = 0;
            // 
            // tbIdCard
            // 
            this.tbIdCard.Font = new System.Drawing.Font("宋体", 10F);
            this.tbIdCard.Location = new System.Drawing.Point(119, 66);
            this.tbIdCard.Margin = new System.Windows.Forms.Padding(4);
            this.tbIdCard.Name = "tbIdCard";
            this.tbIdCard.Size = new System.Drawing.Size(261, 27);
            this.tbIdCard.TabIndex = 0;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(119, 99);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(627, 25);
            this.tbAddress.TabIndex = 0;
            // 
            // tbWorkCard
            // 
            this.tbWorkCard.Location = new System.Drawing.Point(472, 68);
            this.tbWorkCard.Margin = new System.Windows.Forms.Padding(4);
            this.tbWorkCard.Name = "tbWorkCard";
            this.tbWorkCard.Size = new System.Drawing.Size(179, 25);
            this.tbWorkCard.TabIndex = 0;
            // 
            // tbStuName
            // 
            this.tbStuName.Location = new System.Drawing.Point(119, 32);
            this.tbStuName.Margin = new System.Windows.Forms.Padding(4);
            this.tbStuName.Name = "tbStuName";
            this.tbStuName.Size = new System.Drawing.Size(179, 25);
            this.tbStuName.TabIndex = 0;
            // 
            // btnAddStu
            // 
            this.btnAddStu.BackColor = System.Drawing.Color.LightGray;
            this.btnAddStu.Location = new System.Drawing.Point(767, 44);
            this.btnAddStu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(100, 48);
            this.btnAddStu.TabIndex = 2;
            this.btnAddStu.Text = "确认添加";
            this.btnAddStu.UseVisualStyleBackColor = false;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightGray;
            this.btnClose.Location = new System.Drawing.Point(624, 44);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 48);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btSelectPhoto
            // 
            this.btSelectPhoto.Location = new System.Drawing.Point(317, 239);
            this.btSelectPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.btSelectPhoto.Name = "btSelectPhoto";
            this.btSelectPhoto.Size = new System.Drawing.Size(125, 48);
            this.btSelectPhoto.TabIndex = 2;
            this.btSelectPhoto.Text = "选择图片";
            this.btSelectPhoto.UseVisualStyleBackColor = true;
            this.btSelectPhoto.Click += new System.EventHandler(this.btSelectPhoto_Click);
            // 
            // dgvAddStudent
            // 
            this.dgvAddStudent.AllowUserToAddRows = false;
            this.dgvAddStudent.AllowUserToDeleteRows = false;
            this.dgvAddStudent.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddStudent.ColumnHeadersHeight = 25;
            this.dgvAddStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentName,
            this.Gender,
            this.Birthday,
            this.StudentIdNo,
            this.CardNo,
            this.ClassName});
            this.dgvAddStudent.Location = new System.Drawing.Point(29, 451);
            this.dgvAddStudent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAddStudent.Name = "dgvAddStudent";
            this.dgvAddStudent.ReadOnly = true;
            this.dgvAddStudent.RowHeadersWidth = 51;
            this.dgvAddStudent.RowTemplate.Height = 23;
            this.dgvAddStudent.Size = new System.Drawing.Size(959, 180);
            this.dgvAddStudent.TabIndex = 5;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "StudentId";
            this.StudentId.HeaderText = "学号";
            this.StudentId.MinimumWidth = 6;
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentId.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "姓名";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentName.Width = 80;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "StudentName";
            this.Gender.HeaderText = "性别";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Gender.Width = 60;
            // 
            // Birthday
            // 
            this.Birthday.DataPropertyName = "Birthday";
            this.Birthday.HeaderText = "出生日期";
            this.Birthday.MinimumWidth = 6;
            this.Birthday.Name = "Birthday";
            this.Birthday.ReadOnly = true;
            this.Birthday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Birthday.Width = 125;
            // 
            // StudentIdNo
            // 
            this.StudentIdNo.DataPropertyName = "StudentIdNo";
            this.StudentIdNo.HeaderText = "身份证号";
            this.StudentIdNo.MinimumWidth = 6;
            this.StudentIdNo.Name = "StudentIdNo";
            this.StudentIdNo.ReadOnly = true;
            this.StudentIdNo.Width = 120;
            // 
            // CardNo
            // 
            this.CardNo.DataPropertyName = "CardNo";
            this.CardNo.HeaderText = "考勤卡号";
            this.CardNo.MinimumWidth = 6;
            this.CardNo.Name = "CardNo";
            this.CardNo.ReadOnly = true;
            this.CardNo.Width = 125;
            // 
            // ClassName
            // 
            this.ClassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClassName.DataPropertyName = "ClassName";
            this.ClassName.HeaderText = "所在班级";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FrmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 646);
            this.Controls.Add(this.dgvAddStudent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSelectPhoto);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btDeletePhoto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddStu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbStuPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAddStudent";
            this.Text = "添加新学员";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStuPhoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbStuPhoto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btDeletePhoto;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStuName;
        private System.Windows.Forms.ComboBox cbClassName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbIdCard;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbWorkCard;
        private System.Windows.Forms.Button btnAddStu;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btSelectPhoto;
        private System.Windows.Forms.DataGridView dgvAddStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
    }
}