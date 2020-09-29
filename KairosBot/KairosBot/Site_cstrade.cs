using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace KairosBot
{
    public class Site_cstrade
    {
        public WebResponse Original;
        public WebResponse Player;

        public MyConsole console;

        public WebResponse GetOriginalWeb()
        {
            HttpWebRequest rr = (HttpWebRequest)WebRequest.Create("https://cstrade.gg/loadBotInventory?order_by=price_desc&bot=all");
            rr.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 Safari/537.36 OPR/48.0.2685.52";
            return rr.GetResponse();
        }

        public WebResponse GetPlayerWeb()
        {
            HttpWebRequest rr = (HttpWebRequest)WebRequest.Create("https://cstrade.gg/loadUserInventory?order_by=price_desc");
            rr.Headers.Add("cookie:__cfduid=d4795e9456d2a02aac69ba83604d77b421509217994; _gat=1; PHPSESSID=ggca5n7k6a14ouf75qglujuvg7; _ga=GA1.2.2117416394.1509218000; _gid=GA1.2.142409405.1510346044");
            rr.UserAgent = "Mozilla /5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 Safari/537.36 OPR/48.0.2685.52";
            return rr.GetResponse();
        }

        public Primary_list_p Get_player()
        {
            Primary_list_p res = new Primary_list_p();
            res.item = new Primary_item_p[Constant.player_inv];
            Player = GetPlayerWeb();
            string line = "";
            using (StreamReader reader = new StreamReader(Player.GetResponseStream()))
            {
                line = reader.ReadToEnd();
                Console.WriteLine(line);
                Console.WriteLine(line.Length);
            };


            JObject job = JObject.Parse(line);
            JArray jar = job.Value<JArray>("inventory");
            JToken jtok = jar.First;
            int i = 0;

            while (jtok != null)
            {
                res.item[i].name = jtok.Value<string>("market_hash_name");
                if (jtok.Value<string>("status") == "tradable")
                    res.item[i].status = "ok";
                else
                    res.item[i].status = "over";
                if (jtok.Value<string>("price") == null)
                {
                    res.item[i].price = 0;
                    res.item[i].status = "null";
                }
                else res.item[i].price = jtok.Value<float>("price");

                res.item[i].id = jtok.Value<string>("id");
                res.item[i].bot = "user";
                i++;
                jtok = jtok.Next;

            }
            res.count = i;
            return res;
        }
        public Primary_list_s Get_original(float max)
        {
            console.WriteLine(">>> cstrade start loading");     //console
            Primary_list_s res = new Primary_list_s();
            res.item = new Primary_item_s[Constant.original];
            Original = GetOriginalWeb();
            string line = "";
            using (StreamReader reader = new StreamReader(Original.GetResponseStream()))
            {
                line = reader.ReadToEnd();
            };
            console.WriteLine(">>> cstrade data downloaded");     //console

            JObject job = JObject.Parse(line);
            JArray jar = job.Value<JArray>("inventory");
            JToken jtok = jar.First;
            int i = 0;

            while (jtok != null)
            {
                float price = jtok.Value<float>("price");
                if (price <= max)
                {
                    res.item[i].priceFrom = price;
                    string category = jtok.Value<string>("type");

                    float priceTo = 0;
                    switch (category)
                    {
                        case "CSGO_Type_Knife":
                            priceTo = (float)Math.Round(price * 0.95f, 2);
                            break;
                        case "CSGO_Type_Rifle":
                            priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                            break;
                        case "CSGO_Type_MusicKit":
                            priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                            break;
                        case "CSGO_Type_Pistol":
                            priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                            break;
                        case "CSGO_Type_SniperRifle":
                            priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                            break;
                        case "CSGO_Type_SMG":
                            priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                            break;
                        case "CSGO_Type_Collectible":
                            priceTo = (float)Math.Round(price * 0.95f, 2);
                            break;
                        case "CSGO_Tool_Sticker":
                            priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                            break;
                        case "CSGO_Type_Shotgun":
                            priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                            break;
                        case "CSGO_Tool_WeaponCase_KeyTag":
                            priceTo = (float)Math.Round(price * 1.01f / 1.06f, 2);
                            break;
                        case "CSGO_Type_Machinegun":
                            priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                            break;
                        default:
                            priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                            break;
                    }
                    res.item[i].priceTo = priceTo;
                    res.item[i].name = jtok.Value<string>("market_hash_name");
                    res.item[i].status = "trade";
                    res.item[i].id = jtok.Value<string>("id");
                    res.item[i].bot = jtok.Value<string>("bot");
                    i++;
                };
                jtok = jtok.Next;

            }
            res.count = i;
            console.WriteLine(">>> cstrade: ok");     //console
            return res;
        }
    }
}

/*
 *
 * 
             string[] category = new string[90];

            int count_cat = 0;
 * 
 * 
 * string c = jtok.Value<string>("type");

                    int p = 0;
                    while (p < count_cat && category[p] != c)
                        p++;
                    if (p >= count_cat)
                    {   
                        category[p] = c;
                        count_cat++;
                    };
                    
                for (int u = 0; u < count_cat; u++)
            {
                Console.WriteLine(category[u]);
            };
*/