namespace anti_identifier
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pic = new System.Windows.Forms.PictureBox();
            this.forward_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.view_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Load_button = new System.Windows.Forms.Button();
            this.pen_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.chose_destination_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(34, 171);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(532, 519);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // forward_button
            // 
            this.forward_button.Location = new System.Drawing.Point(34, 112);
            this.forward_button.Name = "forward_button";
            this.forward_button.Size = new System.Drawing.Size(84, 33);
            this.forward_button.TabIndex = 1;
            this.forward_button.Text = "上一張";
            this.forward_button.UseVisualStyleBackColor = true;
            this.forward_button.Click += new System.EventHandler(this.forward_button_Click);
            // 
            // next_button
            // 
            this.next_button.Location = new System.Drawing.Point(446, 112);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(84, 33);
            this.next_button.TabIndex = 2;
            this.next_button.Text = "下一張";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // view_button
            // 
            this.view_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.view_button.Location = new System.Drawing.Point(541, 228);
            this.view_button.Name = "view_button";
            this.view_button.Size = new System.Drawing.Size(109, 38);
            this.view_button.TabIndex = 3;
            this.view_button.Text = "選擇資料夾";
            this.view_button.UseVisualStyleBackColor = true;
            this.view_button.Click += new System.EventHandler(this.view_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(541, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 4;
            // 
            // Load_button
            // 
            this.Load_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Load_button.Location = new System.Drawing.Point(541, 290);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(109, 36);
            this.Load_button.TabIndex = 5;
            this.Load_button.Text = "載入";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // pen_button
            // 
            this.pen_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pen_button.Location = new System.Drawing.Point(541, 354);
            this.pen_button.Name = "pen_button";
            this.pen_button.Size = new System.Drawing.Size(109, 32);
            this.pen_button.TabIndex = 6;
            this.pen_button.Text = "遮蔽";
            this.pen_button.UseVisualStyleBackColor = true;
            this.pen_button.Click += new System.EventHandler(this.pen_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_button.Location = new System.Drawing.Point(541, 488);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(109, 32);
            this.reset_button.TabIndex = 8;
            this.reset_button.Text = "取消";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(541, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "儲存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(696, 171);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // chose_destination_button
            // 
            this.chose_destination_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chose_destination_button.Location = new System.Drawing.Point(696, 228);
            this.chose_destination_button.Name = "chose_destination_button";
            this.chose_destination_button.Size = new System.Drawing.Size(109, 38);
            this.chose_destination_button.TabIndex = 11;
            this.chose_destination_button.Text = "選擇目的地";
            this.chose_destination_button.UseVisualStyleBackColor = true;
            this.chose_destination_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(979, 686);
            this.Controls.Add(this.chose_destination_button);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.pen_button);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.view_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.forward_button);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button forward_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button view_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button pen_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button chose_destination_button;
    }
}

