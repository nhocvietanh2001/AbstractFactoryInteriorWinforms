using AbstractFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactoryWinforms
{
    public partial class Form1 : Form
    {
        IStyleFactory factory;
        private int initial;
        public Form1() {
            InitializeComponent();
            initial = this.Controls.Count;
        }
        internal PictureBox GetPictureBox(int width, int height, IStyle style, int x, int y) {
            PictureBox pictureBox = new PictureBox();

            //pictureBox.Image = Image.FromFile("../../../Pictures/Modern/"+ style.GetName() +".jpg");
            pictureBox.Location = new System.Drawing.Point(x, y);
            pictureBox.Height = height;
            pictureBox.Width = width;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = style.GetImage();
            pictureBox.Name = style.GetName();

            return pictureBox;
        }
        private void btnModern_Click(object sender, EventArgs e) {
            if (this.Controls.Count > initial) {
                for (int num = this.Controls.Count; this.Controls.Count > initial;) {
                    this.Controls.RemoveAt(--num);
                }
            }
            
            factory = new ModernFactory();
            int i = 0;
            List<IStyle> store = new List<IStyle>();
            if (chbDesk.Checked) {
                store.Add(factory.CreateDesk());
                i++;
            }
            if (chbChair.Checked) {
                store.Add(factory.CreateChair());
                i++;
            }
            if (chbBed.Checked) {
                store.Add(factory.CreateBed());
                i++;
            }

            switch (i) {
                case 1: {
                        PictureBox pictureBox = GetPictureBox(630, 420, store[0], 90, 10);
                        this.Controls.Add(pictureBox);
                        break;
                    }
                case 2: {
                        PictureBox pictureBox = GetPictureBox(315, 210,  store[0], 90, 168);
                        this.Controls.Add(pictureBox);
                        PictureBox pictureBox2 = GetPictureBox(315, 210, store[1], 415, 168);
                        this.Controls.Add(pictureBox2);
                        break;
                    }
                case 3: {
                        PictureBox pictureBox = GetPictureBox(315, 210, store[0], 90, 10);
                        this.Controls.Add(pictureBox);
                        PictureBox pictureBox2 = GetPictureBox(315, 210, store[1], 415, 10);
                        this.Controls.Add(pictureBox2);
                        PictureBox pictureBox3 = GetPictureBox(315, 210, store[2], 255, 230);
                        this.Controls.Add(pictureBox3);
                        break;
                    }
                default: {
                        break;
                    }
            }
        }
        private void btnTraditional_Click(object sender, EventArgs e) {
            if (this.Controls.Count > initial) {
                for (int num = this.Controls.Count; this.Controls.Count > initial;) {
                    this.Controls.RemoveAt(--num);
                }
            }

            factory = new TraditionalFactory();
            int i = 0;
            List<IStyle> store = new List<IStyle>();
            if (chbDesk.Checked) {
                store.Add(factory.CreateDesk());
                i++;
            }
            if (chbChair.Checked) {
                store.Add(factory.CreateChair());
                i++;
            }
            if (chbBed.Checked) {
                store.Add(factory.CreateBed());
                i++;
            }

            switch (i) {
                case 1: {
                        PictureBox pictureBox = GetPictureBox(630, 420, store[0], 90, 10);
                        this.Controls.Add(pictureBox);
                        break;
                    }
                case 2: {
                        PictureBox pictureBox = GetPictureBox(315, 210, store[0], 90, 168);
                        this.Controls.Add(pictureBox);
                        PictureBox pictureBox2 = GetPictureBox(315, 210, store[1], 415, 168);
                        this.Controls.Add(pictureBox2);
                        break;
                    }
                case 3: {
                        PictureBox pictureBox = GetPictureBox(315, 210, store[0], 90, 10);
                        this.Controls.Add(pictureBox);
                        PictureBox pictureBox2 = GetPictureBox(315, 210, store[1], 415, 10);
                        this.Controls.Add(pictureBox2);
                        PictureBox pictureBox3 = GetPictureBox(315, 210, store[2], 255, 230);
                        this.Controls.Add(pictureBox3);
                        break;
                    }
                default: {
                        break;
                    }
            }
        }
    }
}
