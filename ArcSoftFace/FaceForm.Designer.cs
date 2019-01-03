namespace ArcSoftFace
{
    partial class FaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaceForm));
            this.picImageCompare = new System.Windows.Forms.PictureBox();
            this.lblImageList = new System.Windows.Forms.Label();
            this.chooseMultiImgBtn = new System.Windows.Forms.Button();
            this.logBox = new System.Windows.Forms.TextBox();
            this.chooseImgBtn = new System.Windows.Forms.Button();
            this.imageLists = new System.Windows.Forms.ImageList(this.components);
            this.imageList = new System.Windows.Forms.ListView();
            this.matchBtn = new System.Windows.Forms.Button();
            this.btnClearFaceList = new System.Windows.Forms.Button();
            this.lblCompareImage = new System.Windows.Forms.Label();
            this.lblCompareInfo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            ((System.ComponentModel.ISupportInitialize)(this.picImageCompare)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageCompare
            // 
            this.picImageCompare.BackColor = System.Drawing.Color.White;
            this.picImageCompare.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picImageCompare.Location = new System.Drawing.Point(1508, 92);
            this.picImageCompare.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.picImageCompare.Name = "picImageCompare";
            this.picImageCompare.Size = new System.Drawing.Size(759, 899);
            this.picImageCompare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImageCompare.TabIndex = 1;
            this.picImageCompare.TabStop = false;
            // 
            // lblImageList
            // 
            this.lblImageList.AutoSize = true;
            this.lblImageList.Location = new System.Drawing.Point(30, 28);
            this.lblImageList.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblImageList.Name = "lblImageList";
            this.lblImageList.Size = new System.Drawing.Size(118, 30);
            this.lblImageList.TabIndex = 7;
            this.lblImageList.Text = "人脸库:";
            // 
            // chooseMultiImgBtn
            // 
            this.chooseMultiImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseMultiImgBtn.Location = new System.Drawing.Point(35, 1078);
            this.chooseMultiImgBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.chooseMultiImgBtn.Name = "chooseMultiImgBtn";
            this.chooseMultiImgBtn.Size = new System.Drawing.Size(332, 65);
            this.chooseMultiImgBtn.TabIndex = 32;
            this.chooseMultiImgBtn.Text = "注册人脸";
            this.chooseMultiImgBtn.UseVisualStyleBackColor = true;
            this.chooseMultiImgBtn.Click += new System.EventHandler(this.ChooseMultiImg);
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.White;
            this.logBox.Location = new System.Drawing.Point(35, 1192);
            this.logBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.Size = new System.Drawing.Size(2232, 332);
            this.logBox.TabIndex = 31;
            // 
            // chooseImgBtn
            // 
            this.chooseImgBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseImgBtn.Location = new System.Drawing.Point(1508, 1078);
            this.chooseImgBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.chooseImgBtn.Name = "chooseImgBtn";
            this.chooseImgBtn.Size = new System.Drawing.Size(300, 65);
            this.chooseImgBtn.TabIndex = 30;
            this.chooseImgBtn.Text = "选择识别图";
            this.chooseImgBtn.UseVisualStyleBackColor = true;
            this.chooseImgBtn.Click += new System.EventHandler(this.ChooseImg);
            // 
            // imageLists
            // 
            this.imageLists.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLists.ImageStream")));
            this.imageLists.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLists.Images.SetKeyName(0, "alai_152784032385984494.jpg");
            // 
            // imageList
            // 
            this.imageList.LargeImageList = this.imageLists;
            this.imageList.Location = new System.Drawing.Point(35, 92);
            this.imageList.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(1312, 899);
            this.imageList.TabIndex = 33;
            this.imageList.UseCompatibleStateImageBehavior = false;
            // 
            // matchBtn
            // 
            this.matchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matchBtn.Location = new System.Drawing.Point(1952, 1078);
            this.matchBtn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.matchBtn.Name = "matchBtn";
            this.matchBtn.Size = new System.Drawing.Size(320, 65);
            this.matchBtn.TabIndex = 34;
            this.matchBtn.Text = "开始匹配";
            this.matchBtn.UseVisualStyleBackColor = true;
            this.matchBtn.Click += new System.EventHandler(this.matchBtn_Click);
            // 
            // btnClearFaceList
            // 
            this.btnClearFaceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFaceList.Location = new System.Drawing.Point(1040, 1078);
            this.btnClearFaceList.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnClearFaceList.Name = "btnClearFaceList";
            this.btnClearFaceList.Size = new System.Drawing.Size(312, 65);
            this.btnClearFaceList.TabIndex = 35;
            this.btnClearFaceList.Text = "清空人脸库";
            this.btnClearFaceList.UseVisualStyleBackColor = true;
            this.btnClearFaceList.Click += new System.EventHandler(this.btnClearFaceList_Click);
            // 
            // lblCompareImage
            // 
            this.lblCompareImage.AutoSize = true;
            this.lblCompareImage.Location = new System.Drawing.Point(1502, 28);
            this.lblCompareImage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCompareImage.Name = "lblCompareImage";
            this.lblCompareImage.Size = new System.Drawing.Size(148, 30);
            this.lblCompareImage.TabIndex = 36;
            this.lblCompareImage.Text = "比对人脸:";
            // 
            // lblCompareInfo
            // 
            this.lblCompareInfo.AutoSize = true;
            this.lblCompareInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompareInfo.Location = new System.Drawing.Point(1668, 28);
            this.lblCompareInfo.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCompareInfo.Name = "lblCompareInfo";
            this.lblCompareInfo.Size = new System.Drawing.Size(0, 40);
            this.lblCompareInfo.TabIndex = 37;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1197, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 42);
            this.textBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1014, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "请输入名字:";
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Location = new System.Drawing.Point(1507, 288);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(760, 570);
            this.videoSourcePlayer1.TabIndex = 40;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            this.videoSourcePlayer1.Click += new System.EventHandler(this.videoSourcePlayer1_Click);
            // 
            // FaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2318, 1570);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCompareInfo);
            this.Controls.Add(this.lblCompareImage);
            this.Controls.Add(this.btnClearFaceList);
            this.Controls.Add(this.matchBtn);
            this.Controls.Add(this.imageList);
            this.Controls.Add(this.chooseMultiImgBtn);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.chooseImgBtn);
            this.Controls.Add(this.lblImageList);
            this.Controls.Add(this.picImageCompare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MinimumSize = new System.Drawing.Size(2350, 1658);
            this.Name = "FaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人脸识别系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Closed);
            ((System.ComponentModel.ISupportInitialize)(this.picImageCompare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageCompare;
        private System.Windows.Forms.Label lblImageList;
        private System.Windows.Forms.Button chooseMultiImgBtn;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.Button chooseImgBtn;
        private System.Windows.Forms.ImageList imageLists;
        private System.Windows.Forms.ListView imageList;
        private System.Windows.Forms.Button matchBtn;
        private System.Windows.Forms.Button btnClearFaceList;
        private System.Windows.Forms.Label lblCompareImage;
        private System.Windows.Forms.Label lblCompareInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
    }
}

