namespace Proj0001_MyUtilities
{
    public partial class MainForm : Form
    {
        int count = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��������� �������, ������� ����� ����������� � �����.\n�����: ������� �.�., 2022\n", "� ���������");
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = count.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = count.ToString();
        }
    }
}