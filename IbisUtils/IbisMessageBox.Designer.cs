namespace IbisUtils
{
    partial class IbisMessageBox
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
            this.Content = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(33, 34);
            this.Content.MaxLength = 65535;
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Size = new System.Drawing.Size(748, 352);
            this.Content.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(637, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(144, 52);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // IbisMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 479);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Content);
            this.Name = "IbisMessageBox";
            this.Text = "IbisMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.Button btnClose;
    }
}