namespace RealTimeImageCutDisplay
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.capButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 341);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxDirectory
            // 
            this.textBoxDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDirectory.Enabled = false;
            this.textBoxDirectory.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDirectory.Location = new System.Drawing.Point(219, 3);
            this.textBoxDirectory.Name = "textBoxDirectory";
            this.textBoxDirectory.Size = new System.Drawing.Size(68, 25);
            this.textBoxDirectory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(0, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "y";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxHeight.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxHeight.Location = new System.Drawing.Point(107, 31);
            this.textBoxHeight.MaxLength = 4;
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(40, 25);
            this.textBoxHeight.TabIndex = 4;
            this.textBoxHeight.Text = "520";
            this.textBoxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxY
            // 
            this.textBoxY.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxY.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxY.Location = new System.Drawing.Point(18, 31);
            this.textBoxY.MaxLength = 4;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(40, 25);
            this.textBoxY.TabIndex = 2;
            this.textBoxY.Text = "85";
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxX
            // 
            this.textBoxX.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxX.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxX.Location = new System.Drawing.Point(18, 2);
            this.textBoxX.MaxLength = 4;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(40, 25);
            this.textBoxX.TabIndex = 1;
            this.textBoxX.Text = "800";
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxWidth.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textBoxWidth.Location = new System.Drawing.Point(107, 2);
            this.textBoxWidth.MaxLength = 4;
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(40, 25);
            this.textBoxWidth.TabIndex = 3;
            this.textBoxWidth.Text = "270";
            this.textBoxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(0, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "x";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(64, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "width";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(61, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(151, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Directory";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(250, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 500;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // capButton
            // 
            this.capButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.capButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("capButton.BackgroundImage")));
            this.capButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.capButton.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.capButton.Location = new System.Drawing.Point(154, 30);
            this.capButton.Name = "capButton";
            this.capButton.Size = new System.Drawing.Size(96, 25);
            this.capButton.TabIndex = 11;
            this.capButton.UseVisualStyleBackColor = true;
            this.capButton.Click += new System.EventHandler(this.capButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 398);
            this.Controls.Add(this.capButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDirectory);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RealTimeImageCutDisplay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Move += new System.EventHandler(this.Form1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Button capButton;
    }
}

