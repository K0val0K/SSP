using SSP3_PAIN.Helpers;
using SSP3_PAIN.Models;
using System.Drawing;
using System.Reflection.Metadata;

namespace SSP3_PAIN
{
    public partial class Form1 : Form
    {
        private List<BallModel> ballList;
        private List<LineParamModel> parametrs;
        private LineParamModel firstline;
        private LineParamModel secondline;
        private static readonly string[] speeds = { "4", "6", "8", "10", "12" };
        private static readonly string[] colors = { "Красный", "Чёрный","Синий","Жёлтый","Зелёный", "Cерый" };
        private static readonly string[] size = { "15", "20","25","30","35" };
        public Form1()
        {
            InitializeComponent();
            ballList = new();
            parametrs = new ();
            comboToColor.Items.AddRange(colors);
            comboToColor.SelectedIndex = 0;
            ComboToSize.Items.AddRange(size);
            ComboToSize.SelectedIndex = 3;
            comboBox1.Items.AddRange(speeds);
            comboBox1.SelectedIndex = 1;
            firstline = new LineParamModel(300, 200, 320, 10);
            secondline = new LineParamModel(20, 200, 160, 10);


            ballList.Add(new BallModel(66, 66, 4, 4,25 , new CancellationTokenSource(), Brushes.Blue,parametrs));
           
        }  

      
        private async void PaintAdd(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.LightGray, 20, 20, 600, 400);
               
                if (parametrs.Count != 0)
                {
                    foreach (var item in parametrs)
                    {
                        g.FillRectangle(Brushes.Red, item.First, item.Second, item.Therd, item.Four);
                    }
                }         
                


                foreach (var item in ballList)
                {
                    if (!item.token.IsCancellationRequested)  // проверяем наличие сигнала отмены задачи
                    {
                        
                        item.Task = new Task(() => GetCustomBall(item), item.token.Token);
                       
                        item.Task.RunSynchronously();
                        item.token.Cancel();
                        item.Task.Dispose();
                        item.Task.Wait();
                        
                            
                            
                    }
                    g.FillEllipse(item.Color, item.x, item.y, item.SyzeXY, item.SyzeXY);
                    pictureBox1.Invalidate();

                }
                
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"what.txt", ex.Message);//!!!!!
            }
        }        


        private async Task GetCustomBall(BallModel bm)
        {
            while (bm.x <= 600 && bm.x >= bm.SyzeXY && bm.y <= 400 && bm.y >= bm.SyzeXY)
            {
                bool ind = false;
                if (bm.parmetrs.Count != 0)
                {
                    foreach (var item in parametrs)
                    {
                        if (bm.x > item.First && bm.x < item.First + item.Therd && bm.y < item.Second && bm.y > item.Second - item.Four)
                        
                        {                            
                            bm.dy = -bm.dy;
                            bm.x += bm.dx;
                            bm.y += bm.dy;
                            bm.y = bm.y > 400 ? 400 : bm.y;
                            bm.y = bm.y < bm.SyzeXY ? bm.SyzeXY : bm.y;
                            bm.x = bm.x > 600 ? 600 : bm.x;
                            bm.x = bm.x < bm.SyzeXY ? bm.SyzeXY : bm.x;
                            ind = true;
                            
                        }
                    }
                }
                
                if (bm.y == bm.SyzeXY || bm.y == 400)
                {
                    bm.dy = -bm.dy;
                    bm.x += bm.dx;
                    bm.y += bm.dy;
                    bm.y = bm.y > 400 ? 400 : bm.y;
                    bm.y = bm.y < bm.SyzeXY ? bm.SyzeXY : bm.y;
                    bm.x = bm.x > 600 ? 600 : bm.x;
                    bm.x = bm.x < bm.SyzeXY ? bm.SyzeXY : bm.x;
                }
                else if (bm.x == bm.SyzeXY || bm.x == 600)
                {
                    bm.dx = -bm.dx;
                    bm.x += bm.dx;
                    bm.y += bm.dy;
                    bm.y = bm.y > 400 ? 400 : bm.y;
                    bm.y = bm.y < bm.SyzeXY ? bm.SyzeXY : bm.y;
                    bm.x = bm.x > 600 ? 600 : bm.x;
                    bm.x = bm.x < bm.SyzeXY ? bm.SyzeXY : bm.x;
                }
                else
                {
                    bm.x += bm.dx;
                    bm.y += bm.dy;
                    bm.y = bm.y > 400 ? 400 : bm.y;
                    bm.y = bm.y < bm.SyzeXY ? bm.SyzeXY : bm.y;
                    bm.x = bm.x > 600 ? 600 : bm.x;
                    bm.x = bm.x < bm.SyzeXY ? bm.SyzeXY : bm.x;
                    pictureBox1.Invalidate();
                    await Task.Delay(10);
                }
                
                
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //pictureBox1.Paint += new PaintEventHandler(PaintAdd);
            var size = int.Parse(ComboToSize.SelectedItem.ToString());
            var color = GetColorHelper.GetColor(comboToColor.SelectedItem.ToString());
            if (ballList.Count <= 10)//!!!!
            {
                ballList.Add(new BallModel(35, 35, int.Parse(comboBox1.SelectedItem.ToString()), int.Parse(comboBox1.SelectedItem.ToString()), size, new CancellationTokenSource(), color,parametrs));
                label5.Text=string.Empty;
            }
            else
            {
                label5.Text = "Превышено максимальное количество шаров!!(10)";
            }

           
        }


       
        private void button1_Click(object sender, EventArgs e)
        {
            if (ballList.Count != 0)
            {
                ballList.RemoveAt(ballList.Count - 1);
                label5.Text = string.Empty;
            }
            else
            {
                label5.Text = "Невозможно удалить несуществующий шар";
            }
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (parametrs.Count <= 2)
            {
                if (parametrs.Count == 1)
                {
                    parametrs.Add(firstline);
                }
                else
                {
                    parametrs.Add(secondline);
                }



                label5.Text = string.Empty;
            }
            else
            {
                label5.Text = "Превышено максимальное количество линий!!(2)";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (parametrs.Count != 0)
            {
                parametrs.RemoveAt(parametrs.Count - 1);
                label5.Text = string.Empty;
            }
            else
            {
                label5.Text = "Невозможно удалить несуществующее ограничение";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in ballList)
            {
                if (item.dx <= 0)
                {
                    item.dx--;
                }
                else
                {
                    item.dx++;
                }
                if (item.dy <= 0)
                {
                    item.dy--;
                }
                else
                {
                    item.dy++;
                }
            }
            
            
            //ballList.Add(item);
        }
    }
}