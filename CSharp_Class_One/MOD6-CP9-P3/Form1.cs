using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MOD6_CP9_P3
{
    public partial class Form1 : Form
    {
        public class Image_Info
        {
            public String Path { get; set; }
            public Image Image { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayImages(Image_Info imageOne, Image_Info imageTwo, Image_Info imageThree)
        {
            string[] images = Directory.GetFiles("img");
            string[] to_display = new string[3];
            var rand = new Random();
            for(int i = 0; i < 3; i++)
            {

                int img = rand.Next(1, images.Length);
                to_display[i] = images[img];
            }
            imageOne.Path = to_display[0];
            imageTwo.Path = to_display[1];
            imageThree.Path = to_display[2];
            pictureBox1.Image = Image.FromFile(to_display[0]);
            pictureBox2.Image = Image.FromFile(to_display[1]);
            pictureBox3.Image = Image.FromFile(to_display[2]);
        }

        public void CheckImages(int bet, Image_Info imageOne, Image_Info imageTwo, Image_Info imageThree)
        {
            imageOne.Image = pictureBox1.Image;
            imageTwo.Image = pictureBox2.Image;
            imageThree.Image = pictureBox3.Image;
            //if one == two or one == three
            if(imageOne.Path.Equals(imageTwo.Path) || imageOne.Path.Equals(imageThree.Path))
            {
                int win = bet * 2;
                //if one == two or one == three AND two == three
                if(imageTwo.Path.Equals(imageThree.Path))
                {
                    win = bet * 3;
                    MessageBox.Show("Congradulations you've won 3x your bet! " + win.ToString());
                    return;
                }
                MessageBox.Show("Congradulations you've won 2x your bet! Total: " + win.ToString());
                return;
            }
            //if two == three
            if (imageTwo.Path.Equals(imageThree.Path))
            {
                int win = bet * 2;
                //if one == three
                if (imageOne.Path.Equals(imageThree.Path))
                {
                    win = bet * 3;
                    MessageBox.Show("Congradulations you've won 3x your bet! " + win.ToString());
                    return;
                }
                MessageBox.Show("Congradulations you've won 2x your bet! Total: " + win.ToString());
                return;
            }
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            try
            {
                int bet = Int32.Parse(inputTextBox.Text);
                Image_Info imageOne = new Image_Info();
                Image_Info imageTwo = new Image_Info();
                Image_Info imageThree = new Image_Info();
                DisplayImages(imageOne, imageTwo, imageThree);
                CheckImages(bet, imageOne, imageTwo, imageThree);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
