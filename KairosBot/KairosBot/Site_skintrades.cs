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
    public class Site_skintrades
    {
        public WebResponse Original;
        public WebResponse Player;

        public MyConsole console;

        public WebResponse GetOriginalWeb()
        {
            HttpWebRequest rr = (HttpWebRequest)WebRequest.Create("https://api.skintrades.com/v1/inventory/");
            return rr.GetResponse();
        }

        public WebResponse GetPlayerWeb()
        {
            HttpWebRequest rr = (HttpWebRequest)WebRequest.Create("https://skinsjar.com/api/v3/load/inventory?refresh=1&v=2");
            rr.Headers.Add("method: GET");
            rr.Headers.Add("scheme:https");
            rr.Headers.Add("cookie:__cfduid=d958ce9566bfd5ac031fbc82e7f71bb831509217254; steamid=skinsjar.cookie%3A1A8aM4uMr9GgNOZ%2BDvuIIQ%3D%3D%7E%7E%7E%3A%7E%7E%7EioltEmzzhkL%2B1zwW6grP6REac5Xrr6ad8W0CdZW7TU0%3D; steamProfile=skinsjar.cookie%3AD5Bcez1QpI6bq63Uijhhhg%3D%3D%7E%7E%7E%3A%7E%7E%7ECSpVoBhph08zxRJLCVd63WSvCCzQ3B3meINNW0xazz2d%2FlwUwY1yZwSljpa2b0q%2FUOAa8pfS9%2F3fSona422604ie6Ih%2FpbhPhIP7K9vi1YsuNIrLBvvp8Z6%2Bw1ye1c1BzxB%2BrIpEfOp98ZnlzqGQlyQXbejC2sJLGoksFcw1twbUqIPfuL%2F2O9waFivrj0BFWRhH%2FPSjbaY0AD7PRs7Oc8mwlrk4JgYpjA7d8FJbAj8oq7qMIMlD4cMT3aR%2BCvOk3dFA%2FCzv%2FvcX3NTOGGzKqaRiM0969DGYh%2FjdCLfcbN%2Fs5waohPNww49v%2FpHKY%2FhUythhl%2BTSNA0rZf0bPNmnhh0fnjEfLMBoxhpJxpUnQcXSkKlq5EfS3SMAWBl3bejWBBrJ%2FaYTjHnjVjQSiboe39SrVXf6H%2Fr2S4pBE4gtAAtdHVK%2FcWxSBpu3CsL2smtFL5AHNDCvki4%2Ffq9jTGF%2ByxCtffrF0pGhbUI5NBu9S7tIvLZ8YkUVqmKK%2FxNA4Bi8EaR9sguC%2FwNCyTuXScgEHuItyowVQH6MXNoNnFYGr9WKPPShI6J5l3jPH52ZjPLNHcGfbhJdaCb56df14y7DN0%2FDLGqEzzGl4Sd%2F9VVJZLE9ZFsbrK%2FOOaBxsjidla2VdeAsc2dyrNz1wy3JWknQqYuO5WKiHanKaiUw7em1w0gKYi0M3R5F6IlIwfZkCMbdzlQbcXyrWOrzhAaJnMpfokuroGV70eFdNIiywoHYWOrwlf62DgckeXTfOcMaXfHMFfX15yLp6eCHhK0zGDMmhlPEYWiGb9wmqptaCf4xbXZQqb3yUi0aE9%2F%2Fx1ph2iMjD24Rk2goQBk7xJROcaY5YkpkxbjJOHCzo2jwOrJwZiNTIwfbwsiqKt7OQ0Hipc3fgNp2exSen%2BqxtJukWBeFuZgOXKq0d4f27uvIEGG%2BfPUsGaCyDnhxAKsl6H3%2FcCHnPjG5h%2FIzERAy9%2Be0dIMDCWHEZ%2BDNuULDgXtOqvtqE0WzZbT4Lk4%2BIxKaZlxWQCq%2BiGa2GUZ50Nl3%2BLmN%2BYuJIuqXwIyfrMXxHqAhWqrHPSgksGeOQMRt3jZPdTVilc9LmrHP%2Bca4Vx3%2BtOX0iPm9xjqQ0p%2Bl5gc32fpm2X5clItL6s9HtENoHqWkDdCA9%2Fv82YZ%2BBzQYyqwzKkikCyVv8JxRFuUpfG9%2FiXPFMYaquyFLn18EIH9hrb4cMOuy%2FsUYdCc81fV524KRza865V9Ed73XnddIiAENa7j8Bz%2BaCI54DuMx50cJ%2BopmdEVKtRpPTAlE582Gna%2FJsZfVJZPaoA%3D%3D; PHPSESSID=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzUxMiJ9.eyJhY2NvdW50SWQiOjI3NzYyMiwic3RlYW1pZCI6Ijc2NTYxMTk4MzY4MjA5NDI4In0.3O6lKG0Nc4tyr6_HVSF-PgzObnUpr4YP5RfANVij0BKM5YL1X2Sbiwk0jfjfo8lUnY394CkklgG7j5XuoyjhiQ; language=ru; tradeUrl=skinsjar.cookie%3A2KcLoZJp8m2%2B9kYx%2BB9q6w%3D%3D%7E%7E%7E%3A%7E%7E%7EpwDLSYC4ZGNNE8Zqzcnlf6xtp7apXtGWvX2SeTwHMPkGGVKipDGz32RBY4g0y2NNMh%2FbGOnLazKUilTtzwH4YjhqkYEO2gBE9ZRm8748nv4%3D; inventoryBalance=skinsjar.cookie%3AsV7jvcq5jOTCybR19yI9Kw%3D%3D%7E%7E%7E%3A%7E%7E%7ELfSIdKua0T65BwABMIkahA%3D%3D; transactionsCount=skinsjar.cookie%3AI7c%2BWmxwETsGPkA113NUOw%3D%3D%7E%7E%7E%3A%7E%7E%7ETEUOY%2BK2ReqqhXQa%2Fuymog%3D%3D; abuchat_token=skinsjar.cookie%3AAbdFoxFnQDPNK82vtwQ3Mg%3D%3D%7E%7E%7E%3A%7E%7E%7EFaMhkX%2BQnIoWLJJuLQ1IkA%3D%3D; abuchat_expire_at=skinsjar.cookie%3ArvSUeNgPkPk2XsH0OTUqfQ%3D%3D%7E%7E%7E%3A%7E%7E%7E0J82Qh9wn7hqyuZDW0WSAA%3D%3D; currentCurrencyCode=USD; _ga=GA1.2.172034151.1509217258; _gid=GA1.2.1891063336.1509217258; intercom-id-f94tzf5i=e4ed0f0d-c9ce-437b-bcd2-5f0119b0f5d9; lastUsedBotId=skinsjar.cookie%3A0%2BclYA%2FXlAqmVKyIfEnduQ%3D%3D%7E%7E%7E%3A%7E%7E%7Esj3hVNwlj4xBNNnM1foN8A%3D%3D; last_get_locked=skinsjar.cookie%3AvDNkmoXf4KhPPSn4egyJkA%3D%3D%7E%7E%7E%3A%7E%7E%7EQqGn1A2y1Cx3nlTL%2FwYK3Q%3D%3D; account=5a4c3c5ec5380a9471febf8f3f85cc29b8347576");
            rr.Headers.Add("pragma:no-cache");
            rr.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 Safari/537.36 OPR/48.0.2685.50";
            return rr.GetResponse();
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
            JArray jar = JObject.Parse(line).Value<JArray>("items");

            JToken jtok = jar.First;
            int i = 0;
            JToken jid;
            while (jtok != null)
            {
                string name = jtok.Value<string>("name");
                float price = jtok.Value<float>("price");

                jid = jtok.Value<JArray>("items").First;
                while (jid != null)
                {
                    res.item[i].name = name;
                    res.item[i].price = price;

                    if (res.item[i].price == 0)
                        res.item[i].status = "over";
                    res.item[i].id = jid.Value<string>("id");
                    res.item[i].bot = "user";
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
            console.WriteLine(">>> skintrades start loading");     //console
            Primary_list_s res = new Primary_list_s();
            res.item = new Primary_item_s[Constant.original];
            Original = GetOriginalWeb();
            string line;
            using (StreamReader reader = new StreamReader(Original.GetResponseStream()))
            {
                line = reader.ReadLine();
            };
            console.WriteLine(">>> skintrades data downloaded");     //console

            JArray jar = JObject.Parse(line).Value<JArray>("response");

            JToken jtok = jar.First;
            int i = 0;
            while (jtok != null)
            {
                if (jtok.Value<string>("price") != null)
                {
                    res.item[i].priceFrom = (float)jtok.Value<float>("price");
                    res.item[i].bot = jtok.Value<string>("bot_id");
                    res.item[i].id = jtok.Value<string>("asset_id");
                    res.item[i].name = jtok.Value<string>("market_name");
                    res.item[i].status = "trade";

                    string category = jtok.Value<string>("item_type");
                    float priceTo;
                    float price = res.item[i].priceFrom;

                    switch (category)
                    {
                        case "Knife"://
                            priceTo = (float)Math.Round(price * 0.95f, 2);
                            break;
                        case "Key"://
                            priceTo = (float)Math.Round(price * 0.95f, 2);
                            break;
                        default:
                            priceTo = (float)Math.Round(price * 0.90f / 0.95f, 2);
                            break;
                    };
                    res.item[i].priceTo = priceTo;
                    i++;
                };
                jtok = jtok.Next;
            }

            res.count = i;
            console.WriteLine(">>> skintrades: ok");     //console
            return res;
        }

    }




}
