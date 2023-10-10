namespace lab5ver2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void panel1_MouseClick_1(object sender, MouseEventArgs e)
        {
            Button b = new Button();
            b.Parent = this;
            b.Parent = panel2;
            b.Location = new Point(10, 20);
            b.Size = new Size(100, 30);
            b.Text = "1 But";



            Button c = new Button();
            c.Parent = this;
            c.Parent = panel2;
            c.Location = new Point(10, 50);
            c.Size = new Size(100, 30);
            c.Text = " 2 But";


            Button d = new Button();
            d.Parent = this;
            d.Parent = panel2;
            d.Location = new Point(10, 80);
            d.Size = new Size(100, 30);
            d.Text = "3 But";


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox text1 = new TextBox();
            text1.Parent = this;
            text1.Parent = panel3;
            text1.Location = new Point(10, 20);
            text1.Size = new Size(100, 30);
            text1.Text = "Текст 1";
            text1.ReadOnly = true;


            TextBox text2 = new TextBox();
            text2.Parent = this;
            text2.Parent = panel3;
            text2.Location = new Point(10, 50);
            text2.Size = new Size(100, 30);
            text2.Text = "Текст 2";
            text2.ReadOnly = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Parent = this;
            label1.Parent = panel1;
            label1.Location = new Point(10, 20);
            label1.Size = new Size(100, 30);
            label1.Text = "Лэйбл 1";

            Label label2 = new Label();
            label2.Parent = this;
            label2.Parent = panel1;
            label2.Location = new Point(10, 50);
            label2.Size = new Size(100, 30);
            label2.Text = "Лэйбл 2";
        }
    }
}