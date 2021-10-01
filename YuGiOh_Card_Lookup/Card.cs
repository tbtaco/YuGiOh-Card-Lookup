using System;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace YuGiOh_Card_Lookup
{
    public class Card
    {
        public String ID, Name = "null", Rarity = "null", Type = "null", Aspect = "null", Property = "null", Text = "null", Source = "null";
        public double Price = -1.00;
        public int Stars = -1, Attack = -1, Defense = -1;
        public bool Enabled = true, Temporary = false;
        public char ColorChar;
        public System.Drawing.Color Color;
        public Card(String id)
        {
            ID = id;
        }
        public bool ParseSource()
        {
            if (Source.Equals("null") || !Enabled)
            {
                Enabled = false;
                return false;
            }
            Name = ParseData(UserInterface.Split_Name, "Error");
            Rarity = ParseData(UserInterface.Split_Rarity, "Error");
            Type = ParseData(UserInterface.Split_Type, "None");
            Aspect = ParseData(UserInterface.Split_Aspect, "None");
            Property = ParseData(UserInterface.Split_Property, "None");
            Text = ParseData(UserInterface.Split_Text, "Error").Replace("<br/>", " ").Replace("<br>", "").Replace("<b>", "").Replace("</b>", " ");
            try
            {
                Price = Double.Parse(ParseData(UserInterface.Split_Price, "0.00"));
                Stars = Int32.Parse(ParseData(UserInterface.Split_Stars, "-1"));
                Attack = Int32.Parse(ParseData(UserInterface.Split_Attack, "-1"));
                Defense = Int32.Parse(ParseData(UserInterface.Split_Defense, "-1"));
            }
            catch(Exception){}
            if (Name.Equals("Error"))
                Enabled = false;
            return true;
        }
        private String ParseData(String split, String defaultVal)
        {
            try
            {
                split = split.Replace(UserInterface.Placeholder_ID, ID);
                String[] splitParts = split.Split(new String[]{ UserInterface.Placeholder_Data } , System.StringSplitOptions.RemoveEmptyEntries);
                String[] sourceSplit = Source.Split(new String[] { splitParts[0] }, System.StringSplitOptions.RemoveEmptyEntries);
                String[] sourceSplit2 = sourceSplit[1].Split(new String[] { splitParts[1] }, System.StringSplitOptions.RemoveEmptyEntries);
                if (sourceSplit2[0].Length > 5000)
                    return "Too Long... Error...";
                return sourceSplit2[0];
            }
            catch (Exception)
            {
                return defaultVal;
            }
        }
        public Task GetSource(UserInterface ui, int waitShort, int waitLong)
        {
            return Task.Run(() =>
            {
                try
                {
                    Thread.Sleep(waitShort);
                    if (!Enabled)
                        throw new Exception("Card is not Enabled, skipping source retrieval");
                    Thread.Sleep(waitLong);
                    WebRequest request = WebRequest.Create(UserInterface.Site.Replace(UserInterface.Placeholder_ID, ID));
                    request.Method = "GET";
                    StreamReader sr = new StreamReader(request.GetResponse().GetResponseStream());
                    Source = "";
                    foreach (String l in sr.ReadToEnd().Split(new String[] { "\n\r", "\r\n", "\r", "\n" }, System.StringSplitOptions.RemoveEmptyEntries))
                        Source += l;
                    sr.Close();

                    /*
                    StreamWriter sw = new StreamWriter("source_test_" + ID + ".txt");
                    sw.Write(Source);
                    sw.Close();
                    */
                }
                catch (Exception)
                {
                    Source = "Error";
                    Enabled = false;
                }
            });
        }
        public void setColor(char c)
        {
            ColorChar = c;
            switch(c)
            {
                case 'P': Color = System.Drawing.Color.Purple; break;
                case 'G': Color = System.Drawing.Color.Green; break;
                case 'Y': Color = System.Drawing.Color.Orange; break;
                case 'R': Color = System.Drawing.Color.Red; break;
                case 'B': Color = System.Drawing.Color.Blue; break;
                case '0': Color = System.Drawing.Color.Black; break;
                case 'F': Color = System.Drawing.Color.White; break;
                case 'O': Color = System.Drawing.Color.OrangeRed; break;
            }
        }
        public String getSortValue(String option)
        {
            String value = "";
            switch(option)
            {
                case "ID":
                    value = "ID: " + ID;
                    break;
                case "Name":
                    value = "Name: " + Name;
                    break;
                case "Rarity":
                    switch(Rarity)
                    {
                        case "Common": value = "Rarity: P"; break;
                        case "Short Print": value = "Rarity: O"; break;
                        case "Super Short Print": value = "Rarity: N"; break;
                        case "Parallel Rare": value = "Rarity: M"; break;
                        case "Rare": value = "Rarity: L"; break;
                        case "Super Rare": value = "Rarity: K"; break;
                        case "Ultra Rare": value = "Rarity: J"; break;
                        case "Gold Rare": value = "Rarity: I"; break;
                        case "Ultimate Rare": value = "Rarity: H"; break;
                        case "Secret Rare": value = "Rarity: G"; break;
                        case "Gold Secret Rare": value = "Rarity: F"; break;
                        case "Prismatic Secret Rare": value = "Rarity: E"; break;
                        case "Extra Secret Rare": value = "Rarity: D"; break;
                        case "Platinum Secret Rare": value = "Rarity: C"; break;
                        case "Ghost Rare": value = "Rarity: B"; break;
                        case "Ghost/Gold Rare": value = "Rarity: A"; break;
                        default: value = "Rarity: ZZZ" + Rarity; break;
                    }
                    break;
                case "Price":
                    value= (1000000.00-Price).ToString("F");
                    while (value.Length < 25)
                        value = "0" + value;
                    value = "PriceConst: " + value;
                    break;
                case "Color":
                    switch(ColorChar)
                    {
                        case 'P': value = "Color: A"; break;
                        case 'G': value = "Color: B"; break;
                        case 'Y': value = "Color: C"; break;
                        case 'R': value = "Color: D"; break;
                        case 'B': value = "Color: E"; break;
                        case '0': value = "Color: F"; break;
                        case 'F': value = "Color: G"; break;
                        case 'O': value = "Color: H"; break;
                        default: value = "Color: Z"; break;
                    }
                    break;
                default: throw new Exception("Invalid Option");
            }
            return value.ToUpper();
        }
    }
}
