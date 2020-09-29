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
    public class Site_loot
    {
        public WebResponse Original;
        public WebResponse Player;

        public MyConsole console;

        public WebResponse GetOriginalWeb()
        {
            HttpWebRequest rr = (HttpWebRequest)WebRequest.Create("https://loot.farm/botsInventory_new.json");
            return rr.GetResponse();
        }

        public WebResponse GetPlayerWeb()
        {
            HttpWebRequest rr = (HttpWebRequest)WebRequest.Create("https://loot.farm/getInv_new.php?game=730");
            rr.Headers.Add("method: GET");
            rr.Headers.Add("scheme:https");
            rr.Headers.Add("Cookie:_gat_gtag_UA_2579492_4=1; PHPSESSID=b3f6de4159d3bde3ea6842299de6bddb; lang=en; _ga=GA1.2.1980161549.1509223147; _gid=GA1.2.849829906.1510674323");
            rr.Headers.Add("pragma:no-cache");
            rr.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 Safari/537.36 OPR/48.0.2685.50";
            return rr.GetResponse();
        }



        public string Type_to_string(String type)
        {
            string res = "";
            if (type == "BS")
                res = " (Battle-Scared)";
            if (type == "WW")
                res = " (Well-Worn)";
            if (type == "FT")
                res = " (Field-Tested)";
            if (type == "MW")
                res = " (Minimal Wear)";
            if (type == "FN")
                res = " (Factory New)";
            return res;
        }

        public Primary_list_p Get_player()
        {
            Primary_list_p res = new Primary_list_p();
            res.item = new Primary_item_p[Constant.player_inv];
            Player = GetPlayerWeb();
            string line;
            using (StreamReader reader = new StreamReader(Player.GetResponseStream()))
            {
                line = reader.ReadLine();
            };
            JObject job = JObject.Parse(line).Value<JObject>("result");

            JToken jar = job.First;
            JToken jon = jar.First;
            int i = 0;
            JToken jid;
            while (jar != null)
            {
                jon = jar.First;
                jid = jon.Value<JArray>("u").First;
                while (jid != null)
                {
                    res.item[i].name = jon.Value<string>("n") + Type_to_string(jon.Value<string>("e"));
                    res.item[i].price = jon.Value<float>("pst") / 100;
                    if (res.item[i].price == 0)
                        res.item[i].price = jon.Value<float>("p") / 100;
                    res.item[i].id = jid.Value<string>("id");
                    res.item[i].bot = "user";
                    if (jon.Value<string>("p") == "0" || jon.Value<string>("p") == "")
                        res.item[i].status = "over";
                    else
                        res.item[i].status = "ok";
                    i++;
                    jid = jid.Next;
                };
                jar = jar.Next;
            }
            res.count = i;

            return res;
        }


        public Primary_list_s Get_original(float max)
        {
            console.WriteLine(">>> loot.farm start loading");     //console
            Primary_list_s res = new Primary_list_s();
            res.item = new Primary_item_s[Constant.original];
            Original = GetOriginalWeb();
            string line;
            using (StreamReader reader = new StreamReader(Original.GetResponseStream()))
            {
                line = reader.ReadLine();
            };
            console.WriteLine(">>> loot.farm data downloaded");     //console
            JObject job = JObject.Parse(line).Value<JObject>("result");

            JToken jar = job.First;
            JToken jon = jar.First;
            int i = 0;
            JToken jid;
            int count;
            while (jar != null)
            {
                count = 0;
                jon = jar.First;
                jid = jon.Value<JArray>("u").First;
                int max_count = jid.Count<JToken>();
                while (count < max_count)
                {
                    if (jid!= null)
                        if(jid.Value<JArray>() != null)
                    {
                        JToken x = jid.First;
                        string name = jon.Value<string>("n") + Type_to_string(jon.Value<string>("e"));
                        float price = jon.Value<float>("p") / 100;
                        float price_st = jon.Value<float>("pst") / 100;
                        
                        while (x != null)
                        {
                            int st = x.Value<int>("st");

                                if (st!= 0)
                                {
                                    res.item[i].name = "StatTrak™ " + name;
                                    res.item[i].priceFrom = price_st;
                                }
                                else
                                {
                                    res.item[i].name = name;
                                    res.item[i].priceFrom = price;
                                };

                                if (res.item[i].priceFrom != 0)
                                    res.item[i].status = "ok";
                                else
                                    res.item[i].status = "over";
                                res.item[i].bot = (count + 1).ToString();
                                res.item[i].priceTo = res.item[i].priceFrom * 0.95f;
                                res.item[i].id = x.Value<string>("id");
                                x = x.Next;
                            i++;
                        };
                        count++;
                    };
                    if(jid.Next!= null)
                         jid = jid.Next;
                };
                jar = jar.Next;
            }
            res.count = i;
            console.WriteLine(">>> loot.farm: ok");     //console
            return res;
        }


    }



}
