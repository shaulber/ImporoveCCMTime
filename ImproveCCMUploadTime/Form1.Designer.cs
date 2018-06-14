namespace ImproveCCMUploadTime
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
            this.beforeBtn = new System.Windows.Forms.Button();
            this.afterBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beforeBtn
            // 
            this.beforeBtn.Location = new System.Drawing.Point(103, 71);
            this.beforeBtn.Name = "beforeBtn";
            this.beforeBtn.Size = new System.Drawing.Size(75, 23);
            this.beforeBtn.TabIndex = 0;
            this.beforeBtn.Text = "Before";
            this.beforeBtn.UseVisualStyleBackColor = true;
            this.beforeBtn.Click += new System.EventHandler(this.beforeBtn_Click);
            // 
            // afterBtn
            // 
            this.afterBtn.Location = new System.Drawing.Point(103, 100);
            this.afterBtn.Name = "afterBtn";
            this.afterBtn.Size = new System.Drawing.Size(75, 23);
            this.afterBtn.TabIndex = 1;
            this.afterBtn.Text = "After";
            this.afterBtn.UseVisualStyleBackColor = true;
            this.afterBtn.Click += new System.EventHandler(this.afterBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.afterBtn);
            this.Controls.Add(this.beforeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beforeBtn;
        private System.Windows.Forms.Button afterBtn;
    }
}

