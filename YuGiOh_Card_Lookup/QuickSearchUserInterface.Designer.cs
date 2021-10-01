namespace YuGiOh_Card_Lookup
{
    partial class QuickSearchUserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickSearchUserInterface));
            this.Button_Search = new System.Windows.Forms.Button();
            this.Text_Box = new System.Windows.Forms.TextBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.Button_Remove = new System.Windows.Forms.Button();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Rarity = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Label_Stars = new System.Windows.Forms.Label();
            this.Label_Aspect = new System.Windows.Forms.Label();
            this.Label_Defense = new System.Windows.Forms.Label();
            this.Label_Attack = new System.Windows.Forms.Label();
            this.Label_Property = new System.Windows.Forms.Label();
            this.Label_Type = new System.Windows.Forms.Label();
            this.Label_ID = new System.Windows.Forms.Label();
            this.Text_Box_Description = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Button_Search
            // 
            this.Button_Search.Enabled = false;
            this.Button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Search.Location = new System.Drawing.Point(354, 12);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(169, 58);
            this.Button_Search.TabIndex = 0;
            this.Button_Search.Text = "Search";
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Text_Box
            // 
            this.Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Box.Location = new System.Drawing.Point(12, 14);
            this.Text_Box.MaxLength = 30;
            this.Text_Box.Name = "Text_Box";
            this.Text_Box.Size = new System.Drawing.Size(330, 49);
            this.Text_Box.TabIndex = 1;
            this.Text_Box.TextChanged += new System.EventHandler(this.Text_Box_TextChanged);
            // 
            // Button_Add
            // 
            this.Button_Add.Enabled = false;
            this.Button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Add.Location = new System.Drawing.Point(529, 12);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(169, 58);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "Add";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Button_Remove
            // 
            this.Button_Remove.Enabled = false;
            this.Button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Remove.Location = new System.Drawing.Point(704, 12);
            this.Button_Remove.Name = "Button_Remove";
            this.Button_Remove.Size = new System.Drawing.Size(169, 58);
            this.Button_Remove.TabIndex = 3;
            this.Button_Remove.Text = "Remove";
            this.Button_Remove.UseVisualStyleBackColor = true;
            this.Button_Remove.Click += new System.EventHandler(this.Button_Remove_Click);
            // 
            // Label_Name
            // 
            this.Label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(12, 79);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(858, 38);
            this.Label_Name.TabIndex = 6;
            this.Label_Name.Text = "Card Name Goes Here";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Rarity
            // 
            this.Label_Rarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Rarity.Location = new System.Drawing.Point(12, 117);
            this.Label_Rarity.Name = "Label_Rarity";
            this.Label_Rarity.Size = new System.Drawing.Size(858, 38);
            this.Label_Rarity.TabIndex = 7;
            this.Label_Rarity.Text = "Rarity: Rarity Goes Here";
            this.Label_Rarity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Price
            // 
            this.Label_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.Location = new System.Drawing.Point(437, 155);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(433, 38);
            this.Label_Price.TabIndex = 8;
            this.Label_Price.Text = "Average Price: $000.00";
            this.Label_Price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Stars
            // 
            this.Label_Stars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Stars.Location = new System.Drawing.Point(662, 193);
            this.Label_Stars.Name = "Label_Stars";
            this.Label_Stars.Size = new System.Drawing.Size(208, 38);
            this.Label_Stars.TabIndex = 9;
            this.Label_Stars.Text = "Stars: 0";
            this.Label_Stars.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Aspect
            // 
            this.Label_Aspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Aspect.Location = new System.Drawing.Point(490, 231);
            this.Label_Aspect.Name = "Label_Aspect";
            this.Label_Aspect.Size = new System.Drawing.Size(380, 38);
            this.Label_Aspect.TabIndex = 10;
            this.Label_Aspect.Text = "Aspect: Stuff";
            this.Label_Aspect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Defense
            // 
            this.Label_Defense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Defense.Location = new System.Drawing.Point(570, 269);
            this.Label_Defense.Name = "Label_Defense";
            this.Label_Defense.Size = new System.Drawing.Size(300, 38);
            this.Label_Defense.TabIndex = 11;
            this.Label_Defense.Text = "Defense: 0000";
            this.Label_Defense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Attack
            // 
            this.Label_Attack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Attack.Location = new System.Drawing.Point(12, 269);
            this.Label_Attack.Name = "Label_Attack";
            this.Label_Attack.Size = new System.Drawing.Size(302, 38);
            this.Label_Attack.TabIndex = 18;
            this.Label_Attack.Text = "Attack: 0000";
            this.Label_Attack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Property
            // 
            this.Label_Property.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Property.Location = new System.Drawing.Point(12, 231);
            this.Label_Property.Name = "Label_Property";
            this.Label_Property.Size = new System.Drawing.Size(456, 38);
            this.Label_Property.TabIndex = 17;
            this.Label_Property.Text = "Property: Stuff";
            this.Label_Property.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_Type
            // 
            this.Label_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Type.Location = new System.Drawing.Point(12, 193);
            this.Label_Type.Name = "Label_Type";
            this.Label_Type.Size = new System.Drawing.Size(644, 38);
            this.Label_Type.TabIndex = 16;
            this.Label_Type.Text = "Type: Normal / Stuff";
            this.Label_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label_ID
            // 
            this.Label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ID.Location = new System.Drawing.Point(12, 155);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(352, 38);
            this.Label_ID.TabIndex = 15;
            this.Label_ID.Text = "ID: ABCD-EN000";
            this.Label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Text_Box_Description
            // 
            this.Text_Box_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Box_Description.Location = new System.Drawing.Point(10, 317);
            this.Text_Box_Description.Multiline = true;
            this.Text_Box_Description.Name = "Text_Box_Description";
            this.Text_Box_Description.ReadOnly = true;
            this.Text_Box_Description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text_Box_Description.Size = new System.Drawing.Size(858, 150);
            this.Text_Box_Description.TabIndex = 19;
            this.Text_Box_Description.Text = "Card description.";
            // 
            // QuickSearchUserInterface
            // 
            this.AcceptButton = this.Button_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 480);
            this.Controls.Add(this.Text_Box_Description);
            this.Controls.Add(this.Label_Attack);
            this.Controls.Add(this.Label_Property);
            this.Controls.Add(this.Label_Type);
            this.Controls.Add(this.Label_ID);
            this.Controls.Add(this.Label_Defense);
            this.Controls.Add(this.Label_Aspect);
            this.Controls.Add(this.Label_Stars);
            this.Controls.Add(this.Label_Price);
            this.Controls.Add(this.Label_Rarity);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.Button_Remove);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.Text_Box);
            this.Controls.Add(this.Button_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuickSearchUserInterface";
            this.Text = "Yu-Gi-Oh Card Quick Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Search;
        private System.Windows.Forms.TextBox Text_Box;
        private System.Windows.Forms.Button Button_Add;
        private System.Windows.Forms.Button Button_Remove;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Rarity;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Label Label_Stars;
        private System.Windows.Forms.Label Label_Aspect;
        private System.Windows.Forms.Label Label_Defense;
        private System.Windows.Forms.Label Label_Attack;
        private System.Windows.Forms.Label Label_Property;
        private System.Windows.Forms.Label Label_Type;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.TextBox Text_Box_Description;
    }
}