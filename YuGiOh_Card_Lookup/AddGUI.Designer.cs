namespace YuGiOh_Card_Lookup
{
    partial class AddGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGUI));
            this.Button_Add = new System.Windows.Forms.Button();
            this.Check_Box_Enabled = new System.Windows.Forms.CheckBox();
            this.Combo_Box = new System.Windows.Forms.ComboBox();
            this.Text_Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Add
            // 
            this.Button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(10, 121);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(563, 44);
            this.Button_Add.TabIndex = 0;
            this.Button_Add.Text = "Add Card";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Check_Box_Enabled
            // 
            this.Check_Box_Enabled.AutoSize = true;
            this.Check_Box_Enabled.Checked = true;
            this.Check_Box_Enabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Check_Box_Enabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Check_Box_Enabled.Location = new System.Drawing.Point(430, 73);
            this.Check_Box_Enabled.Name = "Check_Box_Enabled";
            this.Check_Box_Enabled.Size = new System.Drawing.Size(135, 33);
            this.Check_Box_Enabled.TabIndex = 1;
            this.Check_Box_Enabled.Text = "Enabled";
            this.Check_Box_Enabled.UseVisualStyleBackColor = true;
            // 
            // Combo_Box
            // 
            this.Combo_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Box.FormattingEnabled = true;
            this.Combo_Box.Location = new System.Drawing.Point(12, 67);
            this.Combo_Box.Name = "Combo_Box";
            this.Combo_Box.Size = new System.Drawing.Size(395, 37);
            this.Combo_Box.TabIndex = 2;
            this.Combo_Box.Text = "Card Color";
            this.Combo_Box.SelectedIndexChanged += new System.EventHandler(this.Combo_Box_SelectedIndexChanged);
            // 
            // Text_Box
            // 
            this.Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Box.Location = new System.Drawing.Point(12, 14);
            this.Text_Box.Name = "Text_Box";
            this.Text_Box.Size = new System.Drawing.Size(556, 38);
            this.Text_Box.TabIndex = 3;
            this.Text_Box.TextChanged += new System.EventHandler(this.Text_Box_TextChanged);
            // 
            // AddGUI
            // 
            this.AcceptButton = this.Button_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 175);
            this.Controls.Add(this.Text_Box);
            this.Controls.Add(this.Combo_Box);
            this.Controls.Add(this.Check_Box_Enabled);
            this.Controls.Add(this.Button_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddGUI";
            this.Text = "Add Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.CheckBox Check_Box_Enabled;
        private System.Windows.Forms.ComboBox Combo_Box;
        private System.Windows.Forms.TextBox Text_Box;
    }
}