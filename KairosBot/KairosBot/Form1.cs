using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace KairosBot
{
    public partial class Form1 : Form
    {
        // is all variable
        public Main trade = new Main();

        public MyConsole console;

        public Site_csmoney csmoney = new Site_csmoney();
        public Site_cstrade cstrade = new Site_cstrade();
        public Site_skinsjar skinsjar = new Site_skinsjar();
        public Site_csgocasino csgocasino = new Site_csgocasino();
        public Site_skintrades skintrades = new Site_skintrades();
        public Site_bitskins bitskins = new Site_bitskins();

        public Site_loot loot = new Site_loot();
        public Thread thread_player;
        public Thread thread_sites;
        public Thread thread_table;
        public Thread thread_prices;
        public Thread thread_abs;
        int site_index;
        System.Windows.Forms.RadioButton[] radioButtons;
        System.Windows.Forms.CheckBox[] checkboxes;
        // end variable

        public void Get_player_inventory(Main now , int num)
        {
            if (access_site_number('U', num))
            {
                if (num == 0)
                {
                    now.site[0].prime.player = csmoney.Get_player();
                };
                if (num == 1)
                {
                    int j = 1;
                    int line;
                    now.site[1].prime.player.count = 0;
                    console.WriteLine("loading " + now.site[1].name);
                    line = TextBoxConsole.Lines.Length;
                    while (now.site[1].prime.player.count == 0 && j <= 10)
                    {
                        console.StaticWrite("loading " + now.site[1].name + " " + j.ToString() + "/10", line);
                        now.site[1].prime.player = cstrade.Get_player();
                        j++;
                    }
                };
                if (num == 2)
                {
                    now.site[2].prime.player = skinsjar.Get_player();
                };
                if (num == 3)
                {
                    now.site[3].prime.player = csgocasino.Get_player();
                };
                if (num == 4)
                {
                    now.site[4].prime.player = skintrades.Get_player();
                };
                if (num == 5)
                {
                    now.site[5].prime.player = loot.Get_player();
                };
            };
        }
        public void Get_site_inventory(Main now , int num)
        {
            if (access_site_number('S', num))
                {
                if (num == 0)
                    trade.site[0].prime.site = csmoney.Get_original(trade.total);
                if (num == 1)
                    trade.site[1].prime.site = cstrade.Get_original(trade.total);
                if (num == 2)
                    trade.site[2].prime.site = skinsjar.Get_original(trade.total);
                if (num == 3)
                    trade.site[3].prime.site = csgocasino.Get_original(trade.total);
                if (num == 4)
                    trade.site[4].prime.site = skintrades.Get_original(trade.total);
                if (num == 5)
                    trade.site[5].prime.site = loot.Get_original(trade.total);
            };
        }

        public void Player_sort(Main now, int i_site)
        {
            if (access_site_number('U', i_site))
            {
                int i = 0;
                int num_max;
                Primary_item_p temp;
                while (i < now.site[i_site].prime.player.count)
                {
                    num_max = i;
                    for (int j = i + 1; j < now.site[i_site].prime.player.count; j++)
                    {
                        if (Convert.ToUInt64(now.site[i_site].prime.player.item[j].id) > Convert.ToUInt64(now.site[i_site].prime.player.item[num_max].id))
                            num_max = j;
                    };
                    if (num_max != i)
                    {
                        temp = now.site[i_site].prime.player.item[i];
                        now.site[i_site].prime.player.item[i] = now.site[i_site].prime.player.item[num_max];
                        now.site[i_site].prime.player.item[num_max] = temp;
                    }
                    i++;
                }
            };
        }
        public void Get_player_absolute_all(Main now)
        {
            int max;
            int trumode  = -1;
            for (int j = 0; j < now.count_site; j++)
            {
                now.site[j].absolute = new Absolute_part();
                now.site[j].absolute.player = new Absolute_list_p();
                now.site[j].absolute.player.count = 0;
                now.site[j].absolute.player.total = 0;
                now.site[j].absolute.player.item = new Absolute_item[Constant.player_inv];

                if (trumode == -1 && trade.site[j].prime.player.count != 0)
                    trumode = j;
            };
            now.total = 0;


            for (int i = 0; i< now.site[trumode].prime.player.count; i++)
            {
              //  if (access_site_number('U', i))
                {
                    max = 0;
                    for (int j = 0; j < now.count_site; j++)
                    {
                        if (access_site_number('U', j))
                            if (now.site[j].prime.player.item[i].status != "over" && now.site[j].prime.player.item[i].price > now.site[max].prime.player.item[i].price)
                                max = j;
                    };
                    now.site[max].absolute.player.item[now.site[max].absolute.player.count].name = now.site[max].prime.player.item[i].name;
                    now.site[max].absolute.player.item[now.site[max].absolute.player.count].id = now.site[max].prime.player.item[i].id;
                    now.site[max].absolute.player.item[now.site[max].absolute.player.count].price = now.site[max].prime.player.item[i].price;
                    now.site[max].absolute.player.total += now.site[max].prime.player.item[i].price;
                    now.total += now.site[max].prime.player.item[i].price;
                    now.site[max].absolute.player.count++;
                };
            }
        }
        public void Get_cube(Main now,int i_site)
        {
            if (access_site_number('S', i_site) && now.site[i_site].prime.site.count !=0)
            {
                for (int j = 0; j < now.count_cube; j++)
                {
                    now.cube[j].priceFrom[i_site] = 0;
                    now.cube[j].priceTo[i_site] = 0;
                }
                for (int i = 0; i <= now.site[i_site].prime.site.count; i++)
                {
                    int number = 0;
                    while (now.site[i_site].prime.site.item[i].name != now.cube[number].name && number < now.count_cube)
                        number++;
                    if (number < now.count_cube)
                    {
                        now.cube[number].priceFrom[i_site] = now.site[i_site].prime.site.item[i].priceFrom;
                        now.cube[number].priceTo[i_site] = now.site[i_site].prime.site.item[i].priceTo;
                    }
                    else
                    if (number == now.count_cube)
                    {
                        now.cube[number].priceFrom = new float[Constant.site];
                        now.cube[number].priceTo = new float[Constant.site];
                        now.cube[number].name = now.site[i_site].prime.site.item[i].name;
                        now.cube[number].priceFrom[i_site] = now.site[i_site].prime.site.item[i].priceFrom;
                        now.cube[number].priceTo[i_site] = now.site[i_site].prime.site.item[i].priceTo;
                        now.count_cube++;
                    };

                }
            };
        }
        public void Sort_bot_items(Absolute_bot now)
        {
            int i = 0;
            int num_max;
            Absolute_item_s temp;
            while (i < now.list.count)
            {
                num_max = i;
                for (int j = i + 1; j < now.list.count; j++)
                {
                    if (now.list.item[j].profit > now.list.item[num_max].profit)
                        num_max = j;
                };
                if (num_max != i)
                {
                    temp = now.list.item[num_max];
                    now.list.item[num_max] = now.list.item[i];
                    now.list.item[i] = temp;
                }
                i++;
            }


        }        
        public void Add_to_bot(Main now,int i_site, Primary_item_s obj, float price, float future_price)
        {
            if(now.site[i_site].absolute.count_bots == 0)
            {
                now.site[i_site].absolute.bot = new Absolute_bot[Constant.bot];
            };

            int num = 0;
            while (num < now.site[i_site].absolute.count_bots && obj.bot != now.site[i_site].absolute.bot[num].name)
                num++;
            if(num < now.site[i_site].absolute.count_bots)
            {
                if (now.site[i_site].absolute.bot[num].list.count == 0)
                    now.site[i_site].absolute.bot[num].list.item = new Absolute_item_s[Constant.item];
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].id = obj.id;
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].name = obj.name;
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].price = obj.priceFrom;
                now.site[i_site].absolute.bot[num].list.total += obj.priceFrom;
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].future_price = future_price;
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].profit = (float) Math.Round(100 * (price - obj.priceFrom) / obj.priceFrom,2);
                now.site[i_site].absolute.bot[num].list.count++;
            }
            else
            {
                now.site[i_site].absolute.bot[now.site[i_site].absolute.count_bots].name = obj.bot;
                now.site[i_site].absolute.count_bots++;
                if (now.site[i_site].absolute.bot[num].list.count == 0)
                    now.site[i_site].absolute.bot[num].list.item = new Absolute_item_s[Constant.item];
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].id = obj.id;
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].name = obj.name;
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].price = obj.priceFrom;
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].future_price = future_price;
                now.site[i_site].absolute.bot[num].list.item[now.site[i_site].absolute.bot[num].list.count].profit = (float)Math.Round(100 * (price - obj.priceFrom) / obj.priceFrom, 2);
                now.site[i_site].absolute.bot[num].list.count++;
            }
        }
        public void Get_trades(Main now,int i_site, List<int> to)
        {
            if (access_site_number('S', i_site))
            {
                now.site[i_site].absolute.bot = new Absolute_bot[Constant.bot];
                now.site[i_site].absolute.count_bots = 0;
                for (int i = 0; i < now.site[i_site].prime.site.count; i++)
                {
                    int number = 0;
                    while (now.site[i_site].prime.site.item[i].name != now.cube[number].name && number < now.count_cube)
                        number++;
                    if (number < now.count_cube)
                    {
                        for (int j = 0; j < now.count_site; j++)
                            if (j != i_site && now.cube[number].priceTo[j] > now.site[i_site].prime.site.item[i].priceFrom && to.Find((x) => x ==j+1) != 0 && (now.cube[number].priceFrom[j] <= now.site[i_site].absolute.player.total || now.site[i_site].absolute.player.total == 0))
                                Add_to_bot(now, i_site, now.site[i_site].prime.site.item[i], now.cube[number].priceTo[j], now.cube[number].priceFrom[j]);
                    };
                }
            };
        }

        private void PrintTable()
        {
            TablePlayerItems.Invoke((MethodInvoker)delegate
            {
                TablePlayerItems.Columns.Clear();
                TablePlayerItems.Rows.Clear();

                TablePlayerItems.Columns.Add("number", "№");
                TablePlayerItems.Columns.Add("name", "Name");
                TablePlayerItems.Columns.Add("id", "id");

                DataGridViewCell firstCell;
                DataGridViewCell secondCell;
                DataGridViewCell thirdCell;
                DataGridViewCell priceCell;
                DataGridViewRow row = new DataGridViewRow();

                int trumode = -1;
                for (int i = 0; i < trade.count_site; i++)
                {
                    if (access_site_number('U', i))
                    {
                        TablePlayerItems.Columns.Add(trade.site[i].name, trade.site[i].name);
                        if (trumode == -1 && trade.site[i].prime.player.count != 0)
                            trumode = i;
                    };
                };
                if(trumode !=-1)
                for (int j = 0; j < trade.site[0].prime.player.count; j++)
                {

                    firstCell = new DataGridViewTextBoxCell();
                    secondCell = new DataGridViewTextBoxCell();
                    thirdCell = new DataGridViewTextBoxCell();
                    row = new DataGridViewRow();
                    firstCell.Value = (j + 1).ToString();
                    secondCell.Value = trade.site[trumode].prime.player.item[j].name;
                    thirdCell.Value = trade.site[trumode].prime.player.item[j].id;
                    row.Cells.AddRange(firstCell, secondCell, thirdCell);
                    for (int i = 0; i < trade.count_site; i++)
                    {
                        if (access_site_number('U', i))
                        {
                            priceCell = new DataGridViewTextBoxCell();
                            if (trade.site[i].prime.player.item[j].status == "over")
                                priceCell.Value = trade.site[i].prime.player.item[j].price.ToString() + " over";
                            else
                                priceCell.Value = trade.site[i].prime.player.item[j].price.ToString();
                            Font ft = new Font("Tahoma", 14);
                            for (int h = 0; h < trade.site[i].absolute.player.count; h++)
                                if (trade.site[i].prime.player.item[j].id == trade.site[i].absolute.player.item[h].id)
                                {
                                    priceCell.Style.Font = ft;
                                    h = trade.site[i].absolute.player.count;
                                }
                            row.Cells.Add(priceCell);
                        };
                    };

                    TablePlayerItems.Rows.Add(row);
                };
            });
        }
        private void PrintListSites()
        {
            for(int i = 0; i< trade.count_site; i++)
                listBox_sites.Items.Insert(i, trade.site[i].name);
        }
        private void PrintSitesTable()
        {
            TableSitesItems.Invoke((MethodInvoker)delegate
            {
                int num = site_index;
                TableSitesItems.Columns.Clear();
                TableSitesItems.Rows.Clear();

                TableSitesItems.Columns.Add("number", "№");
                TableSitesItems.Columns.Add("name", "Name");
                TableSitesItems.Columns.Add("id", "id");
                TableSitesItems.Columns.Add("bot", "Bot");
                TableSitesItems.Columns.Add("pricefrom", "Price from");
                TableSitesItems.Columns.Add("priceto", "Price to");

                DataGridViewCell numberCell;
                DataGridViewCell nameCell;
                DataGridViewCell idCell;
                DataGridViewCell botCell;
                DataGridViewCell pricefromCell;
                DataGridViewCell pricetoCell;

                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < trade.site[num].prime.site.count; j++)
                {
                    numberCell = new DataGridViewTextBoxCell();
                    nameCell = new DataGridViewTextBoxCell();
                    idCell = new DataGridViewTextBoxCell();
                    botCell = new DataGridViewTextBoxCell();
                    pricefromCell = new DataGridViewTextBoxCell();
                    pricetoCell = new DataGridViewTextBoxCell();
                    row = new DataGridViewRow();

                    numberCell.Value = (j + 1).ToString();
                    nameCell.Value = trade.site[num].prime.site.item[j].name;
                    idCell.Value = trade.site[num].prime.site.item[j].id;
                    botCell.Value = trade.site[num].prime.site.item[j].bot;
                    pricefromCell.Value = trade.site[num].prime.site.item[j].priceFrom.ToString();
                    pricetoCell.Value = trade.site[num].prime.site.item[j].priceTo.ToString();

                    row.Cells.AddRange(numberCell,nameCell,idCell,botCell,pricefromCell,pricetoCell);
               
                    TableSitesItems.Rows.Add(row);
                };
            });
        }
        private void PrintAccessTable()
        {
            TableAccess.Invoke((MethodInvoker)delegate
            {
                int num = site_index;
                TableAccess.Columns.Clear();
                TableAccess.Rows.Clear();
                TableAccess.Columns.Add("number", "№");
                TableAccess.Columns.Add("name", "Name");
                TableAccess.Columns.Add("user", "User");
                TableAccess.Columns.Add("site", "Site");

                DataGridViewCell numberCell;
                DataGridViewCell nameCell;
                DataGridViewCheckBoxCell userCell;
                DataGridViewCheckBoxCell siteCell;

                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < trade.count_site; j++)
                {
                    numberCell = new DataGridViewTextBoxCell();
                    nameCell = new DataGridViewTextBoxCell();
                    userCell = new DataGridViewCheckBoxCell();
                    siteCell = new DataGridViewCheckBoxCell();

                    row = new DataGridViewRow();

                    numberCell.Value = (j + 1).ToString();
                    nameCell.Value = trade.site[j].name;

                    userCell.Value = true;
                    siteCell.Value = true;
                    row.Cells.AddRange(numberCell, nameCell, userCell, siteCell);

                    TableAccess.Rows.Add(row);
                };
            });
        }
        private void PrintPriceTable()
        {
            TablePlayerItems.Invoke((MethodInvoker)delegate
            {
                TableAllPrice.Columns.Clear();
                TableAllPrice.Rows.Clear();

                TableAllPrice.Columns.Add("number", "№");
                TableAllPrice.Columns.Add("name", "Name");

                DataGridViewCell numbeCell;
                DataGridViewCell nameCell;
                DataGridViewCell priceCell;

                DataGridViewRow row = new DataGridViewRow();

                int trumode = -1;
                for (int i = 0; i < trade.count_site; i++)
                {
                    if (access_site_number('S', i))
                    {   
                        TableAllPrice.Columns.Add(trade.site[i].name, trade.site[i].name );
                        if (trumode == -1 && trade.site[i].prime.site.count != 0)
                            trumode = i;
                    };
                };

                for (int j = 0; j < trade.count_cube -1; j++)
                {
                    numbeCell = new DataGridViewTextBoxCell();
                    nameCell = new DataGridViewTextBoxCell();
         
                    row = new DataGridViewRow();
                    numbeCell.Value = (j + 1).ToString();
                    nameCell.Value = trade.cube[j].name;
                    row.Cells.AddRange(numbeCell,nameCell);

                    for (int i = 0; i < trade.count_site; i++)
                    {
                        if (access_site_number('S', i))
                        { 
                            priceCell = new DataGridViewTextBoxCell();
                            priceCell.Value = trade.cube[j].priceFrom[i].ToString() + "    " + trade.cube[j].priceTo[i].ToString();
                            row.Cells.Add(priceCell);
                        };
                    };

                    TableAllPrice.Rows.Add(row);
                };
            });
        }
        private void PrintAbsFrom()
        {
            groupBox_abs_from.Invoke((MethodInvoker)delegate
            {

                radioButtons = new System.Windows.Forms.RadioButton[trade.count_site];
                for (int i = 0; i < trade.count_site; i++)
                {
                    radioButtons[i] = new RadioButton();
                    radioButtons[i].Text = trade.site[i].name;
                    radioButtons[i].Location = new System.Drawing.Point(10, 20 + i * 20);
                    groupBox_abs_from.Controls.Add(radioButtons[i]);
                };
            });
        }
        private void PrintAbsTo()
        {
            groupBox_abs_from.Invoke((MethodInvoker)delegate
            {
                checkboxes = new System.Windows.Forms.CheckBox[trade.count_site];
                for (int i = 0; i < trade.count_site; i++)
                {
                    checkboxes[i] = new CheckBox();
                    checkboxes[i].Text = trade.site[i].name;
                    checkboxes[i].Location = new System.Drawing.Point(10, 20 + i * 20);
                    groupBox_abs_to.Controls.Add(checkboxes[i]);
                };               
            });
        }
        private void PrintAbsTable(int i_site)
        {
            TableAbsolute.Invoke((MethodInvoker)delegate
            {
                int num = site_index;
                TableAbsolute.Columns.Clear();
                TableAbsolute.Rows.Clear();

                TableAbsolute.Columns.Add("number", "№");
                TableAbsolute.Columns.Add("name", "Name");
                TableAbsolute.Columns.Add("id", "id");
                TableAbsolute.Columns.Add("price", "Price");
                TableAbsolute.Columns.Add("future_price", "Future");
                TableAbsolute.Columns.Add("profit", "Profit");
                TableAbsolute.Columns.Add("plus", "Plus");

                DataGridViewCell numberCell;
                DataGridViewCell nameCell;
                DataGridViewCell idCell;
                DataGridViewCell priceCell;
                DataGridViewCell future_priceCell;
                DataGridViewCell profitCell;
                DataGridViewCell plusCell;
                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < trade.site[i_site].absolute.count_bots; j++)
                {
                    numberCell = new DataGridViewTextBoxCell();
                    nameCell = new DataGridViewTextBoxCell();
                    idCell = new DataGridViewTextBoxCell();
                    priceCell = new DataGridViewTextBoxCell();
                    future_priceCell = new DataGridViewTextBoxCell();
                    profitCell = new DataGridViewTextBoxCell();
                    plusCell = new DataGridViewTextBoxCell();
                    row = new DataGridViewRow();

                    numberCell.Value = (j+1).ToString();
                    future_priceCell.Value = trade.site[i_site].absolute.bot[j].list.count.ToString();
                    nameCell.Value = trade.site[i_site].absolute.bot[j].name;
                    priceCell.Value = trade.site[i_site].absolute.bot[j].list.total.ToString();

                    row.Cells.AddRange(numberCell, nameCell, idCell, priceCell, future_priceCell, profitCell, plusCell);

                    TableAbsolute.Rows.Add(row);

                    for (int i = 0; i < trade.site[i_site].absolute.bot[j].list.count; i++)
                    {
                        numberCell = new DataGridViewTextBoxCell();
                        nameCell = new DataGridViewTextBoxCell();
                        idCell = new DataGridViewTextBoxCell();
                        priceCell = new DataGridViewTextBoxCell();
                        future_priceCell = new DataGridViewTextBoxCell();
                        profitCell = new DataGridViewTextBoxCell();
                        plusCell = new DataGridViewTextBoxCell();
                        row = new DataGridViewRow();

                        numberCell.Value = (i + 1).ToString();
                        nameCell.Value = trade.site[i_site].absolute.bot[j].list.item[i].name;
                        idCell.Value = trade.site[i_site].absolute.bot[j].list.item[i].id;
                        priceCell.Value = trade.site[i_site].absolute.bot[j].list.item[i].price.ToString();
                        future_priceCell.Value = trade.site[i_site].absolute.bot[j].list.item[i].future_price.ToString();
                        profitCell.Value = trade.site[i_site].absolute.bot[j].list.item[i].profit;
                        double plus = trade.site[i_site].absolute.bot[j].list.item[i].price * trade.site[i_site].absolute.bot[j].list.item[i].profit / 100;
                        plus = Math.Round(plus, 2);
                        plusCell.Value = plus;
                        row.Cells.AddRange(numberCell, nameCell, idCell, priceCell, future_priceCell, profitCell, plusCell);

                        TableAbsolute.Rows.Add(row);
                    };
                };
            });
        }
        private void PrintAbsStatistic(int i_site)
        {
            float total = 0;
            float true_total = 0;
            float profit = -9999;
            int count = 0;
            textBox_abs_res.Invoke((MethodInvoker)delegate
            {
                textBox_abs_res.Text = "";
                textBox_abs_res.AppendText("Кількість ботів: " + trade.site[i_site].absolute.count_bots.ToString() + "\r\n");
                for(int i = 0; i < trade.site[i_site].absolute.count_bots;i++)
                {
                    total += trade.site[i_site].absolute.bot[i].list.total;
                    for(int j = 0; j < trade.site[i_site].absolute.bot[i].list.count;j++)
                    {
                        count++;
                        if (trade.site[i_site].absolute.bot[i].list.item[j].profit > profit)
                            profit = trade.site[i_site].absolute.bot[i].list.item[j].profit;
                        true_total += trade.site[i_site].absolute.bot[i].list.item[j].profit * trade.site[i_site].absolute.bot[i].list.item[j].price / 100;
                    }
                }
                textBox_abs_res.AppendText("Кількість предметів: " + count.ToString() + "\r\n");
                textBox_abs_res.AppendText("Предметів на суму: " + total.ToString() + "\r\n");
                textBox_abs_res.AppendText("Максимальний профіт: " + profit.ToString() + "\r\n");
                textBox_abs_res.AppendText("Перспектива: " + Math.Round(true_total,2).ToString() + "\r\n");
            });
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            console = new MyConsole();
            console.tb = TextBoxConsole;
            csgocasino.console = console;
            csmoney.console = console;
            cstrade.console = console;
            skinsjar.console = console;
            skintrades.console = console;
            loot.console = console;
            trade.count_site = 6;

            trade.site[0].name = "csmoney";
            trade.site[1].name = "cstrade";
            trade.site[2].name = "skinsjar";
            trade.site[3].name = "csgocasino";
            trade.site[4].name = "skintrades";
            trade.site[5].name = "loot";

            PrintListSites();
            CloseAllPanel();
            PrintAccessTable();
            PrintAbsFrom();
            PrintAbsTo();
        }

        public bool access_site_number(char c, int num)
        {
            bool res = true;
            if (num < trade.count_site && num >=0)
            {
                DataGridViewCheckBoxCell temp = new DataGridViewCheckBoxCell();
                if (c == 'U')
                    temp = (DataGridViewCheckBoxCell)TableAccess.Rows[num].Cells[2];
                if (c == 'S')
                    temp = (DataGridViewCheckBoxCell)TableAccess.Rows[num].Cells[3];
                if (temp.Value.ToString() == "True")
                    res = true;
                if (temp.Value.ToString() == "False")
                    res = false;
            }
            else res = false;
            return res;
        }
        void thread_user()
        {
            for(int i = 0; i < trade.count_site; i++)
                Get_player_inventory(trade, i);

            for (int i = 0; i < trade.count_site; i++)
                Player_sort(trade, i);

            Get_player_absolute_all(trade);
            PrintTable();

            thread_player.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread_player = new Thread(thread_user);
            thread_player.Start();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (thread_player != null)
                if (thread_player.ThreadState == ThreadState.Running)
                    thread_player.Abort();
            Close();
        }

        private void console_TextChanged(object sender, EventArgs e)
        {

        }

        public void CloseAllPanel()
        {
            panel_my_inv.Visible = false;
            panel_all_price.Visible = false;
            panel_site_inv.Visible = false;
            panel_all_price.Visible = false;
            panel_access.Visible = false;
            panel_absolute.Visible = false;
        }

        private void button_my_inv_Click(object sender, EventArgs e)
        {
            CloseAllPanel();
            panel_my_inv.Visible = true;
        }

        private void button_site_inv_Click(object sender, EventArgs e)
        {
            CloseAllPanel();
            panel_site_inv.Visible = true;
        }

        private void button_all_price_Click(object sender, EventArgs e)
        {
            CloseAllPanel();
            panel_all_price.Visible = true;
        }


        public void Thread_void_load_site()
        {
            Get_site_inventory(trade, site_index);
            thread_sites.Abort();
        }
        public void Thread_void_load_all_site()
        {
            for(int i = 0; i< trade.count_site;i++)
                 Get_site_inventory(trade, i);
            thread_sites.Abort();
        }
        public void Thread_void_load_all_price()
        {
            trade.cube = new Global_item[Constant.cube];
            trade.count_cube = 0;
            for (int i = 0; i < trade.count_site; i++)
                Get_cube(trade, i);

            PrintPriceTable();
            thread_sites.Abort();
        }
        public void Thead_void_table()
        {
            PrintSitesTable();
            thread_table.Abort();
        }
        public void Thead_void_abs()
        {
            int from = -1;
            List<int> to = new List<int>(); 
            for(int i = 0; i< trade.count_site; i++)
            {
                if (radioButtons[i].Checked)
                    from = i;
            };
            if (from >= 0 && from < trade.count_site)
            {
                console.WriteLine("from " + trade.site[from].name);
                console.Write("    to: ");
                for (int i = 0; i < trade.count_site; i++)
                {
                    if (checkboxes[i].Checked && i != from)
                    {
                        to.Add(i + 1);     
                        console.Write(trade.site[i].name + " ");
                    };
                };

                if (to.Count > 0)
                {
                    Get_trades(trade, from, to);

                    for (int i = 0; i < trade.site[from].absolute.count_bots; i++)
                        Sort_bot_items(trade.site[from].absolute.bot[i]);

                    PrintAbsTable(from);
                    PrintAbsStatistic(from);
                };
            };
                thread_abs.Abort();
        }
        private void listBox_sites_SelectedIndexChanged(object sender, EventArgs e)
        {
            site_index = listBox_sites.SelectedIndex;
            if (trade.site[site_index].prime.site.count != 0)
            {
                thread_table = new Thread(Thead_void_table);
                thread_table.IsBackground = true;
                thread_table.Start();
            }
            else
                console.WriteLine("Site: " + trade.site[site_index].name + " needs updating");
        }
        private void button_update_site_Click(object sender, EventArgs e)
        {
            thread_sites = new Thread(Thread_void_load_site);
            thread_sites.Start();
        }
        private void button_sites_update_all_Click(object sender, EventArgs e)
        {
            thread_sites = new Thread(Thread_void_load_all_site);
            thread_sites.Start();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_access_Click(object sender, EventArgs e)
        {
            CloseAllPanel();
            panel_access.Visible = true;
        }

        private void button_all_price_update_Click(object sender, EventArgs e)
        {
            thread_prices = new Thread(Thread_void_load_all_price);
            thread_prices.Start();
        }


        private void button_get_absolute_Click(object sender, EventArgs e)
        {
            CloseAllPanel();
            panel_absolute.Visible = true;
        }

        private void button_abs_update_Click(object sender, EventArgs e)
        {
            thread_abs = new Thread(Thead_void_abs);
            thread_abs.Start();
        }
    }
}
