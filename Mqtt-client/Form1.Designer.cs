namespace Mqtt_Client
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
            this.sendTxtBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.receiveTxtBox = new System.Windows.Forms.RichTextBox();
            this.subscribeTopicsBtn = new System.Windows.Forms.Button();
            this.cancelSubscribeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendTxtBox
            // 
            this.sendTxtBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendTxtBox.Location = new System.Drawing.Point(13, 341);
            this.sendTxtBox.Multiline = true;
            this.sendTxtBox.Name = "sendTxtBox";
            this.sendTxtBox.Size = new System.Drawing.Size(401, 97);
            this.sendTxtBox.TabIndex = 1;
            this.sendTxtBox.Text = "这是一个Mqtt客户端测试程序！";
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(614, 331);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(164, 50);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "发布消息";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(614, 388);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(164, 50);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "关闭";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // receiveTxtBox
            // 
            this.receiveTxtBox.BackColor = System.Drawing.SystemColors.Window;
            this.receiveTxtBox.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.receiveTxtBox.Location = new System.Drawing.Point(13, 13);
            this.receiveTxtBox.Name = "receiveTxtBox";
            this.receiveTxtBox.ReadOnly = true;
            this.receiveTxtBox.Size = new System.Drawing.Size(775, 309);
            this.receiveTxtBox.TabIndex = 3;
            this.receiveTxtBox.Text = "";
            // 
            // subscribeTopicsBtn
            // 
            this.subscribeTopicsBtn.Location = new System.Drawing.Point(444, 331);
            this.subscribeTopicsBtn.Name = "subscribeTopicsBtn";
            this.subscribeTopicsBtn.Size = new System.Drawing.Size(164, 50);
            this.subscribeTopicsBtn.TabIndex = 2;
            this.subscribeTopicsBtn.Text = "订阅主题";
            this.subscribeTopicsBtn.UseVisualStyleBackColor = true;
            this.subscribeTopicsBtn.Click += new System.EventHandler(this.subscribeTopicsBtn_Click);
            // 
            // cancelSubscribeBtn
            // 
            this.cancelSubscribeBtn.Location = new System.Drawing.Point(444, 388);
            this.cancelSubscribeBtn.Name = "cancelSubscribeBtn";
            this.cancelSubscribeBtn.Size = new System.Drawing.Size(164, 50);
            this.cancelSubscribeBtn.TabIndex = 2;
            this.cancelSubscribeBtn.Text = "取消订阅";
            this.cancelSubscribeBtn.UseVisualStyleBackColor = true;
            this.cancelSubscribeBtn.Click += new System.EventHandler(this.cancelSubscribeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiveTxtBox);
            this.Controls.Add(this.cancelSubscribeBtn);
            this.Controls.Add(this.subscribeTopicsBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendTxtBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mqtt客户端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        //void client_mqttmsgpublishreceived(object sender, mqttmsgpublisheventargs e)
        //{
        //    //处理接收到的消息
        //    string msg = system.text.encoding.default.getstring(e.message);
        //    receivetxtbox.appendtext("收到消息：" + msg + "\r\n");
        //}
        private System.Windows.Forms.TextBox sendTxtBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RichTextBox receiveTxtBox;
        private System.Windows.Forms.Button subscribeTopicsBtn;
        private System.Windows.Forms.Button cancelSubscribeBtn;
    }
}

