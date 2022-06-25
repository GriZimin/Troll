namespace Troll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void YesButton_MouseMove(object sender, MouseEventArgs e)
        {
            YesButton.Text = "Нет";
            NoButton.Text = "Да";
        }
        private void YesButton_MouseLeave(object sender, EventArgs e)
        {
            YesButton.Text = "Да";
            NoButton.Text = "Нет";
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            TextWindow.Text = "Как... я думал... Теперь я другого мнения о тебе. Я от тебя такого не ожидал.";
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            TextWindow.Text = "Как... я думал... Теперь я другого мнения о тебе. Я от тебя такого не ожидал.";
        }
    }
}