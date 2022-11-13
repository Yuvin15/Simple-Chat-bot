namespace Chat
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.humanMessage = new System.Windows.Forms.TextBox();
            this.AI_Message = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // humanMessage
            // 
            this.humanMessage.Location = new System.Drawing.Point(59, 44);
            this.humanMessage.Multiline = true;
            this.humanMessage.Name = "humanMessage";
            this.humanMessage.Size = new System.Drawing.Size(257, 110);
            this.humanMessage.TabIndex = 0;
            this.humanMessage.TextChanged += new System.EventHandler(this.humanMessage_TextChanged);
            // 
            // AI_Message
            // 
            this.AI_Message.Location = new System.Drawing.Point(59, 317);
            this.AI_Message.Multiline = true;
            this.AI_Message.Name = "AI_Message";
            this.AI_Message.Size = new System.Drawing.Size(257, 110);
            this.AI_Message.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Response";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AI_Message);
            this.Controls.Add(this.humanMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox humanMessage;
        private TextBox AI_Message;
        private Button button1;
    }
}