using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOProgressionHelper
{
    // CardList myDeserializedClass = JsonConvert.DeserializeObject<CardList>(myJsonResponse); 
    public class CardSet
    {
        public string set_name { get; set; }
        public string set_code { get; set; }
        public string set_rarity { get; set; }
        public string set_rarity_code { get; set; }
        public string set_price { get; set; }
    }

    public class CardImage
    {
        public int id { get; set; }
        public string image_url { get; set; }
        public string image_url_small { get; set; }
    }

    public class CardPrice
    {
        public string cardmarket_price { get; set; }
        public string tcgplayer_price { get; set; }
        public string ebay_price { get; set; }
        public string amazon_price { get; set; }
        public string coolstuffinc_price { get; set; }
    }

    public class YGOCard
    {
        public static YGOCard fromTokens(string[] tokens)
        {
            YGOCard outCard = new YGOCard();
            outCard.id = int.Parse(tokens[0]);
            outCard.count = int.Parse(tokens[1]);
            outCard.name = tokens[2];
            outCard.type = tokens[3];
            outCard.desc = tokens[4];
            outCard.atk = int.Parse(tokens[5]);
            outCard.def = int.Parse(tokens[6]);
            outCard.level = int.Parse(tokens[7]);
            outCard.race = tokens[8];
            outCard.attribute = tokens[9];
            outCard.scale = int.Parse(tokens[10]);
            outCard.linkval = int.Parse(tokens[11]);
            return outCard;
        }

        public string toCSVLine()
        {
            string output = $"{id}|{count}|{name}|{type}|{desc}|{atk}|{def}|{level}|{race}|{attribute}|{scale}|{linkval}";
            return output;
        }

        public int id { get; set; }
        public int count { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string desc { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int level { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }
        public int scale { get; set; }
        public int linkval { get; set; }
        public List<CardSet> card_sets { get; set; }
        public List<CardImage> card_images { get; set; }
        public List<CardPrice> card_prices { get; set; }
    }

    public class CardList
    {
        public List<YGOCard> data { get; set; }
    }


}
