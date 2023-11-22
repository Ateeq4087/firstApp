using emplib;

namespace empforms
{
    public partial class Form1 : Form
    {
        employee ateeqkpmg = new employee();

        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click2;
            button1.Click += Button1_Click3;
           

            ateeqkpmg.join += rohit_join;
            ateeqkpmg.join += lekha_join;


            ateeqkpmg.leave += rohit_resign;
            ateeqkpmg.leave += lekha_resign;

        }

        private void rohit_resign(object? sender, EventArgs e)
        {
            MessageBox.Show("Rohit Resigned KPMG successfully");
        }

        private void lekha_resign(object? sender, EventArgs e)
        {
            MessageBox.Show("Lekha Resigned KPMG successfully");
        }



        private void lekha_join(object? sender, EventArgs e)
        {
            MessageBox.Show("Lekha joined KPMG successfully");
        }

        private void rohit_join(object? sender, EventArgs e)
        {
            MessageBox.Show("Rohit joined KPMG successfully");
        }

        private void Button1_Click2(object? sender, EventArgs e)
        {
            MessageBox.Show("I am subscriber 2,click OK to next");
        }
        private void Button1_Click3(object? sender, EventArgs e)
        {
            MessageBox.Show("I am subscriber 3,click OK to return");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked the button,click OK to see your subscribers");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ateeqkpmg.joined();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ateeqkpmg.resign();
        }


    }
}