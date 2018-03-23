namespace RoundCornerControlExample
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
            this.roundCornerControl1 = new RoundCornerControlExample.RoundCornerControl();
            this.roundCornerControl2 = new RoundCornerControlExample.RoundCornerControl();
            this.SuspendLayout();
            // 
            // roundCornerControl1
            // 
            this.roundCornerControl1.BackColor = System.Drawing.Color.Red;
            this.roundCornerControl1.Location = new System.Drawing.Point(12, 12);
            this.roundCornerControl1.Name = "roundCornerControl1";
            this.roundCornerControl1.Size = new System.Drawing.Size(151, 90);
            this.roundCornerControl1.TabIndex = 0;
            this.roundCornerControl1.Text = "roundCornerControl1";
            // 
            // roundCornerControl2
            // 
            this.roundCornerControl2.BackColor = System.Drawing.Color.Green;
            this.roundCornerControl2.Location = new System.Drawing.Point(66, 60);
            this.roundCornerControl2.Name = "roundCornerControl2";
            this.roundCornerControl2.Size = new System.Drawing.Size(151, 90);
            this.roundCornerControl2.TabIndex = 0;
            this.roundCornerControl2.Text = "roundCornerControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 162);
            this.Controls.Add(this.roundCornerControl2);
            this.Controls.Add(this.roundCornerControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundCornerControl roundCornerControl1;
        private RoundCornerControl roundCornerControl2;
    }
}

