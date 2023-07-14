namespace Mini_Project_Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1, y1, x2, y2;
        Pen pen = new Pen(Color.Black, 10);

        private void btn_red(object sender, EventArgs e)
        {
            pen = new Pen(Color.Red, 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Yellow, 10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Blue, 10);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;

            Graphics g = CreateGraphics();
            g.DrawLine(pen, x1, y1, x2, y2);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        //선, 원, 사각형 구분은 if문 사용할 것
        // 원은 DrawArc() , 사각형 DrawRectangle() 사용하기

        private void Line_CheckedChanged(object sender, EventArgs e)
        {

            if (Line.Checked == true)
            {
                Graphics line = CreateGraphics();
                Rectangle rec = new Rectangle(10, 10, 100, 20);

            }
            else if(Circle.Checked == true)
            {
                
            }

            
        }
    }
}