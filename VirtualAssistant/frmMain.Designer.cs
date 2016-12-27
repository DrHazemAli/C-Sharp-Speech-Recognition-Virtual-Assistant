namespace VirtualAssistant
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSpeak = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.ProgVoice = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnSpeak
            // 
            this.btnSpeak.Image = ((System.Drawing.Image)(resources.GetObject("btnSpeak.Image")));
            this.btnSpeak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpeak.Location = new System.Drawing.Point(88, 307);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(144, 36);
            this.btnSpeak.TabIndex = 0;
            this.btnSpeak.Text = "Speak!";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // txtChat
            // 
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(152)))), ((int)(((byte)(223)))));
            this.txtChat.Location = new System.Drawing.Point(14, 12);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(286, 287);
            this.txtChat.TabIndex = 1;
            this.txtChat.Text = "";
            // 
            // ProgVoice
            // 
            this.ProgVoice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgVoice.Location = new System.Drawing.Point(0, 360);
            this.ProgVoice.Name = "ProgVoice";
            this.ProgVoice.Size = new System.Drawing.Size(319, 15);
            this.ProgVoice.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 375);
            this.Controls.Add(this.ProgVoice);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.btnSpeak);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Assistant";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.ProgressBar ProgVoice;
    }
}

