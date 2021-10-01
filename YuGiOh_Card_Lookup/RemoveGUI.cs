using System;
using System.Windows.Forms;

namespace YuGiOh_Card_Lookup
{
    public partial class RemoveGUI : Form
    {
        public RemoveGUI(String text)
        {
            InitializeComponent();
            Text_Box.Text = text;
        }
        private void Button_Remove_Click(object sender, EventArgs e)
        {
            foreach(Card c in UserInterface.UI.Cards)
                if(c.ID.Equals(Text_Box.Text))
                {
                    UserInterface.UI.Cards.Remove(c);
                    Button_Remove.Enabled = false;
                    MessageBox.Show("Card has been removed.  Don't forget to Save and Reload");
                    return;
                }
        }
        private void Text_Box_TextChanged(object sender, EventArgs e)
        {
            int start = Text_Box.SelectionStart;
            int length = Text_Box.SelectionLength;
            Text_Box.Text = Text_Box.Text.Trim().ToUpper();
            Text_Box.SelectionStart = start;
            Text_Box.SelectionLength = length;
            if (UserInterface.UI.CardAlreadyAdded(Text_Box.Text))
                Button_Remove.Enabled = true;
            else
                Button_Remove.Enabled = false;
        }
    }
}