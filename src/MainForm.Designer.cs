namespace WinMessageSender
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uxbtnSend = new System.Windows.Forms.Button();
            this.uxlblMessageType = new System.Windows.Forms.Label();
            this.uxtxtMessage = new System.Windows.Forms.TextBox();
            this.uxlblMessage = new System.Windows.Forms.Label();
            this.uxtxtWParam = new System.Windows.Forms.TextBox();
            this.uxlblWParam = new System.Windows.Forms.Label();
            this.uxtxtLParaam = new System.Windows.Forms.TextBox();
            this.uxlblLParam = new System.Windows.Forms.Label();
            this.uxcboMessageType = new System.Windows.Forms.ComboBox();
            this.uxlblResult = new System.Windows.Forms.Label();
            this.uxtxtHandle = new System.Windows.Forms.TextBox();
            this.uxlblHandle = new System.Windows.Forms.Label();
            this.uxchkPlusWmUser = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // uxbtnSend
            // 
            this.uxbtnSend.Enabled = false;
            this.uxbtnSend.Location = new System.Drawing.Point(124, 190);
            this.uxbtnSend.Margin = new System.Windows.Forms.Padding(4);
            this.uxbtnSend.Name = "uxbtnSend";
            this.uxbtnSend.Size = new System.Drawing.Size(88, 30);
            this.uxbtnSend.TabIndex = 9;
            this.uxbtnSend.Text = " &Send";
            this.uxbtnSend.UseVisualStyleBackColor = true;
            this.uxbtnSend.Click += new System.EventHandler(this.uxbtnSend_Click);
            // 
            // uxlblMessageType
            // 
            this.uxlblMessageType.AutoSize = true;
            this.uxlblMessageType.Location = new System.Drawing.Point(13, 14);
            this.uxlblMessageType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxlblMessageType.Name = "uxlblMessageType";
            this.uxlblMessageType.Size = new System.Drawing.Size(95, 17);
            this.uxlblMessageType.TabIndex = 11;
            this.uxlblMessageType.Text = "Message &Type:";
            // 
            // uxtxtMessage
            // 
            this.uxtxtMessage.Location = new System.Drawing.Point(124, 44);
            this.uxtxtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.uxtxtMessage.Name = "uxtxtMessage";
            this.uxtxtMessage.Size = new System.Drawing.Size(164, 25);
            this.uxtxtMessage.TabIndex = 1;
            this.uxtxtMessage.Text = "0";
            this.uxtxtMessage.TextChanged += new System.EventHandler(this.uxtxtMessage_TextChanged);
            // 
            // uxlblMessage
            // 
            this.uxlblMessage.AutoSize = true;
            this.uxlblMessage.Location = new System.Drawing.Point(13, 47);
            this.uxlblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxlblMessage.Name = "uxlblMessage";
            this.uxlblMessage.Size = new System.Drawing.Size(64, 17);
            this.uxlblMessage.TabIndex = 0;
            this.uxlblMessage.Text = "&Message:";
            // 
            // uxtxtWParam
            // 
            this.uxtxtWParam.Location = new System.Drawing.Point(124, 110);
            this.uxtxtWParam.Margin = new System.Windows.Forms.Padding(4);
            this.uxtxtWParam.Name = "uxtxtWParam";
            this.uxtxtWParam.Size = new System.Drawing.Size(164, 25);
            this.uxtxtWParam.TabIndex = 6;
            this.uxtxtWParam.Text = "0";
            this.uxtxtWParam.TextChanged += new System.EventHandler(this.uxtxtMessage_TextChanged);
            // 
            // uxlblWParam
            // 
            this.uxlblWParam.AutoSize = true;
            this.uxlblWParam.Location = new System.Drawing.Point(13, 113);
            this.uxlblWParam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxlblWParam.Name = "uxlblWParam";
            this.uxlblWParam.Size = new System.Drawing.Size(54, 17);
            this.uxlblWParam.TabIndex = 5;
            this.uxlblWParam.Text = "&wParam";
            // 
            // uxtxtLParaam
            // 
            this.uxtxtLParaam.Location = new System.Drawing.Point(124, 143);
            this.uxtxtLParaam.Margin = new System.Windows.Forms.Padding(4);
            this.uxtxtLParaam.Name = "uxtxtLParaam";
            this.uxtxtLParaam.Size = new System.Drawing.Size(164, 25);
            this.uxtxtLParaam.TabIndex = 8;
            this.uxtxtLParaam.Text = "0";
            this.uxtxtLParaam.TextChanged += new System.EventHandler(this.uxtxtMessage_TextChanged);
            // 
            // uxlblLParam
            // 
            this.uxlblLParam.AutoSize = true;
            this.uxlblLParam.Location = new System.Drawing.Point(13, 146);
            this.uxlblLParam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxlblLParam.Name = "uxlblLParam";
            this.uxlblLParam.Size = new System.Drawing.Size(48, 17);
            this.uxlblLParam.TabIndex = 7;
            this.uxlblLParam.Text = "&lParam";
            // 
            // uxcboMessageType
            // 
            this.uxcboMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxcboMessageType.FormattingEnabled = true;
            this.uxcboMessageType.Items.AddRange(new object[] {
            "PostMessage",
            "SendMessage"});
            this.uxcboMessageType.Location = new System.Drawing.Point(124, 11);
            this.uxcboMessageType.Name = "uxcboMessageType";
            this.uxcboMessageType.Size = new System.Drawing.Size(497, 25);
            this.uxcboMessageType.TabIndex = 12;
            // 
            // uxlblResult
            // 
            this.uxlblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uxlblResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxlblResult.ForeColor = System.Drawing.Color.DimGray;
            this.uxlblResult.Location = new System.Drawing.Point(124, 238);
            this.uxlblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxlblResult.Name = "uxlblResult";
            this.uxlblResult.Size = new System.Drawing.Size(496, 84);
            this.uxlblResult.TabIndex = 10;
            this.uxlblResult.Text = "Result =";
            // 
            // uxtxtHandle
            // 
            this.uxtxtHandle.Location = new System.Drawing.Point(124, 77);
            this.uxtxtHandle.Margin = new System.Windows.Forms.Padding(4);
            this.uxtxtHandle.Name = "uxtxtHandle";
            this.uxtxtHandle.Size = new System.Drawing.Size(164, 25);
            this.uxtxtHandle.TabIndex = 4;
            this.uxtxtHandle.Text = "0";
            this.uxtxtHandle.TextChanged += new System.EventHandler(this.uxtxtMessage_TextChanged);
            // 
            // uxlblHandle
            // 
            this.uxlblHandle.AutoSize = true;
            this.uxlblHandle.Location = new System.Drawing.Point(13, 80);
            this.uxlblHandle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxlblHandle.Name = "uxlblHandle";
            this.uxlblHandle.Size = new System.Drawing.Size(52, 17);
            this.uxlblHandle.TabIndex = 3;
            this.uxlblHandle.Text = "&Handle:";
            // 
            // uxchkPlusWmUser
            // 
            this.uxchkPlusWmUser.AutoSize = true;
            this.uxchkPlusWmUser.Checked = true;
            this.uxchkPlusWmUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.uxchkPlusWmUser.Location = new System.Drawing.Point(301, 46);
            this.uxchkPlusWmUser.Name = "uxchkPlusWmUser";
            this.uxchkPlusWmUser.Size = new System.Drawing.Size(153, 21);
            this.uxchkPlusWmUser.TabIndex = 2;
            this.uxchkPlusWmUser.Text = "+ WM_USE&R (0x0400)";
            this.uxchkPlusWmUser.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 338);
            this.Controls.Add(this.uxchkPlusWmUser);
            this.Controls.Add(this.uxtxtHandle);
            this.Controls.Add(this.uxlblHandle);
            this.Controls.Add(this.uxlblResult);
            this.Controls.Add(this.uxcboMessageType);
            this.Controls.Add(this.uxtxtLParaam);
            this.Controls.Add(this.uxlblLParam);
            this.Controls.Add(this.uxtxtWParam);
            this.Controls.Add(this.uxlblWParam);
            this.Controls.Add(this.uxtxtMessage);
            this.Controls.Add(this.uxlblMessage);
            this.Controls.Add(this.uxlblMessageType);
            this.Controls.Add(this.uxbtnSend);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Message Sender";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxbtnSend;
        private System.Windows.Forms.Label uxlblMessageType;
        private System.Windows.Forms.TextBox uxtxtMessage;
        private System.Windows.Forms.Label uxlblMessage;
        private System.Windows.Forms.TextBox uxtxtWParam;
        private System.Windows.Forms.Label uxlblWParam;
        private System.Windows.Forms.TextBox uxtxtLParaam;
        private System.Windows.Forms.Label uxlblLParam;
        private System.Windows.Forms.ComboBox uxcboMessageType;
        private System.Windows.Forms.Label uxlblResult;
        private System.Windows.Forms.TextBox uxtxtHandle;
        private System.Windows.Forms.Label uxlblHandle;
        private System.Windows.Forms.CheckBox uxchkPlusWmUser;
    }
}

