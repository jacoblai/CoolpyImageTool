namespace CoolpyImageTool
{
    partial class Form1
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
            this.tb_url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_key = new System.Windows.Forms.TextBox();
            this.bt_post = new System.Windows.Forms.Button();
            this.lb_msg = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "传感器地址";
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(100, 6);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(435, 25);
            this.tb_url.TabIndex = 1;
            this.tb_url.Text = "http://localhost:1337/v1.0/device/1/sensor/66/photos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "U-ApiKey";
            // 
            // tb_key
            // 
            this.tb_key.Location = new System.Drawing.Point(100, 41);
            this.tb_key.Name = "tb_key";
            this.tb_key.Size = new System.Drawing.Size(435, 25);
            this.tb_key.TabIndex = 3;
            this.tb_key.Text = "3aa6bdfb-8b94-49e3-ad16-62bdc070f091";
            // 
            // bt_post
            // 
            this.bt_post.Location = new System.Drawing.Point(100, 72);
            this.bt_post.Name = "bt_post";
            this.bt_post.Size = new System.Drawing.Size(435, 23);
            this.bt_post.TabIndex = 4;
            this.bt_post.Text = "选择及提交图片";
            this.bt_post.UseVisualStyleBackColor = true;
            this.bt_post.Click += new System.EventHandler(this.bt_post_Click);
            // 
            // lb_msg
            // 
            this.lb_msg.FormattingEnabled = true;
            this.lb_msg.ItemHeight = 15;
            this.lb_msg.Location = new System.Drawing.Point(100, 101);
            this.lb_msg.Name = "lb_msg";
            this.lb_msg.Size = new System.Drawing.Size(435, 289);
            this.lb_msg.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 404);
            this.Controls.Add(this.lb_msg);
            this.Controls.Add(this.bt_post);
            this.Controls.Add(this.tb_key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "酷痞图像传感器上传工具 http://icoolpy.com";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_key;
        private System.Windows.Forms.Button bt_post;
        private System.Windows.Forms.ListBox lb_msg;
    }
}

