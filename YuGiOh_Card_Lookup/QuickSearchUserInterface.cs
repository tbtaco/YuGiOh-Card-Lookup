using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuGiOh_Card_Lookup
{
    public partial class QuickSearchUserInterface : Form
    {
        private Card card;
        public QuickSearchUserInterface()
        {
            InitializeComponent();
            DefaultText("Type the ID of a card in the bar and click Search to get information on that card.  The ID would look something like \"SDK-001\"");
        }
        private async void Button_Search_Click(object sender, EventArgs e)
        {
            Button_Search.Enabled = false;
            DefaultText("Loading...");
            card = new Card(Text_Box.Text.ToUpper());
            await card.GetSource(UserInterface.UI, 0, 0);
            card.ParseSource();
            if (card.Name.Equals("Error"))
                DefaultText("No card found with that ID.  Did you type it correctly?  For example: \"SDK-001\"");
            else
            {
                this.Text = "Yu-Gi-Oh Card Quick Search ("+card.ID+")";
                Label_Name.Text = card.Name;
                Label_Rarity.Text = "Rarity: " + card.Rarity;
                Label_ID.Text = "ID: " + card.ID;
                Label_Price.Text = "Average Price: $" + card.Price.ToString("F");
                Label_Type.Text = "Type: " + card.Type;
                if(card.Type.Equals("None"))
                    Label_Type.Text = "Type: Magic / Trap";
                Label_Stars.Text = "Stars: " + card.Stars;
                if(card.Stars==-1)
                    Label_Stars.Text = "Stars: None";
                Label_Property.Text = "Property: " + card.Property;
                Label_Aspect.Text = "Aspect: " + card.Aspect;
                Label_Attack.Text = "Attack: " + card.Attack;
                if(card.Attack==-1)
                    Label_Attack.Text = "Attack: None";
                Label_Defense.Text = "Defense: " + card.Defense;
                if (card.Defense == -1)
                    Label_Defense.Text = "Defense: None";
                Text_Box_Description.Text = card.Text;
            }
            Button_Search.Enabled = true;
        }
        private void Button_Add_Click(object sender, EventArgs e)
        {
            new AddGUI(Text_Box.Text).Show();
        }
        private void Button_Remove_Click(object sender, EventArgs e)
        {
            new RemoveGUI(Text_Box.Text).Show();
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
            {
                Button_Search.Enabled = true;
                Button_Add.Enabled = true;
            }
            else
            {
                Button_Search.Enabled = false;
                Button_Add.Enabled = false;
            }
            if (UserInterface.UI.CardAlreadyAdded(Text_Box.Text))
                Button_Remove.Enabled = true;
            else
                Button_Remove.Enabled = false;
        }
        public void DefaultText(String text)
        {
            this.Text = "Yu-Gi-Oh Card Quick Search";
            Label_Name.Text = "";
            Label_Rarity.Text = "";
            Label_ID.Text = "";
            Label_Price.Text = "";
            Label_Type.Text = "";
            Label_Stars.Text = "";
            Label_Property.Text = "";
            Label_Aspect.Text = "";
            Label_Attack.Text = "";
            Label_Defense.Text = "";
            Text_Box_Description.Text = text;
        }
    }
}
