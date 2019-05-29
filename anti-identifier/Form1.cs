using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace anti_identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        List<String> file_name = new List<string> { };
        List<String> destination_file_name = new List<string> { };
        String destination = null;
        Bitmap bmp;
        Bitmap buffer;
        Boolean flag = false;
        Graphics g;
        SolidBrush pen;
        int num = 0;
        int pic_num = 0;
        private void view_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = textBox1.Text;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dialog.SelectedPath;
            }
            destination = textBox2.Text;
        }
        private void forward_button_Click(object sender, EventArgs e)
        {
            drawrectlist.Clear();
            pic_num--;
            if (pic_num<0)
            {
                MessageBox.Show("沒有上一張");
                pic_num = 0;
            }
            else
            {
                if (destination_file_name.Contains(destination + "\\去識別_" + file_name[pic_num].Remove(0, num + 1)))
                {
                    buffer = new Bitmap(destination + "\\去識別_" + file_name[pic_num].Remove(0, num + 1));
                    bmp = resize(buffer, new Size(pic.Width, pic.Height));
                    pic.Image = bmp;
                }
                else
                {
                    buffer = new Bitmap(file_name[pic_num]);
                    bmp = resize(buffer, new Size(pic.Width, pic.Height));
                    pic.Image = bmp;
                }
                
            }
        }
        private void next_button_Click(object sender, EventArgs e)
        {
            drawrectlist.Clear();
            pic_num++;
            if (pic_num > file_name.Count - 1)
            {
                MessageBox.Show("沒有下一張");
                pic_num = file_name.Count - 1;
            }
            else
            {

                if (destination_file_name.Contains(destination + "\\去識別_" + file_name[pic_num].Remove(0, num + 1)))
                {
                    buffer = new Bitmap(destination + "\\去識別_" + file_name[pic_num].Remove(0, num + 1));
                    bmp = resize(buffer, new Size(pic.Width, pic.Height));
                    pic.Image = bmp;
                }
                else
                {
                    buffer = new Bitmap(file_name[pic_num]);
                    bmp = resize(buffer, new Size(pic.Width, pic.Height));
                    pic.Image = bmp;
                }
                
            }
        }
        private void Load_button_Click(object sender, EventArgs e)
        {
            panel3.AutoScroll = true;
            num = textBox1.Text.Length;
            file_name.Clear();
            pic_num = 0;
            destination_file_name.Clear();
            foreach (string fname in System.IO.Directory.GetFileSystemEntries(textBox1.Text))
            {
                file_name.Add(fname);
            }

            if(textBox2.Text==string.Empty)
            {
                MessageBox.Show("請選擇目的地檔案");
            }
            else
            {
                foreach (string fname in System.IO.Directory.GetFileSystemEntries(textBox2.Text))
                {
                    destination_file_name.Add(fname);
                }
                foreach (string x in file_name)
                {
                    Console.WriteLine(x);
                }
                compare_two_directory(file_name, destination_file_name);
                if(pic_num==file_name.Count-1)
                {
                    MessageBox.Show("此檔案已完成");
                    buffer = new Bitmap(destination + "\\去識別_" + file_name[pic_num].Remove(0, num + 1));
                    bmp = resize(buffer, new Size(pic.Width, pic.Height));
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = bmp;
                }
                else
                {
                    buffer = new Bitmap(file_name[pic_num]);
                    bmp = resize(buffer, new Size(pic.Width, pic.Height));
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = bmp;
                }
                
            }
            
            
        }
        private void eraser_button_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(file_name[pic_num]);
            pic.Image = img;
            drawrectlist.Clear();
        }
        Boolean pen_flag = false;
        private void pen_button_Click(object sender, EventArgs e)
        {
            pen_flag = true;
            g = pic.CreateGraphics();

            pen = new SolidBrush(Color.FromArgb(255,0,0));
        }
        Point start = new Point();
        List<Point> drawrectlist = new List<Point>();
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            if(pen_flag==true)
            {
                start = e.Location;
                drawrectlist.Add(start);
                flag = true;                               
            }
            else
            {
                MessageBox.Show("請選擇畫筆");
            }
            
        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(flag==true)
            {
                Rectangle rect = new Rectangle(start.X,start.Y,e.Location.X-start.X,e.Location.Y-start.Y);
                g.FillRectangle(pen,rect);               
            }           
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
            drawrectlist.Add(e.Location);
            
        }
        private void reset_button_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(file_name[pic_num]);
            pic.Image = img;
            drawrectlist.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {//儲存到目標資料夾
            if(textBox2.Text=="")
            {
                MessageBox.Show("請選擇目的地");
            }
            else
            {
                Graphics p = Graphics.FromImage(pic.Image);
                for (int i = 0; i <= drawrectlist.Count - 2; i = i + 2)
                {
                    Rectangle rec = new Rectangle(drawrectlist[i].X, drawrectlist[i].Y, drawrectlist[i + 1].X - drawrectlist[i].X
                        , drawrectlist[i + 1].Y - drawrectlist[i].Y);
                    p.FillRectangle(pen, rec);
                }

                bmp.Save(destination + "\\去識別_" + file_name[pic_num].Remove(0, num + 1), System.Drawing.Imaging.ImageFormat.Bmp);
                destination_file_name.Clear();
                foreach (string fname in System.IO.Directory.GetFileSystemEntries(textBox2.Text))
                {
                    destination_file_name.Add(fname);
                }
                drawrectlist.Clear();
            }


        }
        private Bitmap resize(Bitmap imgToResize, Size size)
        {
            return (new Bitmap(imgToResize, size));
        }
        private void pic_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void compare_two_directory(List<string> file_name,List<string> destination_file_name)
        {
            if(destination_file_name.Count<=0)
            {
                pic_num = 0;
            }
            else
            {
                for (int i = 0; i <= file_name.Count - 1; i++)
                {
                    if (destination_file_name[destination_file_name.Count-1] == destination + "\\去識別_" + file_name[i].Remove(0, num + 1))
                    {
                        pic_num = i;
                        break;
                    }
                }
                if (pic_num != 0 && pic_num< file_name.Count - 1)
                {
                    pic_num += 1;
                }

            }
            
        }
    }
}
