namespace ImagePS42
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
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textResult = new System.Windows.Forms.TextBox();
            this.findTextTest = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.hashButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.hashSimilarly = new System.Windows.Forms.TextBox();
            this.hashText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.hashPosText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mousePosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pointColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pointPos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pointColorName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hashBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnColorCompute = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbColorPos = new System.Windows.Forms.TextBox();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbColorRange = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbColorBais = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbImage = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cameraList
            // 
            this.cameraList.FormattingEnabled = true;
            this.cameraList.Location = new System.Drawing.Point(2, 12);
            this.cameraList.Name = "cameraList";
            this.cameraList.Size = new System.Drawing.Size(205, 20);
            this.cameraList.TabIndex = 0;
            this.cameraList.TextChanged += new System.EventHandler(this.cameraList_TextChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(213, 11);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(38, 23);
            this.start.TabIndex = 1;
            this.start.Text = "截图";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(2, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1396, 763);
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
            this.pictureBox2.Location = new System.Drawing.Point(0, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(312, 237);
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
            this.findPictureTest.Location = new System.Drawing.Point(5, 3);
            this.findPictureTest.Name = "findPictureTest";
            this.findPictureTest.Size = new System.Drawing.Size(75, 23);
            this.findPictureTest.TabIndex = 6;
            this.findPictureTest.Text = "找图测试";
            this.findPictureTest.UseVisualStyleBackColor = true;
            this.findPictureTest.Click += new System.EventHandler(this.findPictureTest_Click);
            // 
            // savePicture
            // 
            this.savePicture.Location = new System.Drawing.Point(136, 28);
            this.savePicture.Name = "savePicture";
            this.savePicture.Size = new System.Drawing.Size(75, 23);
            this.savePicture.TabIndex = 7;
            this.savePicture.Text = "保存图片";
            this.savePicture.UseVisualStyleBackColor = true;
            this.savePicture.Click += new System.EventHandler(this.savePicture_Click);
            // 
            // savePictureName
            // 
            this.savePictureName.Location = new System.Drawing.Point(50, 32);
            this.savePictureName.Name = "savePictureName";
            this.savePictureName.Size = new System.Drawing.Size(77, 21);
            this.savePictureName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "图片名";
            // 
            // openPictureDialog
            // 
            this.openPictureDialog.FileName = "openFileDialog1";
            // 
            // openPicture
            // 
            this.openPicture.Location = new System.Drawing.Point(217, 28);
            this.openPicture.Name = "openPicture";
            this.openPicture.Size = new System.Drawing.Size(75, 23);
            this.openPicture.TabIndex = 10;
            this.openPicture.Text = "加载图片";
            this.openPicture.UseVisualStyleBackColor = true;
            this.openPicture.Click += new System.EventHandler(this.openPicture_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1401, 225);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 304);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "找图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // colorName
            // 
            this.colorName.Location = new System.Drawing.Point(256, 3);
            this.colorName.Name = "colorName";
            this.colorName.Size = new System.Drawing.Size(48, 21);
            this.colorName.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(175, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "测试  ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureResult
            // 
            this.pictureResult.Location = new System.Drawing.Point(86, 4);
            this.pictureResult.Name = "pictureResult";
            this.pictureResult.Size = new System.Drawing.Size(83, 21);
            this.pictureResult.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxThreshold);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textResult);
            this.tabPage2.Controls.Add(this.findTextTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 278);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "找字";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(87, 65);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(44, 21);
            this.textBoxThreshold.TabIndex = 10;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 65);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "二值化";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(256, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "保存图片";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(168, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "加载图片";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Location = new System.Drawing.Point(3, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(328, 271);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "放大";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "汉字识别";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(87, 9);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(232, 21);
            this.textResult.TabIndex = 1;
            // 
            // findTextTest
            // 
            this.findTextTest.Location = new System.Drawing.Point(6, 8);
            this.findTextTest.Name = "findTextTest";
            this.findTextTest.Size = new System.Drawing.Size(75, 23);
            this.findTextTest.TabIndex = 0;
            this.findTextTest.Text = "找字测试";
            this.findTextTest.UseVisualStyleBackColor = true;
            this.findTextTest.Click += new System.EventHandler(this.findTextTest_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.hashButton);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.hashSimilarly);
            this.tabPage3.Controls.Add(this.hashText);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.hashPosText);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(328, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "HASH";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // hashButton
            // 
            this.hashButton.Location = new System.Drawing.Point(170, 85);
            this.hashButton.Name = "hashButton";
            this.hashButton.Size = new System.Drawing.Size(75, 23);
            this.hashButton.TabIndex = 6;
            this.hashButton.Text = "相似";
            this.hashButton.UseVisualStyleBackColor = true;
            this.hashButton.Click += new System.EventHandler(this.hashButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "hash";
            // 
            // hashSimilarly
            // 
            this.hashSimilarly.Location = new System.Drawing.Point(64, 85);
            this.hashSimilarly.Name = "hashSimilarly";
            this.hashSimilarly.Size = new System.Drawing.Size(100, 21);
            this.hashSimilarly.TabIndex = 4;
            // 
            // hashText
            // 
            this.hashText.Location = new System.Drawing.Point(64, 55);
            this.hashText.Name = "hashText";
            this.hashText.Size = new System.Drawing.Size(197, 21);
            this.hashText.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "相似度";
            // 
            // hashPosText
            // 
            this.hashPosText.Location = new System.Drawing.Point(64, 15);
            this.hashPosText.Name = "hashPosText";
            this.hashPosText.Size = new System.Drawing.Size(197, 21);
            this.hashPosText.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "坐标";
            // 
            // mousePosition
            // 
            this.mousePosition.Location = new System.Drawing.Point(531, 14);
            this.mousePosition.Name = "mousePosition";
            this.mousePosition.Size = new System.Drawing.Size(112, 21);
            this.mousePosition.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "坐标";
            // 
            // pointColor
            // 
            this.pointColor.Location = new System.Drawing.Point(684, 14);
            this.pointColor.Name = "pointColor";
            this.pointColor.Size = new System.Drawing.Size(111, 21);
            this.pointColor.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(649, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "颜色";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(1401, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(336, 169);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pointPos
            // 
            this.pointPos.Location = new System.Drawing.Point(830, 15);
            this.pointPos.Name = "pointPos";
            this.pointPos.Size = new System.Drawing.Size(71, 21);
            this.pointPos.TabIndex = 23;
            this.pointPos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(801, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "pos";
            // 
            // pointColorName
            // 
            this.pointColorName.Location = new System.Drawing.Point(952, 14);
            this.pointColorName.Name = "pointColorName";
            this.pointColorName.Size = new System.Drawing.Size(179, 21);
            this.pointColorName.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(905, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "颜色名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "hash";
            // 
            // hashBox
            // 
            this.hashBox.Location = new System.Drawing.Point(299, 13);
            this.hashBox.Name = "hashBox";
            this.hashBox.Size = new System.Drawing.Size(191, 21);
            this.hashBox.TabIndex = 28;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tbColorBais);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.btnColorCompute);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.tbColorPos);
            this.tabPage4.Controls.Add(this.tbColor);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.tbColorRange);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(328, 278);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "找色";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnColorCompute
            // 
            this.btnColorCompute.Location = new System.Drawing.Point(17, 120);
            this.btnColorCompute.Name = "btnColorCompute";
            this.btnColorCompute.Size = new System.Drawing.Size(75, 23);
            this.btnColorCompute.TabIndex = 13;
            this.btnColorCompute.Text = "计算";
            this.btnColorCompute.UseVisualStyleBackColor = true;
            this.btnColorCompute.Click += new System.EventHandler(this.btnColorCompute_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "颜色";
            // 
            // tbColorPos
            // 
            this.tbColorPos.Location = new System.Drawing.Point(60, 83);
            this.tbColorPos.Name = "tbColorPos";
            this.tbColorPos.Size = new System.Drawing.Size(209, 21);
            this.tbColorPos.TabIndex = 11;
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(60, 53);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(100, 21);
            this.tbColor.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 9;
            this.label11.Text = "位置";
            // 
            // tbColorRange
            // 
            this.tbColorRange.Location = new System.Drawing.Point(60, 13);
            this.tbColorRange.Name = "tbColorRange";
            this.tbColorRange.Size = new System.Drawing.Size(209, 21);
            this.tbColorRange.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 7;
            this.label12.Text = "坐标";
            // 
            // tbColorBais
            // 
            this.tbColorBais.Location = new System.Drawing.Point(210, 52);
            this.tbColorBais.Name = "tbColorBais";
            this.tbColorBais.Size = new System.Drawing.Size(59, 21);
            this.tbColorBais.TabIndex = 15;
            this.tbColorBais.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(165, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "偏差";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1348, 10);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(38, 23);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbImage
            // 
            this.cbImage.FormattingEnabled = true;
            this.cbImage.Location = new System.Drawing.Point(1137, 12);
            this.cbImage.Name = "cbImage";
            this.cbImage.Size = new System.Drawing.Size(205, 20);
            this.cbImage.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1392, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(39, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 811);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cbImage);
            this.Controls.Add(this.hashBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pointColorName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pointPos);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pointColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mousePosition);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.cameraList);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "找图找色 1.0";
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
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cameraList;
        private System.Windows.Forms.Button start;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox pointColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox pointPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pointColorName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox colorName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hashBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hashPosText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button hashButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hashSimilarly;
        private System.Windows.Forms.TextBox hashText;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox tbColorBais;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnColorCompute;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbColorPos;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbColorRange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbImage;
        private System.Windows.Forms.Button btnSave;
    }
}

