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
            YesButton.Text = "���";
            NoButton.Text = "��";
        }
        private void YesButton_MouseLeave(object sender, EventArgs e)
        {
            YesButton.Text = "��";
            NoButton.Text = "���";
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            TextWindow.Text = "���... � �����... ������ � ������� ������ � ����. � �� ���� ������ �� ������.";
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            TextWindow.Text = "���... � �����... ������ � ������� ������ � ����. � �� ���� ������ �� ������.";
        }
    }
}