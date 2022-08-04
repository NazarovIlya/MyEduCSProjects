namespace Proj0001_MyUtilities
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random random;
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Небольшие утилиты, которые могут пригодиться в жизни.\nАвтор: Назаров И.А., 2022\n", "О программе");
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

        private void btnGetRandom_Click(object sender, EventArgs e)
        {
            int randomN = 0;
            randomN = random.Next(Convert.ToInt32(numericMin.Value), Convert.ToInt32(numericMax.Value) + 1);
            lblRandomNumber.Text = randomN.ToString();
            if (chBxRepet.Checked == true)
            {
                if (richTxtBxRandomNumbers.Text.IndexOf(randomN.ToString()) == -1)
                    richTxtBxRandomNumbers.AppendText(randomN + "\n");
            }
            else richTxtBxRandomNumbers.AppendText(randomN + "\n");
            

            
        }

        private void lblMax_Click(object sender, EventArgs e)
        {

        }

        private void numericMax_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTxtBxRandomNumbers_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTxtBxClear_Click(object sender, EventArgs e)
        {
            richTxtBxRandomNumbers.Clear();
        }

        private void btnCopyRandom_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTxtBxRandomNumbers.Text);
        }
    }
}