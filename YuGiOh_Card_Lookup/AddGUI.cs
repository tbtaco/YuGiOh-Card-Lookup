using System;
using System.Drawing;
using System.Windows.Forms;

namespace YuGiOh_Card_Lookup
{
    public partial class AddGUI : Form
    {
        private char color = '0';
        public AddGUI(String text)
        {
            InitializeComponent();
            Combo_Box.Items.Clear();
            Combo_Box.Items.Add("Purple");
            Combo_Box.Items.Add("Green");
            Combo_Box.Items.Add("Yellow");
            Combo_Box.Items.Add("Red");
            Combo_Box.Items.Add("Blue");
            Combo_Box.Items.Add("Black");
            Combo_Box.Items.Add("White");
            Combo_Box.Items.Add("Orange");
            Text_Box.Text = text;
            Text_Box_TextChanged(new object(), new EventArgs());
        }
        private void Text_Box_TextChanged(object sender, EventArgs e)
        {
            int start = Text_Box.SelectionStart;
            int length = Text_Box.SelectionLength;
            Text_Box.Text = Text_Box.Text.Trim().ToUpper();
            Text_Box.SelectionStart = start;
            Text_Box.SelectionLength = length;
            String[] parts = Text_Box.Text.Split(new String[] { "-" }, System.StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 2 && parts[0].Length > 0 && parts[1].Length > 0)
                Button_Add.Enabled = true;
            else
                Button_Add.Enabled = false;
            if(UserInterface.UI.CardAlreadyAdded(Text_Box.Text))
            {
                Text = "Edit Card";
                Button_Add.Text = "Edit Card";
            }
            else
            {
                Text = "Add Card";
                Button_Add.Text = "Add Card";
            }
        }
        private void Combo_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Combo_Box.SelectedItem.ToString())
            {
                case "Purple": Combo_Box.ForeColor = Color.Purple; color = 'P'; break;
                case "Green": Combo_Box.ForeColor = Color.Green; color = 'G'; break;
                case "Yellow": Combo_Box.ForeColor = Color.Orange; color = 'Y'; break;
                case "Red": Combo_Box.ForeColor = Color.Red; color = 'R'; break;
                case "Blue": Combo_Box.ForeColor = Color.Blue; color = 'B'; break;
                case "Black": Combo_Box.ForeColor = Color.Black; color = '0'; break;
                case "White": Combo_Box.ForeColor = Color.White; color = 'F'; break;
                case "Orange": Combo_Box.ForeColor = Color.OrangeRed; color = 'O'; break;
                default: Combo_Box.ForeColor = Color.Black; color = 'P'; break;
            }
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            String id = Text_Box.Text;
            if (UserInterface.UI.CardAlreadyAdded(id))
            {
                foreach (Card c in UserInterface.UI.Cards)
                    if (c.ID.Equals(id))
                    {
                        UserInterface.UI.Cards.Remove(c);
                        break;
                    }
                MessageBox.Show("Card has been edited.  Don't forget to Save and Reload");
            }
            else
                MessageBox.Show("Card has been added.  Don't forget to Save and Reload");
            Card card = new Card(id);
            card.Enabled = Check_Box_Enabled.Checked;
            card.setColor(color);
            UserInterface.UI.Cards.Add(card);
        }
    }
}