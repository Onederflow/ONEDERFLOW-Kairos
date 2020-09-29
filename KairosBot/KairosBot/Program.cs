using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
public class Constant
{
    public const int player_inv = 100;
    public const int site = 100;
    public const int cube = 14000;
    public const int original = 35000;
    public const float main_total = 100;
    public const int bot = 200;
    public const int item = 2000;
}


public struct Primary_item_p
{
    public string name;
    public string id;
    public string status;
    public string bot;
    public float price;
}
public struct Primary_list_p
{
    public Primary_item_p[] item;
    public int count;
}

public struct Primary_item_s
{
    public string name;
    public string id;
    public string status;
    public string bot;
    public float priceFrom;
    public float priceTo;
}
public struct Primary_list_s
{
    public Primary_item_s[] item;
    public int count;
}
public struct Primary_part
{
    public Primary_list_p player;
    public Primary_list_s site;
}
public struct Absolute_item
{
    public string name;
    public string id;
    public float price;
}
public struct Absolute_list_p
{
    public Absolute_item[] item;
    public int count;
    public float total;
}


public struct Absolute_item_s
{
    public string name;
    public string id;
    public float price;
    public float future_price;
    public float profit;
}
public struct Absolute_list_s
{
    public Absolute_item_s[] item;
    public int count;
    public float total;
}
public struct Absolute_bot
{
    public string name;
    public Absolute_list_s list;
}

public struct Absolute_part
{
    public Absolute_list_p player;
    public Absolute_bot[] bot;
    public int count_bots;

}

public struct Global_item
{
    public string name;
    public float[] priceTo;
    public float[] priceFrom;
}

public struct All_site
{
    public string name;
    public Primary_part prime;
    public Absolute_part absolute;
}
public class Main
{
    public All_site[] site = new All_site[Constant.site];
    public Global_item[] cube = new Global_item[Constant.cube];
    public int count_site;
    public int count_cube;
    public float total = Constant.main_total;
}

public class MyConsole
{
    public System.Windows.Forms.TextBox tb;

    public void WriteLine(string s)
    {
        if (tb.InvokeRequired)
        {
            tb.Invoke((MethodInvoker)delegate
            {
                tb.AppendText("\r\n" + s);
            });
        }
        else
        {
            tb.AppendText("\r\n" + s);
        }
    }
    public void WriteLine()
    {
        if (tb.InvokeRequired)
        {
            tb.Invoke((MethodInvoker)delegate
            {
                tb.AppendText("\r\n");
            });
        }
        else
        {
            tb.AppendText("\r\n");
        }
    }
    public void WriteLine(float f)
    {
        if (tb.InvokeRequired)
        {
            tb.Invoke((MethodInvoker)delegate
            {
                tb.AppendText("\r\n" + f.ToString());
            });
        }
        else
        {
            tb.AppendText("\r\n" + f.ToString());
        }
    }

    public void Write(string s)
    {
        if (tb.InvokeRequired)
        {
            tb.Invoke((MethodInvoker)delegate
            {
                tb.AppendText(s);
            });
        }
        else
        {
            tb.AppendText(s);
        }
    }
    public void Write()
    {
        if (tb.InvokeRequired)
        {
            tb.Invoke((MethodInvoker)delegate
            {
                tb.AppendText("");
            });
        }
        else
        {
            tb.AppendText("");
        }
    }
    public void Write(float f)
    {
        if (tb.InvokeRequired)
        {
            tb.Invoke((MethodInvoker)delegate
            {
                tb.AppendText(f.ToString());
            });
        }
        else
        {
            tb.AppendText(f.ToString());
        }
    }

    public void StaticWrite(string s, int num)
    {
        if (tb.InvokeRequired)
        {
            tb.Invoke((MethodInvoker)delegate
            {
                if (num <= tb.Lines.Length)
                {
                   tb.Text =  tb.Text.Remove(tb.GetFirstCharIndexFromLine(num - 1), tb.Lines[num - 1].Length);
                   tb.Text = tb.Text.Insert(tb.GetFirstCharIndexFromLine(num - 1), s + "\r\n");
                };
            });
        }
        else
        {
            if (num <= tb.Lines.Length)
            {
                tb.Text = tb.Text.Remove(tb.GetFirstCharIndexFromLine(num - 1), tb.Lines[num - 1].Length);
                tb.Text = tb.Text.Insert(tb.GetFirstCharIndexFromLine(num - 1), s + "\r\n");
            };
        }
    }
}

namespace KairosBot
{   
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}