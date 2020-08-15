using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChalkBoard
{
    public partial class Pedigree : Form
    {

        List<string[]> list;
        string[] person;
        List<string[]> children;
        private bool open; 

        public Pedigree(List<string[]> l, string[] p)
        {

            list = l;
            person = p;

            InitializeComponent();

            drawParents();
            findChildren();
            drawChildren();
            open = true;

        }

        public bool IsOpen()
        {
            return open; 
        }

        public void drawParents()
        {

            MotherLabel.Text = person[3];
            FatherLabel.Text = person[4];
            if (person[1] == "female")
            {
                CharacterPictureBox.Image = Image.FromFile(@"C:\Users\eahea\Desktop\ChalkBoard\Sample\Images\female.png");
            }
            else
            {
                CharacterPictureBox.Image = Image.FromFile(@"C:\Users\eahea\Desktop\ChalkBoard\Sample\Images\male.png");
            }
            NameLabel.Text = person[0];
        }

        public void findChildren()
        {
            children = new List<string[]>();
            foreach(string[] item in list){
                if(item[3]==person[0] || item[4] == person[0])
                {
                    children.Add(item);

                }
            }
        }

        public void drawChildren()
        {

            foreach (string[] item in children)
            {
                PictureBox newBox = new PictureBox();
                Label newLabel = new Label();
                if (item[1] == "male")
                {
                    newBox.Image = Image.FromFile(@"C:\Users\eahea\Desktop\ChalkBoard\Sample\Images\male.png");
                }
                else
                {
                    newBox.Image = Image.FromFile(@"C:\Users\eahea\Desktop\ChalkBoard\Sample\Images\female.png");
                }
                newLabel.Text = item[0];
                ChildrenLayoutPanel.Controls.Add(newBox);
                ChildrenLayoutPanel.Controls.Add(newLabel);
                newLabel.Visible = true;
                newBox.Visible = true;
            }
        }

        private void Pedigree_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            open = false;
        }
    }
}
