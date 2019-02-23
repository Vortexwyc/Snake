using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        /// <summary>设置静态变量,让其他类访问控件</summary>
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }
        Snake snake = new Snake();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.BackColor = Color.Gray;
            

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        Thread thread_SnakeHead = null;
   
        /// <summary>开始按钮(焦点在这里)</summary>
        private void Button_START_Click(object sender, EventArgs e)
        {
            
            thread_SnakeHead = new Thread(Init_Direction);
            thread_SnakeHead.Start();


        }
  
        /// <summary>用户控制移动方向(上下左右)</summary>
        private void Move_keydown(object sender, PreviewKeyDownEventArgs e)
        {

        }
        /// <summary>初始化移动方向</summary>
        public void Init_Direction()
        {
            int counter = 0;
            Random random = new Random();
            Snake.Direction = random.Next() % 4;
            Console.WriteLine("初始方向为"+ Snake.Direction+","+"蛇头为"+Snake.List_Snake.Last());
            while (snake.IsEND())
            {
                snake.Move(Snake.Direction);
                ChangeColor(Snake.List_Snake.Last().ToString());
                RestoreColor(Snake.List_Snake[0].ToString());
                
                //吃到食物
                if (Snake.List_Snake.Last() == Snake.Food)
                {
                    //重新生成食物
                    Snake.Food = snake.Init_Food();
                    NewFood(Snake.Food.ToString());
                    Console.WriteLine("吃到食物!");
                }
                else
                {
                    //要在还原尾巴颜色后删除
                    Snake.List_Snake.RemoveAt(0);
                }
                Thread.Sleep(Snake.Difficult);
                counter += 1;
                Console.WriteLine("移动" + counter + "," + "蛇头为" + Snake.List_Snake.Last() + "," +"蛇长"+Snake.List_Snake.Count()+","+"食物"+Snake.Food);
            }
            
            MessageBox.Show(Snake.THE_END);
            //SetText(id);
            thread_SnakeHead.Abort();
            
        }


        //委托
        private delegate void SetDelegate(string value);
        /// <summary>新蛇头变色</summary>
        private void ChangeColor(string Text)
        {
            if (this.InvokeRequired)
            {
                SetDelegate d = new SetDelegate(ChangeColor);
                this.Invoke(d, Text);
            }
            else
            {
                Button b = (Button)flowLayoutPanel1.Controls[Text];
                b.BackColor = Color.Green;
            }
        }
        /// <summary>尾巴还原颜色</summary>
        private void RestoreColor(string Text)
        {
            if (this.InvokeRequired)
            {
                SetDelegate d = new SetDelegate(RestoreColor);
                this.Invoke(d, Text);
            }
            else
            {
                Button b = (Button)flowLayoutPanel1.Controls[Text];
                b.BackColor = Color.Gray;
            }
        }
        /// <summary>新食物上色</summary>
        private void NewFood(string Text)
        {
            if (this.InvokeRequired)
            {
                SetDelegate d = new SetDelegate(NewFood);
                this.Invoke(d, Text);
            }
            else
            {
                Button b = (Button)flowLayoutPanel1.Controls[Text];
                b.BackColor = Color.Yellow;

            }
        }
        private void Button_EXIT_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Button_INIT_Click(object sender, EventArgs e)
        {
            snake.Init_Snake();
            Snake.Food = snake.Init_Food();
            Snake.THE_END = "";
            Snake.Difficult = snake.Init_Difficult();
            //Snake.Direction = 5;
            this.flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 400; i++)
            {
                Button b = new Button();
                //边界
                if (i < 21 || i>378 || i %20 ==0 ||(i+1) % 20 ==0)
                {
                    b.BackColor = Color.Red;
                }
                //区域
                else
                {
                    b.BackColor = Color.Gray;
                }

                b.Width = 25;
                b.Height = 25;
                //b1.Text = i.ToString();
                b.Name = i.ToString();
                //b.Text = i.ToString();
                b.Enabled = false;
                b.Margin = new Padding(0, 0, 0, 0);

                //每5格,就往下移动
                //b1.Top = b1.Width * (i / 5);
                //每5次重置
                //b1.Left = b1.Height * (i % 5);
                b.FlatAppearance.BorderSize = 0;
                b.FlatStyle = FlatStyle.Flat;


                this.flowLayoutPanel1.Controls.Add(b);
            }
            Button b1 = (Button)flowLayoutPanel1.Controls[Snake.Food.ToString()];
            b1.BackColor = Color.Yellow;
            Button b2 = (Button)flowLayoutPanel1.Controls[Snake.List_Snake.Last().ToString()];
            b2.BackColor = Color.Green;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                if (!(Snake.Direction == 0 || Snake.Direction == 1))

                    Snake.Direction = 0;
            }

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                if (!(Snake.Direction == 0 || Snake.Direction == 1))
                    Snake.Direction = 1;
            }

            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if (!(Snake.Direction == 2 || Snake.Direction == 3))
                    Snake.Direction = 2;
            }

            if (e.KeyCode == Keys.D | e.KeyCode == Keys.Right)
            {
                if (!(Snake.Direction == 2 || Snake.Direction == 3))
                    Snake.Direction = 3;
            }
        }

        private void ComboBox_difficult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
        }
    

