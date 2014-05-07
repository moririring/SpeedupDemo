namespace WindowsFormsApplication3
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.forButton = new System.Windows.Forms.Button();
            this.parallelForButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.progress2ProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressButton = new System.Windows.Forms.Button();
            this.progressCancelButton = new System.Windows.Forms.Button();
            this.buttonOffbutton = new System.Windows.Forms.Button();
            this.popupButton = new System.Windows.Forms.Button();
            this.normalButton = new System.Windows.Forms.Button();
            this.progress1ProgressBar = new System.Windows.Forms.ProgressBar();
            this.threadButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // forButton
            // 
            this.forButton.Location = new System.Drawing.Point(6, 18);
            this.forButton.Name = "forButton";
            this.forButton.Size = new System.Drawing.Size(75, 23);
            this.forButton.TabIndex = 0;
            this.forButton.Text = "for";
            this.forButton.UseVisualStyleBackColor = true;
            this.forButton.Click += new System.EventHandler(this.forButton_Click);
            // 
            // parallelForButton
            // 
            this.parallelForButton.Location = new System.Drawing.Point(6, 47);
            this.parallelForButton.Name = "parallelForButton";
            this.parallelForButton.Size = new System.Drawing.Size(75, 23);
            this.parallelForButton.TabIndex = 2;
            this.parallelForButton.Text = "Parallel.For";
            this.parallelForButton.UseVisualStyleBackColor = true;
            this.parallelForButton.Click += new System.EventHandler(this.parallelForButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.forButton);
            this.groupBox1.Controls.Add(this.parallelForButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 83);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "マルチコア";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.progress2ProgressBar);
            this.groupBox2.Controls.Add(this.progressButton);
            this.groupBox2.Controls.Add(this.progressCancelButton);
            this.groupBox2.Controls.Add(this.buttonOffbutton);
            this.groupBox2.Controls.Add(this.popupButton);
            this.groupBox2.Controls.Add(this.normalButton);
            this.groupBox2.Controls.Add(this.progress1ProgressBar);
            this.groupBox2.Controls.Add(this.threadButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 193);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "マルチスレッド";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(193, 162);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(61, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // progress2ProgressBar
            // 
            this.progress2ProgressBar.Location = new System.Drawing.Point(87, 162);
            this.progress2ProgressBar.Name = "progress2ProgressBar";
            this.progress2ProgressBar.Size = new System.Drawing.Size(100, 23);
            this.progress2ProgressBar.TabIndex = 8;
            // 
            // progressButton
            // 
            this.progressButton.Location = new System.Drawing.Point(6, 133);
            this.progressButton.Name = "progressButton";
            this.progressButton.Size = new System.Drawing.Size(75, 23);
            this.progressButton.TabIndex = 6;
            this.progressButton.Text = "プログレス1";
            this.progressButton.UseVisualStyleBackColor = true;
            this.progressButton.Click += new System.EventHandler(this.progressButton_Click);
            // 
            // progressCancelButton
            // 
            this.progressCancelButton.Location = new System.Drawing.Point(6, 162);
            this.progressCancelButton.Name = "progressCancelButton";
            this.progressCancelButton.Size = new System.Drawing.Size(75, 23);
            this.progressCancelButton.TabIndex = 7;
            this.progressCancelButton.Text = "プログレス2";
            this.progressCancelButton.UseVisualStyleBackColor = true;
            this.progressCancelButton.Click += new System.EventHandler(this.progressCancelButton_Click);
            // 
            // buttonOffbutton
            // 
            this.buttonOffbutton.Location = new System.Drawing.Point(6, 75);
            this.buttonOffbutton.Name = "buttonOffbutton";
            this.buttonOffbutton.Size = new System.Drawing.Size(75, 23);
            this.buttonOffbutton.TabIndex = 4;
            this.buttonOffbutton.Text = "ボタンオフ";
            this.buttonOffbutton.UseVisualStyleBackColor = true;
            this.buttonOffbutton.Click += new System.EventHandler(this.buttonOffbutton_Click);
            // 
            // popupButton
            // 
            this.popupButton.Location = new System.Drawing.Point(6, 104);
            this.popupButton.Name = "popupButton";
            this.popupButton.Size = new System.Drawing.Size(75, 23);
            this.popupButton.TabIndex = 5;
            this.popupButton.Text = "ポップアップ";
            this.popupButton.UseVisualStyleBackColor = true;
            this.popupButton.Click += new System.EventHandler(this.popupButton_Click);
            // 
            // normalButton
            // 
            this.normalButton.Location = new System.Drawing.Point(6, 18);
            this.normalButton.Name = "normalButton";
            this.normalButton.Size = new System.Drawing.Size(75, 23);
            this.normalButton.TabIndex = 0;
            this.normalButton.Text = "ノーマル";
            this.normalButton.UseVisualStyleBackColor = true;
            this.normalButton.Click += new System.EventHandler(this.normalButton_Click);
            // 
            // progress1ProgressBar
            // 
            this.progress1ProgressBar.Location = new System.Drawing.Point(87, 133);
            this.progress1ProgressBar.Name = "progress1ProgressBar";
            this.progress1ProgressBar.Size = new System.Drawing.Size(100, 23);
            this.progress1ProgressBar.TabIndex = 3;
            // 
            // threadButton
            // 
            this.threadButton.Location = new System.Drawing.Point(6, 47);
            this.threadButton.Name = "threadButton";
            this.threadButton.Size = new System.Drawing.Size(75, 23);
            this.threadButton.TabIndex = 2;
            this.threadButton.Text = "スレッド";
            this.threadButton.UseVisualStyleBackColor = true;
            this.threadButton.Click += new System.EventHandler(this.threadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Button parallelForButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button normalButton;
        private System.Windows.Forms.ProgressBar progress1ProgressBar;
        private System.Windows.Forms.Button threadButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ProgressBar progress2ProgressBar;
        private System.Windows.Forms.Button progressButton;
        private System.Windows.Forms.Button progressCancelButton;
        private System.Windows.Forms.Button buttonOffbutton;
        private System.Windows.Forms.Button popupButton;
    }
}

