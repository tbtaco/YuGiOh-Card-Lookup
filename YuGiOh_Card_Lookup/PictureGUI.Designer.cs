namespace YuGiOh_Card_Lookup
{
    partial class PictureGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureGUI));
            this.Picture_Box = new System.Windows.Forms.PictureBox();
            this.Text_Box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Box
            // 
            this.Picture_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Picture_Box.Location = new System.Drawing.Point(12, 12);
            this.Picture_Box.Name = "Picture_Box";
            this.Picture_Box.Size = new System.Drawing.Size(550, 660);
            this.Picture_Box.TabIndex = 0;
            this.Picture_Box.TabStop = false;
            // 
            // Text_Box
            // 
            this.Text_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Text_Box.Location = new System.Drawing.Point(10, 678);
            this.Text_Box.MaxLength = 1000000;
            this.Text_Box.Multiline = true;
            this.Text_Box.Name = "Text_Box";
            this.Text_Box.ReadOnly = true;
            this.Text_Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_Box.Size = new System.Drawing.Size(550, 184);
            this.Text_Box.TabIndex = 2;
            this.Text_Box.Text = " ";
            // 
            // PictureGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 919);
            this.Controls.Add(this.Text_Box);
            this.Controls.Add(this.Picture_Box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(4000, 2000);
            this.MinimumSize = new System.Drawing.Size(100, 300);
            this.Name = "PictureGUI";
            this.Text = "Picture Test";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Box;
        private System.Windows.Forms.TextBox Text_Box;
    }
}