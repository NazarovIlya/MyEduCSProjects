namespace Proj0001_MyUtilities
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random random;
        public MainForm()
        {
            InitializeComponent();
            random = new Random((int)DateTime.Now.Ticks);
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
            richTxtBxRandomNumbers.AppendText(lblRandomNumber.Text + "\n");
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

        private void lblResetInterval_Click(object sender, EventArgs e)
        {
            numericMin.ResetText();
            numericMin.Value = 0;
            numericMax.ResetText();
            numericMax.Value = 0;
        }

        private void tsmiInsertDate_Click(object sender, EventArgs e)
        {
            richTxtBxNotePad.AppendText(DateTime.Now.ToLongDateString() + "\n");
        }

        private void tsmiNotepad_Click(object sender, EventArgs e)
        {
            richTxtBxNotePad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void tsmiClear_Click(object sender, EventArgs e)
        {
            richTxtBxNotePad.Clear();
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            try
            {
                richTxtBxNotePad.SaveFile("Notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении.");
            }
            
        }

        void LoadNotepad()
        {
            try
            {
                richTxtBxNotePad.LoadFile("Notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке.");
            }
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void btnChLBxReset_Click(object sender, EventArgs e)
        {
            chlstbxSimbols.SetItemCheckState(0, CheckState.Unchecked);
            chlstbxSimbols.SetItemCheckState(1, CheckState.Unchecked);
            chlstbxSimbols.SetItemCheckState(2, CheckState.Unchecked);
            chlstbxSimbols.SetItemCheckState(3, CheckState.Unchecked);
        }
        
    }
}