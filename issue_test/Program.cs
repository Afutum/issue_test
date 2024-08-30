using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace issue_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 所持金
            int gold = 1000;
            // 選択番号
            int selectNum = 0;
            int count = 0;

            // アイテム情報の追加
            List<Item> items = new List<Item>();
            items.Add(new Item() { id = 1, name = "木の棒", price = 10 });
            items.Add(new Item() { id = 2, name = "警棒", price = 30 });
            items.Add(new Item() { id = 3, name = "釘バット", price = 100 });
            items.Add(new Item() { id = 4, name = "日本刀", price = 500 });
            items.Add(new Item() { id = 5, name = "ピストル", price = 1000 });

            List<string> personalItems = new List<string>();

            Console.WriteLine("\nいらっしゃい");
            Console.ReadLine();
            Console.Clear();

            while (true)
            {
                Console.WriteLine("\n【所持アイテム】");
                if(personalItems.Count == 0)
                {// 現在の武器が何もない場合
                    Console.WriteLine("なし");
                    Console.WriteLine("----------------\n");
                }
                else
                {
                    // 現在の所持アイテムの一覧
                    for(int n = 0;  n < personalItems.Count; n++)
                    {
                        Console.WriteLine(personalItems[n]);
                    }

                    Console.WriteLine("----------------\n");
                }

                // 所持金の表示
                Console.WriteLine("所持金：{0}G", gold);

                // 武器一覧を表示
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine("" + items[i].id + " " + items[i].name + " " + items[i].price + "G");
                }

                // プレイヤーの入力
                Console.Write("\nどの武器を選ぶんだい (0で終了)>");
                if(int.TryParse(Console.ReadLine(), out int itemId) == true)
                {
                    selectNum = itemId;

                    // 0で終了
                    if (selectNum == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\nありがとよ");
                        Console.WriteLine("また来な");
                        Console.ReadLine();
                        break;
                    }

                    // 所持金がマイナスになる場合
                    if (gold - items[selectNum - 1].price < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("金が足らないみたいだな");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        // 所持アイテムリストに選択した武器を追加
                        personalItems.Add(items[selectNum - 1].name);

                        // 所持金から減算
                        gold -= items[selectNum - 1].price;

                        Console.WriteLine("{0}だな。ほらよ\n", items[selectNum - 1].name);
                        Console.WriteLine("所持金が{0}になった",gold);
                        Console.ReadLine();
                        Console.Clear();
                        count++;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("なに言ってるかわかんねぇな");
                    Console.WriteLine("もう一回言ってくれ");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
