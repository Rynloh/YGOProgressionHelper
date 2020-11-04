using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YGOProgressionHelper
{
    class YGOAPI
    {
        public static CardList lookupCards(List<int> cardList)
        {
            string baseUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php?id=";

            List<string> idList = new List<string>();
            foreach (int id in cardList)
            {
                string ID = id.ToString();
                idList.Add(ID);
            }

            string idString = String.Join(",", idList);
            string url = baseUrl + idString;

            System.Net.WebClient wc = new System.Net.WebClient();
            string json = wc.DownloadString(url);

            CardList outList = JsonConvert.DeserializeObject<CardList>(json);
            return outList;
        }
    }
}
