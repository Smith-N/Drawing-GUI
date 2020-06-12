/* Nick Smith
 * February 20, 2019
 * Drawing GUI
 * The program allows for the user to select from a list of shapes (Ellipse, Circle, Rectangle, Square), and a list of colors.
 * The horizontal scroll bar affects the height of the shape, and the vertical scroll bar affects the width of the shape. 
 * The shape dynamically draws when its width or height is changed, and changes color when a new color is selected. 
 * I Was not able to get a check box or get the shape to move in the panel.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingGUI
{
    public partial class Form1 : Form
    {
        int height = 5; // default height set to 5
        int width = 5; // default width set to 5
        string shape; // shape variable
        string color; // color variable
        Graphics g;
        Pen myPen = new Pen(Color.White); // pen set to white so that if shape is selected first, the program does not crash

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            shape = comboBox1.GetItemText(comboBox1.SelectedItem); // gets shape from combo box
            
            //g = panel1.CreateGraphics();
            g.Clear(Color.White);
            shape = comboBox1.GetItemText(comboBox1.SelectedItem);
            
            // if statements to draw selected shape
            if (shape.Equals("Ellipse"))
            {
                g.DrawEllipse(myPen, 1, 1, height * 20, width * 10);
            }
            if (shape.Equals("Rectangle"))
            {
                g.DrawRectangle(myPen, 1, 1, height * 20, width * 10);
            }
            if (shape.Equals("Circle"))
            {
                g.DrawEllipse(myPen, 1, 1, height * 10, width * 10);
            }
            if (shape.Equals("Square"))
            {
                g.DrawRectangle(myPen, 1, 1, height * 10, width * 10);
            } 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = comboBox2.GetItemText(comboBox2.SelectedItem); // gets color from combo box

            if (color.Equals("Black"))
            {
                myPen = new Pen(Color.Black);
            }
            if (color.Equals("Blue"))
            {
                myPen = new Pen(Color.Blue);
            }
            if (color.Equals("Red"))
            {
                myPen = new Pen(Color.Red);
            }
            if (color.Equals("Purple"))
            {
                myPen = new Pen(Color.Purple);
            }
            if (color.Equals("Yellow"))
            {
                myPen = new Pen(Color.Yellow);
            }
            if (color.Equals("Green"))
            {
                myPen = new Pen(Color.Green);
            }
            if (color.Equals("Orange"))
            {
                myPen = new Pen(Color.Orange);
            }
            if (color.Equals("White"))
            {
                myPen = new Pen(Color.White);
            }
            comboBox1_SelectedIndexChanged(null, null); // redraws shape with new color
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            height = hScrollBar1.Value;
            comboBox1_SelectedIndexChanged(null, null); //redraws shape with new height
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            width = vScrollBar1.Value;
            comboBox1_SelectedIndexChanged(null, null); //redraws shape with new width
        }
    }
}
