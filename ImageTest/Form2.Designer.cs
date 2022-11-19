namespace ImageTest
{
    partial class Form2
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
            this.cameraList = new System.Windows.Forms.ComboBox();
            this.start = new System.Windows.Forms.Button();
            this.psVideoSource = new AForge.Controls.VideoSourcePlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.findPictureTest = new System.Windows.Forms.Button();
            this.savePicture = new System.Windows.Forms.Button();
            this.savePictureDialog = new System.Windows.Forms.SaveFileDialog();
            this.savePictureName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openPictureDialog = new System.Windows.Forms.OpenFileDialog();
            this.openPicture = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.colorName = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureResult = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.findTextTest = new System.Windows.Forms.Button();
            this.mousePosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.is1080P = new System.Windows.Forms.CheckBox();
            this.stop = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pos = new System.Windows.Forms.ComboBox();
            this.isSplit = new System.Windows.Forms.CheckBox();
            this.pointColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pointPos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pointColorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraList
            // 
            this.cameraList.FormattingEnabled = true;
            this.cameraList.Location = new System.Drawing.Point(3, 16);
            this.cameraList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cameraList.Name = "cameraList";
            this.cameraList.Size = new System.Drawing.Size(272, 24);
            this.cameraList.TabIndex = 0;
            this.cameraList.TextChanged += new System.EventHandler(this.cameraList_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(284, 15);
            this.start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(51, 31);
            this.start.TabIndex = 1;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // psVideoSource
            // 
            this.psVideoSource.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.psVideoSource.Location = new System.Drawing.Point(3, 54);
            this.psVideoSource.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.psVideoSource.Name = "psVideoSource";
            this.psVideoSource.Size = new System.Drawing.Size(1280, 720);
            this.psVideoSource.TabIndex = 3;
            this.psVideoSource.Text = "videoSourcePlayer1";
            this.psVideoSource.VideoSource = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(3, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1280, 721);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Location = new System.Drawing.Point(0, 74);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(568, 650);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // findPictureTest
            // 
            this.findPictureTest.Location = new System.Drawing.Point(7, 4);
            this.findPictureTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findPictureTest.Name = "findPictureTest";
            this.findPictureTest.Size = new System.Drawing.Size(100, 31);
            this.findPictureTest.TabIndex = 6;
            this.findPictureTest.Text = "找图测试";
            this.findPictureTest.UseVisualStyleBackColor = true;
            this.findPictureTest.Click += new System.EventHandler(this.findPictureTest_Click);
            // 
            // savePicture
            // 
            this.savePicture.Location = new System.Drawing.Point(181, 38);
            this.savePicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePicture.Name = "savePicture";
            this.savePicture.Size = new System.Drawing.Size(100, 31);
            this.savePicture.TabIndex = 7;
            this.savePicture.Text = "保存图片";
            this.savePicture.UseVisualStyleBackColor = true;
            this.savePicture.Click += new System.EventHandler(this.savePicture_Click);
            // 
            // savePictureName
            // 
            this.savePictureName.Location = new System.Drawing.Point(67, 42);
            this.savePictureName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.savePictureName.Name = "savePictureName";
            this.savePictureName.Size = new System.Drawing.Size(101, 22);
            this.savePictureName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "图片名";
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            // 
            // openPicture
            // 
            this.openPicture.Location = new System.Drawing.Point(289, 38);
            this.openPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openPicture.Name = "openPicture";
            this.openPicture.Size = new System.Drawing.Size(100, 31);
            this.openPicture.TabIndex = 10;
            this.openPicture.Text = "加载图片";
            this.openPicture.UseVisualStyleBackColor = true;
            this.openPicture.Click += new System.EventHandler(this.openPicture_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1287, 284);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(584, 491);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.colorName);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.pictureResult);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.findPictureTest);
            this.tabPage1.Controls.Add(this.openPicture);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.savePicture);
            this.tabPage1.Controls.Add(this.savePictureName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(576, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "找图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // colorName
            // 
            this.colorName.Location = new System.Drawing.Point(397, 4);
            this.colorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorName.Name = "colorName";
            this.colorName.Size = new System.Drawing.Size(107, 22);
            this.colorName.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(289, 4);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 31);
            this.button5.TabIndex = 12;
            this.button5.Text = "测试  ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureResult
            // 
            this.pictureResult.Location = new System.Drawing.Point(115, 6);
            this.pictureResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureResult.Name = "pictureResult";
            this.pictureResult.Size = new System.Drawing.Size(165, 22);
            this.pictureResult.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textResult);
            this.tabPage2.Controls.Add(this.findTextTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(576, 462);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "找字";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 48);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 31);
            this.button4.TabIndex = 8;
            this.button4.Text = "保存图片";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 48);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "加载图片";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(4, 86);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(568, 368);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 48);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "图像处理";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 48);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "输出点阵";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(116, 12);
            this.textResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(308, 22);
            this.textResult.TabIndex = 1;
            // 
            // findTextTest
            // 
            this.findTextTest.Location = new System.Drawing.Point(8, 10);
            this.findTextTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findTextTest.Name = "findTextTest";
            this.findTextTest.Size = new System.Drawing.Size(100, 31);
            this.findTextTest.TabIndex = 0;
            this.findTextTest.Text = "找字测试";
            this.findTextTest.UseVisualStyleBackColor = true;
            this.findTextTest.Click += new System.EventHandler(this.findTextTest_Click);
            // 
            // mousePosition
            // 
            this.mousePosition.Location = new System.Drawing.Point(708, 18);
            this.mousePosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mousePosition.Name = "mousePosition";
            this.mousePosition.Size = new System.Drawing.Size(148, 22);
            this.mousePosition.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "坐标";
            // 
            // is1080P
            // 
            this.is1080P.AutoSize = true;
            this.is1080P.Checked = true;
            this.is1080P.CheckState = System.Windows.Forms.CheckState.Checked;
            this.is1080P.Location = new System.Drawing.Point(400, 21);
            this.is1080P.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.is1080P.Name = "is1080P";
            this.is1080P.Size = new System.Drawing.Size(71, 21);
            this.is1080P.TabIndex = 14;
            this.is1080P.Text = "1080P";
            this.is1080P.UseVisualStyleBackColor = true;
            this.is1080P.CheckedChanged += new System.EventHandler(this.is1080P_CheckedChanged);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(343, 16);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(49, 31);
            this.stop.TabIndex = 15;
            this.stop.Text = "暂停";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "位置";
            // 
            // pos
            // 
            this.pos.FormattingEnabled = true;
            this.pos.Items.AddRange(new object[] {
            "左上",
            "右上",
            "左下",
            "右下"});
            this.pos.Location = new System.Drawing.Point(596, 18);
            this.pos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pos.Name = "pos";
            this.pos.Size = new System.Drawing.Size(56, 24);
            this.pos.TabIndex = 18;
            this.pos.SelectedIndexChanged += new System.EventHandler(this.pos_SelectedIndexChanged);
            // 
            // isSplit
            // 
            this.isSplit.AutoSize = true;
            this.isSplit.Checked = true;
            this.isSplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isSplit.Location = new System.Drawing.Point(480, 22);
            this.isSplit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isSplit.Name = "isSplit";
            this.isSplit.Size = new System.Drawing.Size(58, 21);
            this.isSplit.TabIndex = 19;
            this.isSplit.Text = "分割";
            this.isSplit.UseVisualStyleBackColor = true;
            // 
            // pointColor
            // 
            this.pointColor.Location = new System.Drawing.Point(912, 18);
            this.pointColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pointColor.Name = "pointColor";
            this.pointColor.Size = new System.Drawing.Size(147, 22);
            this.pointColor.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(865, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "颜色";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(1287, 54);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(573, 221);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pointPos
            // 
            this.pointPos.Location = new System.Drawing.Point(1107, 20);
            this.pointPos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pointPos.Name = "pointPos";
            this.pointPos.Size = new System.Drawing.Size(93, 22);
            this.pointPos.TabIndex = 23;
            this.pointPos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1068, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "pos";
            // 
            // pointColorName
            // 
            this.pointColorName.Location = new System.Drawing.Point(1269, 18);
            this.pointColorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pointColorName.Name = "pointColorName";
            this.pointColorName.Size = new System.Drawing.Size(237, 22);
            this.pointColorName.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1207, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "颜色名";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1861, 778);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pointColorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pointPos);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pointColor);
            this.Controls.Add(this.isSplit);
            this.Controls.Add(this.pos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.is1080P);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mousePosition);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.cameraList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.psVideoSource);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "找图找色";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cameraList;
        private System.Windows.Forms.Button start;
        public AForge.Controls.VideoSourcePlayer psVideoSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button findPictureTest;
        private System.Windows.Forms.Button savePicture;
        private System.Windows.Forms.SaveFileDialog savePictureDialog;
        private System.Windows.Forms.TextBox savePictureName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openPictureDialog;
        private System.Windows.Forms.Button openPicture;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Button findTextTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox pictureResult;
        private System.Windows.Forms.TextBox mousePosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox is1080P;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox pos;
        private System.Windows.Forms.CheckBox isSplit;
        private System.Windows.Forms.TextBox pointColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox pointPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pointColorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox colorName;
    }
}

