
namespace WinformText
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.btLoadData = new System.Windows.Forms.Button();
            this.btClearData = new System.Windows.Forms.Button();
            this.btnSerialSave = new System.Windows.Forms.Button();
            this.btnSaveCSV = new System.Windows.Forms.Button();
            this.btnSaveTxt = new System.Windows.Forms.Button();
            this.btCreateRandomData = new System.Windows.Forms.Button();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.tbCTData = new System.Windows.Forms.TextBox();
            this.tbUPH = new System.Windows.Forms.TextBox();
            this.tbYield = new System.Windows.Forms.TextBox();
            this.tbNgTotal = new System.Windows.Forms.TextBox();
            this.tbInputTotal = new System.Windows.Forms.TextBox();
            this.tbOutputTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 25F);
            this.label1.Location = new System.Drawing.Point(135, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "生产数据统计";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.propertyGrid1);
            this.groupBox1.Location = new System.Drawing.Point(401, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 415);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "属性控件保存";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(6, 22);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(375, 368);
            this.propertyGrid1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSavePath);
            this.groupBox2.Controls.Add(this.btLoadData);
            this.groupBox2.Controls.Add(this.btClearData);
            this.groupBox2.Controls.Add(this.btnSerialSave);
            this.groupBox2.Controls.Add(this.btnSaveCSV);
            this.groupBox2.Controls.Add(this.btnSaveTxt);
            this.groupBox2.Controls.Add(this.btCreateRandomData);
            this.groupBox2.Controls.Add(this.tbFilePath);
            this.groupBox2.Controls.Add(this.tbCTData);
            this.groupBox2.Controls.Add(this.tbUPH);
            this.groupBox2.Controls.Add(this.tbYield);
            this.groupBox2.Controls.Add(this.tbNgTotal);
            this.groupBox2.Controls.Add(this.tbInputTotal);
            this.groupBox2.Controls.Add(this.tbOutputTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(13, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 415);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "生产数据保存";
            // 
            // btnSavePath
            // 
            this.btnSavePath.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSavePath.Location = new System.Drawing.Point(275, 330);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(100, 23);
            this.btnSavePath.TabIndex = 34;
            this.btnSavePath.Text = "保存路径";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // btLoadData
            // 
            this.btLoadData.Font = new System.Drawing.Font("宋体", 10F);
            this.btLoadData.Location = new System.Drawing.Point(275, 292);
            this.btLoadData.Name = "btLoadData";
            this.btLoadData.Size = new System.Drawing.Size(100, 23);
            this.btLoadData.TabIndex = 33;
            this.btLoadData.Text = "加载生产数据";
            this.btLoadData.UseVisualStyleBackColor = true;
            this.btLoadData.Click += new System.EventHandler(this.btLoadData_Click);
            // 
            // btClearData
            // 
            this.btClearData.Font = new System.Drawing.Font("宋体", 10F);
            this.btClearData.Location = new System.Drawing.Point(128, 292);
            this.btClearData.Name = "btClearData";
            this.btClearData.Size = new System.Drawing.Size(100, 23);
            this.btClearData.TabIndex = 32;
            this.btClearData.Text = "清除生产数据";
            this.btClearData.UseVisualStyleBackColor = true;
            this.btClearData.Click += new System.EventHandler(this.btClearData_Click);
            // 
            // btnSerialSave
            // 
            this.btnSerialSave.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSerialSave.Location = new System.Drawing.Point(275, 367);
            this.btnSerialSave.Name = "btnSerialSave";
            this.btnSerialSave.Size = new System.Drawing.Size(104, 23);
            this.btnSerialSave.TabIndex = 31;
            this.btnSerialSave.Text = "序列化保存";
            this.btnSerialSave.UseVisualStyleBackColor = true;
            this.btnSerialSave.Click += new System.EventHandler(this.btnSerialSave_Click);
            // 
            // btnSaveCSV
            // 
            this.btnSaveCSV.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSaveCSV.Location = new System.Drawing.Point(134, 367);
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.Size = new System.Drawing.Size(104, 23);
            this.btnSaveCSV.TabIndex = 30;
            this.btnSaveCSV.Text = "保存至CSV";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
            // 
            // btnSaveTxt
            // 
            this.btnSaveTxt.Font = new System.Drawing.Font("宋体", 10F);
            this.btnSaveTxt.Location = new System.Drawing.Point(-5, 367);
            this.btnSaveTxt.Name = "btnSaveTxt";
            this.btnSaveTxt.Size = new System.Drawing.Size(104, 23);
            this.btnSaveTxt.TabIndex = 29;
            this.btnSaveTxt.Text = "保存至TXT";
            this.btnSaveTxt.UseVisualStyleBackColor = true;
            this.btnSaveTxt.Click += new System.EventHandler(this.btnSaveTxt_Click);
            // 
            // btCreateRandomData
            // 
            this.btCreateRandomData.Font = new System.Drawing.Font("宋体", 10F);
            this.btCreateRandomData.Location = new System.Drawing.Point(-6, 292);
            this.btCreateRandomData.Name = "btCreateRandomData";
            this.btCreateRandomData.Size = new System.Drawing.Size(104, 23);
            this.btCreateRandomData.TabIndex = 28;
            this.btCreateRandomData.Text = "生成随机数据";
            this.btCreateRandomData.UseVisualStyleBackColor = true;
            this.btCreateRandomData.Click += new System.EventHandler(this.btCreateRandomData_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFilePath.Location = new System.Drawing.Point(123, 327);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(132, 26);
            this.tbFilePath.TabIndex = 26;
            // 
            // tbCTData
            // 
            this.tbCTData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCTData.Location = new System.Drawing.Point(138, 242);
            this.tbCTData.Name = "tbCTData";
            this.tbCTData.Size = new System.Drawing.Size(100, 19);
            this.tbCTData.TabIndex = 25;
            // 
            // tbUPH
            // 
            this.tbUPH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUPH.Location = new System.Drawing.Point(138, 197);
            this.tbUPH.Name = "tbUPH";
            this.tbUPH.Size = new System.Drawing.Size(100, 19);
            this.tbUPH.TabIndex = 24;
            // 
            // tbYield
            // 
            this.tbYield.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbYield.Location = new System.Drawing.Point(138, 150);
            this.tbYield.Name = "tbYield";
            this.tbYield.Size = new System.Drawing.Size(100, 19);
            this.tbYield.TabIndex = 23;
            // 
            // tbNgTotal
            // 
            this.tbNgTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNgTotal.Location = new System.Drawing.Point(138, 106);
            this.tbNgTotal.Name = "tbNgTotal";
            this.tbNgTotal.Size = new System.Drawing.Size(100, 19);
            this.tbNgTotal.TabIndex = 22;
            // 
            // tbInputTotal
            // 
            this.tbInputTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInputTotal.Location = new System.Drawing.Point(139, 25);
            this.tbInputTotal.Name = "tbInputTotal";
            this.tbInputTotal.Size = new System.Drawing.Size(100, 19);
            this.tbInputTotal.TabIndex = 27;
            // 
            // tbOutputTotal
            // 
            this.tbOutputTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOutputTotal.Location = new System.Drawing.Point(138, 63);
            this.tbOutputTotal.Name = "tbOutputTotal";
            this.tbOutputTotal.Size = new System.Drawing.Size(100, 19);
            this.tbOutputTotal.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(34, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "实时CT：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(26, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "小时UPH：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(18, 151);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "生产良率：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(34, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "NG总数：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "产出总数：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F);
            this.label13.Location = new System.Drawing.Point(297, 242);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "S";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F);
            this.label12.Location = new System.Drawing.Point(297, 197);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "pcs";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.Location = new System.Drawing.Point(297, 150);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.Location = new System.Drawing.Point(297, 106);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "pcs";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.Location = new System.Drawing.Point(297, 63);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "pcs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(297, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "pcs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(135, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F);
            this.label15.Location = new System.Drawing.Point(-4, 332);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 16);
            this.label15.TabIndex = 20;
            this.label15.Text = "文件保存路径：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F);
            this.label16.Location = new System.Drawing.Point(18, 26);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 7;
            this.label16.Text = "投入总数：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F);
            this.label14.Location = new System.Drawing.Point(132, -8);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(696, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "属性保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 499);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.Button btLoadData;
        private System.Windows.Forms.Button btClearData;
        private System.Windows.Forms.Button btnSerialSave;
        private System.Windows.Forms.Button btnSaveCSV;
        private System.Windows.Forms.Button btnSaveTxt;
        private System.Windows.Forms.Button btCreateRandomData;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.TextBox tbCTData;
        private System.Windows.Forms.TextBox tbUPH;
        private System.Windows.Forms.TextBox tbYield;
        private System.Windows.Forms.TextBox tbNgTotal;
        private System.Windows.Forms.TextBox tbInputTotal;
        private System.Windows.Forms.TextBox tbOutputTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
    }
}

