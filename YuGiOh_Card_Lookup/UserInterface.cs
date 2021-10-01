using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace YuGiOh_Card_Lookup
{
    public partial class UserInterface : Form
    {
        public static UserInterface UI;
        new public static String Site;
        public static String Site_Error, File_Name = "YuGiOh Card Data.txt", Placeholder_ID = "%CARD_ID%", 
            Placeholder_Data = "%DATA%", Split_Name, Split_Rarity, Split_Price, Split_Type, Split_Aspect, 
            Split_Property, Split_Stars, Split_Attack, Split_Defense, Split_Text;
        public List<Card> Cards = new List<Card>();
        public List<String> GraphData = new List<String>();
        public String Title = "Yu-Gi-Oh Card Lookup";
        public bool CustomCardSet = false;
        public UserInterface()
        {
            InitializeComponent();
            UI = this;
            Menu_Reload_Click(new Object(), new EventArgs());
            Opacity = 100;
        }
        private void Menu_QuickSearch_Click(object sender, EventArgs e)
        {
            QuickSearchUserInterface qs = new QuickSearchUserInterface();
            qs.Show();
            qs.BringToFront();
        }
        private void Menu_Add_Click(object sender, EventArgs e)
        {
            new AddGUI("").Show();
        }
        private void Menu_Remove_Click(object sender, EventArgs e)
        {
            new RemoveGUI("").Show();
        }
        private void Menu_Save_Click(object sender, EventArgs e)
        {
            if (!SaveConfig())
                MessageBox.Show("Error: Could not save file!");
            MessageBox.Show("File has been saved.");
        }
        private async void Menu_Reload_Click(object sender, EventArgs e)
        {
            Menu_Add.Enabled = false;
            Menu_Remove.Enabled = false;
            Menu_Save.Enabled = false;
            Menu_Reload.Enabled = false;
            Menu_Sort.Enabled = false;
            Menu_Sets.Enabled = false;
            if (CustomCardSet) { }
            else if (!LoadConfig())
            {
                MessageBox.Show("Error Loading Config");
                Close();
            }
            int count = 0;
            int enabled = 0;
            Random r = new Random();
            Text = Title + " - Loading (" + count + " out of " + Cards.Count + " cards)";
            foreach (Card c in Cards)
            {
                await c.GetSource(this, r.Next(5, 100), r.Next(5, 1000));
                if (c.ParseSource())
                    enabled++;
                count++;
                Text = Title + " - Loading (" + count + " out of " + Cards.Count + " cards)";
            }
            ReloadListView();
            Text = Title + " - Complete (" + enabled + " cards total)";
            Menu_Add.Enabled = true;
            Menu_Remove.Enabled = true;
            Menu_Save.Enabled = true;
            Menu_Reload.Enabled = true;
            Menu_Sort.Enabled = true;
            Menu_Sets.Enabled = true;
            
            StreamWriter sw = new StreamWriter("output.csv");
            sw.WriteLine("ID, Name, Rarity, Price, Type, Aspect, Property, Stars, Attack, Defense, Enabled, Text");
            foreach(Card c in Cards)
            {
                sw.Write(c.ID);
                sw.Write(",");
                sw.Write(c.Name.Replace(',', '.'));
                sw.Write(",");
                sw.Write(c.Rarity);
                sw.Write(",");
                sw.Write(c.Price);
                sw.Write(",");
                sw.Write(c.Type);
                sw.Write(",");
                sw.Write(c.Aspect);
                sw.Write(",");
                sw.Write(c.Property);
                sw.Write(",");
                sw.Write(c.Stars);
                sw.Write(",");
                sw.Write(c.Attack);
                sw.Write(",");
                sw.Write(c.Defense);
                sw.Write(",");
                sw.Write(c.Enabled);
                sw.Write(",");
                sw.WriteLine(c.Text.Replace(',', '.'));
            }
            sw.Close();
        }
        private void Menu_Sort_ID_Click(object sender, EventArgs e)
        {
            SortCards("ID");
            ReloadListView();
        }
        private void Menu_Sort_Name_Click(object sender, EventArgs e)
        {
            SortCards("Name");
            ReloadListView();
        }
        private void Menu_Sort_Rarity_Click(object sender, EventArgs e)
        {
            SortCards("Rarity");
            ReloadListView();
        }
        private void Menu_Sort_Price_Click(object sender, EventArgs e)
        {
            SortCards("Price");
            ReloadListView();
        }
        private void Menu_Sort_Color_Click(object sender, EventArgs e)
        {
            SortCards("Color");
            ReloadListView();
        }
        private void Menu_Graph_DDS_001_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work In Progress... DDS-001 Graph");
        }
        private void Menu_Graph_SDK_001_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Work In Progress... SDK-001 Graph");
        }
        private void Menu_Rules_Click(object sender, EventArgs e)
        {
            Process.Start("Removed for Git upload");
        }
        private void Menu_Ban_List_Click(object sender, EventArgs e)
        {
            Process.Start("Removed for Git upload");
        }
        private void Menu_Edition_First_Click(object sender, EventArgs e)
        {
            new PictureGUI("First Edition", "First Edition Cards", "Message Here...").Show();
        }
        private void Menu_Edition_Limited_Click(object sender, EventArgs e)
        {
            new PictureGUI("Limited Edition", "Limited Edition Cards", "Message Here...").Show();
        }
        private void Menu_Edition_Unlimited_Click(object sender, EventArgs e)
        {
            new PictureGUI("Unlimited Edition", "Unlimited Edition Cards", "Message Here...").Show();
        }
        private void Menu_Edition_Duel_Terminal_Click(object sender, EventArgs e)
        {
            new PictureGUI("Duel Terminal", "Duel Terminal Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Common_Click(object sender, EventArgs e)
        {
            new PictureGUI("Common Rarity", "Common Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Short_Print_Click(object sender, EventArgs e)
        {
            new PictureGUI("Short Print", "Short Print Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Super_Short_Print_Click(object sender, EventArgs e)
        {
            new PictureGUI("Super Short Print", "Super Short Print Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Parallel_Click(object sender, EventArgs e)
        {
            new PictureGUI("Parallel Rare", "Parallel Rare Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Rare_Click(object sender, EventArgs e)
        {
            new PictureGUI("Rare", "Rare Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Super_Rare_Click(object sender, EventArgs e)
        {
            new PictureGUI("Super Rare", "Super Rare Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Ultra_Rare_Click(object sender, EventArgs e)
        {
            new PictureGUI("Ultra Rare", "Ultra Rare Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Gold_Rare_Click(object sender, EventArgs e)
        {
            new PictureGUI("Gold Rare", "Gold Rare Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Ultimate_Rare_Click(object sender, EventArgs e)
        {
            new PictureGUI("Ultimate Rare", "Ultimate Rare Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Secret_Rare_Click(object sender, EventArgs e)
        {
            new PictureGUI("Secret Rare", "Secret Rare Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Prismatic_Secret_Rare_Click(object sender, EventArgs e)
        {
            new PictureGUI("Prismatic Secret Rare", "Prismatic Secret Rare Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Ghost_Rare_Click(object sender, EventArgs e)
        {
            new PictureGUI("Ghost Rare", "Ghost Rare Cards", "Message Here...").Show();
        }
        private void Menu_Rarity_Platinum_Rare_Click(object sender, EventArgs e)
        {
            new PictureGUI("Platinum Rare", "Platinum Rare Cards", "Message Here...").Show();
        }
        private void Menu_Sets_2002_SDY_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("SDY-", 1, 50, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2002_SDK_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("SDK-", 1, 50, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2002_LOB_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("LOB-", 0, 125, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2002_MRL_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("MRL-", 0, 103, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2002_MRD_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("MRD-", 0, 143, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2002_BPT_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("BPT-", 1, 6, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2002_DDS_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("DDS-", 1, 6, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2003_SDJ_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("SDJ-", 1, 50, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2003_SDP_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("SDP-", 1, 50, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2003_DCR_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("DCR-", 0, 105, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2003_MFC_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("MFC-", 0, 107, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2003_PGD_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("PGD-", 0, 107, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2003_LOD_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("LOD-", 0, 100, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2003_LON_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("LON-", 0, 104, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2003_PSV_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("PSV-", 0, 104, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_2003_BPT_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("BPT-", 7, 12, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_Other_SYE_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("SYE-", 1, 50, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_Other_SKE_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("SKE-", 1, 50, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_Other_PP01_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("PP01-EN", 1, 15, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_Other_PP02_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("PP02-EN", 1, 20, 3);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_Other_JUMP_Click(object sender, EventArgs e)
        {
            List<Card> part1 = GetRangeOfCards("JMP-", 1, 7, 3);
            List<Card> part2 = GetRangeOfCards("JMP-EN", 1, 7, 3);
            List<Card> part3 = GetRangeOfCards("JMPS-EN", 1, 7, 3);
            List<Card> part4 = GetRangeOfCards("JUMP-EN", 1, 125, 3);
            Cards.Clear();
            foreach (Card c in part1)
                Cards.Add(c);
            foreach (Card c in part2)
                Cards.Add(c);
            foreach (Card c in part3)
                Cards.Add(c);
            foreach (Card c in part4)
                Cards.Add(c);
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Sets_Other_JUMP_New_Click(object sender, EventArgs e)
        {
            Cards = GetRangeOfCards("JUMP-EN", 68, 125, 3);
            foreach(Card c in Cards)
                if (c.ID.CompareTo("JUMP-EN082") >= 0)
                    c.setColor('G');
            CustomCardSet = true;
            Menu_Reload_Click(sender, e);
            CustomCardSet = false;
        }
        private void Menu_Type_Monster_Normal_Click(object sender, EventArgs e)
        {
            new PictureGUI("Normal Monster", "Normal Monsters", "Message Here...").Show();
        }
        private void Menu_Type_Monster_Effect_Click(object sender, EventArgs e)
        {
            new PictureGUI("Effect Monster", "Effect Monsters", "Message Here...").Show();
        }
        private void Menu_Type_Monster_Ritual_Click(object sender, EventArgs e)
        {
            new PictureGUI("Ritual Monster", "Ritual Monsters", "Message Here...").Show();
        }
        private void Menu_Type_Monster_Fusion_Click(object sender, EventArgs e)
        {
            new PictureGUI("Fusion Monster", "Fusion Monsters", "Message Here...").Show();
        }
        private void Menu_Type_Monster_Xyz_Click(object sender, EventArgs e)
        {
            new PictureGUI("Xyz Monster", "Xyz Monsters", "Message Here...").Show();
        }
        private void Menu_Type_Monster_Synchro_Click(object sender, EventArgs e)
        {
            new PictureGUI("Synchro Monster", "Synchro Monsters", "Message Here...").Show();
        }
        private void Menu_Type_Monster_Tuner_Click(object sender, EventArgs e)
        {
            new PictureGUI("Tuner Monster", "Tuner Monsters", "Message Here...").Show();
        }
        private void Menu_Type_Monster_Pendulum_Click(object sender, EventArgs e)
        {
            new PictureGUI("Pendulum Card", "Pendulum Cards", "Message Here...").Show();
        }
        private void Menu_Type_Monster_Link_Click(object sender, EventArgs e)
        {
            new PictureGUI("Link Monster", "Link Monsters", "Message Here...").Show();
        }
        private void Menu_Type_Magic_Click(object sender, EventArgs e)
        {
            new PictureGUI("Magic Card", "Spell Cards", "Message Here...").Show();
        }
        private void Menu_Type_Trap_Click(object sender, EventArgs e)
        {
            new PictureGUI("Trap Card", "Trap Cards", "Message Here...").Show();
        }
        private void Menu_Quality_Damaged_Click(object sender, EventArgs e)
        {
            new PictureGUI("Damaged Card", "Damaged / Poor Quality", "Message Here...").Show();
        }
        private void Menu_Quality_Heavily_Played_Click(object sender, EventArgs e)
        {
            new PictureGUI("Heavily Played Card", "Heavily Played / Good Quality", "Message Here...").Show();
        }
        private void Menu_Quality_Played_Click(object sender, EventArgs e)
        {
            new PictureGUI("Played Card", "Played / Average Quality", "Message Here...").Show();
        }
        private void Menu_Quality_Lightly_Played_Click(object sender, EventArgs e)
        {
            new PictureGUI("Lightly Played Card", "Lightly Played / Excellent Quality", "Message Here...").Show();
        }
        private void Menu_Quality_Near_Mint_Click(object sender, EventArgs e)
        {
            new PictureGUI("Near Mint Card", "Near Mint Quality", "Message Here...").Show();
        }
        private void Menu_Quality_Mint_Click(object sender, EventArgs e)
        {
            new PictureGUI("Mint Card", "Mint Quality", "Message Here...").Show();
        }
        private void Menu_Quality_Factory_Sealed_Click(object sender, EventArgs e)
        {
            new PictureGUI("Factory Sealed Card", "Factory Sealed Quality", "Message Here...").Show();
        }
        private void Menu_Quality_Gem_Mint_Click(object sender, EventArgs e)
        {
            new PictureGUI("Gem Mint Card", "Gem Mint Quality", "Message Here...").Show();
        }
        public bool LoadConfig()
        {
            try
            {
                using (StreamReader sr = new StreamReader(File_Name))
                {
                    Cards.Clear();
                    Site = sr.ReadLine().Substring("SITE: ".Length);
                    Site_Error = sr.ReadLine().Substring("SITE_ERROR: ".Length);
                    Split_Name = sr.ReadLine().Substring("SPLIT_NAME: ".Length);
                    Split_Rarity = sr.ReadLine().Substring("SPLIT_RARITY: ".Length);
                    Split_Price = sr.ReadLine().Substring("SPLIT_PRICE: ".Length);
                    Split_Type = sr.ReadLine().Substring("SPLIT_TYPE: ".Length);
                    Split_Aspect = sr.ReadLine().Substring("SPLIT_ASPECT: ".Length);
                    Split_Property = sr.ReadLine().Substring("SPLIT_PROPERTY: ".Length);
                    Split_Stars = sr.ReadLine().Substring("SPLIT_STARS: ".Length);
                    Split_Attack = sr.ReadLine().Substring("SPLIT_ATTACK: ".Length);
                    Split_Defense = sr.ReadLine().Substring("SPLIT_DEFENSE: ".Length);
                    Split_Text = sr.ReadLine().Substring("SPLIT_TEXT: ".Length);
                    sr.ReadLine();
                    String line = "";
                    while(!sr.EndOfStream && (line=sr.ReadLine()).Substring(0, 2).Equals("  "))
                    {
                        line = line.Substring(2);
                        bool enabled = true;
                        char color = '0';
                        if (line.Substring(0, 2).Equals("//"))
                        {
                            line = line.Substring(2);
                            enabled = false;
                        }
                        if(line[line.Length-2]==':')
                        {
                            color = line[line.Length - 1];
                            line = line.Substring(0, line.Length - 2);
                        }
                        Card card = new Card(line.Trim());
                        card.Enabled = enabled;
                        card.setColor(color);
                        if(!CardAlreadyAdded(card.ID))
                            Cards.Add(card);
                    }
                    GraphData.Clear();
                    if (!sr.EndOfStream)
                        GraphData.Add(line);
                    while (!sr.EndOfStream)
                        GraphData.Add(sr.ReadLine());
                }
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        public bool SaveConfig()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(File_Name))
                {
                    sw.WriteLine("SITE: " + Site);
                    sw.WriteLine("SITE_ERROR: " + Site_Error);
                    sw.WriteLine("SPLIT_NAME: " + Split_Name);
                    sw.WriteLine("SPLIT_RARITY: " + Split_Rarity);
                    sw.WriteLine("SPLIT_PRICE: " + Split_Price);
                    sw.WriteLine("SPLIT_TYPE: " + Split_Type);
                    sw.WriteLine("SPLIT_ASPECT: " + Split_Aspect);
                    sw.WriteLine("SPLIT_PROPERTY: " + Split_Property);
                    sw.WriteLine("SPLIT_STARS: " + Split_Stars);
                    sw.WriteLine("SPLIT_ATTACK: " + Split_Attack);
                    sw.WriteLine("SPLIT_DEFENSE: " + Split_Defense);
                    sw.WriteLine("SPLIT_TEXT: " + Split_Text);
                    sw.WriteLine("CARDS: ");
                    foreach (Card c in Cards)
                        if(c.Enabled)
                            sw.WriteLine("  " + c.ID + ":" + c.ColorChar);
                        else
                            sw.WriteLine("  //" + c.ID + ":" + c.ColorChar);
                    foreach (String s in GraphData)
                        sw.WriteLine(s);
                }
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }
        public void ReloadListView()
        {
            List_View.Columns.Clear();
            List_View.Items.Clear();
            List_View.Columns.Add("ID");
            List_View.Columns.Add("Name");
            List_View.Columns.Add("Rarity");
            List_View.Columns.Add("Average Price");
            List_View.Columns[0].Width = 95;
            List_View.Columns[1].Width = 345;
            List_View.Columns[2].Width = 170;
            List_View.Columns[3].Width = 95;
            List_View.Columns[0].TextAlign = HorizontalAlignment.Left;
            List_View.Columns[1].TextAlign = HorizontalAlignment.Left;
            List_View.Columns[2].TextAlign = HorizontalAlignment.Center;
            List_View.Columns[3].TextAlign = HorizontalAlignment.Right;
            int count = 0;
            foreach (Card c in Cards)
                if(c.Enabled)
                {
                    List_View.Items.Add(c.ID);
                    List_View.Items[count].ForeColor = c.Color;
                    List_View.Items[count].SubItems.Add(c.Name);
                    List_View.Items[count].SubItems.Add(c.Rarity);
                    List_View.Items[count].SubItems.Add("$"+c.Price.ToString("F"));
                    count++;
                }
        }
        public void SortCards(String option)
        {
            List<Card> disabled = new List<Card>();
            List<Card> ordered = new List<Card>();
            for(int i = 0; i < Cards.Count; i++)
                if(!Cards[i].Enabled)
                {
                    disabled.Add(Cards[i]);
                    Cards.RemoveAt(i);
                    i--;
                }
            while(Cards.Count > 0)
            {
                Card highest = Cards[Cards.Count-1];
                for(int i = Cards.Count-2; i >= 0; i--)
                    if(Cards[i].getSortValue(option).CompareTo(highest.getSortValue(option)) > 0)
                        highest = Cards[i];
                ordered.Add(highest);
                Cards.Remove(highest);
            }
            Cards.Clear();
            for (int i = ordered.Count - 1; i >= 0; i--)
                Cards.Add(ordered[i]);
            foreach (Card c in disabled)
                Cards.Add(c);
        }
        public List<Card> GetRangeOfCards(String prefix, int start, int end, int numLength)
        {
            List<Card> cards = new List<Card>();
            for(int i = start; i <= end; i++)
            {
                String num = i.ToString();
                while (num.Length < numLength)
                    num = '0' + num;
                cards.Add(new Card(prefix + num));
            }
            return cards;
        }
        public bool CardAlreadyAdded(String id)
        {
            foreach (Card c in Cards)
                if (c.ID.Equals(id))
                    return true;
            return false;
        }
    }
}