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
    public class Site_csmoney
    {
        public WebResponse Original;
        public WebResponse Player;

        public MyConsole console;

        public WebResponse GetOriginalWeb()
        {
            HttpWebRequest rr = (HttpWebRequest)WebRequest.Create("https://cs.money/load_bots_inventory?hash=1509963751756");
            return rr.GetResponse();
        }

        public WebResponse GetPlayerWeb()
        {
            HttpWebRequest rr = (HttpWebRequest)WebRequest.Create("https://cs.money/load_user_inventory?hash=1510079187011");

            rr.Referer = "referer:https://cs.money/ru";
            rr.Headers.Add("authority:cs.money");
            rr.Headers.Add("cookie:__cfduid=d966327101eca4fcf26088c075fd327f51509217388; theme=pinkTheme; steamid=76561198368209428; avatar=https%3A%2F%2Fsteamcdn-a.akamaihd.net%2Fsteamcommunity%2Fpublic%2Fimages%2Favatars%2Fd2%2Fd2ff620b6fbc3a35ff0c044ad3f176fe5f9ff152_medium.jpg; username=darkpushkin; new_2_csrf=XEZph9kh9rQm9HV7kL3vAXy%2F5xKeOzOrOxgNsELAvQ4%3D; currency=USD; trade_link=https%3A%2F%2Fsteamcommunity.com%2Ftradeoffer%2Fnew%2F%3Fpartner%3D407943700%26token%3DxKbDKU1x; language=ru; type_device=desktop; _ga=GA1.2.1882421986.1509217392; _gid=GA1.2.1367480275.1509963480; _gali=block-items-user");
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
                line = reader.ReadToEnd();
            }
            JArray jar = JArray.Parse(line);
            JToken jtok = jar.First;
            int i = 0;
            JToken jid;
            while (jtok != null)
            {
                jid = jtok.Value<JArray>("id").First;
                while (jid != null)
                {
                    res.item[i].name = jtok.Value<string>("m") + Type_to_string(jtok.Value<string>("e"));
                    res.item[i].price = (float)Math.Round(jtok.Value<float>("p") * jtok.Value<float>("r") / 100f, 2);
                    res.item[i].id = jid.Value<string>();
                    res.item[i].bot = "user";
                    if (jtok.Value<string>("a") == "1")
                        res.item[i].status = "over";
                    else
                        res.item[i].status = "ok";
                    i++;
                    jid = jid.Next;
                };
                jtok = jtok.Next;
            }
            res.count = i;

            return res;
        }
        public Primary_list_s Get_original(float max)
        {
            console.WriteLine(">>> csmoney start loading");     //console
            Primary_list_s res = new Primary_list_s();
            res.item = new Primary_item_s[Constant.original];
            Original = GetOriginalWeb();
            string line;
            using (StreamReader reader = new StreamReader(Original.GetResponseStream()))
            {
                line = reader.ReadLine();
            }
            console.WriteLine(">>> csmoney data downloaded");     //console
            JArray jar = JArray.Parse(line);
            JToken jtok = jar.First;
            int i = 0;
            JToken jid;
            while (jtok != null)
            {
                jid = jtok.Value<JArray>("id").First;
                while (jid != null)
                {
                    float price = jtok.Value<float>("p");
                    JArray x = jtok.Value<JArray>("ar");
                    if (price <= max && x == null)
                    {
                        int category = 0;
                        if (jtok.Value<string>("g") != "")
                            category = jtok.Value<int>("g");
                        float priceTo = 0;
                        switch (category)
                        {
                            case 1:
                                priceTo = (float)Math.Round(price / 1.05f, 2);
                                break;
                            case 2:
                                priceTo = (float)Math.Round(price * 0.95f, 2);
                                break;
                            case 3:
                                priceTo = (float)Math.Round(price * 0.95f, 2);
                                break;
                            case 4:
                                priceTo = (float)Math.Round(price * 0.9f / 0.95f, 2);
                                break;
                            default:
                                priceTo = (float)Math.Round(price * 0.85f / 0.9f, 2);
                                break;

                        }

                        res.item[i].name = jtok.Value<string>("m") + Type_to_string(jtok.Value<string>("e"));
                        res.item[i].priceFrom = price;
                        res.item[i].priceTo = priceTo;
                        res.item[i].id = jid.Value<string>();
                        res.item[i].bot = jtok.Value<JArray>("b").First.Value<string>();
                        res.item[i].status = "trade";
                        i++;
                    };
                    jid = jid.Next;
                };
                jtok = jtok.Next;
            }
            res.count = i;
            console.WriteLine(">>> csmoney: ok");     //console
            return res;
        }

    }


}