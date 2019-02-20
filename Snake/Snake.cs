using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    class Snake
    {
        /// <summary>蛇身的集合,最后一个元素为蛇头</summary>
        public static List<int> List_Snake = new List<int>();
        /// <summary>食物(食物的集合,根据蛇身动态变化)</summary>
        public static List<int> List_Food = new List<int>();
        /// <summary>初始化蛇头</summary>
        public static int SnakeHead;
        /// <summary>初始化食物</summary>
        public static int Food;
        /// <summary>结束语</summary>
        public static string THE_END ;
        /// <summary>移动方向(0123为上下左右)</summary>
        public static int Direction ;
        /// <summary>是否结束(false为结束)</summary>
        public bool IsEND()
        {
            //是否咬到自己
            for (int i = 0; i < List_Snake.Count() - 1; i++)
            {
                if (List_Snake.Last() == List_Snake[i])
                {
                    Console.WriteLine("咬自己");
                    THE_END = "得分:" + List_Snake.Count.ToString() + "\r\n咬到自己了!!蠢货";
                    return false;
                }

            }
            //结束
            if (List_Snake.Last() < 21 || List_Snake.Last() % 20 == 0 || (List_Snake.Last() + 1) % 20 == 0 || 399 - List_Snake.Last() < 20)
            {
                Console.WriteLine("撞墙");
                THE_END += "得分:" + List_Snake.Count.ToString() + "\r\n撞墙了!!蠢货";
                return false;
            }
            //食物集合大小为0
            if (List_Food.Count == 0)
            {
                THE_END += "得分:" + List_Snake.Count.ToString() + "\r\n恭喜你通关了!!!";
                return false;
            }
                return true;

            
        }
        /// <summary>移动,更新list蛇头</summary>
        public void Move(int direction)
        {
            switch (direction)
            {
                case 0:
                    List_Snake.Add((List_Snake.Last() - 20));
                    break;
                case 1:
                    List_Snake.Add((List_Snake.Last()) + 20);
                    break;
                case 2:
                    List_Snake.Add(List_Snake.Last() - 1);
                    break;
                case 3:
                    List_Snake.Add(List_Snake.Last() + 1);
                    break;

            }
           
            
        }

        /// <summary>初始化蛇身(list)</summary>
        public List<int> Init_Snake()
        {
            List_Snake.Clear();
            Random random = new Random();
            List_Snake.Add(random.Next() % 200);
            while (true)
            {
                //如果为边界,重新随机
                if (List_Snake[0] < 21 || List_Snake[0] > 378 || List_Snake[0] % 20 == 0 || (List_Snake[0] + 1) % 20 == 0)
                {
                    List_Snake[0] = random.Next() % 200;
                }
                else
                    return List_Snake;
            }
            
        }
        /// <summary>初始化食物</summary>
        public int Init_Food()
        {
            List_Food.Clear();
            for (int i = 0; i < 400; i++)
            {
                if (!(i < 21 || i > 378 || i % 20 == 0 || (i + 1) % 20 == 0))
                {
                    List_Food.Add(i);
                }
            }
             List_Food = List_Food.Except(List_Snake).ToList() ;
            Random random = new Random();

            return List_Food[ random.Next() % (List_Food.Count)];

        }

    }


}
