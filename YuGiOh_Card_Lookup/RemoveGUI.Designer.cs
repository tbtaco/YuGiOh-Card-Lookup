namespace YuGiOh_Card_Lookup
{
    partial class RemoveGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveGUI));
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Text_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Remove
            // 
            this.Button_Remove.Enabled = false;
            this.Button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Remove.Location = new System.Drawing.Point(10, 65);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(563, 44);
            this.Button_Remove.TabIndex = 4;
            this.Button_Remove.Text = "Remove Card";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Text_Box
            // 
            this.Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Box.Location = new System.Drawing.Point(12, 12);
            this.Text_Box.Name = "Text_Box";
            this.Text_Box.Size = new System.Drawing.Size(556, 38);
            this.Text_Box.TabIndex = 7;
            this.Text_Box.TextChanged += new System.EventHandler(this.Text_Box_TextChanged);
            // 
            // RemoveGUI
            // 
            this.AcceptButton = this.Button_Remove;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 120);
            this.Controls.Add(this.Text_Box);
            this.Controls.Add(this.Button_Remove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RemoveGUI";
            this.Text = "Remove Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.TextBox Text_Box;
    }
}