namespace Proj0001_MyUtilities
{
    public partial class MainForm : Form
    {
        int count = 0;
        Random random;
        Char[] specialSimbols = new char[] {'~', '`', ',', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_',
                                            '=', '+', '-', '<', '>', '[', ']', '{', '}', ';', ':', ',',  ',', '"', '/', '?', '.' };
        Dictionary<string, double> metrica;
        public MainForm()
        {
            InitializeComponent();
            random = new Random((int)DateTime.Now.Ticks);
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 160344);
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

        private void btnNumericLengthReset_Click(object sender, EventArgs e)
        {
            numericPasswordLength.Value = 4;
        }

        private void btnCreatePassword_Click(object sender, EventArgs e)
        {
            if (chlstbxSimbols.CheckedItems.Count == 0) return;
            string password = String.Empty;
            for(int i = 0; i < numericPasswordLength.Value; i++)
            {
                int n = random.Next(0, chlstbxSimbols.CheckedItems.Count);
                string str = chlstbxSimbols.CheckedItems[n].ToString(); 
                switch (str)
                {
                    case "Цифры": password += random.Next(10).ToString(); 
                        break;
                    case "Прописные буквы": password += Convert.ToChar(random.Next(65, 88));
                         break;
                    case "Строчные буквы": password += Convert.ToChar(random.Next(97,122));
                        break;
                    default:
                        password += specialSimbols[random.Next(specialSimbols.Length)];
                        break;

                }
                txtBxPassword.Text = password;
            }
        }

        private void numericPasswordLength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnChBxClear_Click(object sender, EventArgs e)
        {
            txtBxPassword.Clear();
        }

        private void btnCopyToBuffer_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBxPassword.Text);
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            txBxTo.Clear();
            double metrFrom = metrica[cmBxFrom.Text];
            double metrTo = metrica[cmBxTo.Text];
            double metrResult = Convert.ToDouble(txBxFrom.Text);
            txBxTo.Text = (metrResult * metrFrom / metrTo).ToString();

        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            string temp = cmBxFrom.Text;
            cmBxFrom.Text = cmBxTo.Text;
            cmBxTo.Text = temp;
        }

        private void cmBxSwap_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmBxMetrics.Text)
            {
                case "длина":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 160344);
                    cmBxFrom.Items.Clear();
                    cmBxFrom.Items.Add("mm");
                    cmBxFrom.Items.Add("cm");
                    cmBxFrom.Items.Add("dm");
                    cmBxFrom.Items.Add("m");
                    cmBxFrom.Items.Add("km");
                    cmBxFrom.Items.Add("mile");
                    cmBxTo.Items.Clear();
                    cmBxTo.Items.Add("mm");
                    cmBxTo.Items.Add("cm");
                    cmBxTo.Items.Add("dm");
                    cmBxTo.Items.Add("m");
                    cmBxTo.Items.Add("km");
                    cmBxTo.Items.Add("mile");
                    cmBxFrom.Text = "mm";
                    cmBxTo.Text = "mm";
                    break;
                case "вес":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.3);
                    metrica.Add("oz", 283);
                    cmBxFrom.Items.Clear();
                    cmBxFrom.Items.Add("g");
                    cmBxFrom.Items.Add("kg");
                    cmBxFrom.Items.Add("t");
                    cmBxFrom.Items.Add("lb");
                    cmBxFrom.Items.Add("oz");
                    cmBxTo.Items.Clear();
                    cmBxTo.Items.Add("g");
                    cmBxTo.Items.Add("kg");
                    cmBxTo.Items.Add("t");
                    cmBxTo.Items.Add("lb");
                    cmBxTo.Items.Add("oz");
                    cmBxFrom.Text = "g";
                    cmBxTo.Text = "g";
                    break;
            }
        }
    }
}